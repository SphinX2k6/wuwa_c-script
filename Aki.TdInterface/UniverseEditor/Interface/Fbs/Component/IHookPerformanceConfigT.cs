using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D8 RID: 21464
	public class IHookPerformanceConfigT
	{
		// Token: 0x17009DE7 RID: 40423
		// (get) Token: 0x0602339B RID: 144283 RVA: 0x004E0B7C File Offset: 0x004DED7C
		// (set) Token: 0x0602339C RID: 144284 RVA: 0x004E0B84 File Offset: 0x004DED84
		public long HookEffectBuffId { get; set; }

		// Token: 0x17009DE8 RID: 40424
		// (get) Token: 0x0602339D RID: 144285 RVA: 0x004E0B8D File Offset: 0x004DED8D
		// (set) Token: 0x0602339E RID: 144286 RVA: 0x004E0B95 File Offset: 0x004DED95
		public byte NullMask { get; set; }

		// Token: 0x0602339F RID: 144287 RVA: 0x004E0B9E File Offset: 0x004DED9E
		public IHookPerformanceConfigT()
		{
			this.HookEffectBuffId = 0L;
			this.NullMask = 0;
		}
	}
}
