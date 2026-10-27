using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711C RID: 28956
	public class ISitOnGroundT
	{
		// Token: 0x1700D744 RID: 55108
		// (get) Token: 0x06033571 RID: 210289 RVA: 0x006EB9E2 File Offset: 0x006E9BE2
		// (set) Token: 0x06033572 RID: 210290 RVA: 0x006EB9EA File Offset: 0x006E9BEA
		public ELeisureInteract Type { get; set; }

		// Token: 0x06033573 RID: 210291 RVA: 0x006EB9F3 File Offset: 0x006E9BF3
		public ISitOnGroundT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
