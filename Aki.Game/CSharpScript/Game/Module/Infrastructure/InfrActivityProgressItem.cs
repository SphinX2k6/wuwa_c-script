using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x0200590B RID: 22795
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrActivityProgressItem : GridProxyAbstract<List<bool>>
	{
		// Token: 0x06039E31 RID: 237105 RVA: 0x00DBFBCC File Offset: 0x00DBDDCC
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

		// Token: 0x06039E32 RID: 237106 RVA: 0x00DBFC35 File Offset: 0x00DBDE35
		[NullableContext(1)]
		public override void Refresh(List<bool> pointState, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(pointState[0]);
			base.GetItem(1).SetUIActive(pointState[1]);
		}

		// Token: 0x0200BB76 RID: 47990
		private class EComponent
		{
			// Token: 0x0403895B RID: 231771
			public const int PanelLeft = 0;

			// Token: 0x0403895C RID: 231772
			public const int PanelRight = 1;
		}
	}
}
