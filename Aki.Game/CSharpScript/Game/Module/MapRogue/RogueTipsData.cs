using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055F6 RID: 22006
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTipsData : IRogueTipsData
	{
		// Token: 0x17008711 RID: 34577
		// (get) Token: 0x06038074 RID: 229492 RVA: 0x00D4508E File Offset: 0x00D4328E
		// (set) Token: 0x06038075 RID: 229493 RVA: 0x00D45096 File Offset: 0x00D43296
		public string TextId { get; set; }

		// Token: 0x17008712 RID: 34578
		// (get) Token: 0x06038076 RID: 229494 RVA: 0x00D4509F File Offset: 0x00D4329F
		// (set) Token: 0x06038077 RID: 229495 RVA: 0x00D450A7 File Offset: 0x00D432A7
		public string[] TextParam { get; set; }

		// Token: 0x17008713 RID: 34579
		// (get) Token: 0x06038078 RID: 229496 RVA: 0x00D450B0 File Offset: 0x00D432B0
		// (set) Token: 0x06038079 RID: 229497 RVA: 0x00D450B8 File Offset: 0x00D432B8
		[Nullable(2)]
		public Action FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
