using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MarkMenu
{
	// Token: 0x02003730 RID: 14128
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkMenu : WorldMapSecondaryUi
	{
		// Token: 0x06024C0B RID: 150539 RVA: 0x00A61E13 File Offset: 0x00A60013
		public override string GetResourceId()
		{
			return "UiItem_MarkList_Prefab";
		}

		// Token: 0x06024C0C RID: 150540 RVA: 0x00A61E1C File Offset: 0x00A6001C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.Close));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024C0D RID: 150541 RVA: 0x00A61F04 File Offset: 0x00A60104
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06024C0E RID: 150542 RVA: 0x00A61F18 File Offset: 0x00A60118
		private List<UUIItem> GetOrAddUsedItems(int count)
		{
			this.UsedUiItems.Clear();
			int num = count - this.MenuUiItems.Count;
			for (int i = 0; i < num; i++)
			{
				UUIItem item = LguiUtil.Instance.CopyItem(base.GetItem(3), base.GetItem(2));
				this.MenuUiItems.Add(item);
			}
			for (int j = 0; j < this.MenuUiItems.Count; j++)
			{
				bool flag = j < count;
				if (flag)
				{
					this.UsedUiItems.Add(this.MenuUiItems[j]);
				}
				this.MenuUiItems[j].SetUIActive(flag);
			}
			return this.UsedUiItems;
		}

		// Token: 0x06024C0F RID: 150543 RVA: 0x00A61FC0 File Offset: 0x00A601C0
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				List<MarkItem> list = param[0] as List<MarkItem>;
				this.UsedUiItems = this.GetOrAddUsedItems(list.Count);
				this.MarkMenuItems = new List<MarkMenuItem>(list.Count);
				int num = 0;
				using (List<MarkItem>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						MarkMenu.<>c__DisplayClass8_0 CS$<>8__locals1 = new MarkMenu.<>c__DisplayClass8_0();
						CS$<>8__locals1.<>4__this = this;
						CS$<>8__locals1.markItem = enumerator.Current;
						MarkMenu.<>c__DisplayClass8_1 CS$<>8__locals2 = new MarkMenu.<>c__DisplayClass8_1();
						CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
						CS$<>8__locals2.markMenuItem = new MarkMenuItem();
						UUIItem uiItem = this.UsedUiItems[num++];
						CS$<>8__locals2.markMenuItem.Init(uiItem, CS$<>8__locals2.CS$<>8__locals1.markItem).ContinueWith(new Action(CS$<>8__locals2.<OnShowWorldMapSecondaryUi>g__OnCreateDone|0));
					}
				}
			}
		}

		// Token: 0x06024C10 RID: 150544 RVA: 0x00A620A8 File Offset: 0x00A602A8
		protected override void OnCloseWorldMapSecondaryUi()
		{
			if (this.MarkMenuItems == null || this.MarkMenuItems.Count == 0)
			{
				return;
			}
			foreach (MarkMenuItem markMenuItem in this.MarkMenuItems)
			{
				UUIItem rootItem = markMenuItem.GetRootItem();
				if (rootItem != null)
				{
					this.MenuUiItems.Remove(rootItem);
				}
				markMenuItem.Destroy(null);
			}
		}

		// Token: 0x06024C11 RID: 150545 RVA: 0x00A62128 File Offset: 0x00A60328
		protected override void OnBeforeDestroy()
		{
			this.MarkMenuItems = null;
			this.MenuUiItems.Clear();
			this.UsedUiItems.Clear();
		}

		// Token: 0x06024C12 RID: 150546 RVA: 0x00A62147 File Offset: 0x00A60347
		protected override bool GetNeedBgItem()
		{
			return false;
		}

		// Token: 0x0401465C RID: 83548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MarkMenuItem> MarkMenuItems;

		// Token: 0x0401465D RID: 83549
		private List<UUIItem> MenuUiItems = new List<UUIItem>();

		// Token: 0x0401465E RID: 83550
		private List<UUIItem> UsedUiItems = new List<UUIItem>();

		// Token: 0x0200947A RID: 38010
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E697 RID: 190103
			public const int Modal = 0;

			// Token: 0x0402E698 RID: 190104
			public const int ScrollView = 1;

			// Token: 0x0402E699 RID: 190105
			public const int MenuItemRoot = 2;

			// Token: 0x0402E69A RID: 190106
			public const int MenuItem = 3;
		}
	}
}
