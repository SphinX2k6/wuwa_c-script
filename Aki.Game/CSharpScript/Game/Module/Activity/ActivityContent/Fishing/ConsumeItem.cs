using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C9 RID: 26057
	internal class ConsumeItem : UiPanelBase
	{
		// Token: 0x060415BA RID: 267706 RVA: 0x00FD6890 File Offset: 0x00FD4A90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060415BB RID: 267707 RVA: 0x00FD6957 File Offset: 0x00FD4B57
		private void OnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}

		// Token: 0x060415BC RID: 267708 RVA: 0x00FD696B File Offset: 0x00FD4B6B
		protected override void OnStart()
		{
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.RefreshCount));
		}

		// Token: 0x060415BD RID: 267709 RVA: 0x00FD6989 File Offset: 0x00FD4B89
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.RefreshCount));
		}

		// Token: 0x060415BE RID: 267710 RVA: 0x00FD69A7 File Offset: 0x00FD4BA7
		[NullableContext(1)]
		private void RefreshCount(IProto_NormalItem normalItem, int i, int arg3)
		{
			this.Refresh(this.ItemId);
		}

		// Token: 0x060415BF RID: 267711 RVA: 0x00FD69B8 File Offset: 0x00FD4BB8
		public void Refresh(int itemId)
		{
			this.ItemId = itemId;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(itemCountByConfigId.ToString(), true);
			}
			base.SetItemIcon(base.GetTexture(0), itemId, null, null);
		}

		// Token: 0x0402201C RID: 139292
		private int ItemId;

		// Token: 0x0200C7EE RID: 51182
		private class EConsumeItem
		{
			// Token: 0x0403C61C RID: 247324
			public const int Icon = 0;

			// Token: 0x0403C61D RID: 247325
			public const int Text = 1;

			// Token: 0x0403C61E RID: 247326
			public const int Btn = 2;
		}
	}
}
