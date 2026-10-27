using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005918 RID: 22808
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrMaterialsDeliveryEffectItem : GridProxyAbstract<string>
	{
		// Token: 0x06039EAE RID: 237230 RVA: 0x00DC2A90 File Offset: 0x00DC0C90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039EAF RID: 237231 RVA: 0x00DC2AD8 File Offset: 0x00DC0CD8
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200BB94 RID: 48020
		private class EChildType
		{
			// Token: 0x04038A02 RID: 231938
			public const int TextEffect = 0;
		}
	}
}
