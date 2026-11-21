using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B9D RID: 31645
	public class ITeleportTransitionWithEffectT
	{
		// Token: 0x1700ECF7 RID: 60663
		// (get) Token: 0x06039029 RID: 233513 RVA: 0x007B479F File Offset: 0x007B299F
		// (set) Token: 0x0603902A RID: 233514 RVA: 0x007B47A7 File Offset: 0x007B29A7
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECF8 RID: 60664
		// (get) Token: 0x0603902B RID: 233515 RVA: 0x007B47B0 File Offset: 0x007B29B0
		// (set) Token: 0x0603902C RID: 233516 RVA: 0x007B47B8 File Offset: 0x007B29B8
		public string EffectDaPath { get; set; }

		// Token: 0x0603902D RID: 233517 RVA: 0x007B47C1 File Offset: 0x007B29C1
		public ITeleportTransitionWithEffectT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.EffectDaPath = null;
		}
	}
}
