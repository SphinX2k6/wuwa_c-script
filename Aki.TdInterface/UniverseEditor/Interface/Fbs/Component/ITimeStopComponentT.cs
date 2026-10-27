using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB8 RID: 23224
	public class ITimeStopComponentT
	{
		// Token: 0x1700AEE6 RID: 44774
		// (get) Token: 0x0602791E RID: 162078 RVA: 0x00571555 File Offset: 0x0056F755
		// (set) Token: 0x0602791F RID: 162079 RVA: 0x0057155D File Offset: 0x0056F75D
		public bool Disabled { get; set; }

		// Token: 0x1700AEE7 RID: 44775
		// (get) Token: 0x06027920 RID: 162080 RVA: 0x00571566 File Offset: 0x0056F766
		// (set) Token: 0x06027921 RID: 162081 RVA: 0x0057156E File Offset: 0x0056F76E
		public string ActiveState { get; set; }

		// Token: 0x1700AEE8 RID: 44776
		// (get) Token: 0x06027922 RID: 162082 RVA: 0x00571577 File Offset: 0x0056F777
		// (set) Token: 0x06027923 RID: 162083 RVA: 0x0057157F File Offset: 0x0056F77F
		public int StopTime { get; set; }

		// Token: 0x1700AEE9 RID: 44777
		// (get) Token: 0x06027924 RID: 162084 RVA: 0x00571588 File Offset: 0x0056F788
		// (set) Token: 0x06027925 RID: 162085 RVA: 0x00571590 File Offset: 0x0056F790
		public ITimeStopTargetT Target { get; set; }

		// Token: 0x1700AEEA RID: 44778
		// (get) Token: 0x06027926 RID: 162086 RVA: 0x00571599 File Offset: 0x0056F799
		// (set) Token: 0x06027927 RID: 162087 RVA: 0x005715A1 File Offset: 0x0056F7A1
		public byte NullMask { get; set; }

		// Token: 0x06027928 RID: 162088 RVA: 0x005715AA File Offset: 0x0056F7AA
		public ITimeStopComponentT()
		{
			this.Disabled = false;
			this.ActiveState = null;
			this.StopTime = 0;
			this.Target = null;
			this.NullMask = 0;
		}
	}
}
