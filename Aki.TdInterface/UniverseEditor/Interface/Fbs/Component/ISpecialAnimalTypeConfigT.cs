using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596C RID: 22892
	public class ISpecialAnimalTypeConfigT
	{
		// Token: 0x1700ABD1 RID: 43985
		// (get) Token: 0x06026C11 RID: 158737 RVA: 0x00555E82 File Offset: 0x00554082
		// (set) Token: 0x06026C12 RID: 158738 RVA: 0x00555E8A File Offset: 0x0055408A
		public ESpecialAnimalType Type { get; set; }

		// Token: 0x06026C13 RID: 158739 RVA: 0x00555E93 File Offset: 0x00554093
		public ISpecialAnimalTypeConfigT()
		{
			this.Type = ESpecialAnimalType.CollectAnimal;
		}
	}
}
