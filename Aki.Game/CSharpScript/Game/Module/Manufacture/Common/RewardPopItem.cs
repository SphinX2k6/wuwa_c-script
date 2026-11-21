using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004673 RID: 18035
	public class RewardPopItem : UiPanelBase
	{
		// Token: 0x0602D5C8 RID: 185800 RVA: 0x00CB397E File Offset: 0x00CB1B7E
		[NullableContext(1)]
		public RewardPopItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D5C9 RID: 185801 RVA: 0x00CB3994 File Offset: 0x00CB1B94
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
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D5CA RID: 185802 RVA: 0x00CB3A7E File Offset: 0x00CB1C7E
		[NullableContext(1)]
		public void Update(ICommonPopItemData data)
		{
			this.ItemData = data;
			this.SetIcon();
			this.SetQuality();
			this.SetCount();
		}

		// Token: 0x0602D5CB RID: 185803 RVA: 0x00CB3A9C File Offset: 0x00CB1C9C
		private void SetIcon()
		{
			base.SetItemIcon(base.GetTexture(4), this.ItemData.ItemId, null, null);
		}

		// Token: 0x0602D5CC RID: 185804 RVA: 0x00CB3ACC File Offset: 0x00CB1CCC
		private void SetQuality()
		{
			base.SetItemQualityIcon(base.GetSprite(5), this.ItemData.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0602D5CD RID: 185805 RVA: 0x00CB3AFC File Offset: 0x00CB1CFC
		private void SetCount()
		{
			base.GetText(8).SetText(this.ItemData.ItemNum.ToString(), true);
		}

		// Token: 0x0602D5CE RID: 185806 RVA: 0x00CB3B29 File Offset: 0x00CB1D29
		private void OnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemData.ItemId, true, null, false);
		}

		// Token: 0x040184B8 RID: 99512
		[Nullable(2)]
		private ICommonPopItemData ItemData;

		// Token: 0x0200A289 RID: 41609
		private class ECommonPopItemDefine
		{
			// Token: 0x04032709 RID: 206601
			public const int IconTexture = 4;

			// Token: 0x0403270A RID: 206602
			public const int QualitySprite = 5;

			// Token: 0x0403270B RID: 206603
			public const int NumText = 8;

			// Token: 0x0403270C RID: 206604
			public const int ItemButton = 9;
		}
	}
}
