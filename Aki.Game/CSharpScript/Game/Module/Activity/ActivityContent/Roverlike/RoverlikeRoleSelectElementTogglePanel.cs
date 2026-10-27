using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200617A RID: 24954
	public class RoverlikeRoleSelectElementTogglePanel : UiPanelBase
	{
		// Token: 0x0603F131 RID: 258353 RVA: 0x00F3DE2C File Offset: 0x00F3C02C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F132 RID: 258354 RVA: 0x00F3DF1C File Offset: 0x00F3C11C
		public void SetLocked(bool locked)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(locked);
			}
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.useChangeColor = locked;
			}
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 != null)
			{
				texture2.useChangeColor = locked;
			}
			UUITexture texture3 = base.GetTexture(3);
			if (texture3 != null)
			{
				texture3.useChangeColor = locked;
			}
			UUITexture texture4 = base.GetTexture(4);
			if (texture4 != null)
			{
				texture4.useChangeColor = locked;
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.useChangeColor = locked;
			}
		}

		// Token: 0x0200C3E4 RID: 50148
		private class EComponents
		{
			// Token: 0x0403B1C2 RID: 242114
			public const int PnlLock = 0;

			// Token: 0x0403B1C3 RID: 242115
			public const int TexBgColor = 1;

			// Token: 0x0403B1C4 RID: 242116
			public const int TexFeatherBg = 2;

			// Token: 0x0403B1C5 RID: 242117
			public const int TexFeatherShadowUp = 3;

			// Token: 0x0403B1C6 RID: 242118
			public const int TexFeatherShadowDown = 4;

			// Token: 0x0403B1C7 RID: 242119
			public const int SprIconBg = 5;
		}
	}
}
