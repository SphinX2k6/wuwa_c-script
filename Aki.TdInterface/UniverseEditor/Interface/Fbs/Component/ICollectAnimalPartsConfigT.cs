using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550F RID: 21775
	public class ICollectAnimalPartsConfigT
	{
		// Token: 0x17009B9F RID: 39839
		// (get) Token: 0x0602269B RID: 140955 RVA: 0x004BE151 File Offset: 0x004BC351
		// (set) Token: 0x0602269C RID: 140956 RVA: 0x004BE159 File Offset: 0x004BC359
		public ECollectAnimalPartSlot Slot { get; set; }

		// Token: 0x17009BA0 RID: 39840
		// (get) Token: 0x0602269D RID: 140957 RVA: 0x004BE162 File Offset: 0x004BC362
		// (set) Token: 0x0602269E RID: 140958 RVA: 0x004BE16A File Offset: 0x004BC36A
		public string Skeleton { get; set; }

		// Token: 0x17009BA1 RID: 39841
		// (get) Token: 0x0602269F RID: 140959 RVA: 0x004BE173 File Offset: 0x004BC373
		// (set) Token: 0x060226A0 RID: 140960 RVA: 0x004BE17B File Offset: 0x004BC37B
		public int CollectEntity { get; set; }

		// Token: 0x060226A1 RID: 140961 RVA: 0x004BE184 File Offset: 0x004BC384
		public ICollectAnimalPartsConfigT()
		{
			this.Slot = ECollectAnimalPartSlot.Slot0;
			this.Skeleton = null;
			this.CollectEntity = 0;
		}
	}
}
