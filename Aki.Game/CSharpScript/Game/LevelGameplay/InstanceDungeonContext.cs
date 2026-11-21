using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AF9 RID: 23289
	public class InstanceDungeonContext : GeneralContext
	{
		// Token: 0x0603947D RID: 234621 RVA: 0x0100A08E File Offset: 0x0100828E
		public InstanceDungeonContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.InstanceDungeon);
		}

		// Token: 0x0603947E RID: 234622 RVA: 0x0100A0AE File Offset: 0x010082AE
		public override void Reset()
		{
			this.InstanceDungeonId = new int?(0);
		}

		// Token: 0x0603947F RID: 234623 RVA: 0x0100A0BC File Offset: 0x010082BC
		[NullableContext(1)]
		public static InstanceDungeonContext Create(int instanceDungeonId = 0, int nodeId = 0, GameCtxType? subType = null)
		{
			InstanceDungeonContext instanceDungeonContext = GeneralContext.GetObj(EGeneralContextType.InstanceDungeon, subType, () => new InstanceDungeonContext()) as InstanceDungeonContext;
			instanceDungeonContext.InstanceDungeonId = new int?(instanceDungeonId);
			return instanceDungeonContext;
		}

		// Token: 0x0401E293 RID: 123539
		public int? InstanceDungeonId = new int?(0);
	}
}
