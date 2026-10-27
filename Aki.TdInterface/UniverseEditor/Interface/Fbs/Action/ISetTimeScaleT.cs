using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007098 RID: 28824
	public class ISetTimeScaleT
	{
		// Token: 0x1700D62D RID: 54829
		// (get) Token: 0x060330AA RID: 209066 RVA: 0x006E277D File Offset: 0x006E097D
		// (set) Token: 0x060330AB RID: 209067 RVA: 0x006E2785 File Offset: 0x006E0985
		public ISetGlobalTimeScaleT Config { get; set; }

		// Token: 0x060330AC RID: 209068 RVA: 0x006E278E File Offset: 0x006E098E
		public ISetTimeScaleT()
		{
			this.Config = null;
		}
	}
}
