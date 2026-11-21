using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005584 RID: 21892
	public class IContinuesVariableSpeedSplinePointT
	{
		// Token: 0x17009CBF RID: 40127
		// (get) Token: 0x06022CDB RID: 142555 RVA: 0x004CB550 File Offset: 0x004C9750
		// (set) Token: 0x06022CDC RID: 142556 RVA: 0x004CB558 File Offset: 0x004C9758
		public IVectorInfoT Position { get; set; }

		// Token: 0x17009CC0 RID: 40128
		// (get) Token: 0x06022CDD RID: 142557 RVA: 0x004CB561 File Offset: 0x004C9761
		// (set) Token: 0x06022CDE RID: 142558 RVA: 0x004CB569 File Offset: 0x004C9769
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x17009CC1 RID: 40129
		// (get) Token: 0x06022CDF RID: 142559 RVA: 0x004CB572 File Offset: 0x004C9772
		// (set) Token: 0x06022CE0 RID: 142560 RVA: 0x004CB57A File Offset: 0x004C977A
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x17009CC2 RID: 40130
		// (get) Token: 0x06022CE1 RID: 142561 RVA: 0x004CB583 File Offset: 0x004C9783
		// (set) Token: 0x06022CE2 RID: 142562 RVA: 0x004CB58B File Offset: 0x004C978B
		public ESplineLine LineType { get; set; }

		// Token: 0x17009CC3 RID: 40131
		// (get) Token: 0x06022CE3 RID: 142563 RVA: 0x004CB594 File Offset: 0x004C9794
		// (set) Token: 0x06022CE4 RID: 142564 RVA: 0x004CB59C File Offset: 0x004C979C
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x17009CC4 RID: 40132
		// (get) Token: 0x06022CE5 RID: 142565 RVA: 0x004CB5A5 File Offset: 0x004C97A5
		// (set) Token: 0x06022CE6 RID: 142566 RVA: 0x004CB5AD File Offset: 0x004C97AD
		public ITimePathConfigT IntervalTimePathConfig { get; set; }

		// Token: 0x17009CC5 RID: 40133
		// (get) Token: 0x06022CE7 RID: 142567 RVA: 0x004CB5B6 File Offset: 0x004C97B6
		// (set) Token: 0x06022CE8 RID: 142568 RVA: 0x004CB5BE File Offset: 0x004C97BE
		public List<IConditionActionT> ConditionActions { get; set; }

		// Token: 0x17009CC6 RID: 40134
		// (get) Token: 0x06022CE9 RID: 142569 RVA: 0x004CB5C7 File Offset: 0x004C97C7
		// (set) Token: 0x06022CEA RID: 142570 RVA: 0x004CB5CF File Offset: 0x004C97CF
		public float KeepSpeed { get; set; }

		// Token: 0x17009CC7 RID: 40135
		// (get) Token: 0x06022CEB RID: 142571 RVA: 0x004CB5D8 File Offset: 0x004C97D8
		// (set) Token: 0x06022CEC RID: 142572 RVA: 0x004CB5E0 File Offset: 0x004C97E0
		public byte NullMask { get; set; }

		// Token: 0x06022CED RID: 142573 RVA: 0x004CB5EC File Offset: 0x004C97EC
		public IContinuesVariableSpeedSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.IntervalTimePathConfig = null;
			this.ConditionActions = null;
			this.KeepSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
