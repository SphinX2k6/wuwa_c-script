using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B16 RID: 27414
	public class ICommonTipReachChallengeT
	{
		// Token: 0x1700C953 RID: 51539
		// (get) Token: 0x0602F234 RID: 193076 RVA: 0x0066D747 File Offset: 0x0066B947
		// (set) Token: 0x0602F235 RID: 193077 RVA: 0x0066D74F File Offset: 0x0066B94F
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C954 RID: 51540
		// (get) Token: 0x0602F236 RID: 193078 RVA: 0x0066D758 File Offset: 0x0066B958
		// (set) Token: 0x0602F237 RID: 193079 RVA: 0x0066D760 File Offset: 0x0066B960
		public string TidMainText { get; set; }

		// Token: 0x0602F238 RID: 193080 RVA: 0x0066D769 File Offset: 0x0066B969
		public ICommonTipReachChallengeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
