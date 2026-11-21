using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200502C RID: 20524
	public class ICheckSystemStateTypeT
	{
		// Token: 0x170092DD RID: 37597
		// (get) Token: 0x060200E5 RID: 131301 RVA: 0x0047292E File Offset: 0x00470B2E
		// (set) Token: 0x060200E6 RID: 131302 RVA: 0x00472936 File Offset: 0x00470B36
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x060200E7 RID: 131303 RVA: 0x0047293F File Offset: 0x00470B3F
		public ICheckSystemStateTypeT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
		}
	}
}
