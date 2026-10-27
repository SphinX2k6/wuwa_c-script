using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005046 RID: 20550
	public class ICreateStageConfigT
	{
		// Token: 0x1700951E RID: 38174
		// (get) Token: 0x06020EE5 RID: 134885 RVA: 0x00494070 File Offset: 0x00492270
		// (set) Token: 0x06020EE6 RID: 134886 RVA: 0x00494078 File Offset: 0x00492278
		public float PerformDuration { get; set; }

		// Token: 0x1700951F RID: 38175
		// (get) Token: 0x06020EE7 RID: 134887 RVA: 0x00494081 File Offset: 0x00492281
		// (set) Token: 0x06020EE8 RID: 134888 RVA: 0x00494089 File Offset: 0x00492289
		public ICreateBulletConfigT BulletConfig { get; set; }

		// Token: 0x17009520 RID: 38176
		// (get) Token: 0x06020EE9 RID: 134889 RVA: 0x00494092 File Offset: 0x00492292
		// (set) Token: 0x06020EEA RID: 134890 RVA: 0x0049409A File Offset: 0x0049229A
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009521 RID: 38177
		// (get) Token: 0x06020EEB RID: 134891 RVA: 0x004940A3 File Offset: 0x004922A3
		// (set) Token: 0x06020EEC RID: 134892 RVA: 0x004940AB File Offset: 0x004922AB
		public byte NullMask { get; set; }

		// Token: 0x06020EED RID: 134893 RVA: 0x004940B4 File Offset: 0x004922B4
		public ICreateStageConfigT()
		{
			this.PerformDuration = 0f;
			this.BulletConfig = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
