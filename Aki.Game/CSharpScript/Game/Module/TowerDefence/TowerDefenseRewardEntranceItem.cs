using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B54 RID: 19284
	public class TowerDefenseRewardEntranceItem : UiPanelBase
	{
		// Token: 0x06031EFD RID: 204541 RVA: 0x00B96734 File Offset: 0x00B94934
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031EFE RID: 204542 RVA: 0x00B96840 File Offset: 0x00B94A40
		public void RefreshItem()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(TowerDefenseController.Instance.CheckHasReward());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "TowerDefence_PintDesc", Array.Empty<object>());
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(TowerDefenseController.Instance.BuildTotalScoreContent(), true);
			}
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount((float)TowerDefenseController.Instance.GetTotalScoreProgress());
		}

		// Token: 0x06031EFF RID: 204543 RVA: 0x00B968BD File Offset: 0x00B94ABD
		private void OnClickBtnReward()
		{
			TowerDefenseController.Instance.HandleOnClickReward();
		}

		// Token: 0x0200ACD8 RID: 44248
		private class ERewardEntranceComponent
		{
			// Token: 0x0403484B RID: 215115
			public const int RewardBtn = 0;

			// Token: 0x0403484C RID: 215116
			public const int ProgressSpr = 1;

			// Token: 0x0403484D RID: 215117
			public const int TitleTxt = 2;

			// Token: 0x0403484E RID: 215118
			public const int ProgressTxt = 3;

			// Token: 0x0403484F RID: 215119
			public const int RedDotItem = 4;
		}
	}
}
