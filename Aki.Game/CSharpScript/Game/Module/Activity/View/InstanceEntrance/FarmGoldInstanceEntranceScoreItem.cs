using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EEB RID: 20203
	public class FarmGoldInstanceEntranceScoreItem : UiPanelBase
	{
		// Token: 0x06032C8D RID: 208013 RVA: 0x00E42CFC File Offset: 0x00E40EFC
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

		// Token: 0x06032C8E RID: 208014 RVA: 0x00E42DC3 File Offset: 0x00E40FC3
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.FarmGoldReward, base.GetItem(2), null, this.ActivityData.Id);
		}

		// Token: 0x06032C8F RID: 208015 RVA: 0x00E42DE7 File Offset: 0x00E40FE7
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FarmGoldReward, base.GetItem(2), 0);
		}

		// Token: 0x06032C90 RID: 208016 RVA: 0x00E42E00 File Offset: 0x00E41000
		[NullableContext(1)]
		public void SetActivityData(FarmGoldData data)
		{
			this.ActivityData = data;
		}

		// Token: 0x06032C91 RID: 208017 RVA: 0x00E42E0C File Offset: 0x00E4100C
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

		// Token: 0x06032C92 RID: 208018 RVA: 0x00E42E50 File Offset: 0x00E41050
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

		// Token: 0x06032C93 RID: 208019 RVA: 0x00E42E7C File Offset: 0x00E4107C
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

		// Token: 0x0401AF64 RID: 110436
		[Nullable(2)]
		private FarmGoldData ActivityData;

		// Token: 0x0200AC47 RID: 44103
		private enum EComponent
		{
			// Token: 0x040354DB RID: 218331
			BtnScoreReward,
			// Token: 0x040354DC RID: 218332
			TxtScore,
			// Token: 0x040354DD RID: 218333
			ScoreRedDot
		}
	}
}
