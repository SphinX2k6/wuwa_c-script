using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B4B RID: 19275
	public class ICheckTargetAttributeConditionT
	{
		// Token: 0x17008BD4 RID: 35796
		// (get) Token: 0x0601E59F RID: 124319 RVA: 0x00440A55 File Offset: 0x0043EC55
		// (set) Token: 0x0601E5A0 RID: 124320 RVA: 0x00440A5D File Offset: 0x0043EC5D
		public ECondition Type { get; set; }

		// Token: 0x17008BD5 RID: 35797
		// (get) Token: 0x0601E5A1 RID: 124321 RVA: 0x00440A66 File Offset: 0x0043EC66
		// (set) Token: 0x0601E5A2 RID: 124322 RVA: 0x00440A6E File Offset: 0x0043EC6E
		public IPlayerAttributeT Option { get; set; }

		// Token: 0x17008BD6 RID: 35798
		// (get) Token: 0x0601E5A3 RID: 124323 RVA: 0x00440A77 File Offset: 0x0043EC77
		// (set) Token: 0x0601E5A4 RID: 124324 RVA: 0x00440A7F File Offset: 0x0043EC7F
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601E5A5 RID: 124325 RVA: 0x00440A88 File Offset: 0x0043EC88
		public ICheckTargetAttributeConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Option = null;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
