using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200699D RID: 27037
	public class InstanceDungeonContext : GeneralContext
	{
		// Token: 0x06043445 RID: 275525 RVA: 0x01065E26 File Offset: 0x01064026
		public InstanceDungeonContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.InstanceDungeon);
		}

		// Token: 0x06043446 RID: 275526 RVA: 0x01065E46 File Offset: 0x01064046
		public override void Reset()
		{
			this.InstanceDungeonId = new int?(0);
		}

		// Token: 0x06043447 RID: 275527 RVA: 0x01065E54 File Offset: 0x01064054
		[NullableContext(1)]
		public static InstanceDungeonContext Create(int instanceDungeonId = 0, int nodeId = 0, GameCtxType? subType = null)
		{
			InstanceDungeonContext instanceDungeonContext = GeneralContext.GetObj(EGeneralContextType.InstanceDungeon, subType, () => new InstanceDungeonContext()) as InstanceDungeonContext;
			instanceDungeonContext.InstanceDungeonId = new int?(instanceDungeonId);
			return instanceDungeonContext;
		}

		// Token: 0x040230A9 RID: 143529
		public int? InstanceDungeonId = new int?(0);
	}
}
