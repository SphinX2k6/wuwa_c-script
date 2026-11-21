using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004524 RID: 17700
	public class IRoleTowerSystemConfigT
	{
		// Token: 0x17007B1F RID: 31519
		// (get) Token: 0x060199EB RID: 104939 RVA: 0x003A64E3 File Offset: 0x003A46E3
		// (set) Token: 0x060199EC RID: 104940 RVA: 0x003A64EB File Offset: 0x003A46EB
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007B20 RID: 31520
		// (get) Token: 0x060199ED RID: 104941 RVA: 0x003A64F4 File Offset: 0x003A46F4
		// (set) Token: 0x060199EE RID: 104942 RVA: 0x003A64FC File Offset: 0x003A46FC
		public List<IRoleTowerSystemVarT> Vars { get; set; }

		// Token: 0x060199EF RID: 104943 RVA: 0x003A6505 File Offset: 0x003A4705
		public IRoleTowerSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
