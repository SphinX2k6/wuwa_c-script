using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE7 RID: 12263
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisTipsTargetGrid : GridProxyAbstract<TetrisTargetData>
	{
		// Token: 0x0601D19E RID: 119198 RVA: 0x008E52C4 File Offset: 0x008E34C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D19F RID: 119199 RVA: 0x008E5330 File Offset: 0x008E3530
		[NullableContext(1)]
		public override void Refresh(TetrisTargetData data, bool isSelected, int gridIndex)
		{
			this.SetSpriteByPath(data.Icon, base.GetSprite(0), false, null, null);
			base.GetText(1).SetText(data.Num.ToString(), true);
		}

		// Token: 0x02008C60 RID: 35936
		private static class EComponents
		{
			// Token: 0x0402C6DA RID: 181978
			public const int Icon = 0;

			// Token: 0x0402C6DB RID: 181979
			public const int Count = 1;
		}
	}
}
