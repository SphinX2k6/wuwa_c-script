using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C01 RID: 23553
	[NullableContext(1)]
	public interface IBossPilingLevelDescInfo
	{
		// Token: 0x17008D8B RID: 36235
		// (get) Token: 0x0603B875 RID: 243829
		// (set) Token: 0x0603B876 RID: 243830
		bool IsFirstLevel { get; set; }

		// Token: 0x17008D8C RID: 36236
		// (get) Token: 0x0603B877 RID: 243831
		// (set) Token: 0x0603B878 RID: 243832
		int LevelId { get; set; }

		// Token: 0x17008D8D RID: 36237
		// (get) Token: 0x0603B879 RID: 243833
		// (set) Token: 0x0603B87A RID: 243834
		string LevelMechanism { get; set; }

		// Token: 0x17008D8E RID: 36238
		// (get) Token: 0x0603B87B RID: 243835
		// (set) Token: 0x0603B87C RID: 243836
		string MonsterDesc { get; set; }

		// Token: 0x17008D8F RID: 36239
		// (get) Token: 0x0603B87D RID: 243837
		// (set) Token: 0x0603B87E RID: 243838
		string LevelDesc { get; set; }
	}
}
