using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C3 RID: 20931
	public class IEntityTrackControlPointT
	{
		// Token: 0x17009920 RID: 39200
		// (get) Token: 0x06021EC4 RID: 138948 RVA: 0x004B4C7A File Offset: 0x004B2E7A
		// (set) Token: 0x06021EC5 RID: 138949 RVA: 0x004B4C82 File Offset: 0x004B2E82
		public string State { get; set; }

		// Token: 0x17009921 RID: 39201
		// (get) Token: 0x06021EC6 RID: 138950 RVA: 0x004B4C8B File Offset: 0x004B2E8B
		// (set) Token: 0x06021EC7 RID: 138951 RVA: 0x004B4C93 File Offset: 0x004B2E93
		public IConditionGroupT LeftCondition { get; set; }

		// Token: 0x17009922 RID: 39202
		// (get) Token: 0x06021EC8 RID: 138952 RVA: 0x004B4C9C File Offset: 0x004B2E9C
		// (set) Token: 0x06021EC9 RID: 138953 RVA: 0x004B4CA4 File Offset: 0x004B2EA4
		public IConditionGroupT RightCondition { get; set; }

		// Token: 0x06021ECA RID: 138954 RVA: 0x004B4CAD File Offset: 0x004B2EAD
		public IEntityTrackControlPointT()
		{
			this.State = null;
			this.LeftCondition = null;
			this.RightCondition = null;
		}
	}
}
