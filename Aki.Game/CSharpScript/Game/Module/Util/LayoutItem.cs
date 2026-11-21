using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003842 RID: 14402
	[NullableContext(2)]
	[Nullable(0)]
	public class LayoutItem<TLayoutItemItem> : ILayoutItem<TLayoutItemItem>
	{
		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x060256A1 RID: 153249 RVA: 0x00A8A99F File Offset: 0x00A88B9F
		// (set) Token: 0x060256A2 RID: 153250 RVA: 0x00A8A9A7 File Offset: 0x00A88BA7
		[Nullable(1)]
		public object Key { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x060256A3 RID: 153251 RVA: 0x00A8A9B0 File Offset: 0x00A88BB0
		// (set) Token: 0x060256A4 RID: 153252 RVA: 0x00A8A9B8 File Offset: 0x00A88BB8
		public TLayoutItemItem Value { get; set; }
	}
}
