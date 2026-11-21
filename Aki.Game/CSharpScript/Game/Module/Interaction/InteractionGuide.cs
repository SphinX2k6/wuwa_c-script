using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200482C RID: 18476
	public class InteractionGuide : UiPanelBase
	{
		// Token: 0x0602E6CB RID: 190155 RVA: 0x00CF45F0 File Offset: 0x00CF27F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E6CC RID: 190156 RVA: 0x00CF4659 File Offset: 0x00CF2859
		protected override void OnStart()
		{
			this.SetActive(false);
		}

		// Token: 0x0602E6CD RID: 190157 RVA: 0x00CF4662 File Offset: 0x00CF2862
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602E6CE RID: 190158 RVA: 0x00CF4664 File Offset: 0x00CF2864
		[NullableContext(1)]
		public void Refresh(string textId)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalText(text, textId, Array.Empty<object>());
			LguiUtil.Instance.ReplaceWildCard(text);
			this.SetActive(true);
		}

		// Token: 0x0602E6CF RID: 190159 RVA: 0x00CF469C File Offset: 0x00CF289C
		public void RefreshTextWidth()
		{
			UUIText text = base.GetText(1);
			if (text == null || !text.IsValid())
			{
				return;
			}
			if (text.GetWidth() > 760f)
			{
				text.SetWidth(760f);
				text.SetOverflowType(UITextOverflowType.VerticalOverflow);
			}
		}

		// Token: 0x04018B81 RID: 101249
		private const int INTERACT_GUIDE_MAX_TEXT_WIDTH = 760;

		// Token: 0x0200A48F RID: 42127
		internal class EChildType
		{
			// Token: 0x04032FD5 RID: 208853
			public const int GuideItem = 0;

			// Token: 0x04032FD6 RID: 208854
			public const int GuideText = 1;
		}
	}
}
