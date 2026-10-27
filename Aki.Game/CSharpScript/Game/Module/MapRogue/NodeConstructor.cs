using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C5 RID: 21957
	[NullableContext(1)]
	[Nullable(0)]
	public class NodeConstructor : INodeConstructor
	{
		// Token: 0x170086E2 RID: 34530
		// (get) Token: 0x06037F7A RID: 229242 RVA: 0x00D42435 File Offset: 0x00D40635
		// (set) Token: 0x06037F7B RID: 229243 RVA: 0x00D4243D File Offset: 0x00D4063D
		public int GridId { get; set; }

		// Token: 0x170086E3 RID: 34531
		// (get) Token: 0x06037F7C RID: 229244 RVA: 0x00D42446 File Offset: 0x00D40646
		// (set) Token: 0x06037F7D RID: 229245 RVA: 0x00D4244E File Offset: 0x00D4064E
		public IPos Position { get; set; }

		// Token: 0x170086E4 RID: 34532
		// (get) Token: 0x06037F7E RID: 229246 RVA: 0x00D42457 File Offset: 0x00D40657
		// (set) Token: 0x06037F7F RID: 229247 RVA: 0x00D4245F File Offset: 0x00D4065F
		public int Cost { get; set; }

		// Token: 0x170086E5 RID: 34533
		// (get) Token: 0x06037F80 RID: 229248 RVA: 0x00D42468 File Offset: 0x00D40668
		// (set) Token: 0x06037F81 RID: 229249 RVA: 0x00D42470 File Offset: 0x00D40670
		public bool Walkable { get; set; }
	}
}
