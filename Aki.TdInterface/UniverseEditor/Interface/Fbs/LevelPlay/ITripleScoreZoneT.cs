using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A3E RID: 19006
	public class ITripleScoreZoneT
	{
		// Token: 0x17008559 RID: 34137
		// (get) Token: 0x0601C8B4 RID: 116916 RVA: 0x004072D2 File Offset: 0x004054D2
		// (set) Token: 0x0601C8B5 RID: 116917 RVA: 0x004072DA File Offset: 0x004054DA
		public EDartboardZoneType Type { get; set; }

		// Token: 0x1700855A RID: 34138
		// (get) Token: 0x0601C8B6 RID: 116918 RVA: 0x004072E3 File Offset: 0x004054E3
		// (set) Token: 0x0601C8B7 RID: 116919 RVA: 0x004072EB File Offset: 0x004054EB
		public int Score { get; set; }

		// Token: 0x1700855B RID: 34139
		// (get) Token: 0x0601C8B8 RID: 116920 RVA: 0x004072F4 File Offset: 0x004054F4
		// (set) Token: 0x0601C8B9 RID: 116921 RVA: 0x004072FC File Offset: 0x004054FC
		public byte NullMask { get; set; }

		// Token: 0x0601C8BA RID: 116922 RVA: 0x00407305 File Offset: 0x00405505
		public ITripleScoreZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
			this.Score = 0;
			this.NullMask = 0;
		}
	}
}
