using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B2A RID: 19242
	public class ICheckSpringFestivalAtmosphereLevelT
	{
		// Token: 0x17008B99 RID: 35737
		// (get) Token: 0x0601E46A RID: 124010 RVA: 0x0043E4CC File Offset: 0x0043C6CC
		// (set) Token: 0x0601E46B RID: 124011 RVA: 0x0043E4D4 File Offset: 0x0043C6D4
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008B9A RID: 35738
		// (get) Token: 0x0601E46C RID: 124012 RVA: 0x0043E4DD File Offset: 0x0043C6DD
		// (set) Token: 0x0601E46D RID: 124013 RVA: 0x0043E4E5 File Offset: 0x0043C6E5
		public int AtmosphereLevel { get; set; }

		// Token: 0x0601E46E RID: 124014 RVA: 0x0043E4EE File Offset: 0x0043C6EE
		public ICheckSpringFestivalAtmosphereLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.AtmosphereLevel = 0;
		}
	}
}
