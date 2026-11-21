using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FD8 RID: 12248
	public class TetrisRotationButton : UiPanelBase
	{
		// Token: 0x0601D146 RID: 119110 RVA: 0x008E3448 File Offset: 0x008E1648
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D147 RID: 119111 RVA: 0x008E34D2 File Offset: 0x008E16D2
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Tetris2UIText_006", Array.Empty<object>());
			this.SetEnabled(false);
		}

		// Token: 0x0601D148 RID: 119112 RVA: 0x008E34F6 File Offset: 0x008E16F6
		protected override void OnBeforeDestroy()
		{
			this.SetEnabled(false);
		}

		// Token: 0x0601D149 RID: 119113 RVA: 0x008E3500 File Offset: 0x008E1700
		public void SetEnabled(bool enabled)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(enabled);
			}
			UUISprite sprite = base.GetSprite(1);
			FColor? fcolor;
			if (sprite != null)
			{
				fcolor = null;
				sprite.SetChangeColor(enabled, fcolor);
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			fcolor = null;
			text.SetChangeColor(enabled, fcolor);
		}

		// Token: 0x02008C59 RID: 35929
		private static class EComponents
		{
			// Token: 0x0402C6BD RID: 181949
			public const int BtnRotation = 0;

			// Token: 0x0402C6BE RID: 181950
			public const int SprArrow = 1;

			// Token: 0x0402C6BF RID: 181951
			public const int TxtTips = 2;
		}
	}
}
