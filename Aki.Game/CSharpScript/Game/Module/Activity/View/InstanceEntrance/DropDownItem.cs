using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF8 RID: 20216
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownItem : DropDownItemBase<ActivityEntranceDropDownContentData>
	{
		// Token: 0x06032CFA RID: 208122 RVA: 0x00E43BD4 File Offset: 0x00E41DD4
		public DropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06032CFB RID: 208123 RVA: 0x00E43BE0 File Offset: 0x00E41DE0
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

		// Token: 0x06032CFC RID: 208124 RVA: 0x00E43C4C File Offset: 0x00E41E4C
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

		// Token: 0x06032CFD RID: 208125 RVA: 0x00E43C7C File Offset: 0x00E41E7C
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0200AC4D RID: 44109
		[NullableContext(0)]
		private class EDropDownItemComponent
		{
			// Token: 0x040354EA RID: 218346
			public const int TogOption = 0;

			// Token: 0x040354EB RID: 218347
			public const int TxtOption = 1;
		}
	}
}
