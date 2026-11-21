using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AFD RID: 23293
	public class PlotContext : GeneralContext
	{
		// Token: 0x06039487 RID: 234631 RVA: 0x0100A219 File Offset: 0x01008419
		public PlotContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Plot);
		}

		// Token: 0x06039488 RID: 234632 RVA: 0x0100A22E File Offset: 0x0100842E
		public override void Reset()
		{
			this.FlowIncId = 0L;
		}

		// Token: 0x06039489 RID: 234633 RVA: 0x0100A238 File Offset: 0x01008438
		[NullableContext(1)]
		public static PlotContext Create(long flowIncId, GameCtxType? subType = null)
		{
			PlotContext plotContext = GeneralContext.GetObj(EGeneralContextType.Plot, subType, () => new PlotContext()) as PlotContext;
			plotContext.FlowIncId = flowIncId;
			return plotContext;
		}

		// Token: 0x0401E299 RID: 123545
		public long FlowIncId;
	}
}
