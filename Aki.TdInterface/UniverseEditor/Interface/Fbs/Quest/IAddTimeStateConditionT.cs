using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF9 RID: 15609
	public class IAddTimeStateConditionT
	{
		// Token: 0x17006B05 RID: 27397
		// (get) Token: 0x0601581D RID: 88093 RVA: 0x0031B54F File Offset: 0x0031974F
		// (set) Token: 0x0601581E RID: 88094 RVA: 0x0031B557 File Offset: 0x00319757
		public IEntityStateConditionT Condition { get; set; }

		// Token: 0x17006B06 RID: 27398
		// (get) Token: 0x0601581F RID: 88095 RVA: 0x0031B560 File Offset: 0x00319760
		// (set) Token: 0x06015820 RID: 88096 RVA: 0x0031B568 File Offset: 0x00319768
		public int AddTime { get; set; }

		// Token: 0x06015821 RID: 88097 RVA: 0x0031B571 File Offset: 0x00319771
		public IAddTimeStateConditionT()
		{
			this.Condition = null;
			this.AddTime = 0;
		}
	}
}
