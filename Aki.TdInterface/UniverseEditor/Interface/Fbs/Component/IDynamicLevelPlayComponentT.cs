using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564A RID: 22090
	public class IDynamicLevelPlayComponentT
	{
		// Token: 0x17009EAF RID: 40623
		// (get) Token: 0x060234B9 RID: 144569 RVA: 0x004DB24A File Offset: 0x004D944A
		// (set) Token: 0x060234BA RID: 144570 RVA: 0x004DB252 File Offset: 0x004D9452
		public bool Disabled { get; set; }

		// Token: 0x17009EB0 RID: 40624
		// (get) Token: 0x060234BB RID: 144571 RVA: 0x004DB25B File Offset: 0x004D945B
		// (set) Token: 0x060234BC RID: 144572 RVA: 0x004DB263 File Offset: 0x004D9463
		public int DynamicLevelPlayId { get; set; }

		// Token: 0x17009EB1 RID: 40625
		// (get) Token: 0x060234BD RID: 144573 RVA: 0x004DB26C File Offset: 0x004D946C
		// (set) Token: 0x060234BE RID: 144574 RVA: 0x004DB274 File Offset: 0x004D9474
		public byte NullMask { get; set; }

		// Token: 0x060234BF RID: 144575 RVA: 0x004DB27D File Offset: 0x004D947D
		public IDynamicLevelPlayComponentT()
		{
			this.Disabled = false;
			this.DynamicLevelPlayId = 0;
			this.NullMask = 0;
		}
	}
}
