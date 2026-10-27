using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB3 RID: 20403
	public class ICollectAnimalPartsConfigT
	{
		// Token: 0x170093C7 RID: 37831
		// (get) Token: 0x060207A7 RID: 133031 RVA: 0x00484C6D File Offset: 0x00482E6D
		// (set) Token: 0x060207A8 RID: 133032 RVA: 0x00484C75 File Offset: 0x00482E75
		public ECollectAnimalPartSlot Slot { get; set; }

		// Token: 0x170093C8 RID: 37832
		// (get) Token: 0x060207A9 RID: 133033 RVA: 0x00484C7E File Offset: 0x00482E7E
		// (set) Token: 0x060207AA RID: 133034 RVA: 0x00484C86 File Offset: 0x00482E86
		public string Skeleton { get; set; }

		// Token: 0x170093C9 RID: 37833
		// (get) Token: 0x060207AB RID: 133035 RVA: 0x00484C8F File Offset: 0x00482E8F
		// (set) Token: 0x060207AC RID: 133036 RVA: 0x00484C97 File Offset: 0x00482E97
		public int CollectEntity { get; set; }

		// Token: 0x060207AD RID: 133037 RVA: 0x00484CA0 File Offset: 0x00482EA0
		public ICollectAnimalPartsConfigT()
		{
			this.Slot = ECollectAnimalPartSlot.Slot0;
			this.Skeleton = null;
			this.CollectEntity = 0;
		}
	}
}
