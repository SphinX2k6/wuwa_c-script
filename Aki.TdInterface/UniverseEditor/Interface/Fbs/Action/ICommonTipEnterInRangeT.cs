using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B01 RID: 27393
	public class ICommonTipEnterInRangeT
	{
		// Token: 0x1700C92E RID: 51502
		// (get) Token: 0x0602F18A RID: 192906 RVA: 0x0066C78B File Offset: 0x0066A98B
		// (set) Token: 0x0602F18B RID: 192907 RVA: 0x0066C793 File Offset: 0x0066A993
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C92F RID: 51503
		// (get) Token: 0x0602F18C RID: 192908 RVA: 0x0066C79C File Offset: 0x0066A99C
		// (set) Token: 0x0602F18D RID: 192909 RVA: 0x0066C7A4 File Offset: 0x0066A9A4
		public string TidText { get; set; }

		// Token: 0x0602F18E RID: 192910 RVA: 0x0066C7AD File Offset: 0x0066A9AD
		public ICommonTipEnterInRangeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidText = null;
		}
	}
}
