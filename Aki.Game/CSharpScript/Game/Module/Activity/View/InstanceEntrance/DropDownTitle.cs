using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F12 RID: 24338
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownTitle : TitleItemBase<ActivityEntranceDropDownContentData>
	{
		// Token: 0x0603DD63 RID: 253283 RVA: 0x00EF1F7D File Offset: 0x00EF017D
		public DropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0603DD64 RID: 253284 RVA: 0x00EF1F88 File Offset: 0x00EF0188
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DD65 RID: 253285 RVA: 0x00EF1FD0 File Offset: 0x00EF01D0
		public override void ShowTemp(ActivityEntranceDropDownContentData data, DropDownItemBase<ActivityEntranceDropDownContentData> selectedItemObj)
		{
			string dropDownText = data.GetDropDownText();
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(dropDownText, true);
		}

		// Token: 0x0200C241 RID: 49729
		[NullableContext(0)]
		private class EDropDownTitleComponent
		{
			// Token: 0x0403AAFA RID: 240378
			public const int TxtContent = 0;
		}
	}
}
