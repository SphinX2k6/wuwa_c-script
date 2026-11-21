using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA5 RID: 27301
	public class ICloseSkiConfigT
	{
		// Token: 0x1700C888 RID: 51336
		// (get) Token: 0x0602EDC0 RID: 191936 RVA: 0x0066295B File Offset: 0x00660B5B
		// (set) Token: 0x0602EDC1 RID: 191937 RVA: 0x00662963 File Offset: 0x00660B63
		public ESkiConfig Type { get; set; }

		// Token: 0x1700C889 RID: 51337
		// (get) Token: 0x0602EDC2 RID: 191938 RVA: 0x0066296C File Offset: 0x00660B6C
		// (set) Token: 0x0602EDC3 RID: 191939 RVA: 0x00662974 File Offset: 0x00660B74
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x0602EDC4 RID: 191940 RVA: 0x0066297D File Offset: 0x00660B7D
		public ICloseSkiConfigT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
		}
	}
}
