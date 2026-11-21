using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005416 RID: 21526
	public class IAutoLockControlT
	{
		// Token: 0x17009870 RID: 39024
		// (get) Token: 0x06021ABB RID: 137915 RVA: 0x004A408A File Offset: 0x004A228A
		// (set) Token: 0x06021ABC RID: 137916 RVA: 0x004A4092 File Offset: 0x004A2292
		public IConditionGroupT EnableCondition { get; set; }

		// Token: 0x17009871 RID: 39025
		// (get) Token: 0x06021ABD RID: 137917 RVA: 0x004A409B File Offset: 0x004A229B
		// (set) Token: 0x06021ABE RID: 137918 RVA: 0x004A40A3 File Offset: 0x004A22A3
		public IConditionGroupT DisableCondition { get; set; }

		// Token: 0x06021ABF RID: 137919 RVA: 0x004A40AC File Offset: 0x004A22AC
		public IAutoLockControlT()
		{
			this.EnableCondition = null;
			this.DisableCondition = null;
		}
	}
}
