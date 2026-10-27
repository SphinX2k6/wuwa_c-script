using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F2 RID: 22770
	public class ISearchlightRotateT
	{
		// Token: 0x1700AA9E RID: 43678
		// (get) Token: 0x0602676C RID: 157548 RVA: 0x0054CDB7 File Offset: 0x0054AFB7
		// (set) Token: 0x0602676D RID: 157549 RVA: 0x0054CDBF File Offset: 0x0054AFBF
		public EProceduralVisualType Type { get; set; }

		// Token: 0x1700AA9F RID: 43679
		// (get) Token: 0x0602676E RID: 157550 RVA: 0x0054CDC8 File Offset: 0x0054AFC8
		// (set) Token: 0x0602676F RID: 157551 RVA: 0x0054CDD0 File Offset: 0x0054AFD0
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AAA0 RID: 43680
		// (get) Token: 0x06026770 RID: 157552 RVA: 0x0054CDD9 File Offset: 0x0054AFD9
		// (set) Token: 0x06026771 RID: 157553 RVA: 0x0054CDE1 File Offset: 0x0054AFE1
		public string RotateNode { get; set; }

		// Token: 0x1700AAA1 RID: 43681
		// (get) Token: 0x06026772 RID: 157554 RVA: 0x0054CDEA File Offset: 0x0054AFEA
		// (set) Token: 0x06026773 RID: 157555 RVA: 0x0054CDF2 File Offset: 0x0054AFF2
		public float MaxAngleSpeed { get; set; }

		// Token: 0x1700AAA2 RID: 43682
		// (get) Token: 0x06026774 RID: 157556 RVA: 0x0054CDFB File Offset: 0x0054AFFB
		// (set) Token: 0x06026775 RID: 157557 RVA: 0x0054CE03 File Offset: 0x0054B003
		public ESearchlightRotateAxis Axis { get; set; }

		// Token: 0x1700AAA3 RID: 43683
		// (get) Token: 0x06026776 RID: 157558 RVA: 0x0054CE0C File Offset: 0x0054B00C
		// (set) Token: 0x06026777 RID: 157559 RVA: 0x0054CE14 File Offset: 0x0054B014
		public List<ISnapAngleConfigT> SnapConfigs { get; set; }

		// Token: 0x1700AAA4 RID: 43684
		// (get) Token: 0x06026778 RID: 157560 RVA: 0x0054CE1D File Offset: 0x0054B01D
		// (set) Token: 0x06026779 RID: 157561 RVA: 0x0054CE25 File Offset: 0x0054B025
		public byte NullMask { get; set; }

		// Token: 0x0602677A RID: 157562 RVA: 0x0054CE2E File Offset: 0x0054B02E
		public ISearchlightRotateT()
		{
			this.Type = EProceduralVisualType.LookAt;
			this.Condition = null;
			this.RotateNode = null;
			this.MaxAngleSpeed = 0f;
			this.Axis = ESearchlightRotateAxis.Yaw;
			this.SnapConfigs = null;
			this.NullMask = 0;
		}
	}
}
