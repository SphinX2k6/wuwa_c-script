using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE2 RID: 20194
	public class GuQinActivitySubView : ActivitySubViewBase
	{
		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x06032C17 RID: 207895 RVA: 0x00E41447 File Offset: 0x00E3F647
		[Nullable(1)]
		protected new GuQinActivityData ActivityBaseData
		{
			[NullableContext(1)]
			get
			{
				return (GuQinActivityData)this.ActivityBaseData;
			}
		}

		// Token: 0x06032C18 RID: 207896 RVA: 0x00E41454 File Offset: 0x00E3F654
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032C19 RID: 207897 RVA: 0x00E41544 File Offset: 0x00E3F744
		protected override UniTask OnBeforeStartAsync()
		{
			GuQinActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuQinActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032C1A RID: 207898 RVA: 0x00E41588 File Offset: 0x00E3F788
		protected override void OnRefreshView()
		{
			this.RefreshCondition();
			bool functionRedDotVisible = this.ActivityBaseData.HasRedDot() || this.ActivityBaseData.GetButtonRedPointShowState();
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.SetFunctionRedDotVisible(functionRedDotVisible);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(this.ActivityBaseData.HasNewQuestRedDot());
			}
			bool uiactive = this.ActivityBaseData.IsUnLock();
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			ValueTuple<int, int> progress = this.ActivityBaseData.GetProgress();
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(progress.Item1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(progress.Item2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			this.RefreshRecommendQuestTips();
		}

		// Token: 0x06032C1B RID: 207899 RVA: 0x00E41660 File Offset: 0x00E3F860
		private void RefreshCondition()
		{
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
			};
			functional.RefreshGeneralPerformance(parameters);
		}

		// Token: 0x06032C1C RID: 207900 RVA: 0x00E416A1 File Offset: 0x00E3F8A1
		private void OnConfirmBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.GuQinActivityMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x06032C1D RID: 207901 RVA: 0x00E416C0 File Offset: 0x00E3F8C0
		private void RefreshRecommendQuestTips()
		{
			bool flag = !this.ActivityBaseData.IsRecommendQuestFinished();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				string recommendQuestLabel = this.ActivityBaseData.GetGuQinActivityParamConfig().RecommendQuestLabel;
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(recommendQuestLabel, Array.Empty<string>());
			}
		}

		// Token: 0x06032C1E RID: 207902 RVA: 0x00E41710 File Offset: 0x00E3F910
		private void OnRecommendBtnClick()
		{
			int? recommendQuestLinkId = this.ActivityBaseData.GetRecommendQuestLinkId();
			if (recommendQuestLinkId == null || QuestNewModel.Instance.GetQuest(recommendQuestLinkId.Value) == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("GuQinActivity_QuestNotAcceptedTips", Array.Empty<object>());
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, recommendQuestLinkId, null);
		}

		// Token: 0x06032C1F RID: 207903 RVA: 0x00E4176F File Offset: 0x00E3F96F
		private void ExtraButtonFunction()
		{
			if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EGuQinActivityCheckSaveFlag.PreOpen, 0))
			{
				this.OnRefreshView();
			}
		}

		// Token: 0x0401AF4C RID: 110412
		[Nullable(2)]
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401AF4D RID: 110413
		[Nullable(2)]
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200AC3B RID: 44091
		private class EComponent
		{
			// Token: 0x040354A8 RID: 218280
			public const int UiItemComActivityInfo = 0;

			// Token: 0x040354A9 RID: 218281
			public const int PnlProgress = 1;

			// Token: 0x040354AA RID: 218282
			public const int TextProgress = 2;

			// Token: 0x040354AB RID: 218283
			public const int PreOpenTipsItem = 3;

			// Token: 0x040354AC RID: 218284
			public const int PnlUnlockTips = 4;

			// Token: 0x040354AD RID: 218285
			public const int TextUnlockTips = 5;
		}
	}
}
