using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EFD RID: 20221
	public class ActivityInstanceEntranceScoreItem : UiPanelBase
	{
		// Token: 0x06032D18 RID: 208152 RVA: 0x00E44384 File Offset: 0x00E42584
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

		// Token: 0x06032D19 RID: 208153 RVA: 0x00E4444C File Offset: 0x00E4264C
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

		// Token: 0x06032D1A RID: 208154 RVA: 0x00E4452C File Offset: 0x00E4272C
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

		// Token: 0x06032D1B RID: 208155 RVA: 0x00E44558 File Offset: 0x00E42758
		private void OnClickBtnScoreReward()
		{
			Action pointRewardBtnClickCallBack = this.ViewData.GetPointRewardBtnClickCallBack();
			if (pointRewardBtnClickCallBack != null)
			{
				pointRewardBtnClickCallBack();
			}
		}

		// Token: 0x0401AFA4 RID: 110500
		[Nullable(2)]
		private ActivityEntrancePointData ViewData;

		// Token: 0x0200AC58 RID: 44120
		private enum EComponent
		{
			// Token: 0x04035513 RID: 218387
			BtnScoreReward,
			// Token: 0x04035514 RID: 218388
			TxtScore,
			// Token: 0x04035515 RID: 218389
			ScoreRedDot
		}
	}
}
