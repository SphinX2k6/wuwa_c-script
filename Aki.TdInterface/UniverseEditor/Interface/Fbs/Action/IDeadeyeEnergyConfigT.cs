using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006550 RID: 25936
	public class IDeadeyeEnergyConfigT
	{
		// Token: 0x1700C0CE RID: 49358
		// (get) Token: 0x0602D010 RID: 184336 RVA: 0x0062D6DE File Offset: 0x0062B8DE
		// (set) Token: 0x0602D011 RID: 184337 RVA: 0x0062D6E6 File Offset: 0x0062B8E6
		public int MaxEnergy { get; set; }

		// Token: 0x1700C0CF RID: 49359
		// (get) Token: 0x0602D012 RID: 184338 RVA: 0x0062D6EF File Offset: 0x0062B8EF
		// (set) Token: 0x0602D013 RID: 184339 RVA: 0x0062D6F7 File Offset: 0x0062B8F7
		public int BulletConsumption { get; set; }

		// Token: 0x1700C0D0 RID: 49360
		// (get) Token: 0x0602D014 RID: 184340 RVA: 0x0062D700 File Offset: 0x0062B900
		// (set) Token: 0x0602D015 RID: 184341 RVA: 0x0062D708 File Offset: 0x0062B908
		public int TimeConsumption { get; set; }

		// Token: 0x0602D016 RID: 184342 RVA: 0x0062D711 File Offset: 0x0062B911
		public IDeadeyeEnergyConfigT()
		{
			this.MaxEnergy = 0;
			this.BulletConsumption = 0;
			this.TimeConsumption = 0;
		}
	}
}
