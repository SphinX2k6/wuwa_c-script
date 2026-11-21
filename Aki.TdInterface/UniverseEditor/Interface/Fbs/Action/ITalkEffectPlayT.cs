using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A86 RID: 31366
	public class ITalkEffectPlayT
	{
		// Token: 0x1700E5BF RID: 58815
		// (get) Token: 0x06037499 RID: 226457 RVA: 0x00761EB7 File Offset: 0x007600B7
		// (set) Token: 0x0603749A RID: 226458 RVA: 0x00761EBF File Offset: 0x007600BF
		public ETalkEffectActionType Type { get; set; }

		// Token: 0x1700E5C0 RID: 58816
		// (get) Token: 0x0603749B RID: 226459 RVA: 0x00761EC8 File Offset: 0x007600C8
		// (set) Token: 0x0603749C RID: 226460 RVA: 0x00761ED0 File Offset: 0x007600D0
		public ITalkCommonEffectT Effect { get; set; }

		// Token: 0x1700E5C1 RID: 58817
		// (get) Token: 0x0603749D RID: 226461 RVA: 0x00761ED9 File Offset: 0x007600D9
		// (set) Token: 0x0603749E RID: 226462 RVA: 0x00761EE1 File Offset: 0x007600E1
		public bool KeepPlay { get; set; }

		// Token: 0x1700E5C2 RID: 58818
		// (get) Token: 0x0603749F RID: 226463 RVA: 0x00761EEA File Offset: 0x007600EA
		// (set) Token: 0x060374A0 RID: 226464 RVA: 0x00761EF2 File Offset: 0x007600F2
		public string EffectKey { get; set; }

		// Token: 0x1700E5C3 RID: 58819
		// (get) Token: 0x060374A1 RID: 226465 RVA: 0x00761EFB File Offset: 0x007600FB
		// (set) Token: 0x060374A2 RID: 226466 RVA: 0x00761F03 File Offset: 0x00760103
		public float DelayTime { get; set; }

		// Token: 0x1700E5C4 RID: 58820
		// (get) Token: 0x060374A3 RID: 226467 RVA: 0x00761F0C File Offset: 0x0076010C
		// (set) Token: 0x060374A4 RID: 226468 RVA: 0x00761F14 File Offset: 0x00760114
		public byte NullMask { get; set; }

		// Token: 0x060374A5 RID: 226469 RVA: 0x00761F1D File Offset: 0x0076011D
		public ITalkEffectPlayT()
		{
			this.Type = ETalkEffectActionType.Play;
			this.Effect = null;
			this.KeepPlay = false;
			this.EffectKey = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
