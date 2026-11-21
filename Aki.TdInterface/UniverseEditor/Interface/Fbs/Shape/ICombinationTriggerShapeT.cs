using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200400B RID: 16395
	public class ICombinationTriggerShapeT
	{
		// Token: 0x17006F24 RID: 28452
		// (get) Token: 0x0601674F RID: 91983 RVA: 0x003373AF File Offset: 0x003355AF
		// (set) Token: 0x06016750 RID: 91984 RVA: 0x003373B7 File Offset: 0x003355B7
		public ETriggerShape Type { get; set; }

		// Token: 0x17006F25 RID: 28453
		// (get) Token: 0x06016751 RID: 91985 RVA: 0x003373C0 File Offset: 0x003355C0
		// (set) Token: 0x06016752 RID: 91986 RVA: 0x003373C8 File Offset: 0x003355C8
		public List<TCombinationTriggerShapeUnion> CombinationShapes { get; set; }

		// Token: 0x06016753 RID: 91987 RVA: 0x003373D1 File Offset: 0x003355D1
		public ICombinationTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.CombinationShapes = null;
		}
	}
}
