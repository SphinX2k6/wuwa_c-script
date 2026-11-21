using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200499F RID: 18847
	public class IOuterBullZoneT
	{
		// Token: 0x170083EC RID: 33772
		// (get) Token: 0x0601C232 RID: 115250 RVA: 0x003F996E File Offset: 0x003F7B6E
		// (set) Token: 0x0601C233 RID: 115251 RVA: 0x003F9976 File Offset: 0x003F7B76
		public EDartboardZoneType Type { get; set; }

		// Token: 0x0601C234 RID: 115252 RVA: 0x003F997F File Offset: 0x003F7B7F
		public IOuterBullZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
		}
	}
}
