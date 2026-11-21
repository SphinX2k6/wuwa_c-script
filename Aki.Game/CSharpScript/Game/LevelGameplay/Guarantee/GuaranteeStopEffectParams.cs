using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F86 RID: 24454
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeStopEffectParams : ActionParams, IGuaranteeStopEffectParams
	{
		// Token: 0x17006EF2 RID: 28402
		// (get) Token: 0x0603ACA7 RID: 240807 RVA: 0x0109F77A File Offset: 0x0109D97A
		// (set) Token: 0x0603ACA8 RID: 240808 RVA: 0x0109F782 File Offset: 0x0109D982
		public int? EffectId { get; set; }

		// Token: 0x17006EF3 RID: 28403
		// (get) Token: 0x0603ACA9 RID: 240809 RVA: 0x0109F78B File Offset: 0x0109D98B
		// (set) Token: 0x0603ACAA RID: 240810 RVA: 0x0109F793 File Offset: 0x0109D993
		public int? ScreenEffectHandle { get; set; }

		// Token: 0x17006EF4 RID: 28404
		// (get) Token: 0x0603ACAB RID: 240811 RVA: 0x0109F79C File Offset: 0x0109D99C
		// (set) Token: 0x0603ACAC RID: 240812 RVA: 0x0109F7A4 File Offset: 0x0109D9A4
		public string Mp4Name { get; set; }
	}
}
