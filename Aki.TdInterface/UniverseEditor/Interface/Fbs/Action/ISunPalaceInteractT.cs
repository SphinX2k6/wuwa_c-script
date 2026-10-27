using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723F RID: 29247
	public class ISunPalaceInteractT
	{
		// Token: 0x1700D906 RID: 55558
		// (get) Token: 0x06033E00 RID: 212480 RVA: 0x006FA9A6 File Offset: 0x006F8BA6
		// (set) Token: 0x06033E01 RID: 212481 RVA: 0x006FA9AE File Offset: 0x006F8BAE
		public ELeisureInteract Type { get; set; }

		// Token: 0x06033E02 RID: 212482 RVA: 0x006FA9B7 File Offset: 0x006F8BB7
		public ISunPalaceInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
