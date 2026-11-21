using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200539F RID: 21407
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightActivitySubView : ActivitySubViewBase
	{
		// Token: 0x170067DB RID: 26587
		// (get) Token: 0x0603540B RID: 218123 RVA: 0x00EDFC77 File Offset: 0x00EDDE77
		protected new MotorFightActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as MotorFightActivityData;
			}
		}

		// Token: 0x0603540C RID: 218124 RVA: 0x00EDFC84 File Offset: 0x00EDDE84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603540D RID: 218125 RVA: 0x00EDFD10 File Offset: 0x00EDDF10
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603540E RID: 218126 RVA: 0x00EDFD54 File Offset: 0x00EDDF54
		protected override void OnRefreshView()
		{
			this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			ButtonItem rewardBtn = this.RewardBtn;
			if (rewardBtn != null)
			{
				rewardBtn.SetRedDotVisible(this.ActivityBaseData.IsTaskHasRedDot());
			}
			ButtonItem rewardBtn2 = this.RewardBtn;
			if (rewardBtn2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActivityBaseData.GetFinishedTaskNum());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActivityBaseData.GetTotalTaskNum());
			rewardBtn2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0603540F RID: 218127 RVA: 0x00EDFDF4 File Offset: 0x00EDDFF4
		[NullableContext(1)]
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("MotorFightMultiTips", Array.Empty<object>());
					return;
				}
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.MotorFightMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x06035410 RID: 218128 RVA: 0x00EDFE12 File Offset: 0x00EDE012
		private void OnRewardBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x0401C15A RID: 115034
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401C15B RID: 115035
		private ButtonItem RewardBtn;

		// Token: 0x0200B035 RID: 45109
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036740 RID: 223040
			public const int CommonActionInfo = 0;

			// Token: 0x04036741 RID: 223041
			public const int ItemRewardBtn = 1;

			// Token: 0x04036742 RID: 223042
			public const int TextureBg = 2;
		}
	}
}
