using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005671 RID: 22129
	public class SvInfo : UiPanelBase
	{
		// Token: 0x060384CE RID: 230606 RVA: 0x00D5A5BC File Offset: 0x00D587BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x060384CF RID: 230607 RVA: 0x00D5A6B4 File Offset: 0x00D588B4
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x060384D0 RID: 230608 RVA: 0x00D5A6C4 File Offset: 0x00D588C4
		[NullableContext(2)]
		public void SetTypeName(string tag = null)
		{
			UUIText text = base.GetText(0);
			if (!string.IsNullOrEmpty(tag))
			{
				text.SetUIActive(true);
				text.SetText(tag, true);
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x060384D1 RID: 230609 RVA: 0x00D5A6F8 File Offset: 0x00D588F8
		public void SetDescVisible(bool visible)
		{
			base.GetText(3).SetUIActive(visible);
		}

		// Token: 0x060384D2 RID: 230610 RVA: 0x00D5A707 File Offset: 0x00D58907
		public void SetDescBgVisible(bool visible)
		{
			base.GetText(5).SetUIActive(visible);
		}

		// Token: 0x060384D3 RID: 230611 RVA: 0x00D5A716 File Offset: 0x00D58916
		[NullableContext(1)]
		public void SetDesc(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x060384D4 RID: 230612 RVA: 0x00D5A726 File Offset: 0x00D58926
		[NullableContext(1)]
		public void SetDescBg(string text)
		{
			base.GetText(5).SetText(text, true);
		}

		// Token: 0x0200B831 RID: 47153
		private class ESvInfoComponents
		{
			// Token: 0x04037BE0 RID: 228320
			public const int TxtType = 0;

			// Token: 0x04037BE1 RID: 228321
			public const int WeaponView = 1;

			// Token: 0x04037BE2 RID: 228322
			public const int Desc = 3;

			// Token: 0x04037BE3 RID: 228323
			public const int Line = 4;

			// Token: 0x04037BE4 RID: 228324
			public const int DescBg = 5;

			// Token: 0x04037BE5 RID: 228325
			public const int InventoryView = 6;
		}
	}
}
