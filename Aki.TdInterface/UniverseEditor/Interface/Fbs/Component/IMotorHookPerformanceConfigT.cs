using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BE RID: 21950
	public class IMotorHookPerformanceConfigT
	{
		// Token: 0x1700A23B RID: 41531
		// (get) Token: 0x060245D7 RID: 148951 RVA: 0x00505240 File Offset: 0x00503440
		// (set) Token: 0x060245D8 RID: 148952 RVA: 0x00505248 File Offset: 0x00503448
		public long HookEffectBuffId { get; set; }

		// Token: 0x1700A23C RID: 41532
		// (get) Token: 0x060245D9 RID: 148953 RVA: 0x00505251 File Offset: 0x00503451
		// (set) Token: 0x060245DA RID: 148954 RVA: 0x00505259 File Offset: 0x00503459
		public byte NullMask { get; set; }

		// Token: 0x060245DB RID: 148955 RVA: 0x00505262 File Offset: 0x00503462
		public IMotorHookPerformanceConfigT()
		{
			this.HookEffectBuffId = 0L;
			this.NullMask = 0;
		}
	}
}
