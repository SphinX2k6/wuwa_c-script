using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200507C RID: 20604
	public class IDefaultAttachTimingT
	{
		// Token: 0x1700957A RID: 38266
		// (get) Token: 0x0602107F RID: 135295 RVA: 0x00496946 File Offset: 0x00494B46
		// (set) Token: 0x06021080 RID: 135296 RVA: 0x0049694E File Offset: 0x00494B4E
		public EAttachTimingType Type { get; set; }

		// Token: 0x06021081 RID: 135297 RVA: 0x00496957 File Offset: 0x00494B57
		public IDefaultAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
		}
	}
}
