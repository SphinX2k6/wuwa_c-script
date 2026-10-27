using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007170 RID: 29040
	public class ISpawnEntityT
	{
		// Token: 0x1700D7C4 RID: 55236
		// (get) Token: 0x060337DF RID: 210911 RVA: 0x006EFE15 File Offset: 0x006EE015
		// (set) Token: 0x060337E0 RID: 210912 RVA: 0x006EFE1D File Offset: 0x006EE01D
		public int EntityDataId { get; set; }

		// Token: 0x1700D7C5 RID: 55237
		// (get) Token: 0x060337E1 RID: 210913 RVA: 0x006EFE26 File Offset: 0x006EE026
		// (set) Token: 0x060337E2 RID: 210914 RVA: 0x006EFE2E File Offset: 0x006EE02E
		public ITransformT Transform { get; set; }

		// Token: 0x1700D7C6 RID: 55238
		// (get) Token: 0x060337E3 RID: 210915 RVA: 0x006EFE37 File Offset: 0x006EE037
		// (set) Token: 0x060337E4 RID: 210916 RVA: 0x006EFE3F File Offset: 0x006EE03F
		public TVarRefUnion Save { get; set; }

		// Token: 0x060337E5 RID: 210917 RVA: 0x006EFE48 File Offset: 0x006EE048
		public ISpawnEntityT()
		{
			this.EntityDataId = 0;
			this.Transform = null;
			this.Save = null;
		}
	}
}
