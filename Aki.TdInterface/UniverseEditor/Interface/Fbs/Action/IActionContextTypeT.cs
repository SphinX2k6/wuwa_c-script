using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D7 RID: 26327
	public class IActionContextTypeT
	{
		// Token: 0x1700BF68 RID: 49000
		// (get) Token: 0x0602C3D0 RID: 181200 RVA: 0x00606152 File Offset: 0x00604352
		// (set) Token: 0x0602C3D1 RID: 181201 RVA: 0x0060615A File Offset: 0x0060435A
		public TActionContextType Type { get; set; }

		// Token: 0x0602C3D2 RID: 181202 RVA: 0x00606163 File Offset: 0x00604363
		public IActionContextTypeT()
		{
			this.Type = TActionContextType.commonBt;
		}
	}
}
