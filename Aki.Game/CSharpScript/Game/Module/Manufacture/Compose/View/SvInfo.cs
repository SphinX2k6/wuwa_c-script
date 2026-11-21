using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004647 RID: 17991
	public class SvInfo : UiPanelBase
	{
		// Token: 0x0602D3CB RID: 185291 RVA: 0x00CA86BC File Offset: 0x00CA68BC
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

		// Token: 0x0602D3CC RID: 185292 RVA: 0x00CA87B4 File Offset: 0x00CA69B4
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0602D3CD RID: 185293 RVA: 0x00CA87C4 File Offset: 0x00CA69C4
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

		// Token: 0x0602D3CE RID: 185294 RVA: 0x00CA87F8 File Offset: 0x00CA69F8
		public void SetDescVisible(bool visible)
		{
			base.GetText(3).SetUIActive(visible);
		}

		// Token: 0x0602D3CF RID: 185295 RVA: 0x00CA8807 File Offset: 0x00CA6A07
		public void SetDescBgVisible(bool visible)
		{
			base.GetText(5).SetUIActive(visible);
		}

		// Token: 0x0602D3D0 RID: 185296 RVA: 0x00CA8816 File Offset: 0x00CA6A16
		[NullableContext(1)]
		public void SetDesc(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x0602D3D1 RID: 185297 RVA: 0x00CA8826 File Offset: 0x00CA6A26
		[NullableContext(1)]
		public void SetDescBg(string text)
		{
			base.GetText(5).SetText(text, true);
		}

		// Token: 0x0200A259 RID: 41561
		private class ESvInfoComponents
		{
			// Token: 0x040325FE RID: 206334
			public const int TxtType = 0;

			// Token: 0x040325FF RID: 206335
			public const int WeaponView = 1;

			// Token: 0x04032600 RID: 206336
			public const int Desc = 3;

			// Token: 0x04032601 RID: 206337
			public const int Line = 4;

			// Token: 0x04032602 RID: 206338
			public const int DescBg = 5;

			// Token: 0x04032603 RID: 206339
			public const int InventoryView = 6;
		}
	}
}
