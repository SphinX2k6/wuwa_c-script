using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039CC RID: 14796
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseSelectBranchData : ITrapDefenseSelectBranchData
	{
		// Token: 0x17004DD8 RID: 19928
		// (get) Token: 0x060261FA RID: 156154 RVA: 0x00AB1749 File Offset: 0x00AAF949
		// (set) Token: 0x060261FB RID: 156155 RVA: 0x00AB1751 File Offset: 0x00AAF951
		public bool IsInDungeon { get; set; }

		// Token: 0x17004DD9 RID: 19929
		// (get) Token: 0x060261FC RID: 156156 RVA: 0x00AB175A File Offset: 0x00AAF95A
		// (set) Token: 0x060261FD RID: 156157 RVA: 0x00AB1762 File Offset: 0x00AAF962
		public TrapDefenseBuildingDevelopItemData Data { get; set; }
	}
}
