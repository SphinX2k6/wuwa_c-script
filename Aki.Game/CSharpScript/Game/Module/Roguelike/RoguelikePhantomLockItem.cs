using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DBC RID: 15804
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikePhantomLockItem : UiPanelBase
	{
		// Token: 0x0602865C RID: 165468 RVA: 0x00B51A40 File Offset: 0x00B4FC40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602865D RID: 165469 RVA: 0x00B51ACA File Offset: 0x00B4FCCA
		public void SetTextByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0602865E RID: 165470 RVA: 0x00B51ADF File Offset: 0x00B4FCDF
		public void SetTextByText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0602865F RID: 165471 RVA: 0x00B51AEF File Offset: 0x00B4FCEF
		public UUISprite GetIconSprite()
		{
			return base.GetSprite(0);
		}

		// Token: 0x06028660 RID: 165472 RVA: 0x00B51AF8 File Offset: 0x00B4FCF8
		public void SetSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x020099AF RID: 39343
		[NullableContext(0)]
		private class ERedComponents
		{
			// Token: 0x0402FEB8 RID: 196280
			public const int Sprite = 0;

			// Token: 0x0402FEB9 RID: 196281
			public const int Txt = 1;

			// Token: 0x0402FEBA RID: 196282
			public const int Button = 2;
		}
	}
}
