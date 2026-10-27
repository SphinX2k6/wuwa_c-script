using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200699C RID: 27036
	public class LevelPlayContext : GeneralContext
	{
		// Token: 0x06043442 RID: 275522 RVA: 0x01065DD5 File Offset: 0x01063FD5
		public LevelPlayContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.LevelPlay);
		}

		// Token: 0x06043443 RID: 275523 RVA: 0x01065DE9 File Offset: 0x01063FE9
		public override void Reset()
		{
			this.LevelPlayId = 0;
		}

		// Token: 0x06043444 RID: 275524 RVA: 0x01065DF2 File Offset: 0x01063FF2
		[NullableContext(1)]
		public static LevelPlayContext Create(int levelPlayId = 0, GameCtxType? subType = null)
		{
			LevelPlayContext levelPlayContext = GeneralContext.GetObj(EGeneralContextType.LevelPlay, subType, () => new LevelPlayContext()) as LevelPlayContext;
			levelPlayContext.LevelPlayId = levelPlayId;
			return levelPlayContext;
		}

		// Token: 0x040230A8 RID: 143528
		public int LevelPlayId;
	}
}
