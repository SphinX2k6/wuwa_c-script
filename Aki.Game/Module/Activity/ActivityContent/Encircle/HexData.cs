using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003006 RID: 12294
	[NullableContext(1)]
	[Nullable(0)]
	public class HexData : IHexData
	{
		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0601D2DD RID: 119517 RVA: 0x008E90C7 File Offset: 0x008E72C7
		// (set) Token: 0x0601D2DE RID: 119518 RVA: 0x008E90CF File Offset: 0x008E72CF
		public IHexPos HexPos { get; set; }

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0601D2DF RID: 119519 RVA: 0x008E90D8 File Offset: 0x008E72D8
		// (set) Token: 0x0601D2E0 RID: 119520 RVA: 0x008E90E0 File Offset: 0x008E72E0
		public EncircleHexType Type { get; set; }

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0601D2E1 RID: 119521 RVA: 0x008E90E9 File Offset: 0x008E72E9
		// (set) Token: 0x0601D2E2 RID: 119522 RVA: 0x008E90F1 File Offset: 0x008E72F1
		public int MapId { get; set; }
	}
}
