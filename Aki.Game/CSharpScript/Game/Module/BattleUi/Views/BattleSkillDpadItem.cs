using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE2 RID: 23778
	public class BattleSkillDpadItem : UiPanelBase
	{
		// Token: 0x0603C2B7 RID: 246455 RVA: 0x00E6780C File Offset: 0x00E65A0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C2B8 RID: 246456 RVA: 0x00E678D8 File Offset: 0x00E65AD8
		protected override void OnStart()
		{
			this.ItemList.Add(base.GetItem(1));
			this.ItemList.Add(base.GetItem(2));
			this.ItemList.Add(base.GetItem(3));
			this.ItemList.Add(base.GetItem(4));
			for (int i = 0; i < 4; i++)
			{
				this.EnableList.Add(true);
			}
		}

		// Token: 0x0603C2B9 RID: 246457 RVA: 0x00E67945 File Offset: 0x00E65B45
		public void SetVisible(bool bVisible)
		{
			if (bVisible)
			{
				if (!base.IsShowOrShowing)
				{
					base.Show(null);
					return;
				}
			}
			else if (base.IsShowOrShowing)
			{
				base.Hide(null);
			}
		}

		// Token: 0x0603C2BA RID: 246458 RVA: 0x00E67969 File Offset: 0x00E65B69
		public void SetArrowVisible(int index, bool visible)
		{
			this.ItemList[index].SetUIActive(visible);
		}

		// Token: 0x0603C2BB RID: 246459 RVA: 0x00E6797D File Offset: 0x00E65B7D
		public void SetBgVisible(bool visible)
		{
			base.GetItem(0).SetUIActive(visible);
		}

		// Token: 0x0603C2BC RID: 246460 RVA: 0x00E6798C File Offset: 0x00E65B8C
		public void SetArrowEnable(int index, bool bEnable, bool bForce = false)
		{
			if (this.EnableList[index] == bEnable && !bForce)
			{
				return;
			}
			if (bEnable)
			{
				this.ItemList[index].SetAlpha(1f);
			}
			else
			{
				this.ItemList[index].SetAlpha(0.2f);
			}
			this.EnableList[index] = bEnable;
		}

		// Token: 0x0401F5E4 RID: 128484
		[Nullable(1)]
		private readonly List<UUIItem> ItemList = new List<UUIItem>();

		// Token: 0x0401F5E5 RID: 128485
		[Nullable(1)]
		private readonly List<bool> EnableList = new List<bool>();

		// Token: 0x0200BF3E RID: 48958
		private enum EChildType
		{
			// Token: 0x04039AF2 RID: 236274
			BgItem,
			// Token: 0x04039AF3 RID: 236275
			UpItem,
			// Token: 0x04039AF4 RID: 236276
			LeftItem,
			// Token: 0x04039AF5 RID: 236277
			DownItem,
			// Token: 0x04039AF6 RID: 236278
			RightItem
		}
	}
}
