using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006168 RID: 24936
	public class IAdjustPlayerCameraT
	{
		// Token: 0x1700B998 RID: 47512
		// (get) Token: 0x0602AE60 RID: 175712 RVA: 0x005EAF29 File Offset: 0x005E9129
		// (set) Token: 0x0602AE61 RID: 175713 RVA: 0x005EAF31 File Offset: 0x005E9131
		public TAdjustPlayerCameraOptionUnion Option { get; set; }

		// Token: 0x0602AE62 RID: 175714 RVA: 0x005EAF3A File Offset: 0x005E913A
		public IAdjustPlayerCameraT()
		{
			this.Option = null;
		}
	}
}
