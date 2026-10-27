using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A3 RID: 27043
	public class GeneralLogicTreeContext : GeneralContext
	{
		// Token: 0x06043455 RID: 275541 RVA: 0x010660B1 File Offset: 0x010642B1
		public GeneralLogicTreeContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.GeneralLogicTree);
		}

		// Token: 0x06043456 RID: 275542 RVA: 0x010660C5 File Offset: 0x010642C5
		public override void Reset()
		{
			this.TreeIncId = 0L;
			this.NodeId = 0;
		}

		// Token: 0x06043457 RID: 275543 RVA: 0x010660D8 File Offset: 0x010642D8
		[NullableContext(1)]
		public static GeneralLogicTreeContext Create(BtType btType, long treeIncId = 0L, int treeConfigId = 0, int nodeId = 0, GameCtxType? subType = null)
		{
			GeneralLogicTreeContext generalLogicTreeContext = GeneralContext.GetObj(EGeneralContextType.GeneralLogicTree, subType, () => new GeneralLogicTreeContext()) as GeneralLogicTreeContext;
			generalLogicTreeContext.BtType = btType;
			generalLogicTreeContext.TreeIncId = treeIncId;
			generalLogicTreeContext.TreeConfigId = treeConfigId;
			generalLogicTreeContext.NodeId = nodeId;
			return generalLogicTreeContext;
		}

		// Token: 0x040230B4 RID: 143540
		public long TreeIncId;

		// Token: 0x040230B5 RID: 143541
		public int TreeConfigId;

		// Token: 0x040230B6 RID: 143542
		public int NodeId;

		// Token: 0x040230B7 RID: 143543
		public BtType BtType;
	}
}
