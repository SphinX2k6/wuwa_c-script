using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C8 RID: 28872
	public class ILimitPlayerCameraT
	{
		// Token: 0x1700D37C RID: 54140
		// (get) Token: 0x0603222F RID: 205359 RVA: 0x006C8BB2 File Offset: 0x006C6DB2
		// (set) Token: 0x06032230 RID: 205360 RVA: 0x006C8BBA File Offset: 0x006C6DBA
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x06032231 RID: 205361 RVA: 0x006C8BC3 File Offset: 0x006C6DC3
		public ILimitPlayerCameraT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
