using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2D RID: 27181
	public class ILimitPlayerUIT
	{
		// Token: 0x1700C99C RID: 51612
		// (get) Token: 0x0602F914 RID: 194836 RVA: 0x00679A52 File Offset: 0x00677C52
		// (set) Token: 0x0602F915 RID: 194837 RVA: 0x00679A5A File Offset: 0x00677C5A
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0602F916 RID: 194838 RVA: 0x00679A63 File Offset: 0x00677C63
		public ILimitPlayerUIT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
