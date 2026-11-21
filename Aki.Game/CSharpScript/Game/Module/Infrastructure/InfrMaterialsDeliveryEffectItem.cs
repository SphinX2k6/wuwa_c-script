using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F1 RID: 18673
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrMaterialsDeliveryEffectItem : GridProxyAbstract<string>
	{
		// Token: 0x0602EDD1 RID: 191953 RVA: 0x00D11D90 File Offset: 0x00D0FF90
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

		// Token: 0x0602EDD2 RID: 191954 RVA: 0x00D11DD8 File Offset: 0x00D0FFD8
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200A5A4 RID: 42404
		private class EChildType
		{
			// Token: 0x040333EA RID: 209898
			public const int TextEffect = 0;
		}
	}
}
