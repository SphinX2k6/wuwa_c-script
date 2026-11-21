using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007277 RID: 29303
	public class IMotorSoarInteractT
	{
		// Token: 0x1700D6D0 RID: 54992
		// (get) Token: 0x060330FC RID: 209148 RVA: 0x006E43D6 File Offset: 0x006E25D6
		// (set) Token: 0x060330FD RID: 209149 RVA: 0x006E43DE File Offset: 0x006E25DE
		public ELeisureInteract Type { get; set; }

		// Token: 0x060330FE RID: 209150 RVA: 0x006E43E7 File Offset: 0x006E25E7
		public IMotorSoarInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
