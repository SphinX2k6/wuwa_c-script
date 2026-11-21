using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4F RID: 27471
	public class ICreatePrefabT
	{
		// Token: 0x1700C9B5 RID: 51637
		// (get) Token: 0x0602F46B RID: 193643 RVA: 0x0067459D File Offset: 0x0067279D
		// (set) Token: 0x0602F46C RID: 193644 RVA: 0x006745A5 File Offset: 0x006727A5
		public int PosEntityId { get; set; }

		// Token: 0x1700C9B6 RID: 51638
		// (get) Token: 0x0602F46D RID: 193645 RVA: 0x006745AE File Offset: 0x006727AE
		// (set) Token: 0x0602F46E RID: 193646 RVA: 0x006745B6 File Offset: 0x006727B6
		public TPrefabConfigUnion Config { get; set; }

		// Token: 0x1700C9B7 RID: 51639
		// (get) Token: 0x0602F46F RID: 193647 RVA: 0x006745BF File Offset: 0x006727BF
		// (set) Token: 0x0602F470 RID: 193648 RVA: 0x006745C7 File Offset: 0x006727C7
		public TVarRefUnion VarName { get; set; }

		// Token: 0x0602F471 RID: 193649 RVA: 0x006745D0 File Offset: 0x006727D0
		public ICreatePrefabT()
		{
			this.PosEntityId = 0;
			this.Config = null;
			this.VarName = null;
		}
	}
}
