using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F00 RID: 28416
	public class IFrequencyDetectionTipT
	{
		// Token: 0x1700D067 RID: 53351
		// (get) Token: 0x060312C9 RID: 201417 RVA: 0x006AA30B File Offset: 0x006A850B
		// (set) Token: 0x060312CA RID: 201418 RVA: 0x006AA313 File Offset: 0x006A8513
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D068 RID: 53352
		// (get) Token: 0x060312CB RID: 201419 RVA: 0x006AA31C File Offset: 0x006A851C
		// (set) Token: 0x060312CC RID: 201420 RVA: 0x006AA324 File Offset: 0x006A8524
		public ICommonTalkMessageT Content { get; set; }

		// Token: 0x060312CD RID: 201421 RVA: 0x006AA32D File Offset: 0x006A852D
		public IFrequencyDetectionTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.Content = null;
		}
	}
}
