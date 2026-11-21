using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E9 RID: 22761
	public class IHeadInfoChangeDataT
	{
		// Token: 0x1700A515 RID: 42261
		// (get) Token: 0x06024F92 RID: 151442 RVA: 0x00513545 File Offset: 0x00511745
		// (set) Token: 0x06024F93 RID: 151443 RVA: 0x0051354D File Offset: 0x0051174D
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x1700A516 RID: 42262
		// (get) Token: 0x06024F94 RID: 151444 RVA: 0x00513556 File Offset: 0x00511756
		// (set) Token: 0x06024F95 RID: 151445 RVA: 0x0051355E File Offset: 0x0051175E
		public string TidName { get; set; }

		// Token: 0x1700A517 RID: 42263
		// (get) Token: 0x06024F96 RID: 151446 RVA: 0x00513567 File Offset: 0x00511767
		// (set) Token: 0x06024F97 RID: 151447 RVA: 0x0051356F File Offset: 0x0051176F
		public string Icon { get; set; }

		// Token: 0x1700A518 RID: 42264
		// (get) Token: 0x06024F98 RID: 151448 RVA: 0x00513578 File Offset: 0x00511778
		// (set) Token: 0x06024F99 RID: 151449 RVA: 0x00513580 File Offset: 0x00511780
		public string TidSecondaryName { get; set; }

		// Token: 0x06024F9A RID: 151450 RVA: 0x00513589 File Offset: 0x00511789
		public IHeadInfoChangeDataT()
		{
			this.Conditions = null;
			this.TidName = null;
			this.Icon = null;
			this.TidSecondaryName = null;
		}
	}
}
