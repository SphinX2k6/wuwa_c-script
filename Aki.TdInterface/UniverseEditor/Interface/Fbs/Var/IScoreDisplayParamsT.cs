using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC7 RID: 15047
	public class IScoreDisplayParamsT
	{
		// Token: 0x1700673D RID: 26429
		// (get) Token: 0x0601477C RID: 83836 RVA: 0x002FB65E File Offset: 0x002F985E
		// (set) Token: 0x0601477D RID: 83837 RVA: 0x002FB666 File Offset: 0x002F9866
		public EScoreDisplayDataSource Type { get; set; }

		// Token: 0x0601477E RID: 83838 RVA: 0x002FB66F File Offset: 0x002F986F
		public IScoreDisplayParamsT()
		{
			this.Type = EScoreDisplayDataSource.Var;
		}
	}
}
