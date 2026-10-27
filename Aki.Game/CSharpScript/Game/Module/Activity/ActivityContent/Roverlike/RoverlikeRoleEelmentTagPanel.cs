using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200617D RID: 24957
	public class RoverlikeRoleEelmentTagPanel : UiPanelBase
	{
		// Token: 0x0603F140 RID: 258368 RVA: 0x00F3E3EC File Offset: 0x00F3C5EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F141 RID: 258369 RVA: 0x00F3E478 File Offset: 0x00F3C678
		[NullableContext(2)]
		public void Refresh(string iconPath, string textId)
		{
			UUISprite sprite = base.GetSprite(1);
			base.TrySetSpriteByPath(iconPath, sprite, false, null, null);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.TrySetLocalTextNew(text, textId, Array.Empty<object>());
		}

		// Token: 0x0603F142 RID: 258370 RVA: 0x00F3E4B9 File Offset: 0x00F3C6B9
		public void SetTagBgColor(FColor color)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(color);
		}

		// Token: 0x0200C3E8 RID: 50152
		private class ETagComponents
		{
			// Token: 0x0403B1D5 RID: 242133
			public const int SprTagBg = 0;

			// Token: 0x0403B1D6 RID: 242134
			public const int SprTypeIcon = 1;

			// Token: 0x0403B1D7 RID: 242135
			public const int TxtType = 2;
		}
	}
}
