using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003639 RID: 13881
	[NullableContext(2)]
	[Nullable(0)]
	public class WuWaGoWorldMoveTarget : IWuWaGoWorldMoveTarget
	{
		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x06024044 RID: 147524 RVA: 0x00A334B9 File Offset: 0x00A316B9
		// (set) Token: 0x06024045 RID: 147525 RVA: 0x00A334C1 File Offset: 0x00A316C1
		public WuWaGoBaseUnit Unit { get; set; }

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x06024046 RID: 147526 RVA: 0x00A334CA File Offset: 0x00A316CA
		// (set) Token: 0x06024047 RID: 147527 RVA: 0x00A334D2 File Offset: 0x00A316D2
		public AActor Actor { get; set; }

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x06024048 RID: 147528 RVA: 0x00A334DB File Offset: 0x00A316DB
		// (set) Token: 0x06024049 RID: 147529 RVA: 0x00A334E3 File Offset: 0x00A316E3
		public Vector FromWorldPosition { get; set; }

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x0602404A RID: 147530 RVA: 0x00A334EC File Offset: 0x00A316EC
		// (set) Token: 0x0602404B RID: 147531 RVA: 0x00A334F4 File Offset: 0x00A316F4
		public Vector ToWorldPosition { get; set; }
	}
}
