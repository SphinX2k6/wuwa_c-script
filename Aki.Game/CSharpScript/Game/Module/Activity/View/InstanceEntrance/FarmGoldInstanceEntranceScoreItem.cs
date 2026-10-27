using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F04 RID: 24324
	public class FarmGoldInstanceEntranceScoreItem : UiPanelBase
	{
		// Token: 0x0603DCF2 RID: 253170 RVA: 0x00EF0FF4 File Offset: 0x00EEF1F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnScoreReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DCF3 RID: 253171 RVA: 0x00EF10BB File Offset: 0x00EEF2BB
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.FarmGoldReward, base.GetItem(2), null, this.ActivityData.Id);
		}

		// Token: 0x0603DCF4 RID: 253172 RVA: 0x00EF10DF File Offset: 0x00EEF2DF
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FarmGoldReward, base.GetItem(2), 0);
		}

		// Token: 0x0603DCF5 RID: 253173 RVA: 0x00EF10F8 File Offset: 0x00EEF2F8
		[NullableContext(1)]
		public void SetActivityData(FarmGoldData data)
		{
			this.ActivityData = data;
		}

		// Token: 0x0603DCF6 RID: 253174 RVA: 0x00EF1104 File Offset: 0x00EEF304
		public void RefreshView()
		{
			IActivityRewardViewData rewardViewData = this.ActivityData.GetRewardViewData();
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(rewardViewData != null);
			}
			this.RefreshScore();
		}

		// Token: 0x0603DCF7 RID: 253175 RVA: 0x00EF1148 File Offset: 0x00EEF348
		private void RefreshScore()
		{
			string scoreDesc = this.ActivityData.GetScoreDesc();
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(scoreDesc, true);
		}

		// Token: 0x0603DCF8 RID: 253176 RVA: 0x00EF1174 File Offset: 0x00EEF374
		private void OnClickBtnScoreReward()
		{
			if (this.ActivityData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, this.ActivityData.GetRewardPopUpViewData(), delegate(bool success, int viewId)
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.FarmGoldInstanceEntranceView);
				if (viewByName == null)
				{
					return;
				}
				viewByName.AddChildViewById(viewId);
			});
		}

		// Token: 0x04020492 RID: 132242
		[Nullable(2)]
		private FarmGoldData ActivityData;

		// Token: 0x0200C23A RID: 49722
		private enum EComponent
		{
			// Token: 0x0403AAE9 RID: 240361
			BtnScoreReward,
			// Token: 0x0403AAEA RID: 240362
			TxtScore,
			// Token: 0x0403AAEB RID: 240363
			ScoreRedDot
		}
	}
}
