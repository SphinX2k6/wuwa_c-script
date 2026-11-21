using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550C RID: 21772
	public class ICollectAnimalConfigT
	{
		// Token: 0x17009B99 RID: 39833
		// (get) Token: 0x06022681 RID: 140929 RVA: 0x004BDE9B File Offset: 0x004BC09B
		// (set) Token: 0x06022682 RID: 140930 RVA: 0x004BDEA3 File Offset: 0x004BC0A3
		public ESpecialAnimalType Type { get; set; }

		// Token: 0x17009B9A RID: 39834
		// (get) Token: 0x06022683 RID: 140931 RVA: 0x004BDEAC File Offset: 0x004BC0AC
		// (set) Token: 0x06022684 RID: 140932 RVA: 0x004BDEB4 File Offset: 0x004BC0B4
		public List<ICollectAnimalPartsConfigT> PartsMap { get; set; }

		// Token: 0x06022685 RID: 140933 RVA: 0x004BDEBD File Offset: 0x004BC0BD
		public ICollectAnimalConfigT()
		{
			this.Type = ESpecialAnimalType.CollectAnimal;
			this.PartsMap = null;
		}
	}
}
