using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B9 RID: 20665
	public class RoverlikeLootTipsIconItem : UiPanelBase
	{
		// Token: 0x06033B94 RID: 211860 RVA: 0x00E7A128 File Offset: 0x00E78328
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033B95 RID: 211861 RVA: 0x00E7A170 File Offset: 0x00E78370
		[NullableContext(1)]
		public void Refresh(string iconPath)
		{
			base.SetTextureByPath(iconPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200AD7E RID: 44414
		private class EComponents
		{
			// Token: 0x040359BF RID: 219583
			public const int TexIcon = 0;
		}
	}
}
