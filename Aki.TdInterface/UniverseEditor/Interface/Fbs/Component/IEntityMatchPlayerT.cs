using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200519F RID: 20895
	public class IEntityMatchPlayerT
	{
		// Token: 0x170098A9 RID: 39081
		// (get) Token: 0x06021CF3 RID: 138483 RVA: 0x004B0BFB File Offset: 0x004AEDFB
		// (set) Token: 0x06021CF4 RID: 138484 RVA: 0x004B0C03 File Offset: 0x004AEE03
		public EEntityMatchType Type { get; set; }

		// Token: 0x170098AA RID: 39082
		// (get) Token: 0x06021CF5 RID: 138485 RVA: 0x004B0C0C File Offset: 0x004AEE0C
		// (set) Token: 0x06021CF6 RID: 138486 RVA: 0x004B0C14 File Offset: 0x004AEE14
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x170098AB RID: 39083
		// (get) Token: 0x06021CF7 RID: 138487 RVA: 0x004B0C1D File Offset: 0x004AEE1D
		// (set) Token: 0x06021CF8 RID: 138488 RVA: 0x004B0C25 File Offset: 0x004AEE25
		public bool ChangeRoleTrigger { get; set; }

		// Token: 0x170098AC RID: 39084
		// (get) Token: 0x06021CF9 RID: 138489 RVA: 0x004B0C2E File Offset: 0x004AEE2E
		// (set) Token: 0x06021CFA RID: 138490 RVA: 0x004B0C36 File Offset: 0x004AEE36
		public byte NullMask { get; set; }

		// Token: 0x06021CFB RID: 138491 RVA: 0x004B0C3F File Offset: 0x004AEE3F
		public IEntityMatchPlayerT()
		{
			this.Type = EEntityMatchType.Player;
			this.MatchRoleOption = null;
			this.ChangeRoleTrigger = false;
			this.NullMask = 0;
		}
	}
}
