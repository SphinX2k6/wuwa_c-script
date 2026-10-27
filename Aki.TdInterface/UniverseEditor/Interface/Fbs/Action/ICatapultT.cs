using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B5 RID: 25269
	public class ICatapultT
	{
		// Token: 0x1700BCA2 RID: 48290
		// (get) Token: 0x0602BAAF RID: 178863 RVA: 0x00602B6B File Offset: 0x00600D6B
		// (set) Token: 0x0602BAB0 RID: 178864 RVA: 0x00602B73 File Offset: 0x00600D73
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700BCA3 RID: 48291
		// (get) Token: 0x0602BAB1 RID: 178865 RVA: 0x00602B7C File Offset: 0x00600D7C
		// (set) Token: 0x0602BAB2 RID: 178866 RVA: 0x00602B84 File Offset: 0x00600D84
		public ICatapultParamT Param { get; set; }

		// Token: 0x0602BAB3 RID: 178867 RVA: 0x00602B8D File Offset: 0x00600D8D
		public ICatapultT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Param = null;
		}
	}
}
