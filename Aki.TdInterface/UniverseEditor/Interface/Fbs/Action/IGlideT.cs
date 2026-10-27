using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006895 RID: 26773
	public class IGlideT
	{
		// Token: 0x1700C6C6 RID: 50886
		// (get) Token: 0x0602EB1A RID: 191258 RVA: 0x0065DC9E File Offset: 0x0065BE9E
		// (set) Token: 0x0602EB1B RID: 191259 RVA: 0x0065DCA6 File Offset: 0x0065BEA6
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602EB1C RID: 191260 RVA: 0x0065DCAF File Offset: 0x0065BEAF
		public IGlideT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
