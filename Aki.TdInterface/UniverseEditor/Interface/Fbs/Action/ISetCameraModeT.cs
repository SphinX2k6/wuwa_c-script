using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779E RID: 30622
	public class ISetCameraModeT
	{
		// Token: 0x1700E05F RID: 57439
		// (get) Token: 0x06035C13 RID: 220179 RVA: 0x00733AF1 File Offset: 0x00731CF1
		// (set) Token: 0x06035C14 RID: 220180 RVA: 0x00733AF9 File Offset: 0x00731CF9
		public string Mode { get; set; }

		// Token: 0x06035C15 RID: 220181 RVA: 0x00733B02 File Offset: 0x00731D02
		public ISetCameraModeT()
		{
			this.Mode = null;
		}
	}
}
