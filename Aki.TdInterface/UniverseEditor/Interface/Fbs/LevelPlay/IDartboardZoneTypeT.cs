using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048CD RID: 18637
	public class IDartboardZoneTypeT
	{
		// Token: 0x170081D1 RID: 33233
		// (get) Token: 0x0601B951 RID: 112977 RVA: 0x003E693E File Offset: 0x003E4B3E
		// (set) Token: 0x0601B952 RID: 112978 RVA: 0x003E6946 File Offset: 0x003E4B46
		public EDartboardZoneType Type { get; set; }

		// Token: 0x0601B953 RID: 112979 RVA: 0x003E694F File Offset: 0x003E4B4F
		public IDartboardZoneTypeT()
		{
			this.Type = EDartboardZoneType.CenterBull;
		}
	}
}
