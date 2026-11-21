using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD5 RID: 20437
	public class ICheckPlayerRelativeAngleT
	{
		// Token: 0x17009235 RID: 37429
		// (get) Token: 0x0601FE02 RID: 130562 RVA: 0x0046D47C File Offset: 0x0046B67C
		// (set) Token: 0x0601FE03 RID: 130563 RVA: 0x0046D484 File Offset: 0x0046B684
		public ECondition Type { get; set; }

		// Token: 0x17009236 RID: 37430
		// (get) Token: 0x0601FE04 RID: 130564 RVA: 0x0046D48D File Offset: 0x0046B68D
		// (set) Token: 0x0601FE05 RID: 130565 RVA: 0x0046D495 File Offset: 0x0046B695
		public int TargetEntityId { get; set; }

		// Token: 0x17009237 RID: 37431
		// (get) Token: 0x0601FE06 RID: 130566 RVA: 0x0046D49E File Offset: 0x0046B69E
		// (set) Token: 0x0601FE07 RID: 130567 RVA: 0x0046D4A6 File Offset: 0x0046B6A6
		public IVectorInfoT BaseVector { get; set; }

		// Token: 0x17009238 RID: 37432
		// (get) Token: 0x0601FE08 RID: 130568 RVA: 0x0046D4AF File Offset: 0x0046B6AF
		// (set) Token: 0x0601FE09 RID: 130569 RVA: 0x0046D4B7 File Offset: 0x0046B6B7
		public EVectorSpace BaseVectorSpace { get; set; }

		// Token: 0x17009239 RID: 37433
		// (get) Token: 0x0601FE0A RID: 130570 RVA: 0x0046D4C0 File Offset: 0x0046B6C0
		// (set) Token: 0x0601FE0B RID: 130571 RVA: 0x0046D4C8 File Offset: 0x0046B6C8
		public List<IAngleRangeT> ValidAngleRanges { get; set; }

		// Token: 0x1700923A RID: 37434
		// (get) Token: 0x0601FE0C RID: 130572 RVA: 0x0046D4D1 File Offset: 0x0046B6D1
		// (set) Token: 0x0601FE0D RID: 130573 RVA: 0x0046D4D9 File Offset: 0x0046B6D9
		public byte NullMask { get; set; }

		// Token: 0x0601FE0E RID: 130574 RVA: 0x0046D4E2 File Offset: 0x0046B6E2
		public ICheckPlayerRelativeAngleT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetEntityId = 0;
			this.BaseVector = null;
			this.BaseVectorSpace = EVectorSpace.World;
			this.ValidAngleRanges = null;
			this.NullMask = 0;
		}
	}
}
