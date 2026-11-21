using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD8 RID: 20440
	public class ICheckPlayerRelativeDistanceT
	{
		// Token: 0x1700923F RID: 37439
		// (get) Token: 0x0601FE28 RID: 130600 RVA: 0x0046D945 File Offset: 0x0046BB45
		// (set) Token: 0x0601FE29 RID: 130601 RVA: 0x0046D94D File Offset: 0x0046BB4D
		public ECondition Type { get; set; }

		// Token: 0x17009240 RID: 37440
		// (get) Token: 0x0601FE2A RID: 130602 RVA: 0x0046D956 File Offset: 0x0046BB56
		// (set) Token: 0x0601FE2B RID: 130603 RVA: 0x0046D95E File Offset: 0x0046BB5E
		public int TargetEntityId { get; set; }

		// Token: 0x17009241 RID: 37441
		// (get) Token: 0x0601FE2C RID: 130604 RVA: 0x0046D967 File Offset: 0x0046BB67
		// (set) Token: 0x0601FE2D RID: 130605 RVA: 0x0046D96F File Offset: 0x0046BB6F
		public List<IDistanceRangeT> ValidDistanceRanges { get; set; }

		// Token: 0x0601FE2E RID: 130606 RVA: 0x0046D978 File Offset: 0x0046BB78
		public ICheckPlayerRelativeDistanceT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetEntityId = 0;
			this.ValidDistanceRanges = null;
		}
	}
}
