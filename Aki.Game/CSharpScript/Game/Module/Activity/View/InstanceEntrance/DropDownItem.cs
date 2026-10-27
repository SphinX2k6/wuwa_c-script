using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F11 RID: 24337
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownItem : DropDownItemBase<ActivityEntranceDropDownContentData>
	{
		// Token: 0x0603DD5F RID: 253279 RVA: 0x00EF1ECC File Offset: 0x00EF00CC
		public DropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0603DD60 RID: 253280 RVA: 0x00EF1ED8 File Offset: 0x00EF00D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DD61 RID: 253281 RVA: 0x00EF1F44 File Offset: 0x00EF0144
		protected override void OnShowDropDownItemBase(ActivityEntranceDropDownContentData data)
		{
			string newText = data.GetTogOptionText() ?? "";
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0603DD62 RID: 253282 RVA: 0x00EF1F74 File Offset: 0x00EF0174
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0200C240 RID: 49728
		[NullableContext(0)]
		private class EDropDownItemComponent
		{
			// Token: 0x0403AAF8 RID: 240376
			public const int TogOption = 0;

			// Token: 0x0403AAF9 RID: 240377
			public const int TxtOption = 1;
		}
	}
}
