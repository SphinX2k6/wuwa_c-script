using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC4 RID: 19652
	public class BattleSkillDpadItem : UiPanelBase
	{
		// Token: 0x0603120D RID: 201229 RVA: 0x00DB7DC0 File Offset: 0x00DB5FC0
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

		// Token: 0x0603120E RID: 201230 RVA: 0x00DB7E8C File Offset: 0x00DB608C
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

		// Token: 0x0603120F RID: 201231 RVA: 0x00DB7EF9 File Offset: 0x00DB60F9
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

		// Token: 0x06031210 RID: 201232 RVA: 0x00DB7F1D File Offset: 0x00DB611D
		public void SetArrowVisible(int index, bool visible)
		{
			this.ItemList[index].SetUIActive(visible);
		}

		// Token: 0x06031211 RID: 201233 RVA: 0x00DB7F31 File Offset: 0x00DB6131
		public void SetBgVisible(bool visible)
		{
			base.GetItem(0).SetUIActive(visible);
		}

		// Token: 0x06031212 RID: 201234 RVA: 0x00DB7F40 File Offset: 0x00DB6140
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

		// Token: 0x0401A09D RID: 106653
		[Nullable(1)]
		private readonly List<UUIItem> ItemList = new List<UUIItem>();

		// Token: 0x0401A09E RID: 106654
		[Nullable(1)]
		private readonly List<bool> EnableList = new List<bool>();

		// Token: 0x0200A944 RID: 43332
		private enum EChildType
		{
			// Token: 0x040344B4 RID: 214196
			BgItem,
			// Token: 0x040344B5 RID: 214197
			UpItem,
			// Token: 0x040344B6 RID: 214198
			LeftItem,
			// Token: 0x040344B7 RID: 214199
			DownItem,
			// Token: 0x040344B8 RID: 214200
			RightItem
		}
	}
}
