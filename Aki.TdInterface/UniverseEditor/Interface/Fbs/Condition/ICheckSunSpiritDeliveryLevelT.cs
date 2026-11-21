using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200501D RID: 20509
	public class ICheckSunSpiritDeliveryLevelT
	{
		// Token: 0x170092BF RID: 37567
		// (get) Token: 0x06020059 RID: 131161 RVA: 0x004716E4 File Offset: 0x0046F8E4
		// (set) Token: 0x0602005A RID: 131162 RVA: 0x004716EC File Offset: 0x0046F8EC
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170092C0 RID: 37568
		// (get) Token: 0x0602005B RID: 131163 RVA: 0x004716F5 File Offset: 0x0046F8F5
		// (set) Token: 0x0602005C RID: 131164 RVA: 0x004716FD File Offset: 0x0046F8FD
		public int Level { get; set; }

		// Token: 0x0602005D RID: 131165 RVA: 0x00471706 File Offset: 0x0046F906
		public ICheckSunSpiritDeliveryLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Level = 0;
		}
	}
}
