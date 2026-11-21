using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F79 RID: 24441
	public class ISpecialAnimalTypeConfigT
	{
		// Token: 0x1700B505 RID: 46341
		// (get) Token: 0x0602917B RID: 168315 RVA: 0x0059CAEE File Offset: 0x0059ACEE
		// (set) Token: 0x0602917C RID: 168316 RVA: 0x0059CAF6 File Offset: 0x0059ACF6
		public ESpecialAnimalType Type { get; set; }

		// Token: 0x0602917D RID: 168317 RVA: 0x0059CAFF File Offset: 0x0059ACFF
		public ISpecialAnimalTypeConfigT()
		{
			this.Type = ESpecialAnimalType.CollectAnimal;
		}
	}
}
