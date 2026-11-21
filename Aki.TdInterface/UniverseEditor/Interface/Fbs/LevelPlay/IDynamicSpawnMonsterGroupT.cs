using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004909 RID: 18697
	public class IDynamicSpawnMonsterGroupT
	{
		// Token: 0x1700823A RID: 33338
		// (get) Token: 0x0601BB7F RID: 113535 RVA: 0x003EB808 File Offset: 0x003E9A08
		// (set) Token: 0x0601BB80 RID: 113536 RVA: 0x003EB810 File Offset: 0x003E9A10
		public int Id { get; set; }

		// Token: 0x1700823B RID: 33339
		// (get) Token: 0x0601BB81 RID: 113537 RVA: 0x003EB819 File Offset: 0x003E9A19
		// (set) Token: 0x0601BB82 RID: 113538 RVA: 0x003EB821 File Offset: 0x003E9A21
		public int Weight { get; set; }

		// Token: 0x0601BB83 RID: 113539 RVA: 0x003EB82A File Offset: 0x003E9A2A
		public IDynamicSpawnMonsterGroupT()
		{
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
