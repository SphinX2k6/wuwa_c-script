using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1C RID: 27420
	public class ICommonTipTypeT
	{
		// Token: 0x1700C95E RID: 51550
		// (get) Token: 0x0602F266 RID: 193126 RVA: 0x0066DBD2 File Offset: 0x0066BDD2
		// (set) Token: 0x0602F267 RID: 193127 RVA: 0x0066DBDA File Offset: 0x0066BDDA
		public ECommonTipType Type { get; set; }

		// Token: 0x0602F268 RID: 193128 RVA: 0x0066DBE3 File Offset: 0x0066BDE3
		public ICommonTipTypeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
		}
	}
}
