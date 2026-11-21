using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F36 RID: 28470
	public class IGlideT
	{
		// Token: 0x1700D0AC RID: 53420
		// (get) Token: 0x06031454 RID: 201812 RVA: 0x006ACD1E File Offset: 0x006AAF1E
		// (set) Token: 0x06031455 RID: 201813 RVA: 0x006ACD26 File Offset: 0x006AAF26
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031456 RID: 201814 RVA: 0x006ACD2F File Offset: 0x006AAF2F
		public IGlideT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
