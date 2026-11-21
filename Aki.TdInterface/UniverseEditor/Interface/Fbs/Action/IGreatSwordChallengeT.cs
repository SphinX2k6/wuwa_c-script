using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F42 RID: 28482
	public class IGreatSwordChallengeT
	{
		// Token: 0x1700D0C2 RID: 53442
		// (get) Token: 0x060314BC RID: 201916 RVA: 0x006AD834 File Offset: 0x006ABA34
		// (set) Token: 0x060314BD RID: 201917 RVA: 0x006AD83C File Offset: 0x006ABA3C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D0C3 RID: 53443
		// (get) Token: 0x060314BE RID: 201918 RVA: 0x006AD845 File Offset: 0x006ABA45
		// (set) Token: 0x060314BF RID: 201919 RVA: 0x006AD84D File Offset: 0x006ABA4D
		public string MainText { get; set; }

		// Token: 0x1700D0C4 RID: 53444
		// (get) Token: 0x060314C0 RID: 201920 RVA: 0x006AD856 File Offset: 0x006ABA56
		// (set) Token: 0x060314C1 RID: 201921 RVA: 0x006AD85E File Offset: 0x006ABA5E
		public string SubText { get; set; }

		// Token: 0x060314C2 RID: 201922 RVA: 0x006AD867 File Offset: 0x006ABA67
		public IGreatSwordChallengeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
			this.SubText = null;
		}
	}
}
