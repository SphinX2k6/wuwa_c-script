using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004838 RID: 18488
	[NullableContext(1)]
	[Nullable(0)]
	public class DifficultUnlockTipsData
	{
		// Token: 0x17005E26 RID: 24102
		// (get) Token: 0x0602E773 RID: 190323 RVA: 0x00CF71BA File Offset: 0x00CF53BA
		// (set) Token: 0x0602E774 RID: 190324 RVA: 0x00CF71C2 File Offset: 0x00CF53C2
		public string Text { get; set; } = string.Empty;

		// Token: 0x17005E27 RID: 24103
		// (get) Token: 0x0602E775 RID: 190325 RVA: 0x00CF71CB File Offset: 0x00CF53CB
		// (set) Token: 0x0602E776 RID: 190326 RVA: 0x00CF71D3 File Offset: 0x00CF53D3
		public object[] Params { get; set; } = Array.Empty<object>();
	}
}
