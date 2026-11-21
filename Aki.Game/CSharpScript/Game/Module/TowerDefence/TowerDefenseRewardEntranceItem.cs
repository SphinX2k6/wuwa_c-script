using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AFC RID: 15100
	public class TowerDefenseRewardEntranceItem : UiPanelBase
	{
		// Token: 0x06026C8C RID: 158860 RVA: 0x00ADA970 File Offset: 0x00AD8B70
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

		// Token: 0x06026C8D RID: 158861 RVA: 0x00ADAA7C File Offset: 0x00AD8C7C
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

		// Token: 0x06026C8E RID: 158862 RVA: 0x00ADAAF9 File Offset: 0x00AD8CF9
		private void OnClickBtnReward()
		{
			TowerDefenseController.Instance.HandleOnClickReward();
		}

		// Token: 0x020096F7 RID: 38647
		private class ERewardEntranceComponent
		{
			// Token: 0x0402F1F4 RID: 193012
			public const int RewardBtn = 0;

			// Token: 0x0402F1F5 RID: 193013
			public const int ProgressSpr = 1;

			// Token: 0x0402F1F6 RID: 193014
			public const int TitleTxt = 2;

			// Token: 0x0402F1F7 RID: 193015
			public const int ProgressTxt = 3;

			// Token: 0x0402F1F8 RID: 193016
			public const int RedDotItem = 4;
		}
	}
}
