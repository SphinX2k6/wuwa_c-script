using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02005C03 RID: 23555
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockController : ControllerBase
	{
		// Token: 0x06039D7D RID: 236925 RVA: 0x0103F2E8 File Offset: 0x0103D4E8
		protected override bool OnInit()
		{
			Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[RollBlockController] 初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			ResourceSystem.Instance.LoadAsync<BP_RollBlockGameplaySetting_C>("/Game/Aki/Data/Gameplay/RollBlock/DA_RollBlockSetting.DA_RollBlockSetting", delegate([Nullable(2)] BP_RollBlockGameplaySetting_C result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RollBlock;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[RollBlockController] 配置加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Data/Gameplay/RollBlock/DA_RollBlockSetting.DA_RollBlockSetting");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.GameplaySetting = result;
			}, 100, "js_undefined");
			ResourceSystem.Instance.LoadAsync<UKuroForceFeedbackEffect>("/Game/Aki/Character/Role/Common/Data/GamePadShake/CommonShake/FF_Common_Lv1.FF_Common_Lv1", delegate([Nullable(2)] UKuroForceFeedbackEffect result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RollBlock;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[RollBlockController] 通用震动配置加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Character/Role/Common/Data/GamePadShake/CommonShake/FF_Common_Lv1.FF_Common_Lv1");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.CommonForceFeedback = result;
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x06039D7E RID: 236926 RVA: 0x0103F35C File Offset: 0x0103D55C
		public unsafe void EnterRollBlockGameplay(RollBlockOpenGamePlayNotify notify, bool isReset = false)
		{
			if (this.GameplaySetting == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[EnterRollBlockGameplay] GameplaySetting未加载完成", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RollBlockGamePlayPbInfo info = notify.Info;
			int? num = (info != null) ? new int?(info.IncId) : null;
			if (num == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[EnterRollBlockGameplay] IncId未定义", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.OpenedGameplayInfo.ContainsKey(num.Value))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[EnterRollBlockGameplay] IncId重复";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (notify.Info == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[EnterRollBlockGameplay] Info未定义";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", num);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo = new RollBlockGameplayInfo(notify.Info);
			if (this.IsMainController && rollBlockGameplayInfo.IsMainController)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RollBlock;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "[EnterRollBlockGameplay] IsMainController重复";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GroupId", rollBlockGameplayInfo.GroupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Difficulty", rollBlockGameplayInfo.Difficulty);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (rollBlockGameplayInfo.Forward == null || rollBlockGameplayInfo.Right == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.RollBlock;
				ELogAuthor author4 = ELogAuthor.CH;
				string message4 = "[EnterRollBlockGameplay] Forward或Right未定义";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IncId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Forward", rollBlockGameplayInfo.Forward);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Right", rollBlockGameplayInfo.Right);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			this.IsMainController = rollBlockGameplayInfo.IsMainController;
			if (this.IsMainController)
			{
				this.CurrentIncId = num;
				if (!isReset)
				{
					this.TotalInputCount = 0;
				}
				this.MistakeInputCount = 0;
				this.IsOpeningGuide = false;
				EventSystem.Instance.Add(EEventName.OpenView, new Action<EUiViewName, int>(this.OnGuideGroupOpening));
				EventSystem.Instance.Emit<int>(EEventName.OnRollBlockDifficultyChanged, rollBlockGameplayInfo.Difficulty);
			}
			else
			{
				if (!EventSystem.Instance.Has(EEventName.OnLeaveOnlineWorld, new Action(this.ExitOnOnlineModeChange)))
				{
					EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.ExitOnOnlineModeChange));
				}
				this.OnlineCurrentIncId = num;
			}
			if (this.OpenedGameplayInfo.Count == 0)
			{
				EventSystem.Instance.Add(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnEntityCreated));
			}
			this.OpenedGameplayInfo[num.Value] = rollBlockGameplayInfo;
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.RollBlock;
			ELogAuthor author5 = ELogAuthor.CH;
			string message5 = "[EnterRollBlockGameplay] EnterRollBlockGameplay成功";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("IncId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("GroupId", rollBlockGameplayInfo.GroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("Difficulty", rollBlockGameplayInfo.Difficulty);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("IsMainController", rollBlockGameplayInfo.IsMainController);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("EntityIds", rollBlockGameplayInfo.EntityIds);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("InitVisibleEntityIds", rollBlockGameplayInfo.InitVisibleEntityIds);
			instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 6));
			int playerId = CreatureModel.Instance.GetPlayerId();
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
			BaseTagComponent baseTagComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseTagComponent>() : null;
			int? cameraTag = rollBlockGameplayInfo.CameraTag;
			int num2 = 0;
			if (!(cameraTag.GetValueOrDefault() == num2 & cameraTag != null) && baseTagComponent != null)
			{
				baseTagComponent.AddTag(new int?(rollBlockGameplayInfo.CameraTag.Value));
			}
			rollBlockGameplayInfo.InitState = ERollBlockInitState.Enter;
			this.HandleGroupEntitiesCreate(num.Value);
			if (!this.IsReseting && rollBlockGameplayInfo.IsMainController)
			{
				UiManager.Instance.OpenView(EUiViewName.RollBlockView, null, null);
				if (baseTagComponent != null)
				{
					baseTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.休闲待机.禁用休闲待机"]));
				}
			}
			this.PressedKey.Clear();
			this.CurrentKey = null;
		}

		// Token: 0x06039D7F RID: 236927 RVA: 0x0103F814 File Offset: 0x0103DA14
		public void ExitRollBlockGameplay(int incId, bool isReset = false)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ExitRollBlockGameplay] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.OpenedGameplayInfo.Remove(incId);
			this.PendingTickFunctions.Remove(incId);
			if (rollBlockGameplayInfo.IsMainController)
			{
				this.IsMainController = false;
				this.CurrentIncId = null;
			}
			else
			{
				if (EventSystem.Instance.Has(EEventName.OnLeaveOnlineWorld, new Action(this.ExitOnOnlineModeChange)))
				{
					EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.ExitOnOnlineModeChange));
				}
				this.OnlineCurrentIncId = null;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
			BaseTagComponent baseTagComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseTagComponent>() : null;
			int? cameraTag = rollBlockGameplayInfo.CameraTag;
			int num = 0;
			if (!(cameraTag.GetValueOrDefault() == num & cameraTag != null) && baseTagComponent != null)
			{
				baseTagComponent.RemoveTag(new int?(rollBlockGameplayInfo.CameraTag.Value));
			}
			if (!isReset && rollBlockGameplayInfo.IsMainController)
			{
				UiManager.Instance.CloseView(EUiViewName.RollBlockView, null);
				if (baseTagComponent != null)
				{
					baseTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.休闲待机.禁用休闲待机"]));
				}
			}
			if (EventSystem.Instance.Has(EEventName.CloseView, new Action<EUiViewName, int>(this.OnGuideGroupFinished)))
			{
				EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnGuideGroupFinished));
			}
			if (EventSystem.Instance.Has(EEventName.OpenView, new Action<EUiViewName, int>(this.OnGuideGroupOpening)))
			{
				EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnGuideGroupOpening));
			}
			if (EventSystem.Instance.Has(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnEntityCreated)))
			{
				EventSystem.Instance.Remove(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnEntityCreated));
			}
			Dictionary<Entity, Action> dictionary;
			if (this.NotLoadCompletedEntity.TryGetValue(incId, out dictionary))
			{
				foreach (KeyValuePair<Entity, Action> keyValuePair in dictionary)
				{
					EventSystem.Instance.RemoveWithTarget(keyValuePair.Key, EEventName.OnSceneInteractionLoadCompleted, keyValuePair.Value);
				}
				this.NotLoadCompletedEntity.Remove(incId);
			}
		}

		// Token: 0x06039D80 RID: 236928 RVA: 0x0103FA88 File Offset: 0x0103DC88
		public unsafe void UpdateRollBlockGameplayInfo(RollBlockGamePlayPbInfo newInfo)
		{
			int incId = newInfo.IncId;
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[UpdateCurRollBlockGameplayInfo] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo2 = new RollBlockGameplayInfo(newInfo);
			this.IsMainController = rollBlockGameplayInfo2.IsMainController;
			if (this.IsMainController)
			{
				this.CurrentIncId = new int?(incId);
			}
			rollBlockGameplayInfo2.MultiBlock = rollBlockGameplayInfo.MultiBlock;
			this.OpenedGameplayInfo[incId] = rollBlockGameplayInfo2;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RollBlock;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[UpdateCurRollBlockGameplayInfo] 更新玩法信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", incId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Info", newInfo);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			foreach (long num in rollBlockGameplayInfo2.EntityIds)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				if (worldEntity == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.RollBlock;
					ELogAuthor author3 = ELogAuthor.CH;
					string message3 = "[UpdateCurRollBlockGameplayInfo] Entity不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", num);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else if (worldEntity.GetComponent<BaseTagComponent>() == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.RollBlock;
					ELogAuthor author4 = ELogAuthor.CH;
					string message4 = "[UpdateCurRollBlockGameplayInfo] BaseTagComponent不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("EntityId", num);
					instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				}
				else
				{
					RbBaseComponent component = worldEntity.GetComponent<RbBaseComponent>();
					if (component == null)
					{
						Log instance5 = Log.Instance;
						ELogModule module5 = ELogModule.RollBlock;
						ELogAuthor author5 = ELogAuthor.CH;
						string message5 = "[UpdateCurRollBlockGameplayInfo] rbBaseComponent不存在";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("IncId", incId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("EntityId", num);
						instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
					}
					else
					{
						component.RegisterToGameplay(incId);
					}
				}
			}
			foreach (long num2 in rollBlockGameplayInfo2.InitVisibleEntityIds)
			{
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(num2);
				WorldEntity worldEntity2 = (entity2 != null) ? entity2.Entity : null;
				if (worldEntity2 == null)
				{
					Log instance6 = Log.Instance;
					ELogModule module6 = ELogModule.RollBlock;
					ELogAuthor author6 = ELogAuthor.CH;
					string message6 = "[UpdateCurRollBlockGameplayInfo] Entity不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("EntityId", num2);
					instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
				}
				else if (worldEntity2.GetComponent<BaseTagComponent>() == null)
				{
					Log instance7 = Log.Instance;
					ELogModule module7 = ELogModule.RollBlock;
					ELogAuthor author7 = ELogAuthor.CH;
					string message7 = "[UpdateCurRollBlockGameplayInfo] BaseTagComponent不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("EntityId", num2);
					instance7.Error(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 2));
				}
				else
				{
					RbBaseComponent component2 = worldEntity2.GetComponent<RbBaseComponent>();
					if (component2 == null)
					{
						Log instance8 = Log.Instance;
						ELogModule module8 = ELogModule.RollBlock;
						ELogAuthor author8 = ELogAuthor.CH;
						string message8 = "[UpdateCurRollBlockGameplayInfo] rbBaseComponent不存在";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray7 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 0) = new ValueTuple<string, object>("IncId", incId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray7, 1) = new ValueTuple<string, object>("EntityId", num2);
						instance8.Error(module8, author8, message8, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray7, 2));
					}
					else
					{
						component2.RegisterToGameplay(incId);
					}
				}
			}
		}

		// Token: 0x06039D81 RID: 236929 RVA: 0x0103FEEC File Offset: 0x0103E0EC
		public void OnClickMoveInput(string name, InputDistributeDefine.EActionType actionType)
		{
			if (this.IsReseting)
			{
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnClickMoveInput] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool flag = false;
			foreach (RbBaseComponent rbBaseComponent in rollBlockGameplayInfo.RollBlockEntities)
			{
				if (rbBaseComponent.Valid && rbBaseComponent.IsMainController)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[OnClickMoveInput] 没有主控制方块，拦截输入";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.ProcessMoveInput(name, actionType);
			if ((name == this.CurrentKey && actionType == InputDistributeDefine.EActionType.Press) || (this.CurrentKey != null && rollBlockGameplayInfo != null && rollBlockGameplayInfo.AvailableInputs.Contains(RollBlockDefind.Input2RbGridDirection[this.CurrentKey]) && actionType == InputDistributeDefine.EActionType.Release))
			{
				this.OnClickMove();
			}
		}

		// Token: 0x06039D82 RID: 236930 RVA: 0x0104002C File Offset: 0x0103E22C
		private unsafe void ProcessMoveInput(string name, InputDistributeDefine.EActionType actionType)
		{
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				if (this.CurrentKey == null)
				{
					this.CurrentKey = name;
				}
				this.PressedKey.Add(name);
			}
			else
			{
				this.PressedKey.Remove(name);
				if (this.CurrentKey == name)
				{
					string currentKey = null;
					using (HashSet<string>.Enumerator enumerator = this.PressedKey.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							currentKey = enumerator.Current;
						}
					}
					this.CurrentKey = currentKey;
				}
			}
			if (this.CurrentKey != null)
			{
				this.InputDir = new RbGridDirection?(RollBlockDefind.Input2RbGridDirection[this.CurrentKey]);
			}
			else
			{
				this.InputDir = null;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RollBlock;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[Input] InputDir";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionType", actionType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurrentKey", this.CurrentKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("InputDir", this.InputDir);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("PressedKey", this.PressedKey);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x06039D83 RID: 236931 RVA: 0x010401A8 File Offset: 0x0103E3A8
		public void OnClickTip()
		{
			if (this.IsReseting || this.IsRequesting)
			{
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnClickTip] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (rollBlockGameplayInfo.HasTipActorNum > 0)
			{
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickTip] 已经有虚影方块", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickTip]", default(ReadOnlySpan<ValueTuple<string, object>>));
			RollBlockToggleHintRequest rollBlockToggleHintRequest = RollBlockToggleHintRequest.Create();
			rollBlockToggleHintRequest.IncId = this.CurrentIncId.Value;
			rollBlockToggleHintRequest.IsOpen = true;
			Net.Instance.Call(ERequestMessageId.RollBlockToggleHintRequest, rollBlockToggleHintRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RollBlockToggleHintResponse rollBlockToggleHintResponse = (RollBlockToggleHintResponse)msg;
				this.IsRequesting = false;
				if (rollBlockToggleHintResponse == null)
				{
					return;
				}
				Aki.Protocol.ErrorCode code = rollBlockToggleHintResponse.Code;
				if (code != Aki.Protocol.ErrorCode.Success && code != Aki.Protocol.ErrorCode.RollBlockHintAlreadyActive)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.RollBlock;
					ELogAuthor author2 = ELogAuthor.CH;
					string message2 = "[OnClickTip] RollBlockToggleHintRequest失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("errorCode", rollBlockToggleHintResponse.Code);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickTip] RollBlockToggleHintRequest成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, 0);
			this.IsRequesting = true;
		}

		// Token: 0x06039D84 RID: 236932 RVA: 0x010402A0 File Offset: 0x0103E4A0
		public void OnClickReset(bool needDelay = false, bool resetByRollBlockDestroy = false)
		{
			if ((this.IsReseting || this.IsRequesting) && !resetByRollBlockDestroy)
			{
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnClickMoveInput] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool flag = false;
			foreach (RbBaseComponent rbBaseComponent in rollBlockGameplayInfo.RollBlockEntities)
			{
				if (rbBaseComponent.Valid && rbBaseComponent.IsMainController)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[OnClickReset] 没有主控制方块，拦截重置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.IsReseting = true;
			EventSystem.Instance.Emit<ERollBlockResetPhase>(EEventName.OnRollBlockReseting, ERollBlockResetPhase.Start);
			if (needDelay)
			{
				TimerSystem.Instance.Delay(new TTimerAction(this.ExecuteResetInternal), (float)this.GameplaySetting.BlockDestroyDelayResetTime, null, null, true, 1f);
				return;
			}
			this.ExecuteResetInternal(0f);
		}

		// Token: 0x06039D85 RID: 236933 RVA: 0x010403F4 File Offset: 0x0103E5F4
		private void ExecuteResetInternal(float _)
		{
			Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickReset] 重置操作开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			RollBlockResetGamePlayRequest rollBlockResetGamePlayRequest = RollBlockResetGamePlayRequest.Create();
			rollBlockResetGamePlayRequest.IncId = this.CurrentIncId.Value;
			Net.Instance.Call(ERequestMessageId.RollBlockResetGamePlayRequest, rollBlockResetGamePlayRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RollBlockResetGamePlayResponse rollBlockResetGamePlayResponse = (RollBlockResetGamePlayResponse)msg;
				if (rollBlockResetGamePlayResponse == null)
				{
					return;
				}
				if (rollBlockResetGamePlayResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RollBlock;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[OnClickReset] RollBlockResetGamePlayRequest失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", rollBlockResetGamePlayResponse.Code);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.IsReseting = false;
					EventSystem.Instance.Emit<ERollBlockResetPhase>(EEventName.OnRollBlockReseting, ERollBlockResetPhase.Failure);
					return;
				}
				EventSystem.Instance.Emit<ERollBlockResetPhase>(EEventName.OnRollBlockReseting, ERollBlockResetPhase.Succeed);
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickReset] RollBlockResetGamePlayRequest成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, 0);
		}

		// Token: 0x06039D86 RID: 236934 RVA: 0x01040454 File Offset: 0x0103E654
		public void OnClickEsc()
		{
			if (this.IsReseting || this.IsRequesting)
			{
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnClickMoveInput] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool flag = false;
			foreach (RbBaseComponent rbBaseComponent in rollBlockGameplayInfo.RollBlockEntities)
			{
				if (rbBaseComponent.Valid && rbBaseComponent.IsMainController)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[OnClickEsc] 没有主控制方块，拦截退出";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickEsc]", default(ReadOnlySpan<ValueTuple<string, object>>));
			RollBlockExitGamePlayRequest rollBlockExitGamePlayRequest = RollBlockExitGamePlayRequest.Create();
			rollBlockExitGamePlayRequest.IncId = this.CurrentIncId.Value;
			Net.Instance.Call(ERequestMessageId.RollBlockExitGamePlayRequest, rollBlockExitGamePlayRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RollBlockExitGamePlayResponse rollBlockExitGamePlayResponse = (RollBlockExitGamePlayResponse)msg;
				this.IsRequesting = false;
				if (rollBlockExitGamePlayResponse == null)
				{
					return;
				}
				if (rollBlockExitGamePlayResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.RollBlock;
					ELogAuthor author3 = ELogAuthor.CH;
					string message3 = "[OnClickEsc] RollBlockExitGamePlayRequest失败";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("errorCode", rollBlockExitGamePlayResponse.Code);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return;
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickEsc] RollBlockExitGamePlayRequest成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, 0);
			this.IsRequesting = true;
		}

		// Token: 0x06039D87 RID: 236935 RVA: 0x010405AC File Offset: 0x0103E7AC
		public void OnClickSwitch()
		{
			if (this.IsReseting || this.IsRequesting)
			{
				return;
			}
			Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickSwitch]", default(ReadOnlySpan<ValueTuple<string, object>>));
			RollBlockGameplayInfo rollBlockGameplayInfo;
			bool flag = this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo) && rollBlockGameplayInfo.MultiBlock;
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnClickSwitch] 单方块玩法不支持切换控制方块";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MultiBlock", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RollBlockSwitchControlBlockRequest rollBlockSwitchControlBlockRequest = RollBlockSwitchControlBlockRequest.Create();
			rollBlockSwitchControlBlockRequest.IncId = this.CurrentIncId.Value;
			Net.Instance.Call(ERequestMessageId.RollBlockSwitchControlBlockRequest, rollBlockSwitchControlBlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RollBlockSwitchControlBlockResponse rollBlockSwitchControlBlockResponse = (RollBlockSwitchControlBlockResponse)msg;
				this.IsRequesting = false;
				if (rollBlockSwitchControlBlockResponse == null)
				{
					return;
				}
				if (rollBlockSwitchControlBlockResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.RollBlock;
					ELogAuthor author2 = ELogAuthor.CH;
					string message2 = "[OnClickSwitch] RollBlockSwitchControlBlockRequest失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("errorCode", rollBlockSwitchControlBlockResponse.Code);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickSwitch] RollBlockSwitchControlBlockRequest成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				long preMainControlBlockEntityId = rollBlockSwitchControlBlockResponse.PreMainControlBlockEntityId;
				EntityHandle entity = CreatureModel.Instance.GetEntity(preMainControlBlockEntityId);
				RbBaseComponent rbBaseComponent;
				if (entity == null)
				{
					rbBaseComponent = null;
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					rbBaseComponent = ((entity2 != null) ? entity2.GetComponent<RbBaseComponent>() : null);
				}
				RbBaseComponent rbBaseComponent2 = rbBaseComponent;
				if (rbBaseComponent2 != null)
				{
					rbBaseComponent2.IsMainController = false;
				}
				long curMainControlBlockEntityId = rollBlockSwitchControlBlockResponse.CurMainControlBlockEntityId;
				EntityHandle entity3 = CreatureModel.Instance.GetEntity(curMainControlBlockEntityId);
				RbBaseComponent rbBaseComponent3;
				if (entity3 == null)
				{
					rbBaseComponent3 = null;
				}
				else
				{
					WorldEntity entity4 = entity3.Entity;
					rbBaseComponent3 = ((entity4 != null) ? entity4.GetComponent<RbBaseComponent>() : null);
				}
				RbBaseComponent rbBaseComponent4 = rbBaseComponent3;
				if (rbBaseComponent4 != null)
				{
					rbBaseComponent4.IsMainController = true;
				}
			}, 0);
			this.IsRequesting = true;
		}

		// Token: 0x06039D88 RID: 236936 RVA: 0x0104067C File Offset: 0x0103E87C
		public void OnNotifyGameplayReset(RollBlockResetGamePlayNotify notify)
		{
			int incId = notify.Info.IncId;
			if (this.OpenedGameplayInfo.ContainsKey(incId))
			{
				this.ExitRollBlockGameplay(incId, true);
			}
			RollBlockOpenGamePlayNotify rollBlockOpenGamePlayNotify = RollBlockOpenGamePlayNotify.Create();
			rollBlockOpenGamePlayNotify.Info = notify.Info;
			this.EnterRollBlockGameplay(rollBlockOpenGamePlayNotify, true);
			this.IsReseting = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RollBlock;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[OnClickReset] 重置操作完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", notify.Info.IncId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06039D89 RID: 236937 RVA: 0x01040708 File Offset: 0x0103E908
		public void OnNotifyAvailableInputsChange(RollBlockUpdateAvailableInputsNotify notify)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(notify.IncId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnNotifyAvailableInputsChange] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", notify.IncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			rollBlockGameplayInfo.AvailableInputs = new List<RbGridDirection>();
			foreach (RbInput rbInput in notify.AvailableInputs)
			{
				RbRollInput roll = rbInput.Roll;
				bool flag;
				if (roll == null)
				{
					flag = false;
				}
				else
				{
					RbGridDirection direction = roll.Direction;
					flag = true;
				}
				if (flag)
				{
					rollBlockGameplayInfo.AvailableInputs.Add(rbInput.Roll.Direction);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.RollBlock;
					ELogAuthor author2 = ELogAuthor.CH;
					string message2 = "[OnNotifyAvailableInputsChange] 可用输入";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Direction", rbInput.Roll.Direction);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
		}

		// Token: 0x06039D8A RID: 236938 RVA: 0x0104080C File Offset: 0x0103EA0C
		private void OnClickMove()
		{
			if (this.IsRequesting)
			{
				return;
			}
			if (this.InputDir == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickMove] InputDir未定义", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsBlockMoving())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnClickMove] 方块正在移动，忽略此次输入";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InputDir", this.InputDir);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo) || !rollBlockGameplayInfo.AvailableInputs.Contains(this.InputDir.Value))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[OnClickMove] 当前方向不可用，忽略此次输入";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("InputDir", this.InputDir);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.MistakeInputCount++;
				if (this.CommonForceFeedback != null && Info.Instance.IsInGamepad())
				{
					ControlScreenModel instance3 = ControlScreenModel.Instance;
					if (instance3 == null || !instance3.IsTouching)
					{
						GamepadController.Instance.PlayKuroForceFeedback(this.CommonForceFeedback, FNameUtil.GetDynamicFName("RollBlock"), false, false, false, "RollBlockController");
					}
				}
				RollBlockGameplayInfo rollBlockGameplayInfo2;
				foreach (RbBaseComponent rbBaseComponent in (this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo2) ? rollBlockGameplayInfo2.RollBlockEntities : new List<RbBaseComponent>()))
				{
					if (rbBaseComponent.IsMainController)
					{
						BaseTagComponent component = rbBaseComponent.Entity.GetComponent<BaseTagComponent>();
						if (component != null)
						{
							component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.滚方块.错误输入"]));
						}
						if (component == null)
						{
							break;
						}
						component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.滚方块.错误输入"]));
						break;
					}
				}
				if (this.MistakeInputCount >= this.GameplaySetting.ShowMistakeTipsCount)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.GameplaySetting.RollBlockErrorTipKey, null);
					GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new <>z__ReadOnlySingleElementList<object>(localTextNew), null, null, null, null, null, false, null);
				}
				return;
			}
			Log instance4 = Log.Instance;
			ELogModule module3 = ELogModule.RollBlock;
			ELogAuthor author3 = ELogAuthor.CH;
			string message3 = "[OnClickMove] OnClickMove";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("InputDir", this.InputDir);
			instance4.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			RollBlockInputRequest rollBlockInputRequest = RollBlockInputRequest.Create();
			rollBlockInputRequest.IncId = this.CurrentIncId.Value;
			RbRollInput input = RbRollInput.Create();
			input.Direction = this.InputDir.Value;
			RbInput rbInput = RbInput.Create();
			rbInput.Roll = input;
			rollBlockInputRequest.Input = rbInput;
			Net.Instance.Call(ERequestMessageId.RollBlockInputRequest, rollBlockInputRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RollBlockInputResponse rollBlockInputResponse = (RollBlockInputResponse)msg;
				this.IsRequesting = false;
				if (rollBlockInputResponse == null)
				{
					return;
				}
				if (rollBlockInputResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					Log instance5 = Log.Instance;
					ELogModule module4 = ELogModule.RollBlock;
					ELogAuthor author4 = ELogAuthor.CH;
					string message4 = "[OnClickMove] RollBlockInputRequest失败";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("errorCode", rollBlockInputResponse.Code);
					instance5.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					string text;
					if (RollBlockDefind.RbGridDirection2Input.TryGetValue(input.Direction, out text) && text == this.CurrentKey)
					{
						this.ProcessMoveInput(text, InputDistributeDefine.EActionType.Release);
					}
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[OnClickMove] RollBlockInputRequest成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.MistakeInputCount = 0;
				this.TotalInputCount++;
				RollBlockGameplayInfo rollBlockGameplayInfo3;
				if (this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo3) && this.TotalInputCount > rollBlockGameplayInfo3.ShowTipsInputCount && !rollBlockGameplayInfo3.ShowedTips)
				{
					EventSystem.Instance.Emit(EEventName.ShowRollBlockTips);
					rollBlockGameplayInfo3.ShowedTips = true;
				}
			}, 0);
			this.IsRequesting = true;
		}

		// Token: 0x06039D8B RID: 236939 RVA: 0x01040B18 File Offset: 0x0103ED18
		private bool IsBlockMoving()
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[IsBlockMoving] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			foreach (RbBaseComponent rbBaseComponent in rollBlockGameplayInfo.RollBlockEntities)
			{
				if (rbBaseComponent.IsMainController)
				{
					return rbBaseComponent.IsMoving();
				}
			}
			return false;
		}

		// Token: 0x06039D8C RID: 236940 RVA: 0x01040BCC File Offset: 0x0103EDCC
		public void OnRollBlockStateChange(RbBlockStateChangeNotify notify)
		{
			int incId = notify.IncId;
			long entityId = notify.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			if (worldEntity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[StartRollBlockMovement] Entity不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RbBlockComponent component = worldEntity.GetComponent<RbBlockComponent>();
			if (component == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[StartRollBlockMovement] RollBlockItemComponent不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", entityId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			CreatureDataComponent component2 = worldEntity.GetComponent<CreatureDataComponent>();
			long? num = (component2 != null) ? new long?(component2.GetCreatureDataId()) : null;
			if (num == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RollBlock;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "[StartRollBlockMovement] CreatureDataId不存在";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", entityId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo) || (!rollBlockGameplayInfo.EntityIds.Contains(entityId) && !rollBlockGameplayInfo.InitVisibleEntityIds.Contains(entityId)))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.RollBlock;
				ELogAuthor author4 = ELogAuthor.CH;
				string message4 = "[StartRollBlockMovement] Entity不在EntityIds或者InitInvisibleEntityIds中";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("EntityId", entityId);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return;
			}
			RbBlockPbState state = notify.State;
			component.ChangeMoveState(state, false);
			if (((state != null) ? state.IdleState : null) != null && RollBlockDefind.isRbBlockIdleState(state.IdleState) && this.CurrentKey != null)
			{
				this.OnClickMove();
			}
		}

		// Token: 0x06039D8D RID: 236941 RVA: 0x01040D68 File Offset: 0x0103EF68
		private void HandleGroupEntitiesCreate(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[HandleGroupEntitiesCreate] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			List<long> entityIds = rollBlockGameplayInfo.EntityIds;
			if (entityIds.Count == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[HandleGroupEntitiesCreate] EntityIds为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", incId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			if (this.WaitEntityTask.ContainsKey(incId))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RollBlock;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "[HandleGroupEntitiesCreate] WaitEntityTask已存在，将强行停止";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("IncId", incId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				WaitEntityTask waitEntityTask;
				if (this.WaitEntityTask.TryGetValue(incId, out waitEntityTask) && waitEntityTask != null)
				{
					waitEntityTask.Cancel();
				}
			}
			WaitEntityTask value = global::WaitEntityTask.Create("[RollBlockController.HandleGroupEntitiesCreate]", entityIds, delegate(bool? result)
			{
				this.OnAllEntityCreated(result, incId);
			}, -1, false, true);
			this.WaitEntityTask[incId] = value;
			rollBlockGameplayInfo.InitState = ERollBlockInitState.WaitEntitiesCreate;
		}

		// Token: 0x06039D8E RID: 236942 RVA: 0x01040EB4 File Offset: 0x0103F0B4
		private unsafe void OnAllEntityCreated(bool? result, int incId)
		{
			RollBlockController.<>c__DisplayClass35_0 CS$<>8__locals1 = new RollBlockController.<>c__DisplayClass35_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.incId = incId;
			this.WaitEntityTask.Remove(CS$<>8__locals1.incId);
			if (!result.GetValueOrDefault())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnAllEntityCreated] 生成实体失败或者等待超时";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", CS$<>8__locals1.incId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RollBlock;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[OnAllEntityCreated] 生成实体成功";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", CS$<>8__locals1.incId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(CS$<>8__locals1.incId, out rollBlockGameplayInfo))
			{
				return;
			}
			List<long> entityIds = rollBlockGameplayInfo.EntityIds;
			rollBlockGameplayInfo.InitState = ERollBlockInitState.WaitSceneItemLoadCompleted;
			if (entityIds.Count == 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RollBlock;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "[OnAllEntityCreated] EntityIds为空";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("IncId", CS$<>8__locals1.incId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			using (List<long>.Enumerator enumerator = entityIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					RollBlockController.<>c__DisplayClass35_1 CS$<>8__locals2 = new RollBlockController.<>c__DisplayClass35_1();
					CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
					CS$<>8__locals2.entityId = enumerator.Current;
					RollBlockController.<>c__DisplayClass35_1 CS$<>8__locals3 = CS$<>8__locals2;
					EntityHandle entity = CreatureModel.Instance.GetEntity(CS$<>8__locals2.entityId);
					CS$<>8__locals3.entity = ((entity != null) ? entity.Entity : null);
					if (CS$<>8__locals2.entity == null)
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.RollBlock;
						ELogAuthor author4 = ELogAuthor.CH;
						string message4 = "[OnAllEntityCreated] Entity不存在";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", CS$<>8__locals2.CS$<>8__locals1.incId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", CS$<>8__locals2.entityId);
						instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						SceneItemActorComponent component = CS$<>8__locals2.entity.GetComponent<SceneItemActorComponent>();
						if (component == null)
						{
							Log instance5 = Log.Instance;
							ELogModule module5 = ELogModule.RollBlock;
							ELogAuthor author5 = ELogAuthor.CH;
							string message5 = "[OnAllEntityCreated] SceneItemActorComponent不存在";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IncId", CS$<>8__locals2.CS$<>8__locals1.incId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", CS$<>8__locals2.entityId);
							instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						}
						else
						{
							BaseTagComponent component2 = CS$<>8__locals2.entity.GetComponent<BaseTagComponent>();
							if (component2 == null)
							{
								Log instance6 = Log.Instance;
								ELogModule module6 = ELogModule.RollBlock;
								ELogAuthor author6 = ELogAuthor.CH;
								string message6 = "[OnAllEntityCreated] BaseTagComponent不存在";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("IncId", CS$<>8__locals2.CS$<>8__locals1.incId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("EntityId", CS$<>8__locals2.entityId);
								instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
							}
							else
							{
								component2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.隐藏"]));
								if (!component.GetIsSceneInteractionLoadCompleted())
								{
									Dictionary<Entity, Action> entityHandleMap;
									if (!this.NotLoadCompletedEntity.TryGetValue(CS$<>8__locals2.CS$<>8__locals1.incId, out entityHandleMap))
									{
										entityHandleMap = new Dictionary<Entity, Action>();
									}
									this.NotLoadCompletedEntity[CS$<>8__locals2.CS$<>8__locals1.incId] = entityHandleMap;
									Log instance7 = Log.Instance;
									ELogModule module7 = ELogModule.RollBlock;
									ELogAuthor author7 = ELogAuthor.CH;
									string message7 = "[OnAllEntityCreated] 实体IsSceneInteractionLoadCompleted is false";
									<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("IncId", CS$<>8__locals2.CS$<>8__locals1.incId);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("EntityId", CS$<>8__locals2.entityId);
									instance7.Info(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
									Action handle = null;
									handle = delegate()
									{
										EventSystem.Instance.RemoveWithTarget(CS$<>8__locals2.entity, EEventName.OnSceneInteractionLoadCompleted, handle);
										entityHandleMap.Remove(CS$<>8__locals2.entity);
										CS$<>8__locals2.CS$<>8__locals1.<>4__this.NotLoadCompletedEntity[CS$<>8__locals2.CS$<>8__locals1.incId] = entityHandleMap;
										Log instance8 = Log.Instance;
										ELogModule module8 = ELogModule.RollBlock;
										ELogAuthor author8 = ELogAuthor.CH;
										string message8 = "[OnAllEntityCreated] 实体IsSceneInteractionLoadCompleted is true";
										<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
										*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("IncId", CS$<>8__locals2.CS$<>8__locals1.incId);
										*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("EntityId", CS$<>8__locals2.entityId);
										instance8.Info(module8, author8, message8, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
										if (entityHandleMap.Count == 0)
										{
											CS$<>8__locals2.CS$<>8__locals1.<>4__this.OnAllSceneItemLoadCompleted(CS$<>8__locals2.CS$<>8__locals1.incId);
										}
									};
									EventSystem.Instance.AddWithTarget(CS$<>8__locals2.entity, EEventName.OnSceneInteractionLoadCompleted, handle);
									entityHandleMap[CS$<>8__locals2.entity] = handle;
								}
								CS$<>8__locals2.onSetEntityEnable = null;
								CS$<>8__locals2.onSetEntityEnable = delegate(float _)
								{
									CreatureController.Instance.SetEntityEnable(CS$<>8__locals2.entity, true, "RollBlockController", false);
									List<Action<float>> list2;
									if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.PendingTickFunctions.TryGetValue(CS$<>8__locals2.CS$<>8__locals1.incId, out list2))
									{
										int num = list2.IndexOf(CS$<>8__locals2.onSetEntityEnable);
										if (num > -1)
										{
											list2.RemoveAt(num);
										}
										if (list2.Count == 0)
										{
											CS$<>8__locals2.CS$<>8__locals1.<>4__this.PendingTickFunctions.Remove(CS$<>8__locals2.CS$<>8__locals1.incId);
										}
									}
								};
								List<Action<float>> list;
								if (!this.PendingTickFunctions.TryGetValue(CS$<>8__locals2.CS$<>8__locals1.incId, out list))
								{
									list = new List<Action<float>>();
								}
								list.Add(CS$<>8__locals2.onSetEntityEnable);
								this.PendingTickFunctions[CS$<>8__locals2.CS$<>8__locals1.incId] = list;
								TickProcessSystem.Instance.RegisterOnceTickProcess(ETickingGroup.TG_PostUpdateWork, true, CS$<>8__locals2.onSetEntityEnable);
							}
						}
					}
				}
			}
		}

		// Token: 0x06039D8F RID: 236943 RVA: 0x010413AC File Offset: 0x0103F5AC
		private unsafe void OnAllSceneItemLoadCompleted(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnAllSceneItemLoadCompleted] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RollBlock;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[OnAllSceneItemLoadCompleted] 场景物件加载完成";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("IncId", incId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			int num = 0;
			foreach (long num2 in rollBlockGameplayInfo.EntityIds)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num2);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				if (worldEntity == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.RollBlock;
					ELogAuthor author3 = ELogAuthor.CH;
					string message3 = "[OnAllSceneItemLoadCompleted] Entity不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", num2);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else if (worldEntity.GetComponent<BaseTagComponent>() == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.RollBlock;
					ELogAuthor author4 = ELogAuthor.CH;
					string message4 = "[OnAllSceneItemLoadCompleted] BaseTagComponent不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", num2);
					instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					RbBaseComponent component = worldEntity.GetComponent<RbBaseComponent>();
					if (component == null)
					{
						Log instance5 = Log.Instance;
						ELogModule module5 = ELogModule.RollBlock;
						ELogAuthor author5 = ELogAuthor.CH;
						string message5 = "[OnAllSceneItemLoadCompleted] rbBaseComponent不存在";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("IncId", incId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("EntityId", num2);
						instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
					else
					{
						component.RegisterToGameplay(incId);
						if (component is RbBlockComponent)
						{
							num++;
						}
						foreach (JigsawIndex jigsawIndex in component.OccupiedCellIndex)
						{
							string key = jigsawIndex.GetKey();
							List<RbBaseComponent> list;
							if (!rollBlockGameplayInfo.IndexedEntityMap.TryGetValue(key, out list))
							{
								list = new List<RbBaseComponent>();
							}
							list.Add(component);
							rollBlockGameplayInfo.IndexedEntityMap[key] = list;
						}
					}
				}
			}
			rollBlockGameplayInfo.MultiBlock = (num > 1);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.StartRollBlockBirthEffect(incId);
			}, 100f, null, null, true, 1f);
		}

		// Token: 0x06039D90 RID: 236944 RVA: 0x010416DC File Offset: 0x0103F8DC
		private unsafe void StartRollBlockBirthEffect(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[StartRollBlockBirthEffect] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (rollBlockGameplayInfo.Width % 2 == 0)
			{
				this.CurBirthEffectAreaWidth = Vector2D.Create((double)(rollBlockGameplayInfo.Width / 2 - 1), (double)(rollBlockGameplayInfo.Width / 2));
			}
			else
			{
				this.CurBirthEffectAreaWidth = Vector2D.Create((double)((int)Math.Floor((double)rollBlockGameplayInfo.Width / 2.0)), (double)((int)Math.Floor((double)rollBlockGameplayInfo.Width / 2.0)));
			}
			if (rollBlockGameplayInfo.Height % 2 == 0)
			{
				this.CurBirthEffectAreaHeight = Vector2D.Create((double)(rollBlockGameplayInfo.Height / 2 - 1), (double)(rollBlockGameplayInfo.Height / 2));
			}
			else
			{
				this.CurBirthEffectAreaHeight = Vector2D.Create((double)((int)Math.Floor((double)rollBlockGameplayInfo.Height / 2.0)), (double)((int)Math.Floor((double)rollBlockGameplayInfo.Height / 2.0)));
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RollBlock;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[StartRollBlockBirthEffect] 出生表现开始";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Width", this.CurBirthEffectAreaWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Height", this.CurBirthEffectAreaHeight);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			rollBlockGameplayInfo.InitState = ERollBlockInitState.HandleBirthEffect;
			this.NeedShowEntities.Clear();
			int num = (int)this.CurBirthEffectAreaWidth.X;
			while ((double)num <= this.CurBirthEffectAreaWidth.Y)
			{
				int num2 = (int)this.CurBirthEffectAreaHeight.X;
				while ((double)num2 <= this.CurBirthEffectAreaHeight.Y)
				{
					JigsawIndex jigsawIndex = new JigsawIndex(num, num2);
					List<RbBaseComponent> list;
					if (rollBlockGameplayInfo.IndexedEntityMap.TryGetValue(jigsawIndex.GetKey(), out list))
					{
						foreach (RbBaseComponent item in list)
						{
							this.NeedShowEntities.Add(item);
						}
					}
					num2++;
				}
				num++;
			}
			foreach (RbBaseComponent rbBaseComponent in this.NeedShowEntities)
			{
				Entity entity = rbBaseComponent.Entity;
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				if (component == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.RollBlock;
					ELogAuthor author3 = ELogAuthor.CH;
					string message3 = "[StartRollBlockBirthEffect] BaseTagComponent不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IncId", incId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", entity.Id);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.隐藏"]));
				}
			}
			this.SliceBirthEffectIncId = incId;
			this.SliceBirthEffectTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.SliceBirthEffect), (float)this.GameplaySetting.ShowBlockInterval, 1f, null, null, true);
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RollBlock;
			ELogAuthor author4 = ELogAuthor.CH;
			string message4 = "[StartRollBlockBirthEffect] 出生表现开始";
			string item2 = "HandleId";
			TimerHandle sliceBirthEffectTimerHandle = this.SliceBirthEffectTimerHandle;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (sliceBirthEffectTimerHandle != null) ? new int?(sliceBirthEffectTimerHandle.Id) : null);
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x06039D91 RID: 236945 RVA: 0x01041A84 File Offset: 0x0103FC84
		private unsafe void SliceBirthEffect(float _)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.SliceBirthEffectIncId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[SliceBirthEffect] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.SliceBirthEffectIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				TimerSystem.Instance.Remove(this.SliceBirthEffectTimerHandle);
				return;
			}
			if (this.CurBirthEffectAreaWidth.X == 0.0 && this.CurBirthEffectAreaWidth.Y == (double)(rollBlockGameplayInfo.Width - 1) && this.CurBirthEffectAreaHeight.X == 0.0 && this.CurBirthEffectAreaHeight.Y == (double)(rollBlockGameplayInfo.Height - 1))
			{
				TimerSystem.Instance.Remove(this.SliceBirthEffectTimerHandle);
				foreach (long num in rollBlockGameplayInfo.EntityIds)
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity(num);
					WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
					if (worldEntity == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.RollBlock;
						ELogAuthor author2 = ELogAuthor.CH;
						string message2 = "[OnAllSceneItemLoadCompleted] Entity不存在";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", this.CurrentIncId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", num);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						RbBaseComponent component = worldEntity.GetComponent<RbBaseComponent>();
						if (component == null)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.RollBlock;
							ELogAuthor author3 = ELogAuthor.CH;
							string message3 = "[OnAllSceneItemLoadCompleted] rbBaseComponent不存在";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("IncId", this.CurrentIncId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", num);
							instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						}
						else
						{
							component.OnActualShow();
						}
					}
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[SliceBirthEffect] 出生表现完成, 进行玩法准备通知", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.HandleGameplayReady();
				return;
			}
			this.NeedShowEntities.Clear();
			this.CurBirthEffectAreaWidth.X = Math.Max(0.0, this.CurBirthEffectAreaWidth.X - 1.0);
			this.CurBirthEffectAreaWidth.Y = Math.Min((double)(rollBlockGameplayInfo.Width - 1), this.CurBirthEffectAreaWidth.Y + 1.0);
			this.CurBirthEffectAreaHeight.X = Math.Max(0.0, this.CurBirthEffectAreaHeight.X - 1.0);
			this.CurBirthEffectAreaHeight.Y = Math.Min((double)(rollBlockGameplayInfo.Height - 1), this.CurBirthEffectAreaHeight.Y + 1.0);
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RollBlock;
			ELogAuthor author4 = ELogAuthor.CH;
			string message4 = "[SliceBirthEffect] 出生表现分帧";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Width", this.CurBirthEffectAreaWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Height", this.CurBirthEffectAreaHeight);
			instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			int num2 = (int)this.CurBirthEffectAreaWidth.X;
			while ((double)num2 <= this.CurBirthEffectAreaWidth.Y)
			{
				JigsawIndex jigsawIndex = new JigsawIndex(num2, (int)this.CurBirthEffectAreaHeight.X);
				List<RbBaseComponent> list;
				if (rollBlockGameplayInfo.IndexedEntityMap.TryGetValue(jigsawIndex.GetKey(), out list))
				{
					foreach (RbBaseComponent item in list)
					{
						this.NeedShowEntities.Add(item);
						Log instance5 = Log.Instance;
						ELogModule module5 = ELogModule.RollBlock;
						ELogAuthor author5 = ELogAuthor.CH;
						string message5 = "[SliceBirthEffect] 上边界";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Index", jigsawIndex.GetKey());
						instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
				}
				num2++;
			}
			int num3 = (int)this.CurBirthEffectAreaWidth.X;
			while ((double)num3 <= this.CurBirthEffectAreaWidth.Y)
			{
				JigsawIndex jigsawIndex2 = new JigsawIndex(num3, (int)this.CurBirthEffectAreaHeight.Y);
				List<RbBaseComponent> list2;
				if (rollBlockGameplayInfo.IndexedEntityMap.TryGetValue(jigsawIndex2.GetKey(), out list2))
				{
					foreach (RbBaseComponent item2 in list2)
					{
						this.NeedShowEntities.Add(item2);
						Log instance6 = Log.Instance;
						ELogModule module6 = ELogModule.RollBlock;
						ELogAuthor author6 = ELogAuthor.CH;
						string message6 = "[SliceBirthEffect] 下边界";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Index", jigsawIndex2.GetKey());
						instance6.Info(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
				}
				num3++;
			}
			int num4 = (int)this.CurBirthEffectAreaHeight.X + 1;
			while ((double)num4 <= this.CurBirthEffectAreaHeight.Y - 1.0)
			{
				JigsawIndex jigsawIndex3 = new JigsawIndex((int)this.CurBirthEffectAreaWidth.X, num4);
				List<RbBaseComponent> list3;
				if (rollBlockGameplayInfo.IndexedEntityMap.TryGetValue(jigsawIndex3.GetKey(), out list3))
				{
					foreach (RbBaseComponent item3 in list3)
					{
						this.NeedShowEntities.Add(item3);
						Log instance7 = Log.Instance;
						ELogModule module7 = ELogModule.RollBlock;
						ELogAuthor author7 = ELogAuthor.CH;
						string message7 = "[SliceBirthEffect] 左边界";
						ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Index", jigsawIndex3.GetKey());
						instance7.Info(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					}
				}
				num4++;
			}
			int num5 = (int)this.CurBirthEffectAreaHeight.X + 1;
			while ((double)num5 <= this.CurBirthEffectAreaHeight.Y - 1.0)
			{
				JigsawIndex jigsawIndex4 = new JigsawIndex((int)this.CurBirthEffectAreaWidth.Y, num5);
				List<RbBaseComponent> list4;
				if (rollBlockGameplayInfo.IndexedEntityMap.TryGetValue(jigsawIndex4.GetKey(), out list4))
				{
					foreach (RbBaseComponent item4 in list4)
					{
						this.NeedShowEntities.Add(item4);
						Log instance8 = Log.Instance;
						ELogModule module8 = ELogModule.RollBlock;
						ELogAuthor author8 = ELogAuthor.CH;
						string message8 = "[SliceBirthEffect] 右边界";
						ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("Index", jigsawIndex4.GetKey());
						instance8.Info(module8, author8, message8, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
					}
				}
				num5++;
			}
			foreach (RbBaseComponent rbBaseComponent in this.NeedShowEntities)
			{
				Entity entity2 = rbBaseComponent.Entity;
				BaseTagComponent component2 = entity2.GetComponent<BaseTagComponent>();
				if (component2 == null)
				{
					Log instance9 = Log.Instance;
					ELogModule module9 = ELogModule.RollBlock;
					ELogAuthor author9 = ELogAuthor.CH;
					string message9 = "[StartRollBlockBirthEffect] BaseTagComponent不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("IncId", this.CurrentIncId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("EntityId", entity2.Id);
					instance9.Error(module9, author9, message9, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				}
				else
				{
					component2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.隐藏"]));
				}
			}
		}

		// Token: 0x06039D92 RID: 236946 RVA: 0x0104226C File Offset: 0x0104046C
		private unsafe void OnEntityCreated(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
		{
			long creatureDataId = handle.CreatureDataId;
			if (creatureDataId == 0L)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[OnEntityCreated] CreatureDataId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", handle.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (KeyValuePair<int, RollBlockGameplayInfo> keyValuePair in this.OpenedGameplayInfo)
			{
				int key = keyValuePair.Key;
				RollBlockGameplayInfo value = keyValuePair.Value;
				if (value.EntityIds.Contains(creatureDataId) || value.InitVisibleEntityIds.Contains(creatureDataId))
				{
					RbBaseComponent rbBaseComponent;
					if (handle == null)
					{
						rbBaseComponent = null;
					}
					else
					{
						WorldEntity entity = handle.Entity;
						rbBaseComponent = ((entity != null) ? entity.GetComponent<RbBaseComponent>() : null);
					}
					RbBaseComponent rbBaseComponent2 = rbBaseComponent;
					if (rbBaseComponent2 == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.RollBlock;
						ELogAuthor author2 = ELogAuthor.CH;
						string message2 = "[OnEntityCreated] rbBaseComponent不存在";
						string item = "EntityId";
						int? num;
						if (handle == null)
						{
							num = null;
						}
						else
						{
							WorldEntity entity2 = handle.Entity;
							num = ((entity2 != null) ? new int?(entity2.Id) : null);
						}
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item, num);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						break;
					}
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.RollBlock;
					ELogAuthor author3 = ELogAuthor.CH;
					string message3 = "[OnEntityCreated] 实体创建, 注册到IncId";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", (handle != null) ? new long?(handle.CreatureDataId) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IncId", key);
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					rbBaseComponent2.RegisterToGameplay(key);
					RbBlockComponent rbBlockComponent = rbBaseComponent2 as RbBlockComponent;
					if (rbBlockComponent != null && !rbBlockComponent.IsVisionBlock)
					{
						EventSystem.Instance.AddWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainBlockEntityRemoved));
					}
				}
			}
		}

		// Token: 0x06039D93 RID: 236947 RVA: 0x01042474 File Offset: 0x01040674
		private void OnMainBlockEntityRemoved(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (removeType == ERemoveEntityType.RbBlockDestroyed)
			{
				this.OnClickReset(true, true);
			}
			if (EventSystem.Instance.HasWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainBlockEntityRemoved)))
			{
				EventSystem.Instance.RemoveWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainBlockEntityRemoved));
			}
		}

		// Token: 0x06039D94 RID: 236948 RVA: 0x010424CC File Offset: 0x010406CC
		public void RegisterRollBlockToGameplay(RbBaseComponent blockComp, int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[RegisterRollBlockToGameplay] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			rollBlockGameplayInfo.RollBlockEntities.Add(blockComp);
		}

		// Token: 0x06039D95 RID: 236949 RVA: 0x01042528 File Offset: 0x01040728
		public void RegisterVisionRollBlockToGameplay(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[RegisterTipActorCreated] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			rollBlockGameplayInfo.HasTipActorNum++;
		}

		// Token: 0x06039D96 RID: 236950 RVA: 0x01042584 File Offset: 0x01040784
		public void UnRegisterVisionRollBlockToGameplay(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[UnRegisterVisionRollBlockToGameplay] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			rollBlockGameplayInfo.HasTipActorNum--;
		}

		// Token: 0x06039D97 RID: 236951 RVA: 0x010425E0 File Offset: 0x010407E0
		[NullableContext(2)]
		public global::Vector GetForwardVector(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GetFowardVector] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return rollBlockGameplayInfo.Forward;
		}

		// Token: 0x06039D98 RID: 236952 RVA: 0x01042634 File Offset: 0x01040834
		[NullableContext(2)]
		public global::Vector GetRightVector(int incId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(incId, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GetRightVector] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return rollBlockGameplayInfo.Right;
		}

		// Token: 0x06039D99 RID: 236953 RVA: 0x01042688 File Offset: 0x01040888
		public bool GetIsMultiBlock()
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GetIsMultiBlock] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return rollBlockGameplayInfo.MultiBlock;
		}

		// Token: 0x06039D9A RID: 236954 RVA: 0x010426EC File Offset: 0x010408EC
		public bool IsCurrentIncId(int incId)
		{
			int? currentIncId = this.CurrentIncId;
			return currentIncId.GetValueOrDefault() == incId & currentIncId != null;
		}

		// Token: 0x06039D9B RID: 236955 RVA: 0x01042714 File Offset: 0x01040914
		private void OnGuideGroupOpening(EUiViewName viewName, int viewId)
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnGuideGroupOpening));
				return;
			}
			if (viewName != EUiViewName.GuideTutorialView && viewName != EUiViewName.GuideTutorialPopView)
			{
				return;
			}
			this.IsOpeningGuide = true;
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnGuideGroupFinished));
		}

		// Token: 0x06039D9C RID: 236956 RVA: 0x01042790 File Offset: 0x01040990
		private void OnGuideGroupFinished(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.GuideTutorialView && viewName != EUiViewName.GuideTutorialPopView)
			{
				return;
			}
			this.IsOpeningGuide = false;
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnGuideGroupFinished));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnGuideGroupOpening));
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				if (rollBlockGameplayInfo.InitState != ERollBlockInitState.WaitGameplayReadyResponse)
				{
					EventSystem.Instance.Emit(EEventName.RollBlockAllCompleted);
				}
				if (rollBlockGameplayInfo.InitState == ERollBlockInitState.WaitGuideGroupFinished)
				{
					rollBlockGameplayInfo.InitState = ERollBlockInitState.AllCompleted;
				}
			}
		}

		// Token: 0x06039D9D RID: 236957 RVA: 0x01042834 File Offset: 0x01040A34
		public int GetCurrentDifficulty()
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GetCurrentDifficulty] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return -1;
			}
			return rollBlockGameplayInfo.Difficulty;
		}

		// Token: 0x06039D9E RID: 236958 RVA: 0x01042898 File Offset: 0x01040A98
		public int GetTotalDifficulty()
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GetTotalDifficulty] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return -1;
			}
			return rollBlockGameplayInfo.TotalDifficulty;
		}

		// Token: 0x06039D9F RID: 236959 RVA: 0x010428FC File Offset: 0x01040AFC
		private void HandleGameplayReady()
		{
			RollBlockGameplayInfo info;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out info))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GetTotalDifficulty] IncId不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RollBlockGamePlayReadyRequest rollBlockGamePlayReadyRequest = RollBlockGamePlayReadyRequest.Create();
			rollBlockGamePlayReadyRequest.IncId = this.CurrentIncId.Value;
			info.InitState = ERollBlockInitState.WaitGameplayReadyResponse;
			Net.Instance.Call(ERequestMessageId.RollBlockGamePlayReadyRequest, rollBlockGamePlayReadyRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RollBlockGamePlayReadyResponse rollBlockGamePlayReadyResponse = (RollBlockGamePlayReadyResponse)msg;
				if (rollBlockGamePlayReadyResponse == null)
				{
					return;
				}
				if (rollBlockGamePlayReadyResponse.Code != Aki.Protocol.ErrorCode.Success)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.RollBlock;
					ELogAuthor author2 = ELogAuthor.FJH;
					string message2 = "[GamePlayReadyRequest] RollBlockGamePlayReadyRequest失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("errorCode", rollBlockGamePlayReadyResponse.Code);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.FJH, "[GamePlayReadyRequest] RollBlockGamePlayReadyRequest成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (this.IsOpeningGuide)
				{
					info.InitState = ERollBlockInitState.WaitGuideGroupFinished;
					return;
				}
				info.InitState = ERollBlockInitState.AllCompleted;
				EventSystem.Instance.Emit(EEventName.RollBlockAllCompleted);
			}, 0);
		}

		// Token: 0x06039DA0 RID: 236960 RVA: 0x010429AC File Offset: 0x01040BAC
		public void NotifyServerShowAllBlock()
		{
			RollBlockGameplayInfo rollBlockGameplayInfo;
			if (!this.OpenedGameplayInfo.TryGetValue(this.CurrentIncId.Value, out rollBlockGameplayInfo) || rollBlockGameplayInfo.RollBlockEntities == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[NotifyServerShowAllBlock] RollBlockEntities不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", this.CurrentIncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (RbBaseComponent rbBaseComponent in rollBlockGameplayInfo.RollBlockEntities)
			{
				CreatureController.Instance.SetEntityEnable(rbBaseComponent.Entity, true, "RollBlockController", false);
			}
		}

		// Token: 0x06039DA1 RID: 236961 RVA: 0x01042A68 File Offset: 0x01040C68
		public void UpdateRollBlockItem(RollBlockItemUpdateNotify notify)
		{
			long entityId = notify.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity == null || !entity.Valid)
			{
				return;
			}
			if (notify.Component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[UpdateRollBlockItem] 下发的组件信息不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			WorldEntity entity2 = entity.Entity;
			RbItemComponent rbItemComponent = (entity2 != null) ? entity2.GetComponent<RbItemComponent>() : null;
			if (rbItemComponent == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[UpdateRollBlockItem] rbItemComponent";
				string item = "EntityId";
				int? num;
				if (entity == null)
				{
					num = null;
				}
				else
				{
					WorldEntity entity3 = entity.Entity;
					num = ((entity3 != null) ? new int?(entity3.Id) : null);
				}
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item, num);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			rbItemComponent.UpdateRollBlockItem(notify.Component);
		}

		// Token: 0x06039DA2 RID: 236962 RVA: 0x01042B4C File Offset: 0x01040D4C
		public void ExitOnOnlineModeChange()
		{
			if (this.OnlineCurrentIncId != null)
			{
				this.ExitRollBlockGameplay(this.OnlineCurrentIncId.Value, false);
				return;
			}
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.ExitOnOnlineModeChange));
		}

		// Token: 0x17006E36 RID: 28214
		// (get) Token: 0x06039DA3 RID: 236963 RVA: 0x01042B8A File Offset: 0x01040D8A
		public static RollBlockController Instance
		{
			get
			{
				return RollBlockController._Instance;
			}
		}

		// Token: 0x06039DA4 RID: 236964 RVA: 0x01042B91 File Offset: 0x01040D91
		public static RollBlockController GetOrCreateInstance()
		{
			if (RollBlockController._Instance == null)
			{
				RollBlockController.CreateInstance();
			}
			return RollBlockController._Instance;
		}

		// Token: 0x06039DA5 RID: 236965 RVA: 0x01042BA5 File Offset: 0x01040DA5
		public static bool CreateInstance()
		{
			if (RollBlockController._Instance != null)
			{
				return true;
			}
			RollBlockController._Instance = new RollBlockController();
			return true;
		}

		// Token: 0x06039DA6 RID: 236966 RVA: 0x01042BBB File Offset: 0x01040DBB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039DA7 RID: 236967 RVA: 0x01042BBD File Offset: 0x01040DBD
		public static void ResetStaticDefaultValue()
		{
			RollBlockController._Instance = null;
		}

		// Token: 0x06039DA8 RID: 236968 RVA: 0x01042BC5 File Offset: 0x01040DC5
		static RollBlockController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RollBlockController.CreateStaticDefaultValue), new Action(RollBlockController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E8FE RID: 125182
		private const string COMMON_FORCE_FEEDBACK_PATH = "/Game/Aki/Character/Role/Common/Data/GamePadShake/CommonShake/FF_Common_Lv1.FF_Common_Lv1";

		// Token: 0x0401E8FF RID: 125183
		private readonly Dictionary<int, RollBlockGameplayInfo> OpenedGameplayInfo = new Dictionary<int, RollBlockGameplayInfo>();

		// Token: 0x0401E900 RID: 125184
		private readonly Dictionary<int, WaitEntityTask> WaitEntityTask = new Dictionary<int, WaitEntityTask>();

		// Token: 0x0401E901 RID: 125185
		private readonly Dictionary<int, Dictionary<Entity, Action>> NotLoadCompletedEntity = new Dictionary<int, Dictionary<Entity, Action>>();

		// Token: 0x0401E902 RID: 125186
		private bool IsMainController;

		// Token: 0x0401E903 RID: 125187
		private int? CurrentIncId;

		// Token: 0x0401E904 RID: 125188
		private int? OnlineCurrentIncId;

		// Token: 0x0401E905 RID: 125189
		private bool IsReseting;

		// Token: 0x0401E906 RID: 125190
		[Nullable(2)]
		public BP_RollBlockGameplaySetting_C GameplaySetting;

		// Token: 0x0401E907 RID: 125191
		[Nullable(2)]
		private string CurrentKey;

		// Token: 0x0401E908 RID: 125192
		private readonly HashSet<string> PressedKey = new HashSet<string>();

		// Token: 0x0401E909 RID: 125193
		private bool IsRequesting;

		// Token: 0x0401E90A RID: 125194
		private int MistakeInputCount;

		// Token: 0x0401E90B RID: 125195
		private int TotalInputCount;

		// Token: 0x0401E90C RID: 125196
		private readonly Dictionary<int, List<Action<float>>> PendingTickFunctions = new Dictionary<int, List<Action<float>>>();

		// Token: 0x0401E90D RID: 125197
		private bool IsOpeningGuide;

		// Token: 0x0401E90E RID: 125198
		[Nullable(2)]
		private UKuroForceFeedbackEffect CommonForceFeedback;

		// Token: 0x0401E90F RID: 125199
		private RbGridDirection? InputDir;

		// Token: 0x0401E910 RID: 125200
		private Vector2D CurBirthEffectAreaWidth = Vector2D.Create();

		// Token: 0x0401E911 RID: 125201
		private Vector2D CurBirthEffectAreaHeight = Vector2D.Create();

		// Token: 0x0401E912 RID: 125202
		private readonly HashSet<RbBaseComponent> NeedShowEntities = new HashSet<RbBaseComponent>();

		// Token: 0x0401E913 RID: 125203
		[Nullable(2)]
		private TimerHandle SliceBirthEffectTimerHandle;

		// Token: 0x0401E914 RID: 125204
		private int SliceBirthEffectIncId;

		// Token: 0x0401E915 RID: 125205
		[Nullable(2)]
		private static RollBlockController _Instance;
	}
}
