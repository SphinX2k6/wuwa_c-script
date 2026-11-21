using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005011 RID: 20497
	public class ICheckSpringFestivalAtmosphereLevelT
	{
		// Token: 0x170092A9 RID: 37545
		// (get) Token: 0x0601FFF5 RID: 131061 RVA: 0x00470C78 File Offset: 0x0046EE78
		// (set) Token: 0x0601FFF6 RID: 131062 RVA: 0x00470C80 File Offset: 0x0046EE80
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170092AA RID: 37546
		// (get) Token: 0x0601FFF7 RID: 131063 RVA: 0x00470C89 File Offset: 0x0046EE89
		// (set) Token: 0x0601FFF8 RID: 131064 RVA: 0x00470C91 File Offset: 0x0046EE91
		public int AtmosphereLevel { get; set; }

		// Token: 0x0601FFF9 RID: 131065 RVA: 0x00470C9A File Offset: 0x0046EE9A
		public ICheckSpringFestivalAtmosphereLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.AtmosphereLevel = 0;
		}
	}
}
