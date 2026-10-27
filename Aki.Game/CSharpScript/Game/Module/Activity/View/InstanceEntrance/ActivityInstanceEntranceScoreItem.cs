using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F16 RID: 24342
	public class ActivityInstanceEntranceScoreItem : UiPanelBase
	{
		// Token: 0x0603DD7D RID: 253309 RVA: 0x00EF267C File Offset: 0x00EF087C
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

		// Token: 0x0603DD7E RID: 253310 RVA: 0x00EF2744 File Offset: 0x00EF0944
		[NullableContext(2)]
		public void RefreshView(ActivityEntrancePointData data)
		{
			if (this.ViewData != null && this.ViewData.GetRedDotName() != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.ViewData.GetRedDotName().Value, base.GetItem(2), this.ViewData.GetRedDotId());
			}
			this.ViewData = data;
			if (this.ViewData != null && this.ViewData.GetRedDotName() != null)
			{
				RedDotController.Instance.BindRedDot(this.ViewData.GetRedDotName().Value, base.GetItem(2), null, this.ViewData.GetRedDotId());
			}
			IActivityRewardViewData rewardData = data.GetRewardData();
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(rewardData != null);
			}
			this.RefreshScore();
		}

		// Token: 0x0603DD7F RID: 253311 RVA: 0x00EF2824 File Offset: 0x00EF0A24
		private void RefreshScore()
		{
			string scoreDesc = this.ViewData.GetScoreDesc();
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(scoreDesc, true);
		}

		// Token: 0x0603DD80 RID: 253312 RVA: 0x00EF2850 File Offset: 0x00EF0A50
		private void OnClickBtnScoreReward()
		{
			Action pointRewardBtnClickCallBack = this.ViewData.GetPointRewardBtnClickCallBack();
			if (pointRewardBtnClickCallBack != null)
			{
				pointRewardBtnClickCallBack();
			}
		}

		// Token: 0x040204D2 RID: 132306
		[Nullable(2)]
		private ActivityEntrancePointData ViewData;

		// Token: 0x0200C24B RID: 49739
		private enum EComponent
		{
			// Token: 0x0403AB21 RID: 240417
			BtnScoreReward,
			// Token: 0x0403AB22 RID: 240418
			TxtScore,
			// Token: 0x0403AB23 RID: 240419
			ScoreRedDot
		}
	}
}
