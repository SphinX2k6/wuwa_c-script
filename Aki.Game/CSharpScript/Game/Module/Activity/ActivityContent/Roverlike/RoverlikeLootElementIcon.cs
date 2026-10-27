using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200616A RID: 24938
	public class RoverlikeLootElementIcon : UiPanelBase
	{
		// Token: 0x0603F0A5 RID: 258213 RVA: 0x00F3BBC0 File Offset: 0x00F39DC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F0A6 RID: 258214 RVA: 0x00F3BC4C File Offset: 0x00F39E4C
		[NullableContext(1)]
		public void Refresh(string elementIcon)
		{
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(elementIcon, texture, null, null);
		}

		// Token: 0x0200C3D0 RID: 50128
		private class ERoverlikeLootElementIcon
		{
			// Token: 0x0403B16B RID: 242027
			public const int SprElementBg = 0;

			// Token: 0x0403B16C RID: 242028
			public const int TxtElementIcon = 1;

			// Token: 0x0403B16D RID: 242029
			public const int PnlItem = 2;
		}
	}
}
