using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AF8 RID: 23288
	public class LevelPlayContext : GeneralContext
	{
		// Token: 0x0603947A RID: 234618 RVA: 0x0100A03D File Offset: 0x0100823D
		public LevelPlayContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.LevelPlay);
		}

		// Token: 0x0603947B RID: 234619 RVA: 0x0100A051 File Offset: 0x01008251
		public override void Reset()
		{
			this.LevelPlayId = 0;
		}

		// Token: 0x0603947C RID: 234620 RVA: 0x0100A05A File Offset: 0x0100825A
		[NullableContext(1)]
		public static LevelPlayContext Create(int levelPlayId = 0, GameCtxType? subType = null)
		{
			LevelPlayContext levelPlayContext = GeneralContext.GetObj(EGeneralContextType.LevelPlay, subType, () => new LevelPlayContext()) as LevelPlayContext;
			levelPlayContext.LevelPlayId = levelPlayId;
			return levelPlayContext;
		}

		// Token: 0x0401E292 RID: 123538
		public int LevelPlayId;
	}
}
