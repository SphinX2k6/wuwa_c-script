using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A1 RID: 27041
	public class PlotContext : GeneralContext
	{
		// Token: 0x0604344F RID: 275535 RVA: 0x01065FB1 File Offset: 0x010641B1
		public PlotContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Plot);
		}

		// Token: 0x06043450 RID: 275536 RVA: 0x01065FC6 File Offset: 0x010641C6
		public override void Reset()
		{
			this.FlowIncId = 0L;
		}

		// Token: 0x06043451 RID: 275537 RVA: 0x01065FD0 File Offset: 0x010641D0
		[NullableContext(1)]
		public static PlotContext Create(long flowIncId, GameCtxType? subType = null)
		{
			PlotContext plotContext = GeneralContext.GetObj(EGeneralContextType.Plot, subType, () => new PlotContext()) as PlotContext;
			plotContext.FlowIncId = flowIncId;
			return plotContext;
		}

		// Token: 0x040230AF RID: 143535
		public long FlowIncId;
	}
}
