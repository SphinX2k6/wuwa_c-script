using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B04 RID: 23300
	[NullableContext(1)]
	[Nullable(0)]
	public class MachiningClueData : IMachiningClueData
	{
		// Token: 0x17008C6D RID: 35949
		// (get) Token: 0x0603AFFA RID: 241658 RVA: 0x00E110D1 File Offset: 0x00E0F2D1
		// (set) Token: 0x0603AFFB RID: 241659 RVA: 0x00E110D9 File Offset: 0x00E0F2D9
		public bool IsUnlock { get; set; }

		// Token: 0x17008C6E RID: 35950
		// (get) Token: 0x0603AFFC RID: 241660 RVA: 0x00E110E2 File Offset: 0x00E0F2E2
		// (set) Token: 0x0603AFFD RID: 241661 RVA: 0x00E110EA File Offset: 0x00E0F2EA
		public string ContentText { get; set; }
	}
}
