using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E19 RID: 28185
	public class IFailurePoseInteractT
	{
		// Token: 0x1700CE97 RID: 52887
		// (get) Token: 0x06030AAC RID: 199340 RVA: 0x0069B2C7 File Offset: 0x006994C7
		// (set) Token: 0x06030AAD RID: 199341 RVA: 0x0069B2CF File Offset: 0x006994CF
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CE98 RID: 52888
		// (get) Token: 0x06030AAE RID: 199342 RVA: 0x0069B2D8 File Offset: 0x006994D8
		// (set) Token: 0x06030AAF RID: 199343 RVA: 0x0069B2E0 File Offset: 0x006994E0
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06030AB0 RID: 199344 RVA: 0x0069B2E9 File Offset: 0x006994E9
		public IFailurePoseInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Rot = null;
		}
	}
}
