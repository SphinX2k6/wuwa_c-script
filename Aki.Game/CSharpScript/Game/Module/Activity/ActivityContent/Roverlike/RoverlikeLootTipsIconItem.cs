using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200613B RID: 24891
	public class RoverlikeLootTipsIconItem : UiPanelBase
	{
		// Token: 0x0603EED4 RID: 257748 RVA: 0x00F33248 File Offset: 0x00F31448
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

		// Token: 0x0603EED5 RID: 257749 RVA: 0x00F33290 File Offset: 0x00F31490
		[NullableContext(1)]
		public void Refresh(string iconPath)
		{
			base.SetTextureByPath(iconPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200C397 RID: 50071
		private class EComponents
		{
			// Token: 0x0403B05E RID: 241758
			public const int TexIcon = 0;
		}
	}
}
