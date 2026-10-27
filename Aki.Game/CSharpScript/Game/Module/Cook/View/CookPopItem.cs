using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B1D RID: 23325
	[NullableContext(1)]
	[Nullable(0)]
	public class CookPopItem : UiPanelBase
	{
		// Token: 0x0603B0BD RID: 241853 RVA: 0x00E13DFA File Offset: 0x00E11FFA
		public CookPopItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B0BE RID: 241854 RVA: 0x00E13E10 File Offset: 0x00E12010
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(delegate()
			{
				this.OnClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B0BF RID: 241855 RVA: 0x00E13EFA File Offset: 0x00E120FA
		public void Update(ICookPopItem data)
		{
			this.ItemData = data;
			this.SetIcon();
			this.SetQuality();
			this.SetCount();
		}

		// Token: 0x0603B0C0 RID: 241856 RVA: 0x00E13F18 File Offset: 0x00E12118
		private void SetIcon()
		{
			base.SetItemIcon(base.GetTexture(4), this.ItemData.ItemId, null, null);
		}

		// Token: 0x0603B0C1 RID: 241857 RVA: 0x00E13F48 File Offset: 0x00E12148
		private void SetQuality()
		{
			base.SetItemQualityIcon(base.GetSprite(5), this.ItemData.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0603B0C2 RID: 241858 RVA: 0x00E13F78 File Offset: 0x00E12178
		private void SetCount()
		{
			base.GetText(8).SetText(this.ItemData.ItemNum.ToString(), true);
		}

		// Token: 0x0603B0C3 RID: 241859 RVA: 0x00E13FA5 File Offset: 0x00E121A5
		private void OnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemData.ItemId, true, null);
		}

		// Token: 0x0401ECC3 RID: 126147
		[Nullable(2)]
		private ICookPopItem ItemData;
	}
}
