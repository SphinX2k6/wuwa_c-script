using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DF3 RID: 19955
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikePhantomLockItem : UiPanelBase
	{
		// Token: 0x060337F1 RID: 210929 RVA: 0x00C08530 File Offset: 0x00C06730
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

		// Token: 0x060337F2 RID: 210930 RVA: 0x00C085BA File Offset: 0x00C067BA
		public void SetTextByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x060337F3 RID: 210931 RVA: 0x00C085CF File Offset: 0x00C067CF
		public void SetTextByText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x060337F4 RID: 210932 RVA: 0x00C085DF File Offset: 0x00C067DF
		public UUISprite GetIconSprite()
		{
			return base.GetSprite(0);
		}

		// Token: 0x060337F5 RID: 210933 RVA: 0x00C085E8 File Offset: 0x00C067E8
		public void SetSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x0200AF7A RID: 44922
		[NullableContext(0)]
		private class ERedComponents
		{
			// Token: 0x04035485 RID: 218245
			public const int Sprite = 0;

			// Token: 0x04035486 RID: 218246
			public const int Txt = 1;

			// Token: 0x04035487 RID: 218247
			public const int Button = 2;
		}
	}
}
