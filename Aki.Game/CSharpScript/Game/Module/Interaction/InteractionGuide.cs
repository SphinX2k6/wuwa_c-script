using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005854 RID: 22612
	public class InteractionGuide : UiPanelBase
	{
		// Token: 0x060397AE RID: 235438 RVA: 0x00DA58C8 File Offset: 0x00DA3AC8
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

		// Token: 0x060397AF RID: 235439 RVA: 0x00DA5931 File Offset: 0x00DA3B31
		protected override void OnStart()
		{
			this.SetActive(false);
		}

		// Token: 0x060397B0 RID: 235440 RVA: 0x00DA593A File Offset: 0x00DA3B3A
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060397B1 RID: 235441 RVA: 0x00DA593C File Offset: 0x00DA3B3C
		[NullableContext(1)]
		public void Refresh(string textId)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalText(text, textId, Array.Empty<object>());
			LguiUtil.Instance.ReplaceWildCard(text);
			this.SetActive(true);
		}

		// Token: 0x060397B2 RID: 235442 RVA: 0x00DA5974 File Offset: 0x00DA3B74
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

		// Token: 0x0401E0E4 RID: 123108
		private const int INTERACT_GUIDE_MAX_TEXT_WIDTH = 760;

		// Token: 0x0200BA78 RID: 47736
		internal class EChildType
		{
			// Token: 0x040385DE RID: 230878
			public const int GuideItem = 0;

			// Token: 0x040385DF RID: 230879
			public const int GuideText = 1;
		}
	}
}
