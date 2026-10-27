using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004709 RID: 18185
	[NullableContext(2)]
	[Nullable(0)]
	public class WuWaGoWorldMoveTarget : IWuWaGoWorldMoveTarget
	{
		// Token: 0x170076BD RID: 30397
		// (get) Token: 0x0602F87E RID: 194686 RVA: 0x00B037E9 File Offset: 0x00B019E9
		// (set) Token: 0x0602F87F RID: 194687 RVA: 0x00B037F1 File Offset: 0x00B019F1
		public WuWaGoBaseUnit Unit { get; set; }

		// Token: 0x170076BE RID: 30398
		// (get) Token: 0x0602F880 RID: 194688 RVA: 0x00B037FA File Offset: 0x00B019FA
		// (set) Token: 0x0602F881 RID: 194689 RVA: 0x00B03802 File Offset: 0x00B01A02
		public AActor Actor { get; set; }

		// Token: 0x170076BF RID: 30399
		// (get) Token: 0x0602F882 RID: 194690 RVA: 0x00B0380B File Offset: 0x00B01A0B
		// (set) Token: 0x0602F883 RID: 194691 RVA: 0x00B03813 File Offset: 0x00B01A13
		public Vector FromWorldPosition { get; set; }

		// Token: 0x170076C0 RID: 30400
		// (get) Token: 0x0602F884 RID: 194692 RVA: 0x00B0381C File Offset: 0x00B01A1C
		// (set) Token: 0x0602F885 RID: 194693 RVA: 0x00B03824 File Offset: 0x00B01A24
		public Vector ToWorldPosition { get; set; }
	}
}
