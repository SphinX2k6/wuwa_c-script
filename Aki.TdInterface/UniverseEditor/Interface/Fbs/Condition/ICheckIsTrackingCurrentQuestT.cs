using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA3 RID: 19107
	public class ICheckIsTrackingCurrentQuestT
	{
		// Token: 0x17008A78 RID: 35448
		// (get) Token: 0x0601DFB4 RID: 122804 RVA: 0x004358CA File Offset: 0x00433ACA
		// (set) Token: 0x0601DFB5 RID: 122805 RVA: 0x004358D2 File Offset: 0x00433AD2
		public ECondition Type { get; set; }

		// Token: 0x0601DFB6 RID: 122806 RVA: 0x004358DB File Offset: 0x00433ADB
		public ICheckIsTrackingCurrentQuestT()
		{
			this.Type = ECondition.CompareVar;
		}
	}
}
