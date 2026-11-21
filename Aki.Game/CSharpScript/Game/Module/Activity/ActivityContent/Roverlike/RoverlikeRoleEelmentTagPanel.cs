using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050FB RID: 20731
	public class RoverlikeRoleEelmentTagPanel : UiPanelBase
	{
		// Token: 0x06033E00 RID: 212480 RVA: 0x00E852B4 File Offset: 0x00E834B4
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

		// Token: 0x06033E01 RID: 212481 RVA: 0x00E85340 File Offset: 0x00E83540
		[NullableContext(2)]
		public void Refresh(string iconPath, string textId)
		{
			UUISprite sprite = base.GetSprite(1);
			base.TrySetSpriteByPath(iconPath, sprite, false, null, null);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.TrySetLocalTextNew(text, textId, Array.Empty<object>());
		}

		// Token: 0x06033E02 RID: 212482 RVA: 0x00E85381 File Offset: 0x00E83581
		public void SetTagBgColor(FColor color)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(color);
		}

		// Token: 0x0200ADCF RID: 44495
		private class ETagComponents
		{
			// Token: 0x04035B36 RID: 219958
			public const int SprTagBg = 0;

			// Token: 0x04035B37 RID: 219959
			public const int SprTypeIcon = 1;

			// Token: 0x04035B38 RID: 219960
			public const int TxtType = 2;
		}
	}
}
