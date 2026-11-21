using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561A RID: 22042
	public class IDragActorPlayComponentT
	{
		// Token: 0x17009E1B RID: 40475
		// (get) Token: 0x0602328B RID: 144011 RVA: 0x004D6CED File Offset: 0x004D4EED
		// (set) Token: 0x0602328C RID: 144012 RVA: 0x004D6CF5 File Offset: 0x004D4EF5
		public bool Disabled { get; set; }

		// Token: 0x17009E1C RID: 40476
		// (get) Token: 0x0602328D RID: 144013 RVA: 0x004D6CFE File Offset: 0x004D4EFE
		// (set) Token: 0x0602328E RID: 144014 RVA: 0x004D6D06 File Offset: 0x004D4F06
		public List<IDragActorPlayConfigT> Configs { get; set; }

		// Token: 0x17009E1D RID: 40477
		// (get) Token: 0x0602328F RID: 144015 RVA: 0x004D6D0F File Offset: 0x004D4F0F
		// (set) Token: 0x06023290 RID: 144016 RVA: 0x004D6D17 File Offset: 0x004D4F17
		public string ExitSendSelfEvent { get; set; }

		// Token: 0x17009E1E RID: 40478
		// (get) Token: 0x06023291 RID: 144017 RVA: 0x004D6D20 File Offset: 0x004D4F20
		// (set) Token: 0x06023292 RID: 144018 RVA: 0x004D6D28 File Offset: 0x004D4F28
		public byte NullMask { get; set; }

		// Token: 0x06023293 RID: 144019 RVA: 0x004D6D31 File Offset: 0x004D4F31
		public IDragActorPlayComponentT()
		{
			this.Disabled = false;
			this.Configs = null;
			this.ExitSendSelfEvent = null;
			this.NullMask = 0;
		}
	}
}
