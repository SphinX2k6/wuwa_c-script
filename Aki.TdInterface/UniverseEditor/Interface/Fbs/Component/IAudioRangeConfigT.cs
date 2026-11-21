using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540A RID: 21514
	public class IAudioRangeConfigT
	{
		// Token: 0x1700985B RID: 39003
		// (get) Token: 0x06021A5F RID: 137823 RVA: 0x004A3605 File Offset: 0x004A1805
		// (set) Token: 0x06021A60 RID: 137824 RVA: 0x004A360D File Offset: 0x004A180D
		public string LeaveAkEvent { get; set; }

		// Token: 0x06021A61 RID: 137825 RVA: 0x004A3616 File Offset: 0x004A1816
		public IAudioRangeConfigT()
		{
			this.LeaveAkEvent = null;
		}
	}
}
