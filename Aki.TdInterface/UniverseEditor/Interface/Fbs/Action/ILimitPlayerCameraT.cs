using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A18 RID: 27160
	public class ILimitPlayerCameraT
	{
		// Token: 0x1700C97C RID: 51580
		// (get) Token: 0x0602F86F RID: 194671 RVA: 0x0067885A File Offset: 0x00676A5A
		// (set) Token: 0x0602F870 RID: 194672 RVA: 0x00678862 File Offset: 0x00676A62
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0602F871 RID: 194673 RVA: 0x0067886B File Offset: 0x00676A6B
		public ILimitPlayerCameraT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
