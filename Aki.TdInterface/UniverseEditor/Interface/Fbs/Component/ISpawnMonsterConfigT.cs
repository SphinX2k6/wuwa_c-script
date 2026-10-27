using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005951 RID: 22865
	public class ISpawnMonsterConfigT
	{
		// Token: 0x1700ABA1 RID: 43937
		// (get) Token: 0x06026B39 RID: 158521 RVA: 0x00554751 File Offset: 0x00552951
		// (set) Token: 0x06026B3A RID: 158522 RVA: 0x00554759 File Offset: 0x00552959
		public int Id { get; set; }

		// Token: 0x1700ABA2 RID: 43938
		// (get) Token: 0x06026B3B RID: 158523 RVA: 0x00554762 File Offset: 0x00552962
		// (set) Token: 0x06026B3C RID: 158524 RVA: 0x0055476A File Offset: 0x0055296A
		public float DelayTime { get; set; }

		// Token: 0x1700ABA3 RID: 43939
		// (get) Token: 0x06026B3D RID: 158525 RVA: 0x00554773 File Offset: 0x00552973
		// (set) Token: 0x06026B3E RID: 158526 RVA: 0x0055477B File Offset: 0x0055297B
		public List<int> TargetsToAwake { get; set; }

		// Token: 0x1700ABA4 RID: 43940
		// (get) Token: 0x06026B3F RID: 158527 RVA: 0x00554784 File Offset: 0x00552984
		// (set) Token: 0x06026B40 RID: 158528 RVA: 0x0055478C File Offset: 0x0055298C
		public TSpawnMonsterCompleteConditionUnion CompleteCondition { get; set; }

		// Token: 0x1700ABA5 RID: 43941
		// (get) Token: 0x06026B41 RID: 158529 RVA: 0x00554795 File Offset: 0x00552995
		// (set) Token: 0x06026B42 RID: 158530 RVA: 0x0055479D File Offset: 0x0055299D
		public ISpawnMonsterPreDependOnPrecedingT PreCondition { get; set; }

		// Token: 0x1700ABA6 RID: 43942
		// (get) Token: 0x06026B43 RID: 158531 RVA: 0x005547A6 File Offset: 0x005529A6
		// (set) Token: 0x06026B44 RID: 158532 RVA: 0x005547AE File Offset: 0x005529AE
		public byte NullMask { get; set; }

		// Token: 0x06026B45 RID: 158533 RVA: 0x005547B7 File Offset: 0x005529B7
		public ISpawnMonsterConfigT()
		{
			this.Id = 0;
			this.DelayTime = 0f;
			this.TargetsToAwake = null;
			this.CompleteCondition = null;
			this.PreCondition = null;
			this.NullMask = 0;
		}
	}
}
