using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004915 RID: 18709
	public class IFindSunSpiritConfigT
	{
		// Token: 0x17008257 RID: 33367
		// (get) Token: 0x0601BBFF RID: 113663 RVA: 0x003EC7C5 File Offset: 0x003EA9C5
		// (set) Token: 0x0601BC00 RID: 113664 RVA: 0x003EC7CD File Offset: 0x003EA9CD
		public int Id { get; set; }

		// Token: 0x17008258 RID: 33368
		// (get) Token: 0x0601BC01 RID: 113665 RVA: 0x003EC7D6 File Offset: 0x003EA9D6
		// (set) Token: 0x0601BC02 RID: 113666 RVA: 0x003EC7DE File Offset: 0x003EA9DE
		public string Name { get; set; }

		// Token: 0x17008259 RID: 33369
		// (get) Token: 0x0601BC03 RID: 113667 RVA: 0x003EC7E7 File Offset: 0x003EA9E7
		// (set) Token: 0x0601BC04 RID: 113668 RVA: 0x003EC7EF File Offset: 0x003EA9EF
		public IFindSunSpiritLevelConfigT Level { get; set; }

		// Token: 0x0601BC05 RID: 113669 RVA: 0x003EC7F8 File Offset: 0x003EA9F8
		public IFindSunSpiritConfigT()
		{
			this.Id = 0;
			this.Name = null;
			this.Level = null;
		}
	}
}
