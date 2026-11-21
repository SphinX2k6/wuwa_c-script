using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACC RID: 23244
	public class IMechHookAccelerationT
	{
		// Token: 0x1700A976 RID: 43382
		// (get) Token: 0x0602622D RID: 156205 RVA: 0x005399CB File Offset: 0x00537BCB
		// (set) Token: 0x0602622E RID: 156206 RVA: 0x005399D3 File Offset: 0x00537BD3
		public int MaxSpeed { get; set; }

		// Token: 0x1700A977 RID: 43383
		// (get) Token: 0x0602622F RID: 156207 RVA: 0x005399DC File Offset: 0x00537BDC
		// (set) Token: 0x06026230 RID: 156208 RVA: 0x005399E4 File Offset: 0x00537BE4
		public string SpeedSampleCurve { get; set; }

		// Token: 0x06026231 RID: 156209 RVA: 0x005399ED File Offset: 0x00537BED
		public IMechHookAccelerationT()
		{
			this.MaxSpeed = 0;
			this.SpeedSampleCurve = null;
		}
	}
}
