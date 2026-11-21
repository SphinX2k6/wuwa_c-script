using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004188 RID: 16776
	public class ICheckSpringFestivalMixDrinksCompletedT
	{
		// Token: 0x170071AB RID: 29099
		// (get) Token: 0x06017189 RID: 94601 RVA: 0x0034AB22 File Offset: 0x00348D22
		// (set) Token: 0x0601718A RID: 94602 RVA: 0x0034AB2A File Offset: 0x00348D2A
		public ESpringFestivalGameplayType Type { get; set; }

		// Token: 0x170071AC RID: 29100
		// (get) Token: 0x0601718B RID: 94603 RVA: 0x0034AB33 File Offset: 0x00348D33
		// (set) Token: 0x0601718C RID: 94604 RVA: 0x0034AB3B File Offset: 0x00348D3B
		public int Id { get; set; }

		// Token: 0x170071AD RID: 29101
		// (get) Token: 0x0601718D RID: 94605 RVA: 0x0034AB44 File Offset: 0x00348D44
		// (set) Token: 0x0601718E RID: 94606 RVA: 0x0034AB4C File Offset: 0x00348D4C
		public byte NullMask { get; set; }

		// Token: 0x0601718F RID: 94607 RVA: 0x0034AB55 File Offset: 0x00348D55
		public ICheckSpringFestivalMixDrinksCompletedT()
		{
			this.Type = ESpringFestivalGameplayType.MixDrinks;
			this.Id = 0;
			this.NullMask = 0;
		}
	}
}
