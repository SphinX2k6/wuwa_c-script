using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DF RID: 16863
	public class IDangoAbyssInformationViewT
	{
		// Token: 0x170072E7 RID: 29415
		// (get) Token: 0x06017662 RID: 95842 RVA: 0x0035833A File Offset: 0x0035653A
		// (set) Token: 0x06017663 RID: 95843 RVA: 0x00358342 File Offset: 0x00356542
		public EInformationViewType Type { get; set; }

		// Token: 0x06017664 RID: 95844 RVA: 0x0035834B File Offset: 0x0035654B
		public IDangoAbyssInformationViewT()
		{
			this.Type = EInformationViewType.LevelPlay;
		}
	}
}
