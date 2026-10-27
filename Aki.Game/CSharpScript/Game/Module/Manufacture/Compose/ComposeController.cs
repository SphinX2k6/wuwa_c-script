using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005655 RID: 22101
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeController : UiControllerBase
	{
		// Token: 0x17008740 RID: 34624
		// (get) Token: 0x06038337 RID: 230199 RVA: 0x00D5179C File Offset: 0x00D4F99C
		public int ComposeCoinId
		{
			get
			{
				return ConfigCommonParamById.GetIntConfig("ComposeCost").GetValueOrDefault(-1);
			}
		}

		// Token: 0x06038338 RID: 230200 RVA: 0x00D517BC File Offset: 0x00D4F9BC
		protected override bool OnClear()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x06038339 RID: 230201 RVA: 0x00D517C5 File Offset: 0x00D4F9C5
		protected override bool OnLeaveLevel()
		{
			this.ClearCurrentInteractionEntityDisplay();
			return true;
		}

		// Token: 0x0603833A RID: 230202 RVA: 0x00D517D0 File Offset: 0x00D4F9D0
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

		// Token: 0x0603833B RID: 230203 RVA: 0x00D51878 File Offset: 0x00D4FA78
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

		// Token: 0x0603833C RID: 230204 RVA: 0x00D5191D File Offset: 0x00D4FB1D
		private void LoadNewList()
		{
			ComposeModel.Instance.CreatePurificationDataList();
		}

		// Token: 0x0603833D RID: 230205 RVA: 0x00D5192C File Offset: 0x00D4FB2C
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

		// Token: 0x0603833E RID: 230206 RVA: 0x00D51980 File Offset: 0x00D4FB80
		private void ShowComposeStudy(int configId, int count)
		{
			ItemInfo? config = ItemConfig.Instance.GetConfig(configId);
			if (!config.Value.ShowTypes().Contains(35) && !config.Value.ShowTypes().Contains(37))
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

		// Token: 0x0603833F RID: 230207 RVA: 0x00D51A1A File Offset: 0x00D4FC1A
		private void OnCloseView(EUiViewName view, int viewId)
		{
			if (view == EUiViewName.ItemTipsView)
			{
				ComposeModel.Instance.ComposeSelectItem = null;
			}
		}

		// Token: 0x06038340 RID: 230208 RVA: 0x00D51A34 File Offset: 0x00D4FC34
		private static void UpdateHelpRoleItemDataList(int i)
		{
			ComposeModel.Instance.UpdateHelpRoleItemDataList();
		}

		// Token: 0x06038341 RID: 230209 RVA: 0x00D51A40 File Offset: 0x00D4FC40
		public void RegisterCurrentInteractionEntity()
		{
			this.CurrentInteractionEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		}

		// Token: 0x06038342 RID: 230210 RVA: 0x00D51A52 File Offset: 0x00D4FC52
		public void ClearCurrentInteractionEntityDisplay()
		{
			if (this.CurrentInteractionEntityId == null)
			{
				return;
			}
			this.ClearCompositeDisplay();
			this.CurrentInteractionEntityId = null;
		}

		// Token: 0x06038343 RID: 230211 RVA: 0x00D51A74 File Offset: 0x00D4FC74
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

		// Token: 0x06038344 RID: 230212 RVA: 0x00D51ADF File Offset: 0x00D4FCDF
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SynthesisInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SynthesisLevelUpdateNotify);
		}

		// Token: 0x06038345 RID: 230213 RVA: 0x00D51B04 File Offset: 0x00D4FD04
		[NullableContext(2)]
		private void HandleSynthesisInfoRequestCore(SynthesisInfoResponse response)
		{
			ComposeModel.Instance.CreateComposeDataList(response.SynthesisInfoList);
			ComposeModel.Instance.UpdateComposeByServerConfig(response.SynthesisConfigs);
			ComposeModel.Instance.CreateComposeLevelInfo(response.LevelInfo);
			ComposeModel.Instance.SaveLimitRefreshTime(response.LimitRefreshTime);
		}

		// Token: 0x06038346 RID: 230214 RVA: 0x00D51B54 File Offset: 0x00D4FD54
		public UniTask SendSynthesisInfoRequestAsync()
		{
			ComposeController.<SendSynthesisInfoRequestAsync>d__24 <SendSynthesisInfoRequestAsync>d__;
			<SendSynthesisInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSynthesisInfoRequestAsync>d__.<>4__this = this;
			<SendSynthesisInfoRequestAsync>d__.<>1__state = -1;
			<SendSynthesisInfoRequestAsync>d__.<>t__builder.Start<ComposeController.<SendSynthesisInfoRequestAsync>d__24>(ref <SendSynthesisInfoRequestAsync>d__);
			return <SendSynthesisInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038347 RID: 230215 RVA: 0x00D51B98 File Offset: 0x00D4FD98
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

		// Token: 0x06038348 RID: 230216 RVA: 0x00D51BEC File Offset: 0x00D4FDEC
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

		// Token: 0x06038349 RID: 230217 RVA: 0x00D51C50 File Offset: 0x00D4FE50
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

		// Token: 0x0603834A RID: 230218 RVA: 0x00D51CAB File Offset: 0x00D4FEAB
		private static string FormatItemInfoList(IEnumerable<SingleItemInfo> list)
		{
			return string.Join(",", list.Select(delegate(SingleItemInfo item)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(item.ItemId);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(item.ItemNum);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}));
		}

		// Token: 0x0603834B RID: 230219 RVA: 0x00D51CDC File Offset: 0x00D4FEDC
		private static string FormatBatchItems(IEnumerable<BatchItem> items)
		{
			return string.Join("|", items.Select(delegate(BatchItem it)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
				defaultInterpolatedStringHandler.AppendFormatted<int>(it.Id);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(it.Count);
				defaultInterpolatedStringHandler.AppendLiteral("{");
				defaultInterpolatedStringHandler.AppendFormatted(ComposeController.FormatItemInfoList(it.CostItems));
				defaultInterpolatedStringHandler.AppendLiteral("}");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}));
		}

		// Token: 0x0603834C RID: 230220 RVA: 0x00D51D10 File Offset: 0x00D4FF10
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

		// Token: 0x0603834D RID: 230221 RVA: 0x00D51DAC File Offset: 0x00D4FFAC
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

		// Token: 0x0603834E RID: 230222 RVA: 0x00D51F70 File Offset: 0x00D50170
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

		// Token: 0x0603834F RID: 230223 RVA: 0x00D51FCC File Offset: 0x00D501CC
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

		// Token: 0x06038350 RID: 230224 RVA: 0x00D52020 File Offset: 0x00D50220
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(synthesisLevelRewardResponse.Code, 26239, null, true, true);
			}, 0);
		}

		// Token: 0x06038351 RID: 230225 RVA: 0x00D52060 File Offset: 0x00D50260
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(synthesisFormulaUnlockResponse.Code, 17641, null, true, true);
			}, 0);
		}

		// Token: 0x06038352 RID: 230226 RVA: 0x00D520AC File Offset: 0x00D502AC
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

		// Token: 0x06038353 RID: 230227 RVA: 0x00D520F8 File Offset: 0x00D502F8
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

		// Token: 0x06038354 RID: 230228 RVA: 0x00D521B8 File Offset: 0x00D503B8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetComposeItemList()
		{
			return ComposeModel.Instance.GetComposeItemList();
		}

		// Token: 0x06038355 RID: 230229 RVA: 0x00D521C4 File Offset: 0x00D503C4
		public void SetSelectedComposeLevel(int level)
		{
			ComposeModel.Instance.SelectedComposeLevel = level;
		}

		// Token: 0x06038356 RID: 230230 RVA: 0x00D521D1 File Offset: 0x00D503D1
		public int GetSelectedComposeLevel()
		{
			return ComposeModel.Instance.SelectedComposeLevel;
		}

		// Token: 0x06038357 RID: 230231 RVA: 0x00D521DD File Offset: 0x00D503DD
		[NullableContext(2)]
		public IComposeLevelInfoData GetRewardLevelInfo()
		{
			return ComposeModel.Instance.GetComposeInfo();
		}

		// Token: 0x06038358 RID: 230232 RVA: 0x00D521E9 File Offset: 0x00D503E9
		public SynthesisLevel? GetComposeLevelByLevel(int level)
		{
			return ComposeModel.Instance.GetComposeLevelByLevel(level);
		}

		// Token: 0x06038359 RID: 230233 RVA: 0x00D521F6 File Offset: 0x00D503F6
		public int GetSumExpByLevel(int level)
		{
			return ComposeModel.Instance.GetSumExpByLevel(level);
		}

		// Token: 0x0603835A RID: 230234 RVA: 0x00D52203 File Offset: 0x00D50403
		public int GetDropIdByLevel(int level)
		{
			return ComposeModel.Instance.GetDropIdByLevel(level);
		}

		// Token: 0x0603835B RID: 230235 RVA: 0x00D52210 File Offset: 0x00D50410
		public int GetComposeMaxLevel()
		{
			return ComposeModel.Instance.GetComposeMaxLevel();
		}

		// Token: 0x0603835C RID: 230236 RVA: 0x00D5221C File Offset: 0x00D5041C
		public bool CheckCanReagentProduction(int id)
		{
			return ComposeModel.Instance.CheckCanReagentProduction(id);
		}

		// Token: 0x0603835D RID: 230237 RVA: 0x00D52229 File Offset: 0x00D50429
		public bool CheckCanPurification(int id)
		{
			return ComposeModel.Instance.CheckCanPurification(id);
		}

		// Token: 0x0603835E RID: 230238 RVA: 0x00D52236 File Offset: 0x00D50436
		public bool CheckCanCollect(int id)
		{
			return ComposeModel.Instance.CheckCanCollect(id);
		}

		// Token: 0x0603835F RID: 230239 RVA: 0x00D52243 File Offset: 0x00D50443
		public bool CheckCanExchange(int id)
		{
			return ComposeModel.Instance.CheckCanExchange(id);
		}

		// Token: 0x06038360 RID: 230240 RVA: 0x00D52250 File Offset: 0x00D50450
		public bool CheckCanStructure(int id)
		{
			return ComposeModel.Instance.CheckCanStructure(id);
		}

		// Token: 0x06038361 RID: 230241 RVA: 0x00D52260 File Offset: 0x00D50460
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
			foreach (int value in RoleModel.Instance.GetRoleIdList())
			{
				if (array.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038362 RID: 230242 RVA: 0x00D52300 File Offset: 0x00D50500
		public string GetComposeText(int itemId)
		{
			return ComposeModel.Instance.GetComposeText(itemId);
		}

		// Token: 0x06038363 RID: 230243 RVA: 0x00D5230D File Offset: 0x00D5050D
		public int GetComposeId(int itemId)
		{
			return ComposeModel.Instance.GetComposeId(itemId);
		}

		// Token: 0x06038364 RID: 230244 RVA: 0x00D5231A File Offset: 0x00D5051A
		public bool CheckShowRoleView()
		{
			return true;
		}

		// Token: 0x06038365 RID: 230245 RVA: 0x00D52320 File Offset: 0x00D50520
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

		// Token: 0x06038366 RID: 230246 RVA: 0x00D523E8 File Offset: 0x00D505E8
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

		// Token: 0x06038367 RID: 230247 RVA: 0x00D52484 File Offset: 0x00D50684
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

		// Token: 0x06038368 RID: 230248 RVA: 0x00D524D8 File Offset: 0x00D506D8
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

		// Token: 0x06038369 RID: 230249 RVA: 0x00D5253C File Offset: 0x00D5073C
		public int GetCurrentRoleId()
		{
			return ComposeModel.Instance.CurrentComposeRoleId;
		}

		// Token: 0x0603836A RID: 230250 RVA: 0x00D52548 File Offset: 0x00D50748
		public void SetCurrentRoleId(int roleId)
		{
			ComposeModel.Instance.CurrentComposeRoleId = roleId;
		}

		// Token: 0x0603836B RID: 230251 RVA: 0x00D52555 File Offset: 0x00D50755
		public List<ISingleItemInfo> GetManufactureMaterialList(int itemId)
		{
			return ComposeModel.Instance.GetComposeMaterialList(itemId);
		}

		// Token: 0x0603836C RID: 230252 RVA: 0x00D52562 File Offset: 0x00D50762
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			return ComposeModel.Instance.GetHelpRoleItemDataList(itemId);
		}

		// Token: 0x0603836D RID: 230253 RVA: 0x00D52570 File Offset: 0x00D50770
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

		// Token: 0x0603836E RID: 230254 RVA: 0x00D525D7 File Offset: 0x00D507D7
		public bool CheckCanShowExpItem()
		{
			return ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction;
		}

		// Token: 0x0603836F RID: 230255 RVA: 0x00D525EC File Offset: 0x00D507EC
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

		// Token: 0x06038370 RID: 230256 RVA: 0x00D52634 File Offset: 0x00D50834
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

		// Token: 0x06038371 RID: 230257 RVA: 0x00D526D8 File Offset: 0x00D508D8
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

		// Token: 0x06038372 RID: 230258 RVA: 0x00D5272C File Offset: 0x00D5092C
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

		// Token: 0x06038373 RID: 230259 RVA: 0x00D527C4 File Offset: 0x00D509C4
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

		// Token: 0x06038374 RID: 230260 RVA: 0x00D528AC File Offset: 0x00D50AAC
		private void PlayCompositeAudio(string audioId, [Nullable(2)] PlayResult result = null)
		{
			Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
			if (audioPath == null)
			{
				return;
			}
			AudioController.Instance.PostEventByUi(audioPath.Value.Path, result, null, null);
		}

		// Token: 0x06038375 RID: 230261 RVA: 0x00D528F3 File Offset: 0x00D50AF3
		public void PlayLeaveCompositeAudio()
		{
			this.PlayCompositeAudio("play_ui_fx_spl_gen_page_close", null);
		}

		// Token: 0x06038376 RID: 230262 RVA: 0x00D52904 File Offset: 0x00D50B04
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

		// Token: 0x06038377 RID: 230263 RVA: 0x00D5299C File Offset: 0x00D50B9C
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

		// Token: 0x06038378 RID: 230264 RVA: 0x00D52A88 File Offset: 0x00D50C88
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

		// Token: 0x17008741 RID: 34625
		// (get) Token: 0x06038379 RID: 230265 RVA: 0x00D52AC5 File Offset: 0x00D50CC5
		public static ComposeController Instance
		{
			get
			{
				return ComposeController._Instance;
			}
		}

		// Token: 0x0603837A RID: 230266 RVA: 0x00D52ACC File Offset: 0x00D50CCC
		public static ComposeController GetOrCreateInstance()
		{
			if (ComposeController._Instance == null)
			{
				ComposeController.CreateInstance();
			}
			return ComposeController._Instance;
		}

		// Token: 0x0603837B RID: 230267 RVA: 0x00D52AE0 File Offset: 0x00D50CE0
		public static bool CreateInstance()
		{
			if (ComposeController._Instance != null)
			{
				return true;
			}
			ComposeController._Instance = new ComposeController();
			return true;
		}

		// Token: 0x0603837C RID: 230268 RVA: 0x00D52AF6 File Offset: 0x00D50CF6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603837D RID: 230269 RVA: 0x00D52AF8 File Offset: 0x00D50CF8
		public static void ResetStaticDefaultValue()
		{
			ComposeController._Instance = null;
		}

		// Token: 0x0603837E RID: 230270 RVA: 0x00D52B00 File Offset: 0x00D50D00
		static ComposeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeController.CreateStaticDefaultValue), new Action(ComposeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D8EF RID: 121071
		private const string ENTER_AUDIO_ID = "play_ui_fx_spl_gen_page_open";

		// Token: 0x0401D8F0 RID: 121072
		private const string LEAVE_AUDIO_ID = "play_ui_fx_spl_gen_page_close";

		// Token: 0x0401D8F1 RID: 121073
		private const string SUCCESS_AUDIO_ID = "play_ui_fx_spl_gen_robot_success_vo";

		// Token: 0x0401D8F2 RID: 121074
		[Nullable(2)]
		private TimerHandle CompositeDisplayTimerId;

		// Token: 0x0401D8F3 RID: 121075
		[Nullable(2)]
		private Action OnEnterDisplayFinished;

		// Token: 0x0401D8F4 RID: 121076
		[Nullable(2)]
		private Action OnWorkingDisplayFinished;

		// Token: 0x0401D8F5 RID: 121077
		[Nullable(2)]
		private Action OnFailDisplayFinished;

		// Token: 0x0401D8F6 RID: 121078
		private int? CurrentInteractionEntityId;

		// Token: 0x0401D8F7 RID: 121079
		private bool SendRewardFlag;

		// Token: 0x0401D8F8 RID: 121080
		[Nullable(2)]
		private static ComposeController _Instance;

		// Token: 0x0200B814 RID: 47124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037B29 RID: 228137
			[Nullable(0)]
			public static Action<int> <0>__UpdateHelpRoleItemDataList;
		}
	}
}
