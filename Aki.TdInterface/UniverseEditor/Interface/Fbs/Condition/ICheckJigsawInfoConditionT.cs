using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F7E RID: 20350
	public class ICheckJigsawInfoConditionT
	{
		// Token: 0x17009182 RID: 37250
		// (get) Token: 0x0601FB11 RID: 129809 RVA: 0x00467E83 File Offset: 0x00466083
		// (set) Token: 0x0601FB12 RID: 129810 RVA: 0x00467E8B File Offset: 0x0046608B
		public ECondition Type { get; set; }

		// Token: 0x17009183 RID: 37251
		// (get) Token: 0x0601FB13 RID: 129811 RVA: 0x00467E94 File Offset: 0x00466094
		// (set) Token: 0x0601FB14 RID: 129812 RVA: 0x00467E9C File Offset: 0x0046609C
		public TCheckJigsawInfoUnion JigsawCondition { get; set; }

		// Token: 0x0601FB15 RID: 129813 RVA: 0x00467EA5 File Offset: 0x004660A5
		public ICheckJigsawInfoConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.JigsawCondition = null;
		}
	}
}
