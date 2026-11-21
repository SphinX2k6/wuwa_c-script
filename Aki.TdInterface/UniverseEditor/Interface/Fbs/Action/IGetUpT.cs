using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2D RID: 28461
	public class IGetUpT
	{
		// Token: 0x1700D0A2 RID: 53410
		// (get) Token: 0x0603140E RID: 201742 RVA: 0x006AC4F6 File Offset: 0x006AA6F6
		// (set) Token: 0x0603140F RID: 201743 RVA: 0x006AC4FE File Offset: 0x006AA6FE
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031410 RID: 201744 RVA: 0x006AC507 File Offset: 0x006AA707
		public IGetUpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
