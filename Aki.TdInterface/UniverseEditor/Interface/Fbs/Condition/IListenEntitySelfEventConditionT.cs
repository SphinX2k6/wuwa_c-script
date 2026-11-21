using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005140 RID: 20800
	public class IListenEntitySelfEventConditionT
	{
		// Token: 0x17009514 RID: 38164
		// (get) Token: 0x06020B83 RID: 134019 RVA: 0x00488833 File Offset: 0x00486A33
		// (set) Token: 0x06020B84 RID: 134020 RVA: 0x0048883B File Offset: 0x00486A3B
		public ECondition Type { get; set; }

		// Token: 0x17009515 RID: 38165
		// (get) Token: 0x06020B85 RID: 134021 RVA: 0x00488844 File Offset: 0x00486A44
		// (set) Token: 0x06020B86 RID: 134022 RVA: 0x0048884C File Offset: 0x00486A4C
		public string EventKey { get; set; }

		// Token: 0x17009516 RID: 38166
		// (get) Token: 0x06020B87 RID: 134023 RVA: 0x00488855 File Offset: 0x00486A55
		// (set) Token: 0x06020B88 RID: 134024 RVA: 0x0048885D File Offset: 0x00486A5D
		public bool ResetAfterConditionMet { get; set; }

		// Token: 0x17009517 RID: 38167
		// (get) Token: 0x06020B89 RID: 134025 RVA: 0x00488866 File Offset: 0x00486A66
		// (set) Token: 0x06020B8A RID: 134026 RVA: 0x0048886E File Offset: 0x00486A6E
		public byte NullMask { get; set; }

		// Token: 0x06020B8B RID: 134027 RVA: 0x00488877 File Offset: 0x00486A77
		public IListenEntitySelfEventConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EventKey = null;
			this.ResetAfterConditionMet = false;
			this.NullMask = 0;
		}
	}
}
