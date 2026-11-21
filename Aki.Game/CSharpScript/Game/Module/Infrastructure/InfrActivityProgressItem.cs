using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E4 RID: 18660
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrActivityProgressItem : GridProxyAbstract<List<bool>>
	{
		// Token: 0x0602ED54 RID: 191828 RVA: 0x00D0EEC4 File Offset: 0x00D0D0C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602ED55 RID: 191829 RVA: 0x00D0EF2D File Offset: 0x00D0D12D
		[NullableContext(1)]
		public override void Refresh(List<bool> pointState, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(pointState[0]);
			base.GetItem(1).SetUIActive(pointState[1]);
		}

		// Token: 0x0200A586 RID: 42374
		private class EComponent
		{
			// Token: 0x04033343 RID: 209731
			public const int PanelLeft = 0;

			// Token: 0x04033344 RID: 209732
			public const int PanelRight = 1;
		}
	}
}
