using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF7 RID: 23799
	public class IPatrolCycleLooplyT
	{
		// Token: 0x1700AEE7 RID: 44775
		// (get) Token: 0x06027872 RID: 161906 RVA: 0x005689D4 File Offset: 0x00566BD4
		// (set) Token: 0x06027873 RID: 161907 RVA: 0x005689DC File Offset: 0x00566BDC
		public EPatrolCycleMode Type { get; set; }

		// Token: 0x1700AEE8 RID: 44776
		// (get) Token: 0x06027874 RID: 161908 RVA: 0x005689E5 File Offset: 0x00566BE5
		// (set) Token: 0x06027875 RID: 161909 RVA: 0x005689ED File Offset: 0x00566BED
		public bool IsCircle { get; set; }

		// Token: 0x06027876 RID: 161910 RVA: 0x005689F6 File Offset: 0x00566BF6
		public IPatrolCycleLooplyT()
		{
			this.Type = EPatrolCycleMode.Loop;
			this.IsCircle = false;
		}
	}
}
