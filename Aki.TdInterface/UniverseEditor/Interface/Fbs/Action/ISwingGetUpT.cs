using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724B RID: 29259
	public class ISwingGetUpT
	{
		// Token: 0x1700D91A RID: 55578
		// (get) Token: 0x06033E5A RID: 212570 RVA: 0x006FB262 File Offset: 0x006F9462
		// (set) Token: 0x06033E5B RID: 212571 RVA: 0x006FB26A File Offset: 0x006F946A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06033E5C RID: 212572 RVA: 0x006FB273 File Offset: 0x006F9473
		public ISwingGetUpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
