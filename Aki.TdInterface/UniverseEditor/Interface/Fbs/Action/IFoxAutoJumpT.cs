using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006859 RID: 26713
	public class IFoxAutoJumpT
	{
		// Token: 0x1700C667 RID: 50791
		// (get) Token: 0x0602E93F RID: 190783 RVA: 0x0065A9B3 File Offset: 0x00658BB3
		// (set) Token: 0x0602E940 RID: 190784 RVA: 0x0065A9BB File Offset: 0x00658BBB
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C668 RID: 50792
		// (get) Token: 0x0602E941 RID: 190785 RVA: 0x0065A9C4 File Offset: 0x00658BC4
		// (set) Token: 0x0602E942 RID: 190786 RVA: 0x0065A9CC File Offset: 0x00658BCC
		public IVectorInfoT LandPosition { get; set; }

		// Token: 0x0602E943 RID: 190787 RVA: 0x0065A9D5 File Offset: 0x00658BD5
		public IFoxAutoJumpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.LandPosition = null;
		}
	}
}
