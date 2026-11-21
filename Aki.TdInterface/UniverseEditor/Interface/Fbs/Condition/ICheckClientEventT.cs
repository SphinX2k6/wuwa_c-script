using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E58 RID: 20056
	public class ICheckClientEventT
	{
		// Token: 0x17008EF3 RID: 36595
		// (get) Token: 0x0601F0A7 RID: 127143 RVA: 0x0045539D File Offset: 0x0045359D
		// (set) Token: 0x0601F0A8 RID: 127144 RVA: 0x004553A5 File Offset: 0x004535A5
		public ECondition Type { get; set; }

		// Token: 0x17008EF4 RID: 36596
		// (get) Token: 0x0601F0A9 RID: 127145 RVA: 0x004553AE File Offset: 0x004535AE
		// (set) Token: 0x0601F0AA RID: 127146 RVA: 0x004553B6 File Offset: 0x004535B6
		public string EventName { get; set; }

		// Token: 0x17008EF5 RID: 36597
		// (get) Token: 0x0601F0AB RID: 127147 RVA: 0x004553BF File Offset: 0x004535BF
		// (set) Token: 0x0601F0AC RID: 127148 RVA: 0x004553C7 File Offset: 0x004535C7
		public ISelfClientEventT ListenerTarget { get; set; }

		// Token: 0x0601F0AD RID: 127149 RVA: 0x004553D0 File Offset: 0x004535D0
		public ICheckClientEventT()
		{
			this.Type = ECondition.CompareVar;
			this.EventName = null;
			this.ListenerTarget = null;
		}
	}
}
