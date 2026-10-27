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
	// Token: 0x02005EFB RID: 24315
	public class GuQinActivitySubView : ActivitySubViewBase
	{
		// Token: 0x17008EED RID: 36589
		// (get) Token: 0x0603DC7C RID: 253052 RVA: 0x00EEF783 File Offset: 0x00EED983
		[Nullable(1)]
		protected new GuQinActivityData ActivityBaseData
		{
			[NullableContext(1)]
			get
			{
				return (GuQinActivityData)this.ActivityBaseData;
			}
		}

		// Token: 0x0603DC7D RID: 253053 RVA: 0x00EEF790 File Offset: 0x00EED990
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

		// Token: 0x0603DC7E RID: 253054 RVA: 0x00EEF880 File Offset: 0x00EEDA80
		protected override UniTask OnBeforeStartAsync()
		{
			GuQinActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuQinActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DC7F RID: 253055 RVA: 0x00EEF8C4 File Offset: 0x00EEDAC4
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

		// Token: 0x0603DC80 RID: 253056 RVA: 0x00EEF99C File Offset: 0x00EEDB9C
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

		// Token: 0x0603DC81 RID: 253057 RVA: 0x00EEF9DD File Offset: 0x00EEDBDD
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

		// Token: 0x0603DC82 RID: 253058 RVA: 0x00EEF9FC File Offset: 0x00EEDBFC
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

		// Token: 0x0603DC83 RID: 253059 RVA: 0x00EEFA4C File Offset: 0x00EEDC4C
		private void OnRecommendBtnClick()
		{
			int? recommendQuestLinkId = this.ActivityBaseData.GetRecommendQuestLinkId();
			if (recommendQuestLinkId == null || QuestNewModel.Instance.GetQuest(recommendQuestLinkId.Value) == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("GuQinActivity_QuestNotAcceptedTips", Array.Empty<object>());
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, recommendQuestLinkId, null);
		}

		// Token: 0x0603DC84 RID: 253060 RVA: 0x00EEFAAB File Offset: 0x00EEDCAB
		private void ExtraButtonFunction()
		{
			if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EGuQinActivityCheckSaveFlag.PreOpen, 0))
			{
				this.OnRefreshView();
			}
		}

		// Token: 0x0402047A RID: 132218
		[Nullable(2)]
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0402047B RID: 132219
		[Nullable(2)]
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200C22D RID: 49709
		private class EComponent
		{
			// Token: 0x0403AAB4 RID: 240308
			public const int UiItemComActivityInfo = 0;

			// Token: 0x0403AAB5 RID: 240309
			public const int PnlProgress = 1;

			// Token: 0x0403AAB6 RID: 240310
			public const int TextProgress = 2;

			// Token: 0x0403AAB7 RID: 240311
			public const int PreOpenTipsItem = 3;

			// Token: 0x0403AAB8 RID: 240312
			public const int PnlUnlockTips = 4;

			// Token: 0x0403AAB9 RID: 240313
			public const int TextUnlockTips = 5;
		}
	}
}
