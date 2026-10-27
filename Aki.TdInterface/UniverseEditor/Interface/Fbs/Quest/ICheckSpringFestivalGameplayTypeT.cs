using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D68 RID: 15720
	public class ICheckSpringFestivalGameplayTypeT
	{
		// Token: 0x17006BE3 RID: 27619
		// (get) Token: 0x06015C13 RID: 89107 RVA: 0x0032329A File Offset: 0x0032149A
		// (set) Token: 0x06015C14 RID: 89108 RVA: 0x003232A2 File Offset: 0x003214A2
		public ESpringFestivalGameplayType Type { get; set; }

		// Token: 0x06015C15 RID: 89109 RVA: 0x003232AB File Offset: 0x003214AB
		public ICheckSpringFestivalGameplayTypeT()
		{
			this.Type = ESpringFestivalGameplayType.MixDrinks;
		}
	}
}
