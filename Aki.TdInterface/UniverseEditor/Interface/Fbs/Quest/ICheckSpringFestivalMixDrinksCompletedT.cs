using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D71 RID: 15729
	public class ICheckSpringFestivalMixDrinksCompletedT
	{
		// Token: 0x17006BF1 RID: 27633
		// (get) Token: 0x06015C51 RID: 89169 RVA: 0x003238AA File Offset: 0x00321AAA
		// (set) Token: 0x06015C52 RID: 89170 RVA: 0x003238B2 File Offset: 0x00321AB2
		public ESpringFestivalGameplayType Type { get; set; }

		// Token: 0x17006BF2 RID: 27634
		// (get) Token: 0x06015C53 RID: 89171 RVA: 0x003238BB File Offset: 0x00321ABB
		// (set) Token: 0x06015C54 RID: 89172 RVA: 0x003238C3 File Offset: 0x00321AC3
		public int Id { get; set; }

		// Token: 0x17006BF3 RID: 27635
		// (get) Token: 0x06015C55 RID: 89173 RVA: 0x003238CC File Offset: 0x00321ACC
		// (set) Token: 0x06015C56 RID: 89174 RVA: 0x003238D4 File Offset: 0x00321AD4
		public byte NullMask { get; set; }

		// Token: 0x06015C57 RID: 89175 RVA: 0x003238DD File Offset: 0x00321ADD
		public ICheckSpringFestivalMixDrinksCompletedT()
		{
			this.Type = ESpringFestivalGameplayType.MixDrinks;
			this.Id = 0;
			this.NullMask = 0;
		}
	}
}
