using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9E RID: 27294
	public class IMechStuntWaterT
	{
		// Token: 0x1700CA94 RID: 51860
		// (get) Token: 0x0602FD4A RID: 195914 RVA: 0x00681DCE File Offset: 0x0067FFCE
		// (set) Token: 0x0602FD4B RID: 195915 RVA: 0x00681DD6 File Offset: 0x0067FFD6
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FD4C RID: 195916 RVA: 0x00681DDF File Offset: 0x0067FFDF
		public IMechStuntWaterT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
