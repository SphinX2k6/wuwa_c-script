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
	// Token: 0x02005547 RID: 21831
	internal class ConsumeItem : UiPanelBase
	{
		// Token: 0x0603627F RID: 221823 RVA: 0x00F1D8D0 File Offset: 0x00F1BAD0
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

		// Token: 0x06036280 RID: 221824 RVA: 0x00F1D997 File Offset: 0x00F1BB97
		private void OnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}

		// Token: 0x06036281 RID: 221825 RVA: 0x00F1D9AC File Offset: 0x00F1BBAC
		protected override void OnStart()
		{
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.RefreshCount));
		}

		// Token: 0x06036282 RID: 221826 RVA: 0x00F1D9CA File Offset: 0x00F1BBCA
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.RefreshCount));
		}

		// Token: 0x06036283 RID: 221827 RVA: 0x00F1D9E8 File Offset: 0x00F1BBE8
		[NullableContext(1)]
		private void RefreshCount(IProto_NormalItem normalItem, int i, int arg3)
		{
			this.Refresh(this.ItemId);
		}

		// Token: 0x06036284 RID: 221828 RVA: 0x00F1D9F8 File Offset: 0x00F1BBF8
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

		// Token: 0x0401C94D RID: 117069
		private int ItemId;

		// Token: 0x0200B1D1 RID: 45521
		private class EConsumeItem
		{
			// Token: 0x04036F6A RID: 225130
			public const int Icon = 0;

			// Token: 0x04036F6B RID: 225131
			public const int Text = 1;

			// Token: 0x04036F6C RID: 225132
			public const int Btn = 2;
		}
	}
}
