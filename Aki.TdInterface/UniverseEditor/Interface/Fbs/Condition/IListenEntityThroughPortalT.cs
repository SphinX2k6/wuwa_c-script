using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005143 RID: 20803
	public class IListenEntityThroughPortalT
	{
		// Token: 0x1700951C RID: 38172
		// (get) Token: 0x06020BA5 RID: 134053 RVA: 0x00488CF9 File Offset: 0x00486EF9
		// (set) Token: 0x06020BA6 RID: 134054 RVA: 0x00488D01 File Offset: 0x00486F01
		public ECondition Type { get; set; }

		// Token: 0x1700951D RID: 38173
		// (get) Token: 0x06020BA7 RID: 134055 RVA: 0x00488D0A File Offset: 0x00486F0A
		// (set) Token: 0x06020BA8 RID: 134056 RVA: 0x00488D12 File Offset: 0x00486F12
		public TTargetEntityUnion CheckTarget { get; set; }

		// Token: 0x1700951E RID: 38174
		// (get) Token: 0x06020BA9 RID: 134057 RVA: 0x00488D1B File Offset: 0x00486F1B
		// (set) Token: 0x06020BAA RID: 134058 RVA: 0x00488D23 File Offset: 0x00486F23
		public int PortalEntityId { get; set; }

		// Token: 0x06020BAB RID: 134059 RVA: 0x00488D2C File Offset: 0x00486F2C
		public IListenEntityThroughPortalT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckTarget = null;
			this.PortalEntityId = 0;
		}
	}
}
