using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CFA RID: 23802
	public class IPatrolCycleOncelyT
	{
		// Token: 0x1700AEEB RID: 44779
		// (get) Token: 0x06027886 RID: 161926 RVA: 0x00568B72 File Offset: 0x00566D72
		// (set) Token: 0x06027887 RID: 161927 RVA: 0x00568B7A File Offset: 0x00566D7A
		public EPatrolCycleMode Type { get; set; }

		// Token: 0x06027888 RID: 161928 RVA: 0x00568B83 File Offset: 0x00566D83
		public IPatrolCycleOncelyT()
		{
			this.Type = EPatrolCycleMode.Loop;
		}
	}
}
