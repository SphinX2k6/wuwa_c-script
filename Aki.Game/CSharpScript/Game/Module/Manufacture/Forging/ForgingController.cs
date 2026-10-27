using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005643 RID: 22083
	[NullableContext(1)]
	[Nullable(0)]
	public class ForgingController : UiControllerBase
	{
		// Token: 0x1700873A RID: 34618
		// (get) Token: 0x06038250 RID: 229968 RVA: 0x00D4C7A8 File Offset: 0x00D4A9A8
		public int ForgingCostId
		{
			get
			{
				return ConfigCommonParamById.GetIntConfig("ForgingCost").GetValueOrDefault(-1);
			}
		}

		// Token: 0x06038251 RID: 229969 RVA: 0x00D4C7C8 File Offset: 0x00D4A9C8
		protected override bool OnClear()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x06038252 RID: 229970 RVA: 0x00D4C7D1 File Offset: 0x00D4A9D1
		protected override bool OnLeaveLevel()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x06038253 RID: 229971 RVA: 0x00D4C7DC File Offset: 0x00D4A9DC
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

		// Token: 0x06038254 RID: 229972 RVA: 0x00D4C84C File Offset: 0x00D4AA4C
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

		// Token: 0x06038255 RID: 229973 RVA: 0x00D4C8BC File Offset: 0x00D4AABC
		private void LoadNewList()
		{
			ForgingModel.Instance.CreateForgingDataList();
			this.SendForgeInfoRequest();
		}

		// Token: 0x06038256 RID: 229974 RVA: 0x00D4C8CE File Offset: 0x00D4AACE
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

		// Token: 0x06038257 RID: 229975 RVA: 0x00D4C8FD File Offset: 0x00D4AAFD
		private static void UpdateHelpRoleItemDataList(int i)
		{
			ForgingModel.Instance.UpdateHelpRoleItemDataList();
		}

		// Token: 0x06038258 RID: 229976 RVA: 0x00D4C909 File Offset: 0x00D4AB09
		public void RegisterCurrentInteractionEntity()
		{
			this.CurrentInteractionEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		}

		// Token: 0x06038259 RID: 229977 RVA: 0x00D4C91B File Offset: 0x00D4AB1B
		public void ClearCurrentInteractionEntityDisplay()
		{
			if (this.CurrentInteractionEntityId == null)
			{
				return;
			}
			this.ClearForgingDisplay();
			this.CurrentInteractionEntityId = null;
		}

		// Token: 0x0603825A RID: 229978 RVA: 0x00D4C93D File Offset: 0x00D4AB3D
		[NullableContext(2)]
		private void UpdateForgingDataCore(ForgeInfoResponse response)
		{
			ForgingModel.Instance.UpdateForgingDataList(response.ForgeInfoList);
			ForgingModel.Instance.UpdateForgingByServerConfig(response.ForgeInfoList);
		}

		// Token: 0x0603825B RID: 229979 RVA: 0x00D4C95F File Offset: 0x00D4AB5F
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

		// Token: 0x0603825C RID: 229980 RVA: 0x00D4C990 File Offset: 0x00D4AB90
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ForgeItemInfoUpdateNotify);
		}

		// Token: 0x0603825D RID: 229981 RVA: 0x00D4C9A4 File Offset: 0x00D4ABA4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(forgeInfoResponse.Code, 28293, null, true, false);
				if (UiManager.Instance.IsViewShow(EUiViewName.ForgingRootView))
				{
					UiManager.Instance.CloseView(EUiViewName.ForgingRootView, null);
				}
			}, 0);
		}

		// Token: 0x0603825E RID: 229982 RVA: 0x00D4C9E4 File Offset: 0x00D4ABE4
		public UniTask SendForgeInfoRequestAsync()
		{
			ForgingController.<SendForgeInfoRequestAsync>d__23 <SendForgeInfoRequestAsync>d__;
			<SendForgeInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendForgeInfoRequestAsync>d__.<>4__this = this;
			<SendForgeInfoRequestAsync>d__.<>1__state = -1;
			<SendForgeInfoRequestAsync>d__.<>t__builder.Start<ForgingController.<SendForgeInfoRequestAsync>d__23>(ref <SendForgeInfoRequestAsync>d__);
			return <SendForgeInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603825F RID: 229983 RVA: 0x00D4CA28 File Offset: 0x00D4AC28
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(forgeItemResponse.Code, 27784, null, true, true);
			}, 0);
		}

		// Token: 0x06038260 RID: 229984 RVA: 0x00D4CA84 File Offset: 0x00D4AC84
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(forgeFormulaUnlockResponse.Code, 18480, null, true, true);
			}, 0);
		}

		// Token: 0x06038261 RID: 229985 RVA: 0x00D4CAD0 File Offset: 0x00D4ACD0
		public bool CheckIsBuff(int roleId, int id)
		{
			return ForgingConfig.Instance.GetForgeFormulaById(id).Value.RoleList().Contains(roleId);
		}

		// Token: 0x06038262 RID: 229986 RVA: 0x00D4CB00 File Offset: 0x00D4AD00
		public bool CheckIsBuffEx(int roleId, int itemId)
		{
			int[] source = ForgingConfig.Instance.GetForgeFormulaById(itemId).Value.RoleList();
			if (source.Contains(roleId))
			{
				return false;
			}
			foreach (int value in RoleModel.Instance.GetRoleIdList())
			{
				if (source.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038263 RID: 229987 RVA: 0x00D4CB8C File Offset: 0x00D4AD8C
		public int GetMaxCreateCount(int itemId)
		{
			return this.DoGetMaxCreateCount(ForgingConfig.Instance.GetForgeFormulaById(itemId).Value.ConsumeItems(), ConfigCommonParamById.GetIntConfig("MaxForgingCount").Value);
		}

		// Token: 0x06038264 RID: 229988 RVA: 0x00D4CBCC File Offset: 0x00D4ADCC
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

		// Token: 0x06038265 RID: 229989 RVA: 0x00D4CC4C File Offset: 0x00D4AE4C
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

		// Token: 0x06038266 RID: 229990 RVA: 0x00D4CCDC File Offset: 0x00D4AEDC
		public bool CheckCanForging(int id)
		{
			return ForgingModel.Instance.CheckCanForging(id);
		}

		// Token: 0x06038267 RID: 229991 RVA: 0x00D4CCEC File Offset: 0x00D4AEEC
		public bool CheckCanUnlock(int id)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
			return InventoryModel.Instance.GetItemCountByConfigId(forgeFormulaById.Value.FormulaItemId, 0) != 0;
		}

		// Token: 0x06038268 RID: 229992 RVA: 0x00D4CD22 File Offset: 0x00D4AF22
		public bool CheckCanForgingOrCanUnlock(int id)
		{
			if (ForgingModel.Instance.GetForgingDataById(id).IsUnlock > 0)
			{
				return this.CheckCanForging(id);
			}
			return this.CheckCanUnlock(id);
		}

		// Token: 0x06038269 RID: 229993 RVA: 0x00D4CD48 File Offset: 0x00D4AF48
		public string GetForgingText(int id)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(id);
			return ForgingConfig.Instance.GetLocalText(forgeFormulaById.Value.Name);
		}

		// Token: 0x0603826A RID: 229994 RVA: 0x00D4CD7C File Offset: 0x00D4AF7C
		public int GetForgingId(int id)
		{
			return ForgingConfig.Instance.GetForgeFormulaById(id).Value.ItemId;
		}

		// Token: 0x0603826B RID: 229995 RVA: 0x00D4CDA4 File Offset: 0x00D4AFA4
		public List<ISingleItemInfo> GetForgingMaterialList(int itemId)
		{
			return ForgingModel.Instance.GetForgingMaterialList(itemId);
		}

		// Token: 0x0603826C RID: 229996 RVA: 0x00D4CDB1 File Offset: 0x00D4AFB1
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			return ForgingModel.Instance.GetHelpRoleItemDataList(itemId);
		}

		// Token: 0x0603826D RID: 229997 RVA: 0x00D4CDBE File Offset: 0x00D4AFBE
		public bool CheckShowRoleView()
		{
			return true;
		}

		// Token: 0x0603826E RID: 229998 RVA: 0x00D4CDC1 File Offset: 0x00D4AFC1
		public int GetCurrentRoleId()
		{
			return ForgingModel.Instance.CurrentForgingRoleId;
		}

		// Token: 0x0603826F RID: 229999 RVA: 0x00D4CDCD File Offset: 0x00D4AFCD
		public void SetCurrentRoleId(int roleId)
		{
			ForgingModel.Instance.CurrentForgingRoleId = roleId;
		}

		// Token: 0x06038270 RID: 230000 RVA: 0x00D4CDDA File Offset: 0x00D4AFDA
		public void SendManufacture(int itemId, int count)
		{
			if (!this.CheckCanForging(itemId))
			{
				this.PlayForgingFailDisplay(new Action(this.PlayForgingLoopDisplay));
				return;
			}
			this.SendForgeItemRequest(itemId, this.GetCurrentRoleId(), count);
		}

		// Token: 0x06038271 RID: 230001 RVA: 0x00D4CE06 File Offset: 0x00D4B006
		public int GetForgingRoleId(int itemId)
		{
			return ForgingModel.Instance.GetForgingRoleId(itemId);
		}

		// Token: 0x06038272 RID: 230002 RVA: 0x00D4CE13 File Offset: 0x00D4B013
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetForgingItemList()
		{
			return ForgingModel.Instance.GetForgingItemList();
		}

		// Token: 0x06038273 RID: 230003 RVA: 0x00D4CE20 File Offset: 0x00D4B020
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

		// Token: 0x06038274 RID: 230004 RVA: 0x00D4CE68 File Offset: 0x00D4B068
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

		// Token: 0x06038275 RID: 230005 RVA: 0x00D4CEA0 File Offset: 0x00D4B0A0
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

		// Token: 0x06038276 RID: 230006 RVA: 0x00D4CF1C File Offset: 0x00D4B11C
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

		// Token: 0x06038277 RID: 230007 RVA: 0x00D4D004 File Offset: 0x00D4B204
		private void PlayForgingAudio(string audioId, [Nullable(2)] PlayResult result = null)
		{
			Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
			if (audioPath == null)
			{
				return;
			}
			AudioController.Instance.PostEventByUi(audioPath.Value.Path, result, null, null);
		}

		// Token: 0x06038278 RID: 230008 RVA: 0x00D4D04B File Offset: 0x00D4B24B
		public void PlayLeaveForgingAudio()
		{
			this.PlayForgingAudio("play_ui_fx_spl_gen_page_close", null);
		}

		// Token: 0x06038279 RID: 230009 RVA: 0x00D4D05C File Offset: 0x00D4B25C
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

		// Token: 0x0603827A RID: 230010 RVA: 0x00D4D0DC File Offset: 0x00D4B2DC
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

		// Token: 0x0603827B RID: 230011 RVA: 0x00D4D194 File Offset: 0x00D4B394
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

		// Token: 0x1700873B RID: 34619
		// (get) Token: 0x0603827C RID: 230012 RVA: 0x00D4D1D4 File Offset: 0x00D4B3D4
		public static ForgingController Instance
		{
			get
			{
				return ForgingController._Instance;
			}
		}

		// Token: 0x0603827D RID: 230013 RVA: 0x00D4D1DB File Offset: 0x00D4B3DB
		public static ForgingController GetOrCreateInstance()
		{
			if (ForgingController._Instance == null)
			{
				ForgingController.CreateInstance();
			}
			return ForgingController._Instance;
		}

		// Token: 0x0603827E RID: 230014 RVA: 0x00D4D1EF File Offset: 0x00D4B3EF
		public static bool CreateInstance()
		{
			if (ForgingController._Instance != null)
			{
				return true;
			}
			ForgingController._Instance = new ForgingController();
			return true;
		}

		// Token: 0x0603827F RID: 230015 RVA: 0x00D4D205 File Offset: 0x00D4B405
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038280 RID: 230016 RVA: 0x00D4D207 File Offset: 0x00D4B407
		public static void ResetStaticDefaultValue()
		{
			ForgingController._Instance = null;
		}

		// Token: 0x06038281 RID: 230017 RVA: 0x00D4D20F File Offset: 0x00D4B40F
		static ForgingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ForgingController.CreateStaticDefaultValue), new Action(ForgingController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D88A RID: 120970
		public const string ENTER_AUDIO_ID = "play_ui_fx_spl_gen_page_open";

		// Token: 0x0401D88B RID: 120971
		public const string LEAVE_AUDIO_ID = "play_ui_fx_spl_gen_page_close";

		// Token: 0x0401D88C RID: 120972
		public const string SUCCESS_AUDIO_ID = "play_ui_fx_spl_gen_robot_success_vo";

		// Token: 0x0401D88D RID: 120973
		[Nullable(2)]
		private TimerHandle ForgingDisplayTimerId;

		// Token: 0x0401D88E RID: 120974
		[Nullable(2)]
		private Action OnWorkingDisplayFinished;

		// Token: 0x0401D88F RID: 120975
		[Nullable(2)]
		private Action OnFailDisplayFinished;

		// Token: 0x0401D890 RID: 120976
		private int? CurrentInteractionEntityId = new int?(0);

		// Token: 0x0401D891 RID: 120977
		private bool SendForgeInfoRequestFlag;

		// Token: 0x0401D892 RID: 120978
		[Nullable(2)]
		private static ForgingController _Instance;

		// Token: 0x0200B7FA RID: 47098
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037A94 RID: 227988
			[Nullable(0)]
			public static Action<int> <0>__UpdateHelpRoleItemDataList;
		}
	}
}
