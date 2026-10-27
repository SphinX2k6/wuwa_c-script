using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C94 RID: 27796
	public class IPerformSunSpiritGearRoundTripT
	{
		// Token: 0x1700CEFC RID: 52988
		// (get) Token: 0x06030FBB RID: 200635 RVA: 0x006A6640 File Offset: 0x006A4840
		// (set) Token: 0x06030FBC RID: 200636 RVA: 0x006A6648 File Offset: 0x006A4848
		public ESunSpiritGearRoundTripType PerformType { get; set; }

		// Token: 0x1700CEFD RID: 52989
		// (get) Token: 0x06030FBD RID: 200637 RVA: 0x006A6651 File Offset: 0x006A4851
		// (set) Token: 0x06030FBE RID: 200638 RVA: 0x006A6659 File Offset: 0x006A4859
		public int SunSpiritGearId { get; set; }

		// Token: 0x06030FBF RID: 200639 RVA: 0x006A6662 File Offset: 0x006A4862
		public IPerformSunSpiritGearRoundTripT()
		{
			this.PerformType = ESunSpiritGearRoundTripType.FlyToGear;
			this.SunSpiritGearId = 0;
		}
	}
}
