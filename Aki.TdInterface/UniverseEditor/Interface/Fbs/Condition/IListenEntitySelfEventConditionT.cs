using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C4D RID: 19533
	public class IListenEntitySelfEventConditionT
	{
		// Token: 0x17008DEB RID: 36331
		// (get) Token: 0x0601EF7F RID: 126847 RVA: 0x00454F57 File Offset: 0x00453157
		// (set) Token: 0x0601EF80 RID: 126848 RVA: 0x00454F5F File Offset: 0x0045315F
		public ECondition Type { get; set; }

		// Token: 0x17008DEC RID: 36332
		// (get) Token: 0x0601EF81 RID: 126849 RVA: 0x00454F68 File Offset: 0x00453168
		// (set) Token: 0x0601EF82 RID: 126850 RVA: 0x00454F70 File Offset: 0x00453170
		public string EventKey { get; set; }

		// Token: 0x17008DED RID: 36333
		// (get) Token: 0x0601EF83 RID: 126851 RVA: 0x00454F79 File Offset: 0x00453179
		// (set) Token: 0x0601EF84 RID: 126852 RVA: 0x00454F81 File Offset: 0x00453181
		public bool ResetAfterConditionMet { get; set; }

		// Token: 0x17008DEE RID: 36334
		// (get) Token: 0x0601EF85 RID: 126853 RVA: 0x00454F8A File Offset: 0x0045318A
		// (set) Token: 0x0601EF86 RID: 126854 RVA: 0x00454F92 File Offset: 0x00453192
		public byte NullMask { get; set; }

		// Token: 0x0601EF87 RID: 126855 RVA: 0x00454F9B File Offset: 0x0045319B
		public IListenEntitySelfEventConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EventKey = null;
			this.ResetAfterConditionMet = false;
			this.NullMask = 0;
		}
	}
}
