using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055DA RID: 21978
	public interface IFetterStarLvData
	{
		// Token: 0x17008706 RID: 34566
		// (get) Token: 0x06038006 RID: 229382
		// (set) Token: 0x06038007 RID: 229383
		int StageLv { get; set; }

		// Token: 0x17008707 RID: 34567
		// (get) Token: 0x06038008 RID: 229384
		// (set) Token: 0x06038009 RID: 229385
		int StageStarLv { get; set; }

		// Token: 0x17008708 RID: 34568
		// (get) Token: 0x0603800A RID: 229386
		// (set) Token: 0x0603800B RID: 229387
		int CurrentLv { get; set; }

		// Token: 0x17008709 RID: 34569
		// (get) Token: 0x0603800C RID: 229388
		// (set) Token: 0x0603800D RID: 229389
		int MaxLv { get; set; }
	}
}
