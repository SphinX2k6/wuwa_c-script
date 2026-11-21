using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200462B RID: 17963
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeController : UiControllerBase
	{
		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x0602D235 RID: 184885 RVA: 0x00C9F5EC File Offset: 0x00C9D7EC
		public int ComposeCoinId
		{
			get
			{
				return ConfigCommonParamById.GetIntConfig("ComposeCost").GetValueOrDefault(-1);
			}
		}

		// Token: 0x0602D236 RID: 184886 RVA: 0x00C9F60C File Offset: 0x00C9D80C
		protected override bool OnClear()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x0602D237 RID: 184887 RVA: 0x00C9F615 File Offset: 0x00C9D815
		protected override bool OnLeaveLevel()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x0602D238 RID: 184888 RVA: 0x00C9F620 File Offset: 0x00C9D820
		protected override void OnAddEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ActiveRole;
			Action<int> handle;
			if ((handle = ComposeController.<>O.<0>__UpdateHelpRoleItemDataList) == null)
			{
				handle = (ComposeController.<>O.<0>__UpdateHelpRoleItemDataList = new Action<int>(ComposeController.UpdateHelpRoleItemDataList));
			}
			instance.Add<int>(name, handle);
			EventSystem.Instance.Add(EEventName.SwitchViewType, new Action<CSharpScript.Game.Module.Manufacture.Common.EViewType>(this.SwitchViewType));
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.LoadNewList));
			EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.ShowComposeStudy));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602D239 RID: 184889 RVA: 0x00C9F6C8 File Offset: 0x00C9D8C8
		protected override void OnRemoveEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ActiveRole;
			Action<int> handle;
			if ((handle = ComposeController.<>O.<0>__UpdateHelpRoleItemDataList) == null)
			{
				handle = (ComposeController.<>O.<0>__UpdateHelpRoleItemDataList = new Action<int>(ComposeController.UpdateHelpRoleItemDataList));
			}
			instance.Remove(name, handle);
			EventSystem.Instance.Remove(EEventName.SwitchViewType, new Action<CSharpScript.Game.Module.Manufacture.Common.EViewType>(this.SwitchViewType));
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.LoadNewList));
			EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.ShowComposeStudy));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602D23A RID: 184890 RVA: 0x00C9F76D File Offset: 0x00C9D96D
		private void LoadNewList()
		{
			ComposeModel.Instance.CreatePurificationDataList();
		}

		// Token: 0x0602D23B RID: 184891 RVA: 0x00C9F77C File Offset: 0x00C9D97C
		private void SwitchViewType(CSharpScript.Game.Module.Manufacture.Common.EViewType viewType)
		{
			if (CommonManager.Instance.GetCurrentSystem() != CSharpScript.Game.Module.Manufacture.Common.ESystemType.ComposeSystem)
			{
				return;
			}
			switch (viewType)
			{
			case CSharpScript.Game.Module.Manufacture.Common.EViewType.RoleViewType:
				ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeRoleType;
				return;
			case CSharpScript.Game.Module.Manufacture.Common.EViewType.LevelViewType:
				ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeLevelType;
				return;
			case CSharpScript.Game.Module.Manufacture.Common.EViewType.ManufactureViewType:
				ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeType;
				return;
			default:
				return;
			}
		}

		// Token: 0x0602D23C RID: 184892 RVA: 0x00C9F7D0 File Offset: 0x00C9D9D0
		private void ShowComposeStudy(int configId, int count)
		{
			ItemInfo? config = ItemConfig.Instance.GetConfig(configId);
			if (Array.IndexOf<int>(config.Value.ShowTypes(), 35) < 0 && Array.IndexOf<int>(config.Value.ShowTypes(), 37) < 0)
			{
				return;
			}
			SynthesisFormula? synthesisFormulaByFormulaItemId = ComposeConfig.Instance.GetSynthesisFormulaByFormulaItemId(configId);
			string localText = ComposeConfig.Instance.GetLocalText(synthesisFormulaByFormulaItemId.Value.Name);
			GenericPromptController.Instance.ShowPromptByCode("ComposeStudy", new object[]
			{
				localText
			});
			EventSystem.Instance.Emit(EEventName.UpdateFormula);
		}

		// Token: 0x0602D23D RID: 184893 RVA: 0x00C9F86C File Offset: 0x00C9DA6C
		private void OnCloseView(EUiViewName view, int viewId)
		{
			if (view == EUiViewName.ItemTipsView)
			{
				ComposeModel.Instance.ComposeSelectItem = null;
			}
		}

		// Token: 0x0602D23E RID: 184894 RVA: 0x00C9F886 File Offset: 0x00C9DA86
		private static void UpdateHelpRoleItemDataList(int i)
		{
			ComposeModel.Instance.UpdateHelpRoleItemDataList();
		}

		// Token: 0x0602D23F RID: 184895 RVA: 0x00C9F892 File Offset: 0x00C9DA92
		public void RegisterCurrentInteractionEntity()
		{
			this.CurrentInteractionEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		}

		// Token: 0x0602D240 RID: 184896 RVA: 0x00C9F8A4 File Offset: 0x00C9DAA4
		public void ClearCurrentInteractionEntityDisplay()
		{
			if (this.CurrentInteractionEntityId == null)
			{
				return;
			}
			this.ClearCompositeDisplay();
			this.CurrentInteractionEntityId = null;
		}

		// Token: 0x0602D241 RID: 184897 RVA: 0x00C9F8C8 File Offset: 0x00C9DAC8
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SynthesisInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SynthesisInfoUpdateNotify synthesisInfoUpdateNotify = (SynthesisInfoUpdateNotify)msg;
				ComposeModel.Instance.UpdateComposeDataList(synthesisInfoUpdateNotify.SynthesisInfoList);
				ComposeModel.Instance.HideComposeDataList(synthesisInfoUpdateNotify.HideSynthesisIdList);
			});
			Net.Instance.Register(ENotifyMessageId.SynthesisLevelUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SynthesisLevelUpdateNotify synthesisLevelUpdateNotify = (SynthesisLevelUpdateNotify)msg;
				ComposeModel.Instance.UpdateComposeInfo(synthesisLevelUpdateNotify.LevelInfo);
				EventSystem.Instance.Emit(EEventName.UpdateComposeInfo);
			});
		}

		// Token: 0x0602D242 RID: 184898 RVA: 0x00C9F933 File Offset: 0x00C9DB33
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SynthesisInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SynthesisLevelUpdateNotify);
		}

		// Token: 0x0602D243 RID: 184899 RVA: 0x00C9F958 File Offset: 0x00C9DB58
		[NullableContext(2)]
		private void HandleSynthesisInfoRequestCore(SynthesisInfoResponse response)
		{
			ComposeModel.Instance.CreateComposeDataList(response.SynthesisInfoList);
			ComposeModel.Instance.UpdateComposeByServerConfig(response.SynthesisConfigs);
			ComposeModel.Instance.CreateComposeLevelInfo(response.LevelInfo);
			ComposeModel.Instance.SaveLimitRefreshTime(response.LimitRefreshTime);
		}

		// Token: 0x0602D244 RID: 184900 RVA: 0x00C9F9A8 File Offset: 0x00C9DBA8
		public UniTask SendSynthesisInfoRequestAsync()
		{
			ComposeController.<SendSynthesisInfoRequestAsync>d__24 <SendSynthesisInfoRequestAsync>d__;
			<SendSynthesisInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSynthesisInfoRequestAsync>d__.<>4__this = this;
			<SendSynthesisInfoRequestAsync>d__.<>1__state = -1;
			<SendSynthesisInfoRequestAsync>d__.<>t__builder.Start<ComposeController.<SendSynthesisInfoRequestAsync>d__24>(ref <SendSynthesisInfoRequestAsync>d__);
			return <SendSynthesisInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D245 RID: 184901 RVA: 0x00C9F9EC File Offset: 0x00C9DBEC
		public UniTask SendSynthesisItemRequestBatchNew(List<IComposePopupGridItemData> composeGridData, [Nullable(2)] Action successCallback = null)
		{
			ComposeController.<SendSynthesisItemRequestBatchNew>d__25 <SendSynthesisItemRequestBatchNew>d__;
			<SendSynthesisItemRequestBatchNew>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSynthesisItemRequestBatchNew>d__.<>4__this = this;
			<SendSynthesisItemRequestBatchNew>d__.composeGridData = composeGridData;
			<SendSynthesisItemRequestBatchNew>d__.successCallback = successCallback;
			<SendSynthesisItemRequestBatchNew>d__.<>1__state = -1;
			<SendSynthesisItemRequestBatchNew>d__.<>t__builder.Start<ComposeController.<SendSynthesisItemRequestBatchNew>d__25>(ref <SendSynthesisItemRequestBatchNew>d__);
			return <SendSynthesisItemRequestBatchNew>d__.<>t__builder.Task;
		}

		// Token: 0x0602D246 RID: 184902 RVA: 0x00C9FA40 File Offset: 0x00C9DC40
		public UniTask SendSynthesisItemRequestNew(int id, int composeCount, List<SingleItemInfo> composeMaterialList, [Nullable(2)] Action successCallback = null)
		{
			ComposeController.<SendSynthesisItemRequestNew>d__26 <SendSynthesisItemRequestNew>d__;
			<SendSynthesisItemRequestNew>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSynthesisItemRequestNew>d__.<>4__this = this;
			<SendSynthesisItemRequestNew>d__.id = id;
			<SendSynthesisItemRequestNew>d__.composeCount = composeCount;
			<SendSynthesisItemRequestNew>d__.composeMaterialList = composeMaterialList;
			<SendSynthesisItemRequestNew>d__.successCallback = successCallback;
			<SendSynthesisItemRequestNew>d__.<>1__state = -1;
			<SendSynthesisItemRequestNew>d__.<>t__builder.Start<ComposeController.<SendSynthesisItemRequestNew>d__26>(ref <SendSynthesisItemRequestNew>d__);
			return <SendSynthesisItemRequestNew>d__.<>t__builder.Task;
		}

		// Token: 0x0602D247 RID: 184903 RVA: 0x00C9FAA4 File Offset: 0x00C9DCA4
		public UniTask SendSynthesisItemRequest(int id, int roleId, int composeCount)
		{
			ComposeController.<SendSynthesisItemRequest>d__27 <SendSynthesisItemRequest>d__;
			<SendSynthesisItemRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSynthesisItemRequest>d__.<>4__this = this;
			<SendSynthesisItemRequest>d__.id = id;
			<SendSynthesisItemRequest>d__.roleId = roleId;
			<SendSynthesisItemRequest>d__.composeCount = composeCount;
			<SendSynthesisItemRequest>d__.<>1__state = -1;
			<SendSynthesisItemRequest>d__.<>t__builder.Start<ComposeController.<SendSynthesisItemRequest>d__27>(ref <SendSynthesisItemRequest>d__);
			return <SendSynthesisItemRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602D248 RID: 184904 RVA: 0x00C9FB00 File Offset: 0x00C9DD00
		private static string FormatItemInfoList(IEnumerable<SingleItemInfo> list)
		{
			List<string> list2 = new List<string>();
			foreach (SingleItemInfo singleItemInfo in list)
			{
				List<string> list3 = list2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(singleItemInfo.ItemId);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(singleItemInfo.ItemNum);
				list3.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return string.Join(",", list2);
		}

		// Token: 0x0602D249 RID: 184905 RVA: 0x00C9FB90 File Offset: 0x00C9DD90
		private static string FormatBatchItems(IEnumerable<BatchItem> items)
		{
			List<string> list = new List<string>();
			foreach (BatchItem batchItem in items)
			{
				List<string> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
				defaultInterpolatedStringHandler.AppendFormatted<int>(batchItem.Id);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(batchItem.Count);
				defaultInterpolatedStringHandler.AppendLiteral("{");
				defaultInterpolatedStringHandler.AppendFormatted(ComposeController.FormatItemInfoList(batchItem.CostItems));
				defaultInterpolatedStringHandler.AppendLiteral("}");
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return string.Join("|", list);
		}

		// Token: 0x0602D24A RID: 184906 RVA: 0x00C9FC48 File Offset: 0x00C9DE48
		private static string FormatConsumeMap(Dictionary<int, int> consumeItems)
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<int, int> keyValuePair in consumeItems)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int value = num;
				int value2 = num2;
				List<string> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return string.Join(",", list);
		}

		// Token: 0x0602D24B RID: 184907 RVA: 0x00C9FCE4 File Offset: 0x00C9DEE4
		private unsafe void ProcessComposeResponseSuccess(IList<SingleItemInfo> tmpList, [Nullable(2)] Action successCallback = null)
		{
			ComposeController.<>c__DisplayClass31_0 CS$<>8__locals1 = new ComposeController.<>c__DisplayClass31_0();
			CS$<>8__locals1.<>4__this = this;
			ComposeModel instance = ComposeModel.Instance;
			IComposeLevelInfoData composeInfo = instance.GetComposeInfo();
			int composeLevel = composeInfo.ComposeLevel;
			int composeMaxLevel = instance.GetComposeMaxLevel();
			SynthesisLevel? composeLevelByLevel = instance.GetComposeLevelByLevel(composeMaxLevel);
			int totalProficiency = composeInfo.TotalProficiency;
			int completeness = composeLevelByLevel.Value.Completeness;
			CS$<>8__locals1.rewardProgressList = null;
			if (instance.CurrentComposeListType == EComposeListType.ReagentProduction && (instance.LastExp < completeness || (composeLevel < composeMaxLevel && totalProficiency < completeness)))
			{
				SynthesisLevel? composeLevelByLevel2 = instance.GetComposeLevelByLevel(Math.Min(composeMaxLevel, composeLevel + 1));
				IRewardProgress rewardProgress = new RewardProgress
				{
					FromProgress = instance.LastExp,
					ToProgress = totalProficiency,
					MaxProgress = composeLevelByLevel2.Value.Completeness
				};
				ComposeController.<>c__DisplayClass31_0 CS$<>8__locals2 = CS$<>8__locals1;
				int num = 1;
				List<IRewardProgress> list = new List<IRewardProgress>(num);
				CollectionsMarshal.SetCount<IRewardProgress>(list, num);
				Span<IRewardProgress> span = CollectionsMarshal.AsSpan<IRewardProgress>(list);
				int index = 0;
				*span[index] = rewardProgress;
				CS$<>8__locals2.rewardProgressList = list;
			}
			instance.LastExp = totalProficiency;
			CS$<>8__locals1.rewardItemDataList = new List<RewardItemData>();
			foreach (SingleItemInfo singleItemInfo in tmpList)
			{
				int itemId = singleItemInfo.ItemId;
				int itemNum = singleItemInfo.ItemNum;
				RewardItemData item = new RewardItemData(itemId, itemNum, null, EDropItemType.Normal);
				CS$<>8__locals1.rewardItemDataList.Add(item);
			}
			if (successCallback != null)
			{
				successCallback();
			}
			else if (!this.PlayCompositeWorkingDisplay(delegate
			{
				CS$<>8__locals1.<>4__this.PlayCompositeAudio("play_ui_fx_spl_gen_robot_success_vo", null);
				CS$<>8__locals1.<>4__this.PlayCompositeLoopDisplay();
				ItemRewardController.Instance.OpenCompositeRewardView(2004, true, CS$<>8__locals1.rewardItemDataList, CS$<>8__locals1.rewardProgressList);
			}))
			{
				ItemRewardController.Instance.OpenCompositeRewardView(2004, true, CS$<>8__locals1.rewardItemDataList, CS$<>8__locals1.rewardProgressList);
			}
			ComposeModel.Instance.UpdateComposeItemList(tmpList);
			EventSystem.Instance.Emit(EEventName.ComposeSuccess);
		}

		// Token: 0x0602D24C RID: 184908 RVA: 0x00C9FEA8 File Offset: 0x00C9E0A8
		[NullableContext(2)]
		public UniTask SendExchangeItemRequest(int targetId, int consumeItemId, int consumeCount, Action successCallback = null)
		{
			ComposeController.<SendExchangeItemRequest>d__32 <SendExchangeItemRequest>d__;
			<SendExchangeItemRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendExchangeItemRequest>d__.targetId = targetId;
			<SendExchangeItemRequest>d__.consumeItemId = consumeItemId;
			<SendExchangeItemRequest>d__.consumeCount = consumeCount;
			<SendExchangeItemRequest>d__.successCallback = successCallback;
			<SendExchangeItemRequest>d__.<>1__state = -1;
			<SendExchangeItemRequest>d__.<>t__builder.Start<ComposeController.<SendExchangeItemRequest>d__32>(ref <SendExchangeItemRequest>d__);
			return <SendExchangeItemRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602D24D RID: 184909 RVA: 0x00C9FF04 File Offset: 0x00C9E104
		public UniTask SendBatchMaterialReplaceRequest(int targetId, Dictionary<int, int> consumeItems, [Nullable(2)] Action successCallback = null)
		{
			ComposeController.<SendBatchMaterialReplaceRequest>d__33 <SendBatchMaterialReplaceRequest>d__;
			<SendBatchMaterialReplaceRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendBatchMaterialReplaceRequest>d__.targetId = targetId;
			<SendBatchMaterialReplaceRequest>d__.consumeItems = consumeItems;
			<SendBatchMaterialReplaceRequest>d__.successCallback = successCallback;
			<SendBatchMaterialReplaceRequest>d__.<>1__state = -1;
			<SendBatchMaterialReplaceRequest>d__.<>t__builder.Start<ComposeController.<SendBatchMaterialReplaceRequest>d__33>(ref <SendBatchMaterialReplaceRequest>d__);
			return <SendBatchMaterialReplaceRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602D24E RID: 184910 RVA: 0x00C9FF58 File Offset: 0x00C9E158
		public void SendSynthesisLevelRewardRequest()
		{
			if (this.SendRewardFlag)
			{
				return;
			}
			SynthesisLevelRewardRequest message = SynthesisLevelRewardRequest.Create();
			this.SendRewardFlag = true;
			Net.Instance.Call(ERequestMessageId.SynthesisLevelRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
			{
				SynthesisLevelRewardResponse synthesisLevelRewardResponse = (SynthesisLevelRewardResponse)msg;
				this.SendRewardFlag = false;
				if (synthesisLevelRewardResponse.Code == Aki.Protocol.ErrorCode.Success)
				{
					EventSystem.Instance.Emit(EEventName.UpgradeComposeLevel);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(synthesisLevelRewardResponse.Code, 21274, null, true, true);
			}, 0);
		}

		// Token: 0x0602D24F RID: 184911 RVA: 0x00C9FF98 File Offset: 0x00C9E198
		public void SendSynthesisFormulaUnlockRequest(int formulaId)
		{
			SynthesisFormulaUnlockRequest synthesisFormulaUnlockRequest = SynthesisFormulaUnlockRequest.Create();
			synthesisFormulaUnlockRequest.Id = formulaId;
			Net.Instance.Call(ERequestMessageId.SynthesisFormulaUnlockRequest, synthesisFormulaUnlockRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				SynthesisFormulaUnlockResponse synthesisFormulaUnlockResponse = (SynthesisFormulaUnlockResponse)msg;
				if (synthesisFormulaUnlockResponse.Code == Aki.Protocol.ErrorCode.Success)
				{
					ComposeModel.Instance.UnlockReagentProductionData(synthesisFormulaUnlockResponse.Id);
					ComposeModel.Instance.UnlockStructureData(synthesisFormulaUnlockResponse.Id);
					SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(formulaId);
					string localText = ComposeConfig.Instance.GetLocalText(synthesisFormulaById.Value.Name);
					GenericPromptController.Instance.ShowPromptByCode("ComposeStudy", new object[]
					{
						localText
					});
					EventSystem.Instance.Emit(EEventName.UpdateComposeFormula);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(synthesisFormulaUnlockResponse.Code, 23763, null, true, true);
			}, 0);
		}

		// Token: 0x0602D250 RID: 184912 RVA: 0x00C9FFE4 File Offset: 0x00C9E1E4
		public bool CheckIsBuff(int roleId, int itemId)
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(itemId);
			for (int i = 0; i < synthesisFormulaById.Value.RoleListLength; i++)
			{
				if (synthesisFormulaById.Value.RoleList(i) == roleId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D251 RID: 184913 RVA: 0x00CA0030 File Offset: 0x00C9E230
		public string GetComposeInfoText(int roleId)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			IEnumerable<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
			string result = "";
			foreach (Aki.Config.Skill skill in skillList)
			{
				if (skill.LeftSkillEffect != 0)
				{
					List<string> list = new List<string>();
					for (int i = 0; i < skill.SkillDetailNumLength; i++)
					{
						list.Add(skill.SkillDetailNum(i));
					}
					result = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(skill.SkillDescribe, null), list.ToArray());
				}
			}
			return result;
		}

		// Token: 0x0602D252 RID: 184914 RVA: 0x00CA00F0 File Offset: 0x00C9E2F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetComposeItemList()
		{
			return ComposeModel.Instance.GetComposeItemList();
		}

		// Token: 0x0602D253 RID: 184915 RVA: 0x00CA00FC File Offset: 0x00C9E2FC
		public void SetSelectedComposeLevel(int level)
		{
			ComposeModel.Instance.SelectedComposeLevel = level;
		}

		// Token: 0x0602D254 RID: 184916 RVA: 0x00CA0109 File Offset: 0x00C9E309
		public int GetSelectedComposeLevel()
		{
			return ComposeModel.Instance.SelectedComposeLevel;
		}

		// Token: 0x0602D255 RID: 184917 RVA: 0x00CA0115 File Offset: 0x00C9E315
		[NullableContext(2)]
		public IComposeLevelInfoData GetRewardLevelInfo()
		{
			return ComposeModel.Instance.GetComposeInfo();
		}

		// Token: 0x0602D256 RID: 184918 RVA: 0x00CA0121 File Offset: 0x00C9E321
		public SynthesisLevel? GetComposeLevelByLevel(int level)
		{
			return ComposeModel.Instance.GetComposeLevelByLevel(level);
		}

		// Token: 0x0602D257 RID: 184919 RVA: 0x00CA012E File Offset: 0x00C9E32E
		public int GetSumExpByLevel(int level)
		{
			return ComposeModel.Instance.GetSumExpByLevel(level);
		}

		// Token: 0x0602D258 RID: 184920 RVA: 0x00CA013B File Offset: 0x00C9E33B
		public int GetDropIdByLevel(int level)
		{
			return ComposeModel.Instance.GetDropIdByLevel(level);
		}

		// Token: 0x0602D259 RID: 184921 RVA: 0x00CA0148 File Offset: 0x00C9E348
		public int GetComposeMaxLevel()
		{
			return ComposeModel.Instance.GetComposeMaxLevel();
		}

		// Token: 0x0602D25A RID: 184922 RVA: 0x00CA0154 File Offset: 0x00C9E354
		public bool CheckCanReagentProduction(int id)
		{
			return ComposeModel.Instance.CheckCanReagentProduction(id);
		}

		// Token: 0x0602D25B RID: 184923 RVA: 0x00CA0161 File Offset: 0x00C9E361
		public bool CheckCanPurification(int id)
		{
			return ComposeModel.Instance.CheckCanPurification(id);
		}

		// Token: 0x0602D25C RID: 184924 RVA: 0x00CA016E File Offset: 0x00C9E36E
		public bool CheckCanCollect(int id)
		{
			return ComposeModel.Instance.CheckCanCollect(id);
		}

		// Token: 0x0602D25D RID: 184925 RVA: 0x00CA017B File Offset: 0x00C9E37B
		public bool CheckCanExchange(int id)
		{
			return ComposeModel.Instance.CheckCanExchange(id);
		}

		// Token: 0x0602D25E RID: 184926 RVA: 0x00CA0188 File Offset: 0x00C9E388
		public bool CheckCanStructure(int id)
		{
			return ComposeModel.Instance.CheckCanStructure(id);
		}

		// Token: 0x0602D25F RID: 184927 RVA: 0x00CA0198 File Offset: 0x00C9E398
		public bool CheckIsBuffEx(int roleId, int itemId)
		{
			int[] array = ComposeConfig.Instance.GetSynthesisFormulaById(itemId).Value.RoleList();
			int[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == roleId)
				{
					return false;
				}
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

		// Token: 0x0602D260 RID: 184928 RVA: 0x00CA0238 File Offset: 0x00C9E438
		public string GetComposeText(int itemId)
		{
			return ComposeModel.Instance.GetComposeText(itemId);
		}

		// Token: 0x0602D261 RID: 184929 RVA: 0x00CA0245 File Offset: 0x00C9E445
		public int GetComposeId(int itemId)
		{
			return ComposeModel.Instance.GetComposeId(itemId);
		}

		// Token: 0x0602D262 RID: 184930 RVA: 0x00CA0252 File Offset: 0x00C9E452
		public bool CheckShowRoleView()
		{
			return true;
		}

		// Token: 0x0602D263 RID: 184931 RVA: 0x00CA0258 File Offset: 0x00C9E458
		[NullableContext(2)]
		public int GetMaxCreateCount(int configId, IBaseItemData itemData = null)
		{
			if (ComposeModel.Instance.IsInPurificationList())
			{
				return ComposeModel.Instance.GetMaxCreateCountPurification(configId, itemData);
			}
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(configId);
			List<OneItemConfig> list = new List<OneItemConfig>(synthesisFormulaById.Value.ConsumeItemsLength);
			for (int i = 0; i < synthesisFormulaById.Value.ConsumeItemsLength; i++)
			{
				list.Add(synthesisFormulaById.Value.ConsumeItems(i).Value);
			}
			int num = this.DoGetMaxCreateCount(list, synthesisFormulaById.Value.LimitCount);
			if (itemData == null)
			{
				return num;
			}
			if (itemData.TotalMakeCountInLimitTime <= 0)
			{
				return num;
			}
			int val = itemData.TotalMakeCountInLimitTime - itemData.MadeCountInLimitTime;
			return Math.Min(num, val);
		}

		// Token: 0x0602D264 RID: 184932 RVA: 0x00CA0320 File Offset: 0x00C9E520
		private int DoGetMaxCreateCount(IList<OneItemConfig> itemMap, int limitCount)
		{
			int num = 0;
			if (limitCount != 0)
			{
				num = limitCount;
			}
			else
			{
				num = ConfigCommonParamById.GetIntConfig("max_cooking_count").Value;
			}
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

		// Token: 0x0602D265 RID: 184933 RVA: 0x00CA03BC File Offset: 0x00C9E5BC
		public UniTask SendManufacture(int configId, int count)
		{
			ComposeController.<SendManufacture>d__58 <SendManufacture>d__;
			<SendManufacture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendManufacture>d__.<>4__this = this;
			<SendManufacture>d__.configId = configId;
			<SendManufacture>d__.count = count;
			<SendManufacture>d__.<>1__state = -1;
			<SendManufacture>d__.<>t__builder.Start<ComposeController.<SendManufacture>d__58>(ref <SendManufacture>d__);
			return <SendManufacture>d__.<>t__builder.Task;
		}

		// Token: 0x0602D266 RID: 184934 RVA: 0x00CA0410 File Offset: 0x00C9E610
		[NullableContext(2)]
		public UniTask SendExchangeRequest(int targetId, int consumeItemId, int consumeCount, Action successCallback = null)
		{
			ComposeController.<SendExchangeRequest>d__59 <SendExchangeRequest>d__;
			<SendExchangeRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendExchangeRequest>d__.<>4__this = this;
			<SendExchangeRequest>d__.targetId = targetId;
			<SendExchangeRequest>d__.consumeItemId = consumeItemId;
			<SendExchangeRequest>d__.consumeCount = consumeCount;
			<SendExchangeRequest>d__.successCallback = successCallback;
			<SendExchangeRequest>d__.<>1__state = -1;
			<SendExchangeRequest>d__.<>t__builder.Start<ComposeController.<SendExchangeRequest>d__59>(ref <SendExchangeRequest>d__);
			return <SendExchangeRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602D267 RID: 184935 RVA: 0x00CA0474 File Offset: 0x00C9E674
		public int GetCurrentRoleId()
		{
			return ComposeModel.Instance.CurrentComposeRoleId;
		}

		// Token: 0x0602D268 RID: 184936 RVA: 0x00CA0480 File Offset: 0x00C9E680
		public void SetCurrentRoleId(int roleId)
		{
			ComposeModel.Instance.CurrentComposeRoleId = roleId;
		}

		// Token: 0x0602D269 RID: 184937 RVA: 0x00CA048D File Offset: 0x00C9E68D
		public List<ISingleItemInfo> GetManufactureMaterialList(int itemId)
		{
			return ComposeModel.Instance.GetComposeMaterialList(itemId);
		}

		// Token: 0x0602D26A RID: 184938 RVA: 0x00CA049A File Offset: 0x00C9E69A
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			return ComposeModel.Instance.GetHelpRoleItemDataList(itemId);
		}

		// Token: 0x0602D26B RID: 184939 RVA: 0x00CA04A8 File Offset: 0x00C9E6A8
		public int GetComposeRoleId(int itemId)
		{
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				return ComposeModel.Instance.GetReagentProductionRoleId(itemId);
			case EComposeListType.Structure:
				return ComposeModel.Instance.GetStructureRoleId(itemId);
			case EComposeListType.Purification:
				return ComposeModel.Instance.GetPurificationRoleId(itemId);
			case EComposeListType.Collect:
				return ComposeModel.Instance.GetCollectRoleId(itemId);
			}
			return 0;
		}

		// Token: 0x0602D26C RID: 184940 RVA: 0x00CA050F File Offset: 0x00C9E70F
		public bool CheckCanShowExpItem()
		{
			return ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction;
		}

		// Token: 0x0602D26D RID: 184941 RVA: 0x00CA0524 File Offset: 0x00C9E724
		public bool CheckCanGetComposeLevel()
		{
			IComposeLevelInfoData composeInfo = ComposeModel.Instance.GetComposeInfo();
			if (composeInfo.ComposeLevel != ComposeModel.Instance.GetComposeMaxLevel())
			{
				int sumExpByLevel = ComposeModel.Instance.GetSumExpByLevel(composeInfo.ComposeLevel);
				if (composeInfo.TotalProficiency >= sumExpByLevel)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D26E RID: 184942 RVA: 0x00CA056C File Offset: 0x00C9E76C
		[NullableContext(2)]
		public void PlayCompositeEnterDisplay(Action onFinished = null)
		{
			this.ClearCompositeDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			PlayFlow composeEnterFlow = ComposeModel.Instance.ComposeEnterFlow;
			this.PlayCompositeFlow(composeEnterFlow);
			this.PlayCompositeAudio("play_ui_fx_spl_gen_page_open", null);
			global::Log.Instance.Info(ELogModule.Test, ELogAuthor.WZ, "[CompositeDisplay]播放进入合成表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			int value = GameplayTagDefine.EGameplayTagId["关卡.场景交互物.进入"];
			currentEntityTagComponent.AddTag(new int?(value));
			this.OnEnterDisplayFinished = onFinished;
			this.CompositeDisplayTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (this.OnEnterDisplayFinished != null)
				{
					this.OnEnterDisplayFinished();
				}
			}, 3000f, null, null, true, 1f);
		}

		// Token: 0x0602D26F RID: 184943 RVA: 0x00CA0610 File Offset: 0x00C9E810
		public void PlayCompositeLoopDisplay()
		{
			this.ClearCompositeDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			global::Log.Instance.Info(ELogModule.Test, ELogAuthor.WZ, "[CompositeDisplay]播放合成循环表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			currentEntityTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.循环"]));
		}

		// Token: 0x0602D270 RID: 184944 RVA: 0x00CA0664 File Offset: 0x00C9E864
		[NullableContext(2)]
		public bool PlayCompositeWorkingDisplay(Action onFinished = null)
		{
			this.ClearCompositeDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return false;
			}
			EventSystem.Instance.Emit(EEventName.OnBeginPlayCompositeWorkingDisplay);
			global::Log.Instance.Info(ELogModule.Test, ELogAuthor.WZ, "[CompositeDisplay]播放合成工作中表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			int value = GameplayTagDefine.EGameplayTagId["关卡.场景交互物.工作中"];
			currentEntityTagComponent.AddTag(new int?(value));
			this.OnWorkingDisplayFinished = onFinished;
			this.CompositeDisplayTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit(EEventName.OnPlayCompositeWorkingDisplayFinished);
				if (this.OnWorkingDisplayFinished != null)
				{
					this.OnWorkingDisplayFinished();
				}
			}, 2000f, null, null, true, 1f);
			return true;
		}

		// Token: 0x0602D271 RID: 184945 RVA: 0x00CA06FC File Offset: 0x00C9E8FC
		[NullableContext(2)]
		public unsafe void PlayCompositeFlow(PlayFlow playFlow)
		{
			if (playFlow != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "[PlayCompositeFlow]播放D级剧情";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", playFlow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StateId", playFlow.StateId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", playFlow.FlowId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				UiParam uiParam = new UiParam
				{
					ViewName = new EUiViewName?(EUiViewName.ComposeCarryOnView),
					Position = new EPlotLowLevelPosition?(EPlotLowLevelPosition.Center),
					TextWidth = new EPlotTextWidthType?(EPlotTextWidthType.Short)
				};
				FlowController.Instance.StartFlowForView(playFlow.FlowListName, playFlow.StateId, playFlow.FlowId, uiParam, true);
			}
		}

		// Token: 0x0602D272 RID: 184946 RVA: 0x00CA07E4 File Offset: 0x00C9E9E4
		private void PlayCompositeAudio(string audioId, [Nullable(2)] PlayResult result = null)
		{
			Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
			if (audioPath == null)
			{
				return;
			}
			AudioController.Instance.PostEventByUi(audioPath.Value.Path, result, null, null);
		}

		// Token: 0x0602D273 RID: 184947 RVA: 0x00CA082B File Offset: 0x00C9EA2B
		public void PlayLeaveCompositeAudio()
		{
			this.PlayCompositeAudio("play_ui_fx_spl_gen_page_close", null);
		}

		// Token: 0x0602D274 RID: 184948 RVA: 0x00CA083C File Offset: 0x00C9EA3C
		[NullableContext(2)]
		public void PlayCompositeFailDisplay(Action onFinished = null)
		{
			this.ClearCompositeDisplay();
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			PlayFlow composeFailFlow = ComposeModel.Instance.ComposeFailFlow;
			this.PlayCompositeFlow(composeFailFlow);
			global::Log.Instance.Info(ELogModule.Test, ELogAuthor.WZ, "[CompositeDisplay]播放合成失败表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			int value = GameplayTagDefine.EGameplayTagId["关卡.场景交互物.失败"];
			currentEntityTagComponent.AddTag(new int?(value));
			this.OnFailDisplayFinished = onFinished;
			this.CompositeDisplayTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (this.OnFailDisplayFinished != null)
				{
					this.OnFailDisplayFinished();
				}
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0602D275 RID: 184949 RVA: 0x00CA08D4 File Offset: 0x00C9EAD4
		public void ClearCompositeDisplay()
		{
			LevelTagComponent currentEntityTagComponent = this.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent != null)
			{
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.失败"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.工作中"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.循环"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.进入"]));
				global::Log.Instance.Info(ELogModule.Test, ELogAuthor.WZ, "[CompositeDisplay]清理所有GameplayTag", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.OnEnterDisplayFinished = null;
			this.OnWorkingDisplayFinished = null;
			this.OnFailDisplayFinished = null;
			if (this.CompositeDisplayTimerId != null && TimerSystem.Instance.Has(this.CompositeDisplayTimerId))
			{
				TimerSystem.Instance.Remove(this.CompositeDisplayTimerId);
				this.CompositeDisplayTimerId = null;
			}
		}

		// Token: 0x0602D276 RID: 184950 RVA: 0x00CA09C0 File Offset: 0x00C9EBC0
		[NullableContext(2)]
		private LevelTagComponent GetCurrentEntityTagComponent()
		{
			if (this.CurrentInteractionEntityId == null)
			{
				return null;
			}
			Entity entity = EntitySystem.Instance.Get(this.CurrentInteractionEntityId.Value);
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<LevelTagComponent>();
		}

		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x0602D277 RID: 184951 RVA: 0x00CA09FD File Offset: 0x00C9EBFD
		public static ComposeController Instance
		{
			get
			{
				return ComposeController._Instance;
			}
		}

		// Token: 0x0602D278 RID: 184952 RVA: 0x00CA0A04 File Offset: 0x00C9EC04
		public static ComposeController GetOrCreateInstance()
		{
			if (ComposeController._Instance == null)
			{
				ComposeController.CreateInstance();
			}
			return ComposeController._Instance;
		}

		// Token: 0x0602D279 RID: 184953 RVA: 0x00CA0A18 File Offset: 0x00C9EC18
		public static bool CreateInstance()
		{
			if (ComposeController._Instance != null)
			{
				return true;
			}
			ComposeController._Instance = new ComposeController();
			return true;
		}

		// Token: 0x0602D27A RID: 184954 RVA: 0x00CA0A2E File Offset: 0x00C9EC2E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D27B RID: 184955 RVA: 0x00CA0A30 File Offset: 0x00C9EC30
		public static void ResetStaticDefaultValue()
		{
			ComposeController._Instance = null;
		}

		// Token: 0x0602D27C RID: 184956 RVA: 0x00CA0A38 File Offset: 0x00C9EC38
		static ComposeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeController.CreateStaticDefaultValue), new Action(ComposeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401837A RID: 99194
		private const string ENTER_AUDIO_ID = "play_ui_fx_spl_gen_page_open";

		// Token: 0x0401837B RID: 99195
		private const string LEAVE_AUDIO_ID = "play_ui_fx_spl_gen_page_close";

		// Token: 0x0401837C RID: 99196
		private const string SUCCESS_AUDIO_ID = "play_ui_fx_spl_gen_robot_success_vo";

		// Token: 0x0401837D RID: 99197
		[Nullable(2)]
		private TimerHandle CompositeDisplayTimerId;

		// Token: 0x0401837E RID: 99198
		[Nullable(2)]
		private Action OnEnterDisplayFinished;

		// Token: 0x0401837F RID: 99199
		[Nullable(2)]
		private Action OnWorkingDisplayFinished;

		// Token: 0x04018380 RID: 99200
		[Nullable(2)]
		private Action OnFailDisplayFinished;

		// Token: 0x04018381 RID: 99201
		private int? CurrentInteractionEntityId;

		// Token: 0x04018382 RID: 99202
		private bool SendRewardFlag;

		// Token: 0x04018383 RID: 99203
		[Nullable(2)]
		private static ComposeController _Instance;

		// Token: 0x0200A23D RID: 41533
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403254D RID: 206157
			[Nullable(0)]
			public static Action<int> <0>__UpdateHelpRoleItemDataList;
		}
	}
}
