using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004537 RID: 17719
	public class IOuterBullZoneT
	{
		// Token: 0x17007DAB RID: 32171
		// (get) Token: 0x0601AA5D RID: 109149 RVA: 0x003CD6D2 File Offset: 0x003CB8D2
		// (set) Token: 0x0601AA5E RID: 109150 RVA: 0x003CD6DA File Offset: 0x003CB8DA
		public EDartboardZoneType Type { get; set; }

		// Token: 0x0601AA5F RID: 109151 RVA: 0x003CD6E3 File Offset: 0x003CB8E3
		public IOuterBullZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
		}
	}
}
