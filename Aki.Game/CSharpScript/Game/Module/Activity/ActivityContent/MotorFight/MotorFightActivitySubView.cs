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
	// Token: 0x02006421 RID: 25633
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightActivitySubView : ActivitySubViewBase
	{
		// Token: 0x17009479 RID: 38009
		// (get) Token: 0x0604074A RID: 264010 RVA: 0x00F98CD7 File Offset: 0x00F96ED7
		protected new MotorFightActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as MotorFightActivityData;
			}
		}

		// Token: 0x0604074B RID: 264011 RVA: 0x00F98CE4 File Offset: 0x00F96EE4
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

		// Token: 0x0604074C RID: 264012 RVA: 0x00F98D70 File Offset: 0x00F96F70
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604074D RID: 264013 RVA: 0x00F98DB4 File Offset: 0x00F96FB4
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

		// Token: 0x0604074E RID: 264014 RVA: 0x00F98E54 File Offset: 0x00F97054
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

		// Token: 0x0604074F RID: 264015 RVA: 0x00F98E72 File Offset: 0x00F97072
		private void OnRewardBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x0402182B RID: 137259
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0402182C RID: 137260
		private ButtonItem RewardBtn;

		// Token: 0x0200C64E RID: 50766
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BDE3 RID: 245219
			public const int CommonActionInfo = 0;

			// Token: 0x0403BDE4 RID: 245220
			public const int ItemRewardBtn = 1;

			// Token: 0x0403BDE5 RID: 245221
			public const int TextureBg = 2;
		}
	}
}
