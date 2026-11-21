using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050BD RID: 20669
	public class RoverlikeSettleBlessingPanel : UiPanelBase, IRoverlikeSettleSelectablePanel
	{
		// Token: 0x06033BA3 RID: 211875 RVA: 0x00E7A6BC File Offset: 0x00E788BC
		[NullableContext(1)]
		public void BindOnItemClick(Action<int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x06033BA4 RID: 211876 RVA: 0x00E7A6C8 File Offset: 0x00E788C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033BA5 RID: 211877 RVA: 0x00E7A773 File Offset: 0x00E78973
		protected override void OnStart()
		{
			this.BlessingLayout = new GenericLayout<RoverlikeBlessingSuitBlessItem, int>(base.GetGridLayout(1), new Func<RoverlikeBlessingSuitBlessItem>(this.CreateBlessingItem), null, false, true);
		}

		// Token: 0x06033BA6 RID: 211878 RVA: 0x00E7A798 File Offset: 0x00E78998
		[NullableContext(1)]
		public void Refresh(List<int> configIdList)
		{
			base.GetText(0).SetText(configIdList.Count.ToString(), true);
			bool flag = configIdList.Count > 0;
			GenericLayout<RoverlikeBlessingSuitBlessItem, int> blessingLayout = this.BlessingLayout;
			if (blessingLayout != null)
			{
				blessingLayout.SetActive(flag);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			if (flag)
			{
				this.BlessingLayout.RefreshByData(configIdList, null, true);
			}
		}

		// Token: 0x06033BA7 RID: 211879 RVA: 0x00E7A803 File Offset: 0x00E78A03
		public void SelectByKey(int key)
		{
			GenericLayout<RoverlikeBlessingSuitBlessItem, int> blessingLayout = this.BlessingLayout;
			if (blessingLayout == null)
			{
				return;
			}
			blessingLayout.SelectGridProxyByKey(key, false);
		}

		// Token: 0x06033BA8 RID: 211880 RVA: 0x00E7A81C File Offset: 0x00E78A1C
		public void ClearSelect()
		{
			GenericLayout<RoverlikeBlessingSuitBlessItem, int> blessingLayout = this.BlessingLayout;
			if (blessingLayout == null)
			{
				return;
			}
			blessingLayout.DeselectCurrentGridProxy();
		}

		// Token: 0x06033BA9 RID: 211881 RVA: 0x00E7A82E File Offset: 0x00E78A2E
		[NullableContext(1)]
		private RoverlikeBlessingSuitBlessItem CreateBlessingItem()
		{
			RoverlikeBlessingSuitBlessItem roverlikeBlessingSuitBlessItem = new RoverlikeBlessingSuitBlessItem();
			roverlikeBlessingSuitBlessItem.BindOnItemClick(new Action<int>(this.OnGridItemClick));
			return roverlikeBlessingSuitBlessItem;
		}

		// Token: 0x06033BAA RID: 211882 RVA: 0x00E7A847 File Offset: 0x00E78A47
		private void OnGridItemClick(int blessId)
		{
			Action<int> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(blessId);
		}

		// Token: 0x0401B6C3 RID: 112323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeBlessingSuitBlessItem, int> BlessingLayout;

		// Token: 0x0401B6C4 RID: 112324
		[Nullable(2)]
		private Action<int> OnItemClick;

		// Token: 0x0200AD82 RID: 44418
		private class EComponents
		{
			// Token: 0x040359D1 RID: 219601
			public const int TxtNum = 0;

			// Token: 0x040359D2 RID: 219602
			public const int LayoutBlessing = 1;

			// Token: 0x040359D3 RID: 219603
			public const int UiItemBlessingItem = 2;

			// Token: 0x040359D4 RID: 219604
			public const int ItemEmpty = 3;
		}
	}
}
