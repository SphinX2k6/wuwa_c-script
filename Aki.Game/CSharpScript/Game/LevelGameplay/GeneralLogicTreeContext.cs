using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AFF RID: 23295
	public class GeneralLogicTreeContext : GeneralContext
	{
		// Token: 0x0603948D RID: 234637 RVA: 0x0100A319 File Offset: 0x01008519
		public GeneralLogicTreeContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.GeneralLogicTree);
		}

		// Token: 0x0603948E RID: 234638 RVA: 0x0100A32D File Offset: 0x0100852D
		public override void Reset()
		{
			this.TreeIncId = 0L;
			this.NodeId = 0;
		}

		// Token: 0x0603948F RID: 234639 RVA: 0x0100A340 File Offset: 0x01008540
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

		// Token: 0x0401E29E RID: 123550
		public long TreeIncId;

		// Token: 0x0401E29F RID: 123551
		public int TreeConfigId;

		// Token: 0x0401E2A0 RID: 123552
		public int NodeId;

		// Token: 0x0401E2A1 RID: 123553
		public BtType BtType;
	}
}
