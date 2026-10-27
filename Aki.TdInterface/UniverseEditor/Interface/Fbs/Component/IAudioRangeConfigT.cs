using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EDB RID: 20187
	public class IAudioRangeConfigT
	{
		// Token: 0x170090E8 RID: 37096
		// (get) Token: 0x0601FD1B RID: 130331 RVA: 0x0046D835 File Offset: 0x0046BA35
		// (set) Token: 0x0601FD1C RID: 130332 RVA: 0x0046D83D File Offset: 0x0046BA3D
		public string LeaveAkEvent { get; set; }

		// Token: 0x0601FD1D RID: 130333 RVA: 0x0046D846 File Offset: 0x0046BA46
		public IAudioRangeConfigT()
		{
			this.LeaveAkEvent = null;
		}
	}
}
