using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Manufacture.Forging
{
	// Token: 0x02004619 RID: 17945
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingController : UiControllerBase
	{
		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x0602D14E RID: 184654 RVA: 0x00C9A4F0 File Offset: 0x00C986F0
		public int ForgingCostId
		{
			get
			{
				return ConfigCommonParamById.GetIntConfig("ForgingCost").GetValueOrDefault(-1);
			}
		}

		// Token: 0x0602D14F RID: 184655 RVA: 0x00C9A510 File Offset: 0x00C98710
		protected override bool OnClear()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x0602D150 RID: 184656 RVA: 0x00C9A519 File Offset: 0x00C98719
		protected override bool OnLeaveLevel()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x0602D151 RID: 184657 RVA: 0x00C9A524 File Offset: 0x00C98724
		protected override void OnAddEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ActiveRole;
			Action<int> handle;
			if ((handle = ForgingController.<>O.<0>__UpdateHelpRoleItemDataList) == null)
			{
				handle = (ForgingController.<>O.<0>__UpdateHelpRoleItemDataList = new Action<int>(ForgingController.UpdateHelpRoleItemDataList));
			}
			instance.Add<int>(name, handle);
			EventSystem.Instance.Add(EEventName.SwitchViewType, new Action<CSharpScript.Game.Module.Manufacture.Common.EViewType>(this.SwitchViewType));
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.LoadNewList));
		}

		// Token: 0x0602D152 RID: 184658 RVA: 0x00C9A594 File Offset: 0x00C98794
		protected override void OnRemoveEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ActiveRole;
			Action<int> handle;
			if ((handle = ForgingController.<>O.<0>__UpdateHelpRoleItemDataList) == null)
			{
				handle = (ForgingController.<>O.<0>__UpdateHelpRoleItemDataList = new Action<int>(ForgingController.UpdateHelpRoleItemDataList));
			}
			instance.Remove(name, handle);
			EventSystem.Instance.Remove(EEventName.SwitchViewType, new Action<CSharpScript.Game.Module.Manufacture.Common.EViewType>(this.SwitchViewType));
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.LoadNewList));
		}

		// Token: 0x0602D153 RID: 184659 RVA: 0x00C9A604 File Offset: 0x00C98804
		private void LoadNewList()
		{
			ForgingModel.Instance.CreateForgingDataList();
			this.SendForgeInfoRequest();
		}

		// Token: 0x0602D154 RID: 184660 RVA: 0x00C9A616 File Offset: 0x00C98816
		private void SwitchViewType(CSharpScript.Game.Module.Manufacture.Common.EViewType viewType)
		{
			if (CommonManager.Instance.GetCurrentSystem() != CSharpScript.Game.Module.Manufacture.Common.ESystemType.ForgingSystem)
			{
				return;
			}
			if (viewType == CSharpScript.Game.Module.Manufacture.Common.EViewType.RoleViewType)
			{
				ForgingModel.Instance.CurrentForgingViewType = EForgingViewType.ForgingRoleType;
				return;
			}
			if (viewType != CSharpScript.Game.Module.Manufacture.Common.EViewType.ManufactureViewType)
			{
				return;
			}
			ForgingModel.Instance.CurrentForgingViewType = EForgingViewType.ForgingType;
		}

		// Token: 0x0602D155 RID: 184661 RVA: 0x00C9A645 File Offset: 0x00C98845
		private static void UpdateHelpRoleItemDataList(int i)
		{
			ForgingModel.Instance.UpdateHelpRoleItemDataList();
		}

		// Token: 0x0602D156 RID: 184662 RVA: 0x00C9A651 File Offset: 0x00C98851
		public void RegisterCurrentInteractionEntity()
		{
			this.CurrentInteractionEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		}

		// Token: 0x0602D157 RID: 184663 RVA: 0x00C9A663 File Offset: 0x00C98863
		public void ClearCurrentInteractionEntityDisplay()
		{
			if (this.CurrentInteractionEntityId == null)
			{
				return;
			}
			this.ClearForgingDisplay();
			this.CurrentInteractionEntityId = null;
		}

		// Token: 0x0602D158 RID: 184664 RVA: 0x00C9A685 File Offset: 0x00C98885
		[NullableContext(2)]
		private void UpdateForgingDataCore(ForgeInfoResponse response)
		{
			ForgingModel.Instance.UpdateForgingDataList(response.ForgeInfoList);
			ForgingModel.Instance.UpdateForgingByServerConfig(response.ForgeInfoList);
		}

		// Token: 0x0602D159 RID: 184665 RVA: 0x00C9A6A7 File Offset: 0x00C988A7
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.ForgeItemInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				ForgeItemInfoUpdateNotify forgeItemInfoUpdateNotify = (ForgeItemInfoUpdateNotify)msg;
				ForgingModel instance = ForgingModel.Instance;
				bool flag = false;
				foreach (OneForgeInfo oneForgeInfo in forgeItemInfoUpdateNotify.ForgeInfoList)
				{
					int id = oneForgeInfo.Id;
					IWeaponForgingData forgingDataById = instance.GetForgingDataById(id);
					if (forgingDataById != null && forgingDataById.IsUnlock <= 0)
					{
						forgingDataById.IsNew = true;
						forgingDataById.IsUnlock = 1;
						NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.ForgingLevelKey, id);
						flag = true;
					}
				}
				if (flag)
				{
					GenericPromptController.Instance.ShowPromptByCode("FormulaLearned", Array.Empty<object>());
				}
			});
		}

		// Token: 0x0602D15A RID: 184666 RVA: 0x00C9A6D8 File Offset: 0x00C988D8
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ForgeItemInfoUpdateNotify);
		}

		// Token: 0x0602D15B RID: 184667 RVA: 0x00C9A6EC File Offset: 0x00C988EC
		public void SendForgeInfoRequest()
		{
			if (this.SendForgeInfoRequestFlag)
			{
				return;
			}
			this.SendForgeInfoRequestFlag = true;
			ForgeInfoRequest message = ForgeInfoRequest.Create();
			Net.Instance.Call(ERequestMessageId.ForgeInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				ForgeInfoResponse forgeInfoResponse = (ForgeInfoResponse)msg;
				this.SendForgeInfoRequestFlag = false;
				if (forgeInfoResponse.Code == Aki.Protocol.ErrorCode.Success)
				{
					ForgingModel.Instance.SaveLimitRefreshTime(forgeInfoResponse.LimitRefreshTime);
					this.UpdateForgingDataCore(forgeInfoResponse);
					EventSystem.Instance.Emit(EEventName.GetForgingData);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(forgeInfoResponse.Code, 18747, null, true, false);
				if (UiManager.Instance.IsViewShow(EUiViewName.ForgingRootView))
				{
					UiManager.Instance.CloseView(EUiViewName.ForgingRootView, null);
				}
			}, 0);
		}

		// Token: 0x0602D15C RID: 184668 RVA: 0x00C9A72C File Offset: 0x00C9892C
		public UniTask SendForgeInfoRequestAsync()
		{
			ForgingController.<SendForgeInfoRequestAsync>d__23 <SendForgeInfoRequestAsync>d__;
			<SendForgeInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendForgeInfoRequestAsync>d__.<>4__this = this;
			<SendForgeInfoRequestAsync>d__.<>1__state = -1;
			<SendForgeInfoRequestAsync>d__.<>t__builder.Start<ForgingController.<SendForgeInfoRequestAsync>d__23>(ref <SendForgeInfoRequestAsync>d__);
			return <SendForgeInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D15D RID: 184669 RVA: 0x00C9A770 File Offset: 0x00C98970
		public void SendForgeItemRequest(int id, int roleId, int forgingCount)
		{
			ForgeItemRequest forgeItemRequest = ForgeItemRequest.Create();
			forgeItemRequest.Id = id;
			forgeItemRequest.RoleId = roleId;
			forgeItemRequest.Count = forgingCount;
			forgeItemRequest.InteractEntityId = ForgingModel.Instance.CurrentInteractCreatureDataLongId.Value;
			Net.Instance.Call(ERequestMessageId.ForgeItemRequest, forgeItemRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				ForgeItemResponse forgeItemResponse = (ForgeItemResponse)msg;
				if (forgeItemResponse.Code == Aki.Protocol.ErrorCode.Success)
				{
					IWeaponForgingData forgingDataById = ForgingModel.Instance.GetForgingDataById(forgeItemResponse.Id);
					if (forgingDataById != null)
					{
						forgingDataById.LastRoleId = forgeItemResponse.RoleId;
					}
					RepeatedField<SingleItemInfo> itemInfos = forgeItemResponse.ItemInfos;
					if (forgeItemResponse.ExtraItemInfos.Count != 0)
					{
						itemInfos.AddRange(forgeItemResponse.ExtraItemInfos);
					}
					List<RewardItemData> list = new List<RewardItemData>();
					foreach (SingleItemInfo singleItemInfo in itemInfos)
					{
						int itemId = singleItemInfo.ItemId;
						int count = 1;
						for (int i = 0; i < singleItemInfo.ItemNum; i++)
						{
							RewardItemData item = new RewardItemData(itemId, count, null, EDropItemType.Normal);
							list.Add(item);
						}
					}
					this.PlayForgingAudio("play_ui_fx_spl_gen_robot_success_vo", null);
					ItemRewardController.Instance.OpenCompositeRewardView(2003, true, list, null);
					ForgingModel.Instance.UpdateForgingItemList(itemInfos);
					EventSystem.Instance.Emit(EEventName.ForgingSuccess);
					return;
				}
				EventSystem.Instance.Emit(EEventName.ForgingFail);
				ErrorCodeController.Instance.OpenErrorCodeTipView(forgeItemResponse.Code, 24992, null, true, true);
			}, 0);
		}

		// Token: 0x0602D15E RID: 184670 RVA: 0x00C9A7CC File Offset: 0x00C989CC
		public void SendForgeFormulaUnlockRequest(int formulaId)
		{
			ForgeFormulaUnlockRequest forgeFormulaUnlockRequest = ForgeFormulaUnlockRequest.Create();
			forgeFormulaUnlockRequest.Id = formulaId;
			Net.Instance.Call(ERequestMessageId.ForgeFormulaUnlockRequest, forgeFormulaUnlockRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				ForgeFormulaUnlockResponse forgeFormulaUnlockResponse = (ForgeFormulaUnlockResponse)msg;
				if (forgeFormulaUnlockResponse.Code == Aki.Protocol.ErrorCode.Success)
				{
					ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(formulaId);
					string localText = ForgingConfig.Instance.GetLocalText(forgeFormulaById.Value.Name);
					GenericPromptController.Instance.ShowPromptByCode("ComposeStudy", new object[]
					{
						localText
					});
					EventSystem.Instance.Emit(EEventName.UpdateForgingFormula);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(forgeFormulaUnlockResponse.Code, 26326, null, true, true);
			}, 0);
		}

		// Token: 0x0602D15F RID: 184671 RVA: 0x00C9A818 File Offset: 0x00C98A18
		public bool CheckIsBuff(int roleId, int id)
		{
			return Array.IndexOf<int>(ForgingConfig.Instance.GetForgeFormulaById(id).Value.RoleList(), roleId) >= 0;
		}

		// Token: 0x0602D160 RID: 184672 RVA: 0x00C9A84C File Offset: 0x00C98A4C
		public bool CheckIsBuffEx(int roleId, int itemId)
		{
			int[] array = ForgingConfig.Instance.GetForgeFormulaById(itemId).Value.RoleList();
			if (Array.IndexOf<int>(array, roleId) >= 0)
			{
				return false;
			}
			foreach (int value in RoleModel.Instance.GetRoleIdList(null))
			{
				if (Array.IndexOf<int>(array, value) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D161 RID: 184673 RVA: 0x00C9A8DC File Offset: 0x00C98ADC
		public int GetMaxCreateCount(int itemId)
		{
			return this.DoGetMaxCreateCount(ForgingConfig.Instance.GetForgeFormulaById(itemId).Value.ConsumeItems(), ConfigCommonParamById.GetIntConfig("MaxForgingCount").Value);
		}

		// Token: 0x0602D162 RID: 184674 RVA: 0x00C9A91C File Offset: 0x00C98B1C
		private int DoGetMaxCreateCount(IList<OneItemConfig> itemMap, int limitCount)
		{
			int num = limitCount;
			foreach (OneItemConfig oneItemConfig in itemMap)
			{
				int count = oneItemConfig.Count;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(oneItemConfig.ItemId, 0);
				if (count > itemCountByConfigId)
				{
					return 0;
				}
				int num2 = itemCountByConfigId / count;
				num = ((num < num2) ? num : num2);
			}
			return num;
		}

		// Token: 0x0602D163 RID: 184675 RVA: 0x00C9A99C File Offset: 0x00C98B9C
		public string GetForgingInfoText(int roleId)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			IEnumerable<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
			string result = "";
			foreach (Aki.Config.Skill skill in skillList)
			{
				if (skill.LeftSkillEffect != 0)
				{
					result = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(skill.SkillDescribe, null), skill.SkillDetailNum());
				}
			}
			return result;
		}

		// Token: 0x0602D164 RID: 184676 RVA: 0x00C9AA2C File Offset: 0x00C98C2C
		public bool CheckCanForging(int id)
		{
			return ForgingModel.Instance.CheckCanForging(id);
		}

		// Token: 0x0602D165 RID: 184677 RVA: 0x00C9AA3C File Offset: 0x00C98C3C
		public bool CheckCanUnlock(int id)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
			return InventoryModel.Instance.GetItemCountByConfigId(forgeFormulaById.Value.FormulaItemId, 0) != 0;
		}

		// Token: 0x0602D166 RID: 184678 RVA: 0x00C9AA72 File Offset: 0x00C98C72
		public bool CheckCanForgingOrCanUnlock(int id)
		{
			if (ForgingModel.Instance.GetForgingDataById(id).IsUnlock > 0)
			{
				return this.CheckCanForging(id);
			}
			return this.CheckCanUnlock(id);
		}

		// Token: 0x0602D167 RID: 184679 RVA: 0x00C9AA98 File Offset: 0x00C98C98
		public string GetForgingText(int id)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
			return ForgingConfig.Instance.GetLocalText(forgeFormulaById.Value.Name);
		}

		// Token: 0x0602D168 RID: 184680 RVA: 0x00C9AACC File Offset: 0x00C98CCC
		public int GetForgingId(int id)
		{
			return ForgingConfig.Instance.GetForgeFormulaById(id).Value.ItemId;
		}

		// Token: 0x0602D169 RID: 184681 RVA: 0x00C9AAF4 File Offset: 0x00C98CF4
		public List<ISingleItemInfo> GetForgingMaterialList(int itemId)
		{
			return ForgingModel.Instance.GetForgingMaterialList(itemId);
		}

		// Token: 0x0602D16A RID: 184682 RVA: 0x00C9AB01 File Offset: 0x00C98D01
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			return ForgingModel.Instance.GetHelpRoleItemDataList(itemId);
		}

		// Token: 0x0602D16B RID: 184683 RVA: 0x00C9AB0E File Offset: 0x00C98D0E
		public bool CheckShowRoleView()
		{
			return true;
		}

		// Token: 0x0602D16C RID: 184684 RVA: 0x00C9AB11 File Offset: 0x00C98D11
		public int GetCurrentRoleId()
		{
			return ForgingModel.Instance.CurrentForgingRoleId;
		}

		// Token: 0x0602D16D RID: 184685 RVA: 0x00C9AB1D File Offset: 0x00C98D1D
		public void SetCurrentRoleId(int roleId)
		{
			ForgingModel.Instance.CurrentForgingRoleId = roleId;
		}

		// Token: 0x0602D16E RID: 184686 RVA: 0x00C9AB2A File Offset: 0x00C98D2A
		public void SendManufacture(int itemId, int count)
		{
			if (!this.CheckCanForging(itemId))
			{
				this.PlayForgingFailDisplay(new Action(this.PlayForgingLoopDisplay));
				return;
			}
			this.SendForgeItemRequest(itemId, this.GetCurrentRoleId(), count);
		}

		// Token: 0x0602D16F RID: 184687 RVA: 0x00C9AB56 File Offset: 0x00C98D56
		public int GetForgingRoleId(int itemId)
		{
			return ForgingModel.Instance.GetForgingRoleId(itemId);
		}

		// Token: 0x0602D170 RID: 184688 RVA: 0x00C9AB63 File Offset: 0x00C98D63
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetForgingItemList()
		{
			return ForgingModel.Instance.GetForgingItemList();
		}

		// Token: 0x0602D171 RID: 184689 RVA: 0x00C9AB70 File Offset: 0x00C98D70
		[NullableContext(2)]
		public void PlayForgingEnterDisplay(Action onFinished = null)
		{
			this.ClearForgingDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			this.PlayForgingAudio("play_ui_fx_spl_gen_page_open", null);
			int value = GameplayTagDefine.EGameplayTagId["关卡.场景交互物.进入"];
			currentEntityTagComponent.AddTag(new int?(value));
		}

		// Token: 0x0602D172 RID: 184690 RVA: 0x00C9ABB8 File Offset: 0x00C98DB8
		public void PlayForgingLoopDisplay()
		{
			this.ClearForgingDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			currentEntityTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.循环"]));
		}

		// Token: 0x0602D173 RID: 184691 RVA: 0x00C9ABF0 File Offset: 0x00C98DF0
		[NullableContext(2)]
		public bool PlayForgingWorkingDisplay(Action onFinished = null)
		{
			this.ClearForgingDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return false;
			}
			EventSystem.Instance.Emit(EEventName.OnBeginPlayForgingWorkingDisplay);
			int value = GameplayTagDefine.EGameplayTagId["关卡.场景交互物.工作中"];
			currentEntityTagComponent.AddTag(new int?(value));
			this.OnWorkingDisplayFinished = onFinished;
			this.ForgingDisplayTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit(EEventName.OnPlayForgingWorkingDisplayFinished);
				if (this.OnWorkingDisplayFinished != null)
				{
					this.OnWorkingDisplayFinished();
				}
			}, 2000f, null, null, true, 1f);
			return true;
		}

		// Token: 0x0602D174 RID: 184692 RVA: 0x00C9AC6C File Offset: 0x00C98E6C
		[NullableContext(2)]
		public unsafe void PlayForgingFlow(PlayFlow playFlow, EPlotLowLevelPosition position = EPlotLowLevelPosition.Center)
		{
			if (playFlow != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "[PlayForgingFlow]播放D级剧情";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", playFlow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StateId", playFlow.StateId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", playFlow.FlowId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				UiParam uiParam = new UiParam
				{
					ViewName = new EUiViewName?(EUiViewName.ForgingRootView),
					Position = new EPlotLowLevelPosition?(position),
					TextWidth = new EPlotTextWidthType?(EPlotTextWidthType.Short)
				};
				FlowController.Instance.StartFlowForView(playFlow.FlowListName, playFlow.StateId, playFlow.FlowId, uiParam, true);
			}
		}

		// Token: 0x0602D175 RID: 184693 RVA: 0x00C9AD54 File Offset: 0x00C98F54
		private void PlayForgingAudio(string audioId, [Nullable(2)] PlayResult result = null)
		{
			Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
			if (audioPath == null)
			{
				return;
			}
			AudioController.Instance.PostEventByUi(audioPath.Value.Path, result, null, null);
		}

		// Token: 0x0602D176 RID: 184694 RVA: 0x00C9AD9B File Offset: 0x00C98F9B
		public void PlayLeaveForgingAudio()
		{
			this.PlayForgingAudio("play_ui_fx_spl_gen_page_close", null);
		}

		// Token: 0x0602D177 RID: 184695 RVA: 0x00C9ADAC File Offset: 0x00C98FAC
		[NullableContext(2)]
		public void PlayForgingFailDisplay(Action onFinished = null)
		{
			this.ClearForgingDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			PlayFlow composeFailFlow = ComposeModel.Instance.ComposeFailFlow;
			this.PlayForgingFlow(composeFailFlow, EPlotLowLevelPosition.Center);
			int value = GameplayTagDefine.EGameplayTagId["关卡.场景交互物.失败"];
			currentEntityTagComponent.AddTag(new int?(value));
			this.OnFailDisplayFinished = onFinished;
			this.ForgingDisplayTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (this.OnFailDisplayFinished != null)
				{
					this.OnFailDisplayFinished();
				}
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0602D178 RID: 184696 RVA: 0x00C9AE2C File Offset: 0x00C9902C
		public void ClearForgingDisplay()
		{
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent != null)
			{
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.失败"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.工作中"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.循环"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.进入"]));
			}
			if (this.ForgingDisplayTimerId != null && TimerSystem.Instance.Has(this.ForgingDisplayTimerId))
			{
				TimerSystem.Instance.Remove(this.ForgingDisplayTimerId);
				this.ForgingDisplayTimerId = null;
			}
		}

		// Token: 0x0602D179 RID: 184697 RVA: 0x00C9AEE4 File Offset: 0x00C990E4
		[NullableContext(2)]
		private LevelTagComponent GetCurrentEntityTagComponent()
		{
			int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
			if (currentInteractEntityId == null)
			{
				return null;
			}
			Entity entity = EntitySystem.Instance.Get(currentInteractEntityId.Value);
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<LevelTagComponent>();
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x0602D17A RID: 184698 RVA: 0x00C9AF24 File Offset: 0x00C99124
		public static ForgingController Instance
		{
			get
			{
				return ForgingController._Instance;
			}
		}

		// Token: 0x0602D17B RID: 184699 RVA: 0x00C9AF2B File Offset: 0x00C9912B
		public static ForgingController GetOrCreateInstance()
		{
			if (ForgingController._Instance == null)
			{
				ForgingController.CreateInstance();
			}
			return ForgingController._Instance;
		}

		// Token: 0x0602D17C RID: 184700 RVA: 0x00C9AF3F File Offset: 0x00C9913F
		public static bool CreateInstance()
		{
			if (ForgingController._Instance != null)
			{
				return true;
			}
			ForgingController._Instance = new ForgingController();
			return true;
		}

		// Token: 0x0602D17D RID: 184701 RVA: 0x00C9AF55 File Offset: 0x00C99155
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D17E RID: 184702 RVA: 0x00C9AF57 File Offset: 0x00C99157
		public static void ResetStaticDefaultValue()
		{
			ForgingController._Instance = null;
		}

		// Token: 0x0602D17F RID: 184703 RVA: 0x00C9AF5F File Offset: 0x00C9915F
		static ForgingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ForgingController.CreateStaticDefaultValue), new Action(ForgingController.ResetStaticDefaultValue));
		}

		// Token: 0x04018315 RID: 99093
		public const string ENTER_AUDIO_ID = "play_ui_fx_spl_gen_page_open";

		// Token: 0x04018316 RID: 99094
		public const string LEAVE_AUDIO_ID = "play_ui_fx_spl_gen_page_close";

		// Token: 0x04018317 RID: 99095
		public const string SUCCESS_AUDIO_ID = "play_ui_fx_spl_gen_robot_success_vo";

		// Token: 0x04018318 RID: 99096
		[Nullable(2)]
		private TimerHandle ForgingDisplayTimerId;

		// Token: 0x04018319 RID: 99097
		[Nullable(2)]
		private Action OnWorkingDisplayFinished;

		// Token: 0x0401831A RID: 99098
		[Nullable(2)]
		private Action OnFailDisplayFinished;

		// Token: 0x0401831B RID: 99099
		private int? CurrentInteractionEntityId = new int?(0);

		// Token: 0x0401831C RID: 99100
		private bool SendForgeInfoRequestFlag;

		// Token: 0x0401831D RID: 99101
		[Nullable(2)]
		private static ForgingController _Instance;

		// Token: 0x0200A225 RID: 41509
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040324BE RID: 206014
			[Nullable(0)]
			public static Action<int> <0>__UpdateHelpRoleItemDataList;
		}
	}
}
