using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006799 RID: 26521
	public class IFailurePoseInteractT
	{
		// Token: 0x1700C4E1 RID: 50401
		// (get) Token: 0x0602E266 RID: 189030 RVA: 0x0064DB83 File Offset: 0x0064BD83
		// (set) Token: 0x0602E267 RID: 189031 RVA: 0x0064DB8B File Offset: 0x0064BD8B
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C4E2 RID: 50402
		// (get) Token: 0x0602E268 RID: 189032 RVA: 0x0064DB94 File Offset: 0x0064BD94
		// (set) Token: 0x0602E269 RID: 189033 RVA: 0x0064DB9C File Offset: 0x0064BD9C
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0602E26A RID: 189034 RVA: 0x0064DBA5 File Offset: 0x0064BDA5
		public IFailurePoseInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Rot = null;
		}
	}
}
