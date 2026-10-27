using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200613F RID: 24895
	public class RoverlikeSettleBlessingPanel : UiPanelBase, IRoverlikeSettleSelectablePanel
	{
		// Token: 0x0603EEE3 RID: 257763 RVA: 0x00F337DC File Offset: 0x00F319DC
		[NullableContext(1)]
		public void BindOnItemClick(Action<int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x0603EEE4 RID: 257764 RVA: 0x00F337E8 File Offset: 0x00F319E8
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

		// Token: 0x0603EEE5 RID: 257765 RVA: 0x00F33893 File Offset: 0x00F31A93
		protected override void OnStart()
		{
			this.BlessingLayout = new GenericLayout<RoverlikeBlessingSuitBlessItem, int>(base.GetGridLayout(1), new Func<RoverlikeBlessingSuitBlessItem>(this.CreateBlessingItem), null, false, true);
		}

		// Token: 0x0603EEE6 RID: 257766 RVA: 0x00F338B8 File Offset: 0x00F31AB8
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

		// Token: 0x0603EEE7 RID: 257767 RVA: 0x00F33923 File Offset: 0x00F31B23
		public void SelectByKey(int key)
		{
			GenericLayout<RoverlikeBlessingSuitBlessItem, int> blessingLayout = this.BlessingLayout;
			if (blessingLayout == null)
			{
				return;
			}
			blessingLayout.SelectGridProxyByKey(key, false);
		}

		// Token: 0x0603EEE8 RID: 257768 RVA: 0x00F3393C File Offset: 0x00F31B3C
		public void ClearSelect()
		{
			GenericLayout<RoverlikeBlessingSuitBlessItem, int> blessingLayout = this.BlessingLayout;
			if (blessingLayout == null)
			{
				return;
			}
			blessingLayout.DeselectCurrentGridProxy();
		}

		// Token: 0x0603EEE9 RID: 257769 RVA: 0x00F3394E File Offset: 0x00F31B4E
		[NullableContext(1)]
		private RoverlikeBlessingSuitBlessItem CreateBlessingItem()
		{
			RoverlikeBlessingSuitBlessItem roverlikeBlessingSuitBlessItem = new RoverlikeBlessingSuitBlessItem();
			roverlikeBlessingSuitBlessItem.BindOnItemClick(new Action<int>(this.OnGridItemClick));
			return roverlikeBlessingSuitBlessItem;
		}

		// Token: 0x0603EEEA RID: 257770 RVA: 0x00F33967 File Offset: 0x00F31B67
		private void OnGridItemClick(int blessId)
		{
			Action<int> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(blessId);
		}

		// Token: 0x04020D96 RID: 134550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeBlessingSuitBlessItem, int> BlessingLayout;

		// Token: 0x04020D97 RID: 134551
		[Nullable(2)]
		private Action<int> OnItemClick;

		// Token: 0x0200C39B RID: 50075
		private class EComponents
		{
			// Token: 0x0403B070 RID: 241776
			public const int TxtNum = 0;

			// Token: 0x0403B071 RID: 241777
			public const int LayoutBlessing = 1;

			// Token: 0x0403B072 RID: 241778
			public const int UiItemBlessingItem = 2;

			// Token: 0x0403B073 RID: 241779
			public const int ItemEmpty = 3;
		}
	}
}
