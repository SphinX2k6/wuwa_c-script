using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005367 RID: 21351
	public class GuqinSubController : MusicalInstrumentSubController
	{
		// Token: 0x060368C0 RID: 223424 RVA: 0x00CEA66B File Offset: 0x00CE886B
		public override EInstrumentType GetType()
		{
			return EInstrumentType.ChineseZither;
		}

		// Token: 0x060368C1 RID: 223425 RVA: 0x00CEA670 File Offset: 0x00CE8870
		[NullableContext(2)]
		private string GetAbortReason()
		{
			GameModeModel instance = GameModeModel.Instance;
			if (!instance.WorldDone)
			{
				return "世界未就绪";
			}
			if (instance.IsTeleport)
			{
				return "传送中";
			}
			if (instance.ChangeModeState)
			{
				return "切换世界模式中";
			}
			if (this.IsEnterCancelled)
			{
				return "进入已被取消";
			}
			if (this.IsEntityChanged())
			{
				return "弹琴实体已被换下";
			}
			if (this.IsSkillStarted && !this.IsSkillPlaying())
			{
				return "弹琴技能已被打断";
			}
			return null;
		}

		// Token: 0x060368C2 RID: 223426 RVA: 0x00CEA6E0 File Offset: 0x00CE88E0
		private bool CheckAborted()
		{
			string abortReason = this.GetAbortReason();
			if (abortReason == null)
			{
				return false;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MusicalInstrument;
			ELogAuthor author = ELogAuthor.CB;
			string message = "古琴玩法:进入中止";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", abortReason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x060368C3 RID: 223427 RVA: 0x00CEA724 File Offset: 0x00CE8924
		public override UniTask<bool> OnEnter([Nullable(1)] MusicalInstrumentEnterParam param)
		{
			GuqinSubController.<OnEnter>d__17 <OnEnter>d__;
			<OnEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnEnter>d__.<>4__this = this;
			<OnEnter>d__.<>1__state = -1;
			<OnEnter>d__.<>t__builder.Start<GuqinSubController.<OnEnter>d__17>(ref <OnEnter>d__);
			return <OnEnter>d__.<>t__builder.Task;
		}

		// Token: 0x060368C4 RID: 223428 RVA: 0x00CEA767 File Offset: 0x00CE8967
		public override void CancelEnter()
		{
			this.IsEnterCancelled = true;
			this.EndSkill();
			this.CancelWaitMontage();
		}

		// Token: 0x060368C5 RID: 223429 RVA: 0x00CEA77C File Offset: 0x00CE897C
		private bool CheckRestrictedWithTip()
		{
			int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
			if (restrictConditionGroupId <= 0)
			{
				return false;
			}
			if (!LevelGeneralController.Instance.CheckCondition(restrictConditionGroupId.ToString(), null, false, Array.Empty<object>()))
			{
				return false;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MusicalInstrument;
			ELogAuthor author = ELogAuthor.CB;
			string message = "古琴玩法:进入-限制条件已满足,取消进入";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConditionGroupId", restrictConditionGroupId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(restrictConditionGroupId);
			if (conditionGroupHintText != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupHintText, Array.Empty<object>());
			}
			return true;
		}

		// Token: 0x060368C6 RID: 223430 RVA: 0x00CEA818 File Offset: 0x00CE8A18
		private UniTask EnsureBattleViewReset()
		{
			GuqinSubController.<EnsureBattleViewReset>d__20 <EnsureBattleViewReset>d__;
			<EnsureBattleViewReset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureBattleViewReset>d__.<>1__state = -1;
			<EnsureBattleViewReset>d__.<>t__builder.Start<GuqinSubController.<EnsureBattleViewReset>d__20>(ref <EnsureBattleViewReset>d__);
			return <EnsureBattleViewReset>d__.<>t__builder.Task;
		}

		// Token: 0x060368C7 RID: 223431 RVA: 0x00CEA854 File Offset: 0x00CE8A54
		private UniTask<bool> PrepareNormalEnter()
		{
			GuqinSubController.<PrepareNormalEnter>d__21 <PrepareNormalEnter>d__;
			<PrepareNormalEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareNormalEnter>d__.<>4__this = this;
			<PrepareNormalEnter>d__.<>1__state = -1;
			<PrepareNormalEnter>d__.<>t__builder.Start<GuqinSubController.<PrepareNormalEnter>d__21>(ref <PrepareNormalEnter>d__);
			return <PrepareNormalEnter>d__.<>t__builder.Task;
		}

		// Token: 0x060368C8 RID: 223432 RVA: 0x00CEA898 File Offset: 0x00CE8A98
		private bool PrepareQteEnter()
		{
			this.HandleBattleViewVisible(false);
			string uiCameraId = ConfigGuQinActivityParamById.GetConfig(111400001, true).Value.UiCameraId;
			this.CameraHandle = UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(uiCameraId, false, true, "1001", false, null, null);
			if (!this.CaptureCurrentEntity())
			{
				return false;
			}
			this.PlayQtePreMontage();
			return true;
		}

		// Token: 0x060368C9 RID: 223433 RVA: 0x00CEA8FC File Offset: 0x00CE8AFC
		private UniTask<bool> EnterInternal([Nullable(2)] MusicalInstrumentQteData qteData)
		{
			GuqinSubController.<EnterInternal>d__23 <EnterInternal>d__;
			<EnterInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnterInternal>d__.<>4__this = this;
			<EnterInternal>d__.qteData = qteData;
			<EnterInternal>d__.<>1__state = -1;
			<EnterInternal>d__.<>t__builder.Start<GuqinSubController.<EnterInternal>d__23>(ref <EnterInternal>d__);
			return <EnterInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060368CA RID: 223434 RVA: 0x00CEA948 File Offset: 0x00CE8B48
		[NullableContext(2)]
		private void RollbackEnter(MusicalInstrumentQteData qteData)
		{
			this.RemoveExitEvents();
			if (this.IsServerEntered)
			{
				this.RequestPlayState(ZitherOpState.OpExit).Forget<bool>();
				this.IsServerEntered = false;
			}
			if (EventSystem.Instance.Has<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd)))
			{
				EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
			}
			this.EndSkill();
			this.CancelWaitMontage();
			this.DestroyView();
			if (qteData == null)
			{
				if (this.ConditionPassCallback != null)
				{
					int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
					LevelConditionRegistry.Instance.UnRegisterConditionGroup(restrictConditionGroupId, this.ConditionPassCallback);
				}
			}
			else if (this.CameraHandle != null)
			{
				this.PlayQteEndSection();
				UiCameraAnimationManager.Instance.PopCameraHandle(this.CameraHandle, null);
				this.CameraHandle = null;
			}
			this.HandleBattleViewVisible(true);
			LevelLoadingController.Instance.CloseLoading((qteData == null) ? ELoadingReason.MusicalInstrument : ELoadingReason.Common, "GuqinSubController.Enter", null, new float?(0.5f));
			this.UnlockInput();
		}

		// Token: 0x060368CB RID: 223435 RVA: 0x00CEAA4E File Offset: 0x00CE8C4E
		private void RefreshInputTag(EInputControllerMainType last, EInputControllerMainType now)
		{
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x060368CC RID: 223436 RVA: 0x00CEAA5A File Offset: 0x00CE8C5A
		private void LockInput()
		{
			InputManager.Instance.RegisterLockShortcutKeyReason("MusicalInstrument.ChineseZither", null);
			this.SetInputRestricted(true);
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.RefreshInputTag));
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x060368CD RID: 223437 RVA: 0x00CEAA99 File Offset: 0x00CE8C99
		private void UnlockInput()
		{
			InputManager.Instance.RemoveLockShortcutKeyReason("MusicalInstrument.ChineseZither");
			this.SetInputRestricted(false);
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.RefreshInputTag));
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x060368CE RID: 223438 RVA: 0x00CEAAD8 File Offset: 0x00CE8CD8
		private void SetInputRestricted(bool restricted)
		{
			MusicalInstrumentSubModel subModel = base.GetSubModel();
			if (subModel == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到SubModel", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			subModel.IsInputRestricted = restricted;
		}

		// Token: 0x060368CF RID: 223439 RVA: 0x00CEAB18 File Offset: 0x00CE8D18
		private void AddExitEvents()
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationChanged));
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add(EEventName.ChangeMode, new Action(this.OnGameModeChanged));
		}

		// Token: 0x060368D0 RID: 223440 RVA: 0x00CEAB98 File Offset: 0x00CE8D98
		private void RemoveExitEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationChanged));
			EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Remove<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove(EEventName.ChangeMode, new Action(this.OnGameModeChanged));
		}

		// Token: 0x060368D1 RID: 223441 RVA: 0x00CEAC18 File Offset: 0x00CE8E18
		private bool CaptureCurrentEntity()
		{
			this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (this.CurrentEntity == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:进入-取不到弹琴实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x060368D2 RID: 223442 RVA: 0x00CEAC5F File Offset: 0x00CE8E5F
		private bool IsEntityOnStage()
		{
			return this.CurrentEntity != null && this.CurrentEntity == SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x060368D3 RID: 223443 RVA: 0x00CEAC7D File Offset: 0x00CE8E7D
		private bool IsEntityChanged()
		{
			return this.CurrentEntity != null && this.CurrentEntity != SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x060368D4 RID: 223444 RVA: 0x00CEACA0 File Offset: 0x00CE8EA0
		private void OnFormationChanged()
		{
			if (!this.IsEntityChanged())
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MusicalInstrument;
			ELogAuthor author = ELogAuthor.CB;
			string message = "古琴玩法:弹琴实体已被换下,触发退出";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Old";
			EntityHandle currentEntity = this.CurrentEntity;
			ptr = new ValueTuple<string, object>(item, (currentEntity != null) ? new int?(currentEntity.Id) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "New";
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			ptr2 = new ValueTuple<string, object>(item2, (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x060368D5 RID: 223445 RVA: 0x00CEAD78 File Offset: 0x00CE8F78
		private void OnGameModeChanged()
		{
			global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:世界模式已切换,触发退出", default(ReadOnlySpan<ValueTuple<string, object>>));
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x060368D6 RID: 223446 RVA: 0x00CEADC4 File Offset: 0x00CE8FC4
		private void OnRestrictConditionCallback([Nullable(new byte[]
		{
			2,
			1
		})] object[] parameters)
		{
			int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
			if (restrictConditionGroupId > 0)
			{
				string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(restrictConditionGroupId);
				if (conditionGroupHintText != null)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupHintText, Array.Empty<object>());
				}
			}
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x060368D7 RID: 223447 RVA: 0x00CEAE2F File Offset: 0x00CE902F
		private void OnTeleportStart(bool loading)
		{
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x060368D8 RID: 223448 RVA: 0x00CEAE54 File Offset: 0x00CE9054
		private void OnRoleDead(int charId)
		{
			EntityHandle currentEntity = this.CurrentEntity;
			int? num = (currentEntity != null) ? new int?(currentEntity.Id) : null;
			if (!(charId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.CurrentEntity = null;
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x060368D9 RID: 223449 RVA: 0x00CEAEC0 File Offset: 0x00CE90C0
		private void OnSkillEnd(int entityId, int skillId)
		{
			EntityHandle currentEntity = this.CurrentEntity;
			int? num = (currentEntity != null) ? new int?(currentEntity.Id) : null;
			if (!(entityId == num.GetValueOrDefault() & num != null) || skillId != 800030)
			{
				return;
			}
			this.IsSkillEnded = true;
			this.CancelWaitMontage();
		}

		// Token: 0x060368DA RID: 223450 RVA: 0x00CEAF18 File Offset: 0x00CE9118
		private UniTask<bool> CreateView()
		{
			GuqinSubController.<CreateView>d__40 <CreateView>d__;
			<CreateView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CreateView>d__.<>4__this = this;
			<CreateView>d__.<>1__state = -1;
			<CreateView>d__.<>t__builder.Start<GuqinSubController.<CreateView>d__40>(ref <CreateView>d__);
			return <CreateView>d__.<>t__builder.Task;
		}

		// Token: 0x060368DB RID: 223451 RVA: 0x00CEAF5B File Offset: 0x00CE915B
		private void DestroyView()
		{
			if (this.ViewId != null)
			{
				UiManager.Instance.CloseViewById(this.ViewId.Value, null);
				this.ViewId = null;
			}
		}

		// Token: 0x060368DC RID: 223452 RVA: 0x00CEAF8C File Offset: 0x00CE918C
		private void HandleBattleViewVisible(bool visible)
		{
			if (visible)
			{
				BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
				if (childViewData == null)
				{
					return;
				}
				childViewData.ShowBattleView(EBattleUiVisibleReason.UiControl, 0);
				return;
			}
			else
			{
				BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
				if (childViewData2 == null)
				{
					return;
				}
				childViewData2.HideBattleView(EBattleUiVisibleReason.UiControl, new List<EBattleUiChild>
				{
					EBattleUiChild.GuideTipsView
				}, 0);
				return;
			}
		}

		// Token: 0x060368DD RID: 223453 RVA: 0x00CEAFD8 File Offset: 0x00CE91D8
		public override UniTask<bool> OnExit([Nullable(1)] MusicalInstrumentExitParam param)
		{
			GuqinSubController.<OnExit>d__43 <OnExit>d__;
			<OnExit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnExit>d__.<>4__this = this;
			<OnExit>d__.<>1__state = -1;
			<OnExit>d__.<>t__builder.Start<GuqinSubController.<OnExit>d__43>(ref <OnExit>d__);
			return <OnExit>d__.<>t__builder.Task;
		}

		// Token: 0x060368DE RID: 223454 RVA: 0x00CEB01C File Offset: 0x00CE921C
		private UniTask<bool> UseSkill()
		{
			GuqinSubController.<UseSkill>d__44 <UseSkill>d__;
			<UseSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UseSkill>d__.<>1__state = -1;
			<UseSkill>d__.<>t__builder.Start<GuqinSubController.<UseSkill>d__44>(ref <UseSkill>d__);
			return <UseSkill>d__.<>t__builder.Task;
		}

		// Token: 0x060368DF RID: 223455 RVA: 0x00CEB058 File Offset: 0x00CE9258
		private bool IsSkillPlaying()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return false;
			}
			global::Skill currentSkill = obj2.CurrentSkill;
			return ((currentSkill != null) ? new int?(currentSkill.SkillId) : null).GetValueOrDefault() == 800030;
		}

		// Token: 0x060368E0 RID: 223456 RVA: 0x00CEB0B8 File Offset: 0x00CE92B8
		private void EndSkill()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			object obj2 = obj;
			bool flag;
			if (obj2 == null)
			{
				flag = true;
			}
			else
			{
				global::Skill currentSkill = obj2.CurrentSkill;
				flag = (((currentSkill != null) ? new int?(currentSkill.SkillId) : null).GetValueOrDefault() != 800030);
			}
			if (flag)
			{
				return;
			}
			EntityHandle currentEntity2 = this.CurrentEntity;
			BaseTagComponent baseTagComponent;
			if (currentEntity2 == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity2 = currentEntity2.Entity;
				baseTagComponent = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到Tag组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int tagIdByName = GameplayTagUtils.GetTagIdByName("系统.活动.弹琴玩法.结束弹琴");
			if (baseTagComponent2.HasTag(tagIdByName))
			{
				return;
			}
			baseTagComponent2.AddTag(new int?(tagIdByName));
		}

		// Token: 0x060368E1 RID: 223457 RVA: 0x00CEB180 File Offset: 0x00CE9380
		private UniTask WaitQteAudioFinish()
		{
			GuqinSubController.<WaitQteAudioFinish>d__47 <WaitQteAudioFinish>d__;
			<WaitQteAudioFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitQteAudioFinish>d__.<>4__this = this;
			<WaitQteAudioFinish>d__.<>1__state = -1;
			<WaitQteAudioFinish>d__.<>t__builder.Start<GuqinSubController.<WaitQteAudioFinish>d__47>(ref <WaitQteAudioFinish>d__);
			return <WaitQteAudioFinish>d__.<>t__builder.Task;
		}

		// Token: 0x060368E2 RID: 223458 RVA: 0x00CEB1C3 File Offset: 0x00CE93C3
		public override void OnQteCompleted()
		{
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetType()
			}).Forget<bool>();
		}

		// Token: 0x060368E3 RID: 223459 RVA: 0x00CEB1E8 File Offset: 0x00CE93E8
		private void PlayQtePreMontage()
		{
			GuQinActivityParam? config = ConfigGuQinActivityParamById.GetConfig(111400001, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.MusicalInstrument;
				ELogAuthor author = ELogAuthor.CB;
				string message = "古琴玩法:获取不到活动配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", 111400001);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			GuQinActivityParam valueOrDefault = config.GetValueOrDefault();
			string montagePath = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? valueOrDefault.MaleMontagePaths(0) : valueOrDefault.FemaleMontagePaths(0);
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterAnimationComponent characterAnimationComponent;
			if (currentEntity == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAnimationComponent2.MontageManager.PlayMontage(new IPlayMontageParam
			{
				MontagePath = montagePath,
				InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.START_SECTION)
			});
		}

		// Token: 0x060368E4 RID: 223460 RVA: 0x00CEB2DC File Offset: 0x00CE94DC
		private UniTask WaitMontageSection(FName sectionName)
		{
			GuqinSubController.<WaitMontageSection>d__50 <WaitMontageSection>d__;
			<WaitMontageSection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitMontageSection>d__.<>4__this = this;
			<WaitMontageSection>d__.sectionName = sectionName;
			<WaitMontageSection>d__.<>1__state = -1;
			<WaitMontageSection>d__.<>t__builder.Start<GuqinSubController.<WaitMontageSection>d__50>(ref <WaitMontageSection>d__);
			return <WaitMontageSection>d__.<>t__builder.Task;
		}

		// Token: 0x060368E5 RID: 223461 RVA: 0x00CEB328 File Offset: 0x00CE9528
		private void CancelWaitMontage()
		{
			TimerHandle montageTimer = this.MontageTimer;
			if (montageTimer != null && montageTimer.Valid())
			{
				this.MontageTimer.Remove();
			}
			this.MontageTimer = null;
			CustomPromise montagePromise = this.MontagePromise;
			if (montagePromise != null)
			{
				montagePromise.SetResult();
			}
			this.MontagePromise = null;
		}

		// Token: 0x060368E6 RID: 223462 RVA: 0x00CEB374 File Offset: 0x00CE9574
		private float? GetMontageSectionEndTime(FName sectionName)
		{
			if (!this.IsEntityOnStage())
			{
				return null;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			UAnimMontage uanimMontage;
			if (obj2 == null)
			{
				uanimMontage = null;
			}
			else
			{
				UAnimInstance mainAnimInstance = obj2.MainAnimInstance;
				uanimMontage = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
			}
			UAnimMontage uanimMontage2 = uanimMontage;
			if (uanimMontage2 == null)
			{
				return null;
			}
			TArray<FCompositeSection> compositeSections = uanimMontage2.CompositeSections;
			int num = compositeSections.Num();
			for (int i = 0; i < num; i++)
			{
				if (compositeSections.Get(i).SectionName.Equals(sectionName))
				{
					return new float?((i + 1 < num) ? compositeSections.Get(i + 1).SegmentBeginTime : uanimMontage2.SequenceLength);
				}
			}
			return null;
		}

		// Token: 0x060368E7 RID: 223463 RVA: 0x00CEB43C File Offset: 0x00CE963C
		private UniTask WaitMontagePosition(float targetPosition)
		{
			GuqinSubController.<WaitMontagePosition>d__53 <WaitMontagePosition>d__;
			<WaitMontagePosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitMontagePosition>d__.<>4__this = this;
			<WaitMontagePosition>d__.targetPosition = targetPosition;
			<WaitMontagePosition>d__.<>1__state = -1;
			<WaitMontagePosition>d__.<>t__builder.Start<GuqinSubController.<WaitMontagePosition>d__53>(ref <WaitMontagePosition>d__);
			return <WaitMontagePosition>d__.<>t__builder.Task;
		}

		// Token: 0x060368E8 RID: 223464 RVA: 0x00CEB488 File Offset: 0x00CE9688
		private float GetCurrentMontageBlendInTime()
		{
			if (!this.IsEntityOnStage())
			{
				return 0f;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			object obj3;
			if (obj2 == null)
			{
				obj3 = null;
			}
			else
			{
				UAnimInstance mainAnimInstance = obj2.MainAnimInstance;
				obj3 = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
			}
			object obj4 = obj3;
			if (obj4 == null)
			{
				return 0f;
			}
			return obj4.BlendIn.BlendTime;
		}

		// Token: 0x060368E9 RID: 223465 RVA: 0x00CEB4F0 File Offset: 0x00CE96F0
		private void PlayQtePostMontage()
		{
			GuQinActivityParam? config = ConfigGuQinActivityParamById.GetConfig(111400001, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.MusicalInstrument;
				ELogAuthor author = ELogAuthor.CB;
				string message = "古琴玩法:获取不到活动配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", 111400001);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			GuQinActivityParam valueOrDefault = config.GetValueOrDefault();
			string montagePath = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? valueOrDefault.MaleMontagePaths(1) : valueOrDefault.FemaleMontagePaths(1);
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterAnimationComponent characterAnimationComponent;
			if (currentEntity == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAnimationComponent2.MontageManager.PlayMontage(new IPlayMontageParam
			{
				MontagePath = montagePath,
				InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.LOOP_SECTION)
			});
		}

		// Token: 0x060368EA RID: 223466 RVA: 0x00CEB5E4 File Offset: 0x00CE97E4
		private void PlayQteEndSection()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterAnimationComponent characterAnimationComponent;
			if (currentEntity == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (characterAnimationComponent2 == null)
			{
				global::Log.Instance.Info(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取不到动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAnimationComponent2.MontageManager.StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendToEndSection)
			});
		}

		// Token: 0x060368EB RID: 223467 RVA: 0x00CEB650 File Offset: 0x00CE9850
		private float GetCurrentMontageBlendOutTime()
		{
			if (!this.IsEntityOnStage())
			{
				return 0f;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			object obj;
			if (currentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			object obj3;
			if (obj2 == null)
			{
				obj3 = null;
			}
			else
			{
				UAnimInstance mainAnimInstance = obj2.MainAnimInstance;
				obj3 = ((mainAnimInstance != null) ? mainAnimInstance.GetCurrentActiveMontage() : null);
			}
			object obj4 = obj3;
			if (obj4 == null)
			{
				return 0f;
			}
			return obj4.BlendOut.BlendTime;
		}

		// Token: 0x060368EC RID: 223468 RVA: 0x00CEB6B8 File Offset: 0x00CE98B8
		private UniTask<bool> RequestPlayState(ZitherOpState state)
		{
			GuqinSubController.<RequestPlayState>d__58 <RequestPlayState>d__;
			<RequestPlayState>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestPlayState>d__.state = state;
			<RequestPlayState>d__.<>1__state = -1;
			<RequestPlayState>d__.<>t__builder.Start<GuqinSubController.<RequestPlayState>d__58>(ref <RequestPlayState>d__);
			return <RequestPlayState>d__.<>t__builder.Task;
		}

		// Token: 0x060368ED RID: 223469 RVA: 0x00CEB6FB File Offset: 0x00CE98FB
		[NullableContext(2)]
		public GuqinView GetView()
		{
			if (this.ViewId == null)
			{
				return null;
			}
			return UiManager.Instance.GetView(this.ViewId.Value) as GuqinView;
		}

		// Token: 0x060368EE RID: 223470 RVA: 0x00CEB728 File Offset: 0x00CE9928
		[NullableContext(1)]
		public void OnGamepadCameraZoom(string axisName, float value)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			MusicalInstrumentSubModel subModel = base.GetSubModel();
			if (((subModel != null) ? subModel.GetQteData() : null) != null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.HelpView))
			{
				return;
			}
			EntityHandle currentEntity = this.CurrentEntity;
			CharacterInputComponent characterInputComponent;
			if (currentEntity == null)
			{
				characterInputComponent = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				characterInputComponent = ((entity != null) ? entity.GetComponent<CharacterInputComponent>() : null);
			}
			CharacterInputComponent characterInputComponent2 = characterInputComponent;
			if (characterInputComponent2 == null)
			{
				return;
			}
			float value2 = value * 80f;
			characterInputComponent2.HandleInputAxis(EInputAxis.Zoom, value2);
		}

		// Token: 0x0401CD6B RID: 118123
		private const int SKILL_ID = 800030;

		// Token: 0x0401CD6C RID: 118124
		private const int ACTIVITYID = 111400001;

		// Token: 0x0401CD6D RID: 118125
		[Nullable(1)]
		private const string END_GUQIN_TAG_NAME = "系统.活动.弹琴玩法.结束弹琴";

		// Token: 0x0401CD6E RID: 118126
		private const float BLACK_FADE_TIME = 0.5f;

		// Token: 0x0401CD6F RID: 118127
		[Nullable(2)]
		private CustomPromise MontagePromise;

		// Token: 0x0401CD70 RID: 118128
		[Nullable(2)]
		private TimerHandle MontageTimer;

		// Token: 0x0401CD71 RID: 118129
		[Nullable(2)]
		private UiCameraHandleData CameraHandle;

		// Token: 0x0401CD72 RID: 118130
		private int? ViewId;

		// Token: 0x0401CD73 RID: 118131
		[Nullable(1)]
		private ConditionPassCallback ConditionPassCallback;

		// Token: 0x0401CD74 RID: 118132
		[Nullable(2)]
		private EntityHandle CurrentEntity;

		// Token: 0x0401CD75 RID: 118133
		private bool IsSkillEnded;

		// Token: 0x0401CD76 RID: 118134
		private bool IsEnterCancelled;

		// Token: 0x0401CD77 RID: 118135
		private bool IsSkillStarted;

		// Token: 0x0401CD78 RID: 118136
		private bool IsServerEntered;
	}
}
