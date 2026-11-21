using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5C RID: 23388
	public class IMotorHookPerformanceConfigT
	{
		// Token: 0x1700AAC3 RID: 43715
		// (get) Token: 0x060267E4 RID: 157668 RVA: 0x005457B8 File Offset: 0x005439B8
		// (set) Token: 0x060267E5 RID: 157669 RVA: 0x005457C0 File Offset: 0x005439C0
		public long HookEffectBuffId { get; set; }

		// Token: 0x1700AAC4 RID: 43716
		// (get) Token: 0x060267E6 RID: 157670 RVA: 0x005457C9 File Offset: 0x005439C9
		// (set) Token: 0x060267E7 RID: 157671 RVA: 0x005457D1 File Offset: 0x005439D1
		public byte NullMask { get; set; }

		// Token: 0x060267E8 RID: 157672 RVA: 0x005457DA File Offset: 0x005439DA
		public IMotorHookPerformanceConfigT()
		{
			this.HookEffectBuffId = 0L;
			this.NullMask = 0;
		}
	}
}
