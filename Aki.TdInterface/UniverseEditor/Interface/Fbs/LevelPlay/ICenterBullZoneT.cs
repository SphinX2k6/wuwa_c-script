using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004441 RID: 17473
	public class ICenterBullZoneT
	{
		// Token: 0x17007B1C RID: 31516
		// (get) Token: 0x06019FF0 RID: 106480 RVA: 0x003B74F2 File Offset: 0x003B56F2
		// (set) Token: 0x06019FF1 RID: 106481 RVA: 0x003B74FA File Offset: 0x003B56FA
		public EDartboardZoneType Type { get; set; }

		// Token: 0x06019FF2 RID: 106482 RVA: 0x003B7503 File Offset: 0x003B5703
		public ICenterBullZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
		}
	}
}
