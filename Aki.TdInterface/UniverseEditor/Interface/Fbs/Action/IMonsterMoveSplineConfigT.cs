using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADD RID: 27357
	public class IMonsterMoveSplineConfigT
	{
		// Token: 0x1700CAF6 RID: 51958
		// (get) Token: 0x0602FF40 RID: 196416 RVA: 0x0068564C File Offset: 0x0068384C
		// (set) Token: 0x0602FF41 RID: 196417 RVA: 0x00685654 File Offset: 0x00683854
		public int TargetEntityId { get; set; }

		// Token: 0x1700CAF7 RID: 51959
		// (get) Token: 0x0602FF42 RID: 196418 RVA: 0x0068565D File Offset: 0x0068385D
		// (set) Token: 0x0602FF43 RID: 196419 RVA: 0x00685665 File Offset: 0x00683865
		public int SplineEntityId { get; set; }

		// Token: 0x0602FF44 RID: 196420 RVA: 0x0068566E File Offset: 0x0068386E
		public IMonsterMoveSplineConfigT()
		{
			this.TargetEntityId = 0;
			this.SplineEntityId = 0;
		}
	}
}
