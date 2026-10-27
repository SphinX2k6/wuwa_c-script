using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B31 RID: 27441
	public class IMotorSoarInteractT
	{
		// Token: 0x1700CBEB RID: 52203
		// (get) Token: 0x060302A5 RID: 197285 RVA: 0x0068BE1A File Offset: 0x0068A01A
		// (set) Token: 0x060302A6 RID: 197286 RVA: 0x0068BE22 File Offset: 0x0068A022
		public ELeisureInteract Type { get; set; }

		// Token: 0x060302A7 RID: 197287 RVA: 0x0068BE2B File Offset: 0x0068A02B
		public IMotorSoarInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
