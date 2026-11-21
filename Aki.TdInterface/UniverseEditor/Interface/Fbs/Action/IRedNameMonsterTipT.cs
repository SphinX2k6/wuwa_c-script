using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007595 RID: 30101
	public class IRedNameMonsterTipT
	{
		// Token: 0x1700DD5E RID: 56670
		// (get) Token: 0x06034CCE RID: 216270 RVA: 0x0071966A File Offset: 0x0071786A
		// (set) Token: 0x06034CCF RID: 216271 RVA: 0x00719672 File Offset: 0x00717872
		public ECommonTipType Type { get; set; }

		// Token: 0x1700DD5F RID: 56671
		// (get) Token: 0x06034CD0 RID: 216272 RVA: 0x0071967B File Offset: 0x0071787B
		// (set) Token: 0x06034CD1 RID: 216273 RVA: 0x00719683 File Offset: 0x00717883
		public int MonsterId { get; set; }

		// Token: 0x1700DD60 RID: 56672
		// (get) Token: 0x06034CD2 RID: 216274 RVA: 0x0071968C File Offset: 0x0071788C
		// (set) Token: 0x06034CD3 RID: 216275 RVA: 0x00719694 File Offset: 0x00717894
		public float Duration { get; set; }

		// Token: 0x06034CD4 RID: 216276 RVA: 0x0071969D File Offset: 0x0071789D
		public IRedNameMonsterTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MonsterId = 0;
			this.Duration = 0f;
		}
	}
}
