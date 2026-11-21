using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF9 RID: 20217
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownTitle : TitleItemBase<ActivityEntranceDropDownContentData>
	{
		// Token: 0x06032CFE RID: 208126 RVA: 0x00E43C85 File Offset: 0x00E41E85
		public DropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06032CFF RID: 208127 RVA: 0x00E43C90 File Offset: 0x00E41E90
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

		// Token: 0x06032D00 RID: 208128 RVA: 0x00E43CD8 File Offset: 0x00E41ED8
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

		// Token: 0x0200AC4E RID: 44110
		[NullableContext(0)]
		private class EDropDownTitleComponent
		{
			// Token: 0x040354EC RID: 218348
			public const int TxtContent = 0;
		}
	}
}
