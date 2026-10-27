using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState;
using CSharpScript.Game.LevelGamePlay.SunSpirit.View;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x020069ED RID: 27117
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SunSpiritController : ControllerBase
	{
		// Token: 0x17009883 RID: 39043
		// (get) Token: 0x0604374E RID: 276302 RVA: 0x0107C954 File Offset: 0x0107AB54
		private bool IsInDebugMode
		{
			get
			{
				SundryModel instance = SundryModel.Instance;
				if (instance == null)
				{
					return false;
				}
				instance.GetModuleDebugLevel("SunSpirit");
				return true;
			}
		}

		// Token: 0x0604374F RID: 276303 RVA: 0x0107C970 File Offset: 0x0107AB70
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.SunSpiritListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSunSpiritListNotify));
			Net.Instance.Register(ENotifyMessageId.SunSpiritCollectNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSunSpiritCollectNotify));
			Net.Instance.Register(ENotifyMessageId.SunSpiritUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSunSpiritUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SunSpiritActionOperationNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSunSpiritActionOperationNotify));
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				SundryModel instance = SundryModel.Instance;
				if (instance != null)
				{
					instance.ChangeModuleDebugLevel("SunSpirit", 1);
				}
			}
			if (!EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			return true;
		}

		// Token: 0x06043750 RID: 276304 RVA: 0x0107CA68 File Offset: 0x0107AC68
		private void OnWorldDone()
		{
			CreatureModel instance = CreatureModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetPlayerId()) : null;
			if (num == null)
			{
				return;
			}
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(num.Value);
			BaseTagComponent baseTagComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null)
			{
				return;
			}
			foreach (int value in this.ENABLE_TAGS)
			{
				ITagTask tagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(value), new BaseTagComponent.TTagSwitchedCallback(this.OnEnableTagAddOrRemove), null);
				if (tagTask != null)
				{
					this.TagListeners.Add(tagTask);
				}
			}
			this.UpdateSunSpiritEnable();
		}

		// Token: 0x06043751 RID: 276305 RVA: 0x0107CB14 File Offset: 0x0107AD14
		private void OnSunSpiritEnableUpdate()
		{
			bool newEnable = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SunSpirit;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "日灵系统开启状态更新";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NewEnable", newEnable);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (newEnable)
			{
				SunSpiritModel.Instance.LoadAndInitSunSpiritConfig(false, delegate(bool success)
				{
					if (success)
					{
						SunSpiritModel instance3 = SunSpiritModel.Instance;
						BP_CrowdAiConfig_C bp_CrowdAiConfig_C = (instance3 != null) ? instance3.GetSunSpiritConfig().CrowdAiConfig : null;
						if (bp_CrowdAiConfig_C == null)
						{
							Log.Instance.Error(ELogModule.SunSpirit, ELogAuthor.ZYL, "日灵: 集群启用失败，日灵集群配置获取不到", default(ReadOnlySpan<ValueTuple<string, object>>));
							CrowdAiController.Instance.EnableCrowdAiSystemByConfigPath(null);
						}
						else
						{
							CrowdAiController.Instance.EnableCrowdAiSystemByConfigAsset(bp_CrowdAiConfig_C);
						}
						this.RefreshSunSpiritsStateFromCachedProto(true);
						this.TryOpenHintView();
						EventSystem.Instance.Emit<bool>(EEventName.OnSunSpiritEnableUpdated, newEnable);
						return;
					}
					Log.Instance.Warn(ELogModule.SunSpirit, ELogAuthor.ZYL, "日灵系统开启失败，加载并初始化SunSpiritConfig时被中断", default(ReadOnlySpan<ValueTuple<string, object>>));
				});
				return;
			}
			CrowdAiController.Instance.DisableCrowdAiSystem(false);
			SunSpiritModel instance2 = SunSpiritModel.Instance;
			if (instance2 != null)
			{
				instance2.ClearAndReleaseSunSpiritConfig();
			}
			this.RefreshSunSpiritsStateFromCachedProto(true);
			this.TryCloseHintView();
			EventSystem.Instance.Emit<bool>(EEventName.OnSunSpiritEnableUpdated, newEnable);
		}

		// Token: 0x06043752 RID: 276306 RVA: 0x0107CBD0 File Offset: 0x0107ADD0
		private void TryOpenHintView()
		{
			if (this.SunSpiritHintView == null)
			{
				this.SunSpiritHintView = new SunSpiritHintView();
				this.SunSpiritHintView.CreateByResourceIdAsync("UiItem_LaHaiLuoRiLing", UiLayer.Instance.GetBattleViewUnit(1), false);
			}
			if (this.SunSpiritLauncherHintView == null)
			{
				this.SunSpiritLauncherHintView = new SunSpiritLauncherHintView();
				this.SunSpiritLauncherHintView.CreateByResourceIdAsync("UiItem_LaHaiLuoRiLing", UiLayer.Instance.GetBattleViewUnit(1), false);
			}
		}

		// Token: 0x06043753 RID: 276307 RVA: 0x0107CC3D File Offset: 0x0107AE3D
		private void TryCloseHintView()
		{
			if (this.SunSpiritHintView != null)
			{
				this.SunSpiritHintView.Destroy(null);
				this.SunSpiritHintView = null;
			}
			if (this.SunSpiritLauncherHintView != null)
			{
				this.SunSpiritLauncherHintView.Destroy(null);
				this.SunSpiritLauncherHintView = null;
			}
		}

		// Token: 0x06043754 RID: 276308 RVA: 0x0107CC78 File Offset: 0x0107AE78
		private void UpdateSunSpiritEnable()
		{
			CreatureModel instance = CreatureModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetPlayerId()) : null;
			if (num == null)
			{
				return;
			}
			bool flag = false;
			foreach (int tagId in this.ENABLE_TAGS)
			{
				flag = (flag || FormationDataController.Instance.HasPlayerTag(num.Value, tagId, true));
				if (flag)
				{
					break;
				}
			}
			this.SetSunSpiritEnable(flag);
		}

		// Token: 0x06043755 RID: 276309 RVA: 0x0107CCF4 File Offset: 0x0107AEF4
		public void SetSunSpiritEnable(bool targetEnable)
		{
			bool isSunSpiritEnable = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			if (isSunSpiritEnable != targetEnable)
			{
				SunSpiritModel.Instance.SetIsSunSpiritEnable(targetEnable);
			}
			bool isSunSpiritEnable2 = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			if (isSunSpiritEnable != isSunSpiritEnable2)
			{
				this.OnSunSpiritEnableUpdate();
			}
		}

		// Token: 0x06043756 RID: 276310 RVA: 0x0107CD30 File Offset: 0x0107AF30
		public void SetGmOverrideSunSpiritEnable(bool bIsEnable)
		{
			bool isSunSpiritEnable = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			SunSpiritModel.Instance.GmOverrideIsSunSpiritEnable = bIsEnable;
			SunSpiritModel.Instance.IsUsingGmOverrideSunSpiritEnable = true;
			bool isSunSpiritEnable2 = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			if (isSunSpiritEnable != isSunSpiritEnable2)
			{
				this.OnSunSpiritEnableUpdate();
			}
		}

		// Token: 0x06043757 RID: 276311 RVA: 0x0107CD74 File Offset: 0x0107AF74
		public void ClearGmOverrideSunSpiritEnable()
		{
			bool isSunSpiritEnable = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			SunSpiritModel.Instance.GmOverrideIsSunSpiritEnable = false;
			SunSpiritModel.Instance.IsUsingGmOverrideSunSpiritEnable = false;
			bool isSunSpiritEnable2 = SunSpiritModel.Instance.GetIsSunSpiritEnable();
			if (isSunSpiritEnable != isSunSpiritEnable2)
			{
				this.OnSunSpiritEnableUpdate();
			}
		}

		// Token: 0x06043758 RID: 276312 RVA: 0x0107CDB8 File Offset: 0x0107AFB8
		private void RefreshSunSpiritsStateFromCachedProto(bool bDoIfSameState)
		{
			this.TempSunSpiritList.Clear();
			SunSpiritModel instance = SunSpiritModel.Instance;
			if (instance != null)
			{
				CreatureModel instance2 = CreatureModel.Instance;
				int playerId = (instance2 != null) ? instance2.GetPlayerId() : 0;
				AreaModel instance3 = AreaModel.Instance;
				Area? area;
				instance.GetAllSunSpiritDataByPlayerIdAndAreaId(playerId, ((instance3 != null) ? ((instance3.AreaInfo != null) ? new int?(area.GetValueOrDefault().AreaId) : null) : null).GetValueOrDefault(), true, null, this.TempSunSpiritList);
			}
			foreach (SunSpiritData sunSpiritData in this.TempSunSpiritList)
			{
				sunSpiritData.RefreshSunSpiritStateByCachedProto(bDoIfSameState);
			}
			this.TempSunSpiritList.Clear();
		}

		// Token: 0x06043759 RID: 276313 RVA: 0x0107CE94 File Offset: 0x0107B094
		private void OnEnableTagAddOrRemove(int tagId, bool tagExist)
		{
			this.UpdateSunSpiritEnable();
		}

		// Token: 0x0604375A RID: 276314 RVA: 0x0107CE9C File Offset: 0x0107B09C
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SunSpiritListNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SunSpiritCollectNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SunSpiritUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SunSpiritActionOperationNotify);
			this.TryCloseHintView();
			this.TempSunSpiritList.Clear();
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			foreach (ITagTask tagTask in this.TagListeners)
			{
				tagTask.EndTask();
			}
			this.TagListeners.Clear();
			return true;
		}

		// Token: 0x0604375B RID: 276315 RVA: 0x0107CFA0 File Offset: 0x0107B1A0
		protected override void OnTick(float delta)
		{
			this.TickSunSpirits((double)delta);
			this.TickView(delta);
		}

		// Token: 0x0604375C RID: 276316 RVA: 0x0107CFB1 File Offset: 0x0107B1B1
		private void TickView(float delta)
		{
			if (this.SunSpiritHintView != null)
			{
				this.SunSpiritHintView.Tick(delta);
			}
			if (this.SunSpiritLauncherHintView != null)
			{
				this.SunSpiritLauncherHintView.Tick((double)delta);
			}
		}

		// Token: 0x0604375D RID: 276317 RVA: 0x0107CFDC File Offset: 0x0107B1DC
		private void TickSunSpirits(double delta)
		{
			this.DeltaFromLastTick += delta;
			if (this.DeltaFromLastTick < 33.0)
			{
				return;
			}
			float deltaSeconds = (float)(this.DeltaFromLastTick * 0.0010000000474974513);
			this.DeltaFromLastTick = 0.0;
			this.TempSunSpiritList.Clear();
			SunSpiritModel instance = SunSpiritModel.Instance;
			if (instance != null)
			{
				CreatureModel instance2 = CreatureModel.Instance;
				int playerId = (instance2 != null) ? instance2.GetPlayerId() : 0;
				AreaModel instance3 = AreaModel.Instance;
				Area? area;
				instance.GetAllSunSpiritDataByPlayerIdAndAreaId(playerId, ((instance3 != null) ? ((instance3.AreaInfo != null) ? new int?(area.GetValueOrDefault().AreaId) : null) : null).GetValueOrDefault(), true, null, this.TempSunSpiritList);
			}
			foreach (SunSpiritData sunSpiritData in this.TempSunSpiritList)
			{
				sunSpiritData.TickState(deltaSeconds);
			}
			this.TempSunSpiritList.Clear();
		}

		// Token: 0x0604375E RID: 276318 RVA: 0x0107D0FC File Offset: 0x0107B2FC
		[NullableContext(2)]
		private void OnSunSpiritListNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			SunSpiritListNotify sunSpiritListNotify = (SunSpiritListNotify)msg;
			if (this.IsInDebugMode)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 列表初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigs", sunSpiritListNotify.SpiritInfo);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				Log.Instance.Info(ELogModule.SunSpirit, ELogAuthor.ZYL, "日灵: 列表初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			foreach (SunSpiritPb sunSpiritPb in sunSpiritListNotify.SpiritInfo)
			{
				SunSpiritModel instance2 = SunSpiritModel.Instance;
				if (instance2 != null)
				{
					instance2.AddOrUpdateSunSpiritDataByPb(sunSpiritPb, true);
				}
			}
		}

		// Token: 0x0604375F RID: 276319 RVA: 0x0107D1B8 File Offset: 0x0107B3B8
		[NullableContext(2)]
		private void OnSunSpiritCollectNotify(IMessage msg, Net.CallbackStatus status)
		{
			SunSpiritPb spiritInfo = ((SunSpiritCollectNotify)msg).SpiritInfo;
			if (spiritInfo == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SunSpirit;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "日灵: 收集";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", spiritInfo.EntityConfigId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SunSpiritModel instance2 = SunSpiritModel.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.AddOrUpdateSunSpiritDataByPb(spiritInfo, true);
		}

		// Token: 0x06043760 RID: 276320 RVA: 0x0107D21C File Offset: 0x0107B41C
		[NullableContext(2)]
		private void OnSunSpiritUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SunSpiritUpdateNotify sunSpiritUpdateNotify = (SunSpiritUpdateNotify)msg;
			if (this.IsInDebugMode)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 列表更新";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigs", sunSpiritUpdateNotify.SpiritInfo);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				Log.Instance.Info(ELogModule.SunSpirit, ELogAuthor.ZYL, "日灵: 列表更新", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			foreach (SunSpiritPb sunSpiritPb in sunSpiritUpdateNotify.SpiritInfo)
			{
				SunSpiritModel instance2 = SunSpiritModel.Instance;
				if (instance2 != null)
				{
					instance2.AddOrUpdateSunSpiritDataByPb(sunSpiritPb, true);
				}
			}
		}

		// Token: 0x06043761 RID: 276321 RVA: 0x0107D2D8 File Offset: 0x0107B4D8
		public void OnEntityInitSetSunSpirit(IEnumerable<SunSpiritPb> data)
		{
			if (this.IsInDebugMode)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 列表更新(实体添加)";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigs", data);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				Log.Instance.Info(ELogModule.SunSpirit, ELogAuthor.ZYL, "日灵: 列表更新(实体添加)", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			foreach (SunSpiritPb sunSpiritPb in data)
			{
				SunSpiritModel instance2 = SunSpiritModel.Instance;
				if (instance2 != null)
				{
					instance2.AddOrUpdateSunSpiritDataByPb(sunSpiritPb, true);
				}
			}
		}

		// Token: 0x06043762 RID: 276322 RVA: 0x0107D380 File Offset: 0x0107B580
		[NullableContext(2)]
		private unsafe void OnSunSpiritActionOperationNotify(IMessage msg, Net.CallbackStatus status)
		{
			SunSpiritActionOperationNotify sunSpiritActionOperationNotify = (SunSpiritActionOperationNotify)msg;
			if (this.IsInDebugMode)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 执行操作";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RelatedSceneItemId", sunSpiritActionOperationNotify.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationType", sunSpiritActionOperationNotify.OperationType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SpiritConfigs", sunSpiritActionOperationNotify.TakeUpInfo);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SunSpirit;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "日灵: 执行操作";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OperationType", sunSpiritActionOperationNotify.OperationType);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.ActiveActionOperationNotifyHandlerMap[sunSpiritActionOperationNotify] = new HashSet<SunSpiritPb>(sunSpiritActionOperationNotify.TakeUpInfo);
			SunSpiritOperationType operationType = sunSpiritActionOperationNotify.OperationType;
			if (operationType == SunSpiritOperationType.Fly)
			{
				this.HandleSunSpiritActionOperationNotifyFly(sunSpiritActionOperationNotify);
				return;
			}
			if (operationType != SunSpiritOperationType.Back)
			{
				return;
			}
			this.HandleSunSpiritActionOperationNotifyBack(sunSpiritActionOperationNotify);
		}

		// Token: 0x06043763 RID: 276323 RVA: 0x0107D494 File Offset: 0x0107B694
		private void HandleSunSpiritActionOperationNotifyFly(SunSpiritActionOperationNotify notify)
		{
			SunSpiritController.<>c__DisplayClass30_0 CS$<>8__locals1 = new SunSpiritController.<>c__DisplayClass30_0();
			CS$<>8__locals1.notify = notify;
			CS$<>8__locals1.<>4__this = this;
			if (CS$<>8__locals1.notify.OperationType != SunSpiritOperationType.Fly)
			{
				return;
			}
			SunSpiritController.<>c__DisplayClass30_0 CS$<>8__locals2 = CS$<>8__locals1;
			SunSpiritModel instance = SunSpiritModel.Instance;
			CS$<>8__locals2.config = ((instance != null) ? instance.GetSunSpiritConfig() : null);
			if (CS$<>8__locals1.config == null)
			{
				return;
			}
			CS$<>8__locals1.gearConfigIds = new List<int>();
			SunSpiritPb sunSpiritPb;
			using (IEnumerator<SunSpiritPb> enumerator = CS$<>8__locals1.notify.TakeUpInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					sunSpiritPb = enumerator.Current;
					SunSpiritTakeUpPb takeUpData = sunSpiritPb.TakeUpData;
					int? num = (takeUpData != null) ? new int?(takeUpData.TrapEntityConfigId) : null;
					if (num != null)
					{
						CS$<>8__locals1.gearConfigIds.Add(num.Value);
					}
					SunSpiritModel instance2 = SunSpiritModel.Instance;
					if (instance2 != null)
					{
						instance2.AddOrUpdateSunSpiritDataByPb(sunSpiritPb, false);
					}
				}
			}
			WaitEntityTask.CreateWithPbDataId("HandleSunSpiritActionOperationNotifyFly", CS$<>8__locals1.gearConfigIds, delegate(bool? r)
			{
				float flyingDuration2 = CS$<>8__locals1.config.FlyFromPlayerToGearDefaultDuration;
				CreatureModel instance3 = CreatureModel.Instance;
				EntityHandle entityHandle = (instance3 != null) ? instance3.GetEntityByPbDataId(CS$<>8__locals1.gearConfigIds[0]) : null;
				global::Vector vector = global::Vector.Create();
				bool flag = false;
				if (entityHandle != null && entityHandle.Valid)
				{
					WorldEntity entity = entityHandle.Entity;
					bool flag2;
					if (entity == null)
					{
						flag2 = false;
					}
					else
					{
						SceneItemSunSpiritGearComponent component = entity.GetComponent<SceneItemSunSpiritGearComponent>();
						flag2 = ((component != null) ? new bool?(component.GetSunSpiritSocketLocAndRot(0, vector, null)) : null).GetValueOrDefault();
					}
					flag = flag2;
				}
				if (flag)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					global::Vector vector2;
					if (baseCharacter == null)
					{
						vector2 = null;
					}
					else
					{
						CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
						vector2 = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
					}
					global::Vector vector3 = vector2;
					if (vector3 != null)
					{
						float num2 = (float)global::Vector.Dist(vector, vector3);
						float flyFromPlayerToGearSpeedForCalc = CS$<>8__locals1.config.FlyFromPlayerToGearSpeedForCalc;
						if (flyFromPlayerToGearSpeedForCalc > 0f)
						{
							flyingDuration2 = num2 / flyFromPlayerToGearSpeedForCalc;
						}
					}
				}
				float flyingDuration = flyingDuration2;
				Dictionary<int, List<SunSpiritPb>> dictionary = new Dictionary<int, List<SunSpiritPb>>();
				List<SunSpiritPb> list = new List<SunSpiritPb>();
				foreach (SunSpiritPb sunSpiritPb2 in CS$<>8__locals1.notify.TakeUpInfo)
				{
					if (sunSpiritPb2.TakeUpData == null)
					{
						list.Add(sunSpiritPb2);
					}
					else
					{
						int trapEntityConfigId = sunSpiritPb2.TakeUpData.TrapEntityConfigId;
						List<SunSpiritPb> list2;
						if (!dictionary.TryGetValue(trapEntityConfigId, out list2))
						{
							list2 = new List<SunSpiritPb>();
							dictionary[trapEntityConfigId] = list2;
						}
						list2.Add(sunSpiritPb2);
					}
				}
				foreach (List<SunSpiritPb> list3 in dictionary.Values)
				{
					Comparison<SunSpiritPb> comparison;
					if ((comparison = CS$<>8__locals1.<>9__1) == null)
					{
						comparison = (CS$<>8__locals1.<>9__1 = delegate(SunSpiritPb a, SunSpiritPb b)
						{
							if (!CS$<>8__locals1.config.FlyFromPlayerToGearInOrderFromMinToMax)
							{
								return b.TakeUpData.Index - a.TakeUpData.Index;
							}
							return a.TakeUpData.Index - b.TakeUpData.Index;
						});
					}
					list3.Sort(comparison);
				}
				float num3 = CS$<>8__locals1.config.FlyFromPlayerToGearDelayInterval * 1000f;
				float waitBeforeFlyingDuration = CS$<>8__locals1.config.FlyFromPlayerToGearWaitTimeBeforeFly;
				foreach (List<SunSpiritPb> list4 in dictionary.Values)
				{
					float num4 = 0f;
					using (List<SunSpiritPb>.Enumerator enumerator4 = list4.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							SunSpiritPb sunSpiritPb = enumerator4.Current;
							if (num4 < 20f)
							{
								CS$<>8__locals1.<>4__this.HandleSunSpiritFlyFromPlayerToGear(CS$<>8__locals1.notify, sunSpiritPb, waitBeforeFlyingDuration, flyingDuration);
							}
							else
							{
								TimerSystem.Instance.Delay(delegate(float _)
								{
									CS$<>8__locals1.<>4__this.HandleSunSpiritFlyFromPlayerToGear(CS$<>8__locals1.notify, sunSpiritPb, waitBeforeFlyingDuration, flyingDuration);
								}, Math.Min(num4, 180000f), null, null, true, 1f);
							}
							num4 += num3;
						}
					}
				}
				foreach (SunSpiritPb singleSunSpiritPb in list)
				{
					CS$<>8__locals1.<>4__this.HandleSunSpiritFlyFromPlayerToGear(CS$<>8__locals1.notify, singleSunSpiritPb, waitBeforeFlyingDuration, flyingDuration);
				}
			}, 60000, true, false);
		}

		// Token: 0x06043764 RID: 276324 RVA: 0x0107D5A0 File Offset: 0x0107B7A0
		private void HandleSunSpiritActionOperationNotifyBack(SunSpiritActionOperationNotify notify)
		{
			SunSpiritController.<>c__DisplayClass31_0 CS$<>8__locals1 = new SunSpiritController.<>c__DisplayClass31_0();
			CS$<>8__locals1.notify = notify;
			CS$<>8__locals1.<>4__this = this;
			if (CS$<>8__locals1.notify.OperationType != SunSpiritOperationType.Back)
			{
				return;
			}
			SunSpiritController.<>c__DisplayClass31_0 CS$<>8__locals2 = CS$<>8__locals1;
			SunSpiritModel instance = SunSpiritModel.Instance;
			CS$<>8__locals2.config = ((instance != null) ? instance.GetSunSpiritConfig() : null);
			if (CS$<>8__locals1.config == null)
			{
				return;
			}
			CS$<>8__locals1.gearConfigIds = new List<int>();
			SunSpiritPb sunSpiritPb;
			using (IEnumerator<SunSpiritPb> enumerator = CS$<>8__locals1.notify.TakeUpInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					sunSpiritPb = enumerator.Current;
					SunSpiritTakeUpPb takeUpData = sunSpiritPb.TakeUpData;
					int? num = (takeUpData != null) ? new int?(takeUpData.TrapEntityConfigId) : null;
					if (num != null)
					{
						CS$<>8__locals1.gearConfigIds.Add(num.Value);
					}
				}
			}
			WaitEntityTask.CreateWithPbDataId("HandleSunSpiritActionOperationNotifyBack", CS$<>8__locals1.gearConfigIds, delegate(bool? r)
			{
				float flyingDuration2 = CS$<>8__locals1.config.FlyFromGearToPlayerDefaultDuration;
				CreatureModel instance2 = CreatureModel.Instance;
				EntityHandle entityHandle = (instance2 != null) ? instance2.GetEntityByPbDataId(CS$<>8__locals1.gearConfigIds[0]) : null;
				global::Vector vector = global::Vector.Create();
				bool flag = false;
				if (entityHandle != null && entityHandle.Valid)
				{
					WorldEntity entity = entityHandle.Entity;
					bool flag2;
					if (entity == null)
					{
						flag2 = false;
					}
					else
					{
						SceneItemSunSpiritGearComponent component = entity.GetComponent<SceneItemSunSpiritGearComponent>();
						flag2 = ((component != null) ? new bool?(component.GetSunSpiritSocketLocAndRot(0, vector, null)) : null).GetValueOrDefault();
					}
					flag = flag2;
				}
				if (flag)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					global::Vector vector2;
					if (baseCharacter == null)
					{
						vector2 = null;
					}
					else
					{
						CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
						vector2 = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
					}
					global::Vector vector3 = vector2;
					if (vector3 != null)
					{
						float num2 = (float)global::Vector.Dist(vector, vector3);
						float flyFromGearToPlayerSpeedForCalc = CS$<>8__locals1.config.FlyFromGearToPlayerSpeedForCalc;
						if (flyFromGearToPlayerSpeedForCalc > 0f)
						{
							flyingDuration2 = num2 / flyFromGearToPlayerSpeedForCalc;
						}
					}
				}
				float flyingDuration = flyingDuration2;
				Dictionary<long, List<SunSpiritPb>> dictionary = new Dictionary<long, List<SunSpiritPb>>();
				List<SunSpiritPb> list = new List<SunSpiritPb>();
				foreach (SunSpiritPb sunSpiritPb2 in CS$<>8__locals1.notify.TakeUpInfo)
				{
					if (sunSpiritPb2.TakeUpData == null)
					{
						list.Add(sunSpiritPb2);
					}
					else
					{
						long key = (long)sunSpiritPb2.TakeUpData.TrapEntityConfigId;
						List<SunSpiritPb> list2;
						if (!dictionary.TryGetValue(key, out list2))
						{
							list2 = new List<SunSpiritPb>();
							dictionary[key] = list2;
						}
						list2.Add(sunSpiritPb2);
					}
				}
				foreach (List<SunSpiritPb> list3 in dictionary.Values)
				{
					Comparison<SunSpiritPb> comparison;
					if ((comparison = CS$<>8__locals1.<>9__1) == null)
					{
						comparison = (CS$<>8__locals1.<>9__1 = delegate(SunSpiritPb a, SunSpiritPb b)
						{
							if (!CS$<>8__locals1.config.FlyFromGearToPlayerInOrderFromMinToMax)
							{
								return b.TakeUpData.Index - a.TakeUpData.Index;
							}
							return a.TakeUpData.Index - b.TakeUpData.Index;
						});
					}
					list3.Sort(comparison);
				}
				float num3 = CS$<>8__locals1.config.FlyFromGearToPlayerDelayInterval * 1000f;
				float waitBeforeFlyingDuration = CS$<>8__locals1.config.FlyFromGearToPlayerWaitTimeBeforeFly;
				foreach (List<SunSpiritPb> list4 in dictionary.Values)
				{
					float num4 = 0f;
					using (List<SunSpiritPb>.Enumerator enumerator4 = list4.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							SunSpiritPb sunSpiritPb = enumerator4.Current;
							if (num4 < 20f)
							{
								CS$<>8__locals1.<>4__this.HandleSunSpiritFlyFromGearToPlayer(CS$<>8__locals1.notify, sunSpiritPb, waitBeforeFlyingDuration, flyingDuration);
							}
							else
							{
								TimerSystem.Instance.Delay(delegate(float _)
								{
									CS$<>8__locals1.<>4__this.HandleSunSpiritFlyFromGearToPlayer(CS$<>8__locals1.notify, sunSpiritPb, waitBeforeFlyingDuration, flyingDuration);
								}, Math.Min(num4, 180000f), null, null, true, 1f);
							}
							num4 += num3;
						}
					}
				}
				foreach (SunSpiritPb singleSunSpiritPb in list)
				{
					CS$<>8__locals1.<>4__this.HandleSunSpiritFlyFromGearToPlayer(CS$<>8__locals1.notify, singleSunSpiritPb, waitBeforeFlyingDuration, flyingDuration);
				}
			}, 60000, true, false);
		}

		// Token: 0x06043765 RID: 276325 RVA: 0x0107D698 File Offset: 0x0107B898
		private void HandleSunSpiritFlyFromPlayerToGear(SunSpiritActionOperationNotify notify, SunSpiritPb singleSunSpiritPb, float waitBeforeFlyingDuration, float flyingDuration)
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			SunSpiritData sunSpiritData = (instance != null) ? instance.GetSunSpiritDataByPlayerIdAndConfigId(CreatureModel.Instance.GetPlayerId(), singleSunSpiritPb.InstId, singleSunSpiritPb.EntityConfigId) : null;
			if (sunSpiritData == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 执行操作，未找到日灵数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", singleSunSpiritPb.EntityConfigId);
				instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OnActionOperationChildTaskFinish(notify, singleSunSpiritPb);
				return;
			}
			if (singleSunSpiritPb.TakeUpData == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SunSpirit;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "日灵: 操作协议内容有误";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("SpiritConfigId", singleSunSpiritPb.EntityConfigId);
				instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.OnActionOperationChildTaskFinish(notify, singleSunSpiritPb);
				return;
			}
			int trapEntityConfigId = singleSunSpiritPb.TakeUpData.TrapEntityConfigId;
			int index = singleSunSpiritPb.TakeUpData.Index;
			SunSpiritFlyingToGearState newState = new SunSpiritFlyingToGearState(sunSpiritData, waitBeforeFlyingDuration, flyingDuration, trapEntityConfigId, index, delegate()
			{
				this.OnActionOperationChildTaskFinish(notify, singleSunSpiritPb);
			});
			sunSpiritData.StopAllAndSetNextSunSpiritState(newState, false);
		}

		// Token: 0x06043766 RID: 276326 RVA: 0x0107D7E0 File Offset: 0x0107B9E0
		private void HandleSunSpiritFlyFromGearToPlayer(SunSpiritActionOperationNotify notify, SunSpiritPb singleSunSpiritPb, float waitBeforeFlyingDuration, float flyingDuration)
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			SunSpiritData sunSpiritData = (instance != null) ? instance.GetSunSpiritDataByPlayerIdAndConfigId(CreatureModel.Instance.GetPlayerId(), singleSunSpiritPb.InstId, singleSunSpiritPb.EntityConfigId) : null;
			if (sunSpiritData == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 执行操作，未找到日灵数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", singleSunSpiritPb.EntityConfigId);
				instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OnActionOperationChildTaskFinish(notify, singleSunSpiritPb);
				return;
			}
			if (singleSunSpiritPb.TakeUpData == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SunSpirit;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "日灵: 操作协议内容有误";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("SpiritConfigId", singleSunSpiritPb.EntityConfigId);
				instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.OnActionOperationChildTaskFinish(notify, singleSunSpiritPb);
				return;
			}
			int trapEntityConfigId = singleSunSpiritPb.TakeUpData.TrapEntityConfigId;
			int index = singleSunSpiritPb.TakeUpData.Index;
			SunSpiritFlyingToPlayerState newState = new SunSpiritFlyingToPlayerState(sunSpiritData, waitBeforeFlyingDuration, flyingDuration, trapEntityConfigId, index, delegate()
			{
				this.OnActionOperationChildTaskFinish(notify, singleSunSpiritPb);
			});
			sunSpiritData.StopAllAndSetNextSunSpiritState(newState, false);
		}

		// Token: 0x06043767 RID: 276327 RVA: 0x0107D928 File Offset: 0x0107BB28
		private unsafe void PushSunSpiritActionOperationEnd(SunSpiritActionOperationNotify reqData)
		{
			if (this.IsInDebugMode)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 执行操作完成";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RelatedSceneItemId", reqData.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationType", reqData.OperationType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SpiritConfigs", reqData.TakeUpInfo);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SunSpirit;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "日灵: 执行操作完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OperationType", reqData.OperationType);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			SunSpiritActionOperationEndPush sunSpiritActionOperationEndPush = SunSpiritActionOperationEndPush.Create();
			sunSpiritActionOperationEndPush.IncId = reqData.IncId;
			sunSpiritActionOperationEndPush.Index = reqData.Index;
			sunSpiritActionOperationEndPush.PlayerId = reqData.PlayerId;
			Net.Instance.Send(EPushMessageId.SunSpiritActionOperationEndPush, sunSpiritActionOperationEndPush);
		}

		// Token: 0x06043768 RID: 276328 RVA: 0x0107DA38 File Offset: 0x0107BC38
		private unsafe void OnActionOperationChildTaskFinish(SunSpiritActionOperationNotify notify, SunSpiritPb childTaskPb)
		{
			HashSet<SunSpiritPb> hashSet;
			if (!this.ActiveActionOperationNotifyHandlerMap.TryGetValue(notify, out hashSet))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: 执行操作，单个日灵执行操作完成回调时，发现所属的操作列表已非活跃";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RelatedSceneItemId", notify.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationType", notify.OperationType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SunSpiritConfigId", childTaskPb.EntityConfigId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (!hashSet.Contains(childTaskPb))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SunSpirit;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "日灵: 执行操作，单个日灵执行操作完成回调时，发现所执行的操作已非活跃";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("RelatedSceneItemId", notify.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("OperationType", notify.OperationType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SunSpiritConfigId", childTaskPb.EntityConfigId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SunSpirit;
			ELogAuthor author3 = ELogAuthor.ZYL;
			string message3 = "日灵: 执行操作，单个日灵执行操作完成";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("RelatedSceneItemId", notify.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("OperationType", notify.OperationType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("SunSpiritConfigId", childTaskPb.EntityConfigId);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			hashSet.Remove(childTaskPb);
			if (hashSet.Count == 0)
			{
				this.ActiveActionOperationNotifyHandlerMap.Remove(notify);
				if (notify.OperationType == SunSpiritOperationType.Fly)
				{
					foreach (SunSpiritPb sunSpiritPb in notify.TakeUpInfo)
					{
						SunSpiritModel instance4 = SunSpiritModel.Instance;
						if (instance4 != null)
						{
							instance4.AddOrUpdateSunSpiritDataByPb(sunSpiritPb, true);
						}
					}
				}
				this.PushSunSpiritActionOperationEnd(notify);
			}
		}

		// Token: 0x06043769 RID: 276329 RVA: 0x0107DC88 File Offset: 0x0107BE88
		private void OnBattleStateChanged(bool isInBattleState)
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			if (instance != null)
			{
				CreatureModel instance2 = CreatureModel.Instance;
				int playerId = (instance2 != null) ? instance2.GetPlayerId() : 0;
				AreaModel instance3 = AreaModel.Instance;
				Area? area;
				instance.GetAllSunSpiritDataByPlayerIdAndAreaId(playerId, ((instance3 != null) ? ((instance3.AreaInfo != null) ? new int?(area.GetValueOrDefault().AreaId) : null) : null).GetValueOrDefault(), true, null, this.TempSunSpiritList);
			}
			foreach (SunSpiritData sunSpiritData in this.TempSunSpiritList)
			{
				if (sunSpiritData.GetSunSpiritState().StateType == ESunSpiritStateType.OccupiedByPlayer)
				{
					SunSpiritBasePerform sunSpiritPerform = sunSpiritData.GetSunSpiritPerform();
					if (sunSpiritPerform is SunSpiritCrowdPerform)
					{
						((SunSpiritCrowdPerform)sunSpiritPerform).OnBattleStateChanged(isInBattleState);
					}
				}
			}
		}

		// Token: 0x17009884 RID: 39044
		// (get) Token: 0x0604376A RID: 276330 RVA: 0x0107DD78 File Offset: 0x0107BF78
		public static SunSpiritController Instance
		{
			get
			{
				return SunSpiritController._Instance;
			}
		}

		// Token: 0x0604376B RID: 276331 RVA: 0x0107DD7F File Offset: 0x0107BF7F
		public static SunSpiritController GetOrCreateInstance()
		{
			if (SunSpiritController._Instance == null)
			{
				SunSpiritController.CreateInstance();
			}
			return SunSpiritController._Instance;
		}

		// Token: 0x0604376C RID: 276332 RVA: 0x0107DD93 File Offset: 0x0107BF93
		public static bool CreateInstance()
		{
			if (SunSpiritController._Instance != null)
			{
				return true;
			}
			SunSpiritController._Instance = new SunSpiritController();
			return true;
		}

		// Token: 0x0604376D RID: 276333 RVA: 0x0107DDA9 File Offset: 0x0107BFA9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604376E RID: 276334 RVA: 0x0107DDAB File Offset: 0x0107BFAB
		public static void ResetStaticDefaultValue()
		{
			SunSpiritController._Instance = null;
		}

		// Token: 0x0604376F RID: 276335 RVA: 0x0107DDB3 File Offset: 0x0107BFB3
		static SunSpiritController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SunSpiritController.CreateStaticDefaultValue), new Action(SunSpiritController.ResetStaticDefaultValue));
		}

		// Token: 0x0402335A RID: 144218
		public const string DEBUG_KEY = "SunSpirit";

		// Token: 0x0402335B RID: 144219
		public const int TICK_INTERVAL = 33;

		// Token: 0x0402335C RID: 144220
		[StaticVariableRuleIgnore]
		public readonly int[] ENABLE_TAGS = new int[]
		{
			GameplayTagDefine.EGameplayTagId["关卡.日灵.3_0浮光林POI日灵"]
		};

		// Token: 0x0402335D RID: 144221
		[Nullable(2)]
		private SunSpiritHintView SunSpiritHintView;

		// Token: 0x0402335E RID: 144222
		[Nullable(2)]
		private SunSpiritLauncherHintView SunSpiritLauncherHintView;

		// Token: 0x0402335F RID: 144223
		private readonly List<ITagTask> TagListeners = new List<ITagTask>();

		// Token: 0x04023360 RID: 144224
		private double DeltaFromLastTick;

		// Token: 0x04023361 RID: 144225
		private readonly List<SunSpiritData> TempSunSpiritList = new List<SunSpiritData>();

		// Token: 0x04023362 RID: 144226
		private readonly Dictionary<SunSpiritActionOperationNotify, HashSet<SunSpiritPb>> ActiveActionOperationNotifyHandlerMap = new Dictionary<SunSpiritActionOperationNotify, HashSet<SunSpiritPb>>();

		// Token: 0x04023363 RID: 144227
		[Nullable(2)]
		private static SunSpiritController _Instance;
	}
}
