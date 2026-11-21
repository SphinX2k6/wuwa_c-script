using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E8 RID: 20712
	public class RoverlikeLootElementIcon : UiPanelBase
	{
		// Token: 0x06033D65 RID: 212325 RVA: 0x00E82A94 File Offset: 0x00E80C94
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

		// Token: 0x06033D66 RID: 212326 RVA: 0x00E82B20 File Offset: 0x00E80D20
		[NullableContext(1)]
		public void Refresh(string elementIcon)
		{
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(elementIcon, texture, null, null);
		}

		// Token: 0x0200ADB7 RID: 44471
		private class ERoverlikeLootElementIcon
		{
			// Token: 0x04035ACC RID: 219852
			public const int SprElementBg = 0;

			// Token: 0x04035ACD RID: 219853
			public const int TxtElementIcon = 1;

			// Token: 0x04035ACE RID: 219854
			public const int PnlItem = 2;
		}
	}
}
