using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC9 RID: 16073
	public class IScoreDisplayParamsT
	{
		// Token: 0x17006CD8 RID: 27864
		// (get) Token: 0x06015C26 RID: 89126 RVA: 0x003218EE File Offset: 0x0031FAEE
		// (set) Token: 0x06015C27 RID: 89127 RVA: 0x003218F6 File Offset: 0x0031FAF6
		public EScoreDisplayDataSource Type { get; set; }

		// Token: 0x06015C28 RID: 89128 RVA: 0x003218FF File Offset: 0x0031FAFF
		public IScoreDisplayParamsT()
		{
			this.Type = EScoreDisplayDataSource.Var;
		}
	}
}
