using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004755 RID: 18261
	public class IFixActionT
	{
		// Token: 0x170082FF RID: 33535
		// (get) Token: 0x0601C1A9 RID: 115113 RVA: 0x003FB6A5 File Offset: 0x003F98A5
		// (set) Token: 0x0601C1AA RID: 115114 RVA: 0x003FB6AD File Offset: 0x003F98AD
		public string Timing { get; set; }

		// Token: 0x17008300 RID: 33536
		// (get) Token: 0x0601C1AB RID: 115115 RVA: 0x003FB6B6 File Offset: 0x003F98B6
		// (set) Token: 0x0601C1AC RID: 115116 RVA: 0x003FB6BE File Offset: 0x003F98BE
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17008301 RID: 33537
		// (get) Token: 0x0601C1AD RID: 115117 RVA: 0x003FB6C7 File Offset: 0x003F98C7
		// (set) Token: 0x0601C1AE RID: 115118 RVA: 0x003FB6CF File Offset: 0x003F98CF
		public List<IActionInfoT> ThenActions { get; set; }

		// Token: 0x17008302 RID: 33538
		// (get) Token: 0x0601C1AF RID: 115119 RVA: 0x003FB6D8 File Offset: 0x003F98D8
		// (set) Token: 0x0601C1B0 RID: 115120 RVA: 0x003FB6E0 File Offset: 0x003F98E0
		public bool Period { get; set; }

		// Token: 0x17008303 RID: 33539
		// (get) Token: 0x0601C1B1 RID: 115121 RVA: 0x003FB6E9 File Offset: 0x003F98E9
		// (set) Token: 0x0601C1B2 RID: 115122 RVA: 0x003FB6F1 File Offset: 0x003F98F1
		public float CheckPeriod { get; set; }

		// Token: 0x17008304 RID: 33540
		// (get) Token: 0x0601C1B3 RID: 115123 RVA: 0x003FB6FA File Offset: 0x003F98FA
		// (set) Token: 0x0601C1B4 RID: 115124 RVA: 0x003FB702 File Offset: 0x003F9902
		public byte NullMask { get; set; }

		// Token: 0x0601C1B5 RID: 115125 RVA: 0x003FB70B File Offset: 0x003F990B
		public IFixActionT()
		{
			this.Timing = null;
			this.Condition = null;
			this.ThenActions = null;
			this.Period = false;
			this.CheckPeriod = 0f;
			this.NullMask = 0;
		}
	}
}
