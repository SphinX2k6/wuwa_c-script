using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200792A RID: 31018
	public class ISoarT
	{
		// Token: 0x1700E38F RID: 58255
		// (get) Token: 0x06036A04 RID: 223748 RVA: 0x0074F64E File Offset: 0x0074D84E
		// (set) Token: 0x06036A05 RID: 223749 RVA: 0x0074F656 File Offset: 0x0074D856
		public ELeisureInteract Type { get; set; }

		// Token: 0x06036A06 RID: 223750 RVA: 0x0074F65F File Offset: 0x0074D85F
		public ISoarT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
