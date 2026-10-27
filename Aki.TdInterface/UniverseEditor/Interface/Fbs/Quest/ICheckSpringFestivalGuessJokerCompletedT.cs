using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D6E RID: 15726
	public class ICheckSpringFestivalGuessJokerCompletedT
	{
		// Token: 0x17006BEA RID: 27626
		// (get) Token: 0x06015C37 RID: 89143 RVA: 0x0032361A File Offset: 0x0032181A
		// (set) Token: 0x06015C38 RID: 89144 RVA: 0x00323622 File Offset: 0x00321822
		public ESpringFestivalGameplayType Type { get; set; }

		// Token: 0x17006BEB RID: 27627
		// (get) Token: 0x06015C39 RID: 89145 RVA: 0x0032362B File Offset: 0x0032182B
		// (set) Token: 0x06015C3A RID: 89146 RVA: 0x00323633 File Offset: 0x00321833
		public int Id { get; set; }

		// Token: 0x17006BEC RID: 27628
		// (get) Token: 0x06015C3B RID: 89147 RVA: 0x0032363C File Offset: 0x0032183C
		// (set) Token: 0x06015C3C RID: 89148 RVA: 0x00323644 File Offset: 0x00321844
		public byte NullMask { get; set; }

		// Token: 0x06015C3D RID: 89149 RVA: 0x0032364D File Offset: 0x0032184D
		public ICheckSpringFestivalGuessJokerCompletedT()
		{
			this.Type = ESpringFestivalGameplayType.MixDrinks;
			this.Id = 0;
			this.NullMask = 0;
		}
	}
}
