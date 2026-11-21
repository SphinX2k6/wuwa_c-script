using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045FF RID: 17919
	public class ITakePhoto2TimeConditionT
	{
		// Token: 0x17007D59 RID: 32089
		// (get) Token: 0x0601A322 RID: 107298 RVA: 0x003BB14F File Offset: 0x003B934F
		// (set) Token: 0x0601A323 RID: 107299 RVA: 0x003BB157 File Offset: 0x003B9357
		public IHourToHourT TimeRange { get; set; }

		// Token: 0x17007D5A RID: 32090
		// (get) Token: 0x0601A324 RID: 107300 RVA: 0x003BB160 File Offset: 0x003B9360
		// (set) Token: 0x0601A325 RID: 107301 RVA: 0x003BB168 File Offset: 0x003B9368
		public ECompare Compare { get; set; }

		// Token: 0x0601A326 RID: 107302 RVA: 0x003BB171 File Offset: 0x003B9371
		public ITakePhoto2TimeConditionT()
		{
			this.TimeRange = null;
			this.Compare = ECompare.Eq;
		}
	}
}
