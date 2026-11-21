using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050F8 RID: 20728
	public class RoverlikeRoleSelectElementTogglePanel : UiPanelBase
	{
		// Token: 0x06033DF1 RID: 212465 RVA: 0x00E84CF4 File Offset: 0x00E82EF4
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

		// Token: 0x06033DF2 RID: 212466 RVA: 0x00E84DE4 File Offset: 0x00E82FE4
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

		// Token: 0x0200ADCB RID: 44491
		private class EComponents
		{
			// Token: 0x04035B23 RID: 219939
			public const int PnlLock = 0;

			// Token: 0x04035B24 RID: 219940
			public const int TexBgColor = 1;

			// Token: 0x04035B25 RID: 219941
			public const int TexFeatherBg = 2;

			// Token: 0x04035B26 RID: 219942
			public const int TexFeatherShadowUp = 3;

			// Token: 0x04035B27 RID: 219943
			public const int TexFeatherShadowDown = 4;

			// Token: 0x04035B28 RID: 219944
			public const int SprIconBg = 5;
		}
	}
}
