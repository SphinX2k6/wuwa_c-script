using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD7 RID: 27351
	public class IModifyTipTextT
	{
		// Token: 0x1700CAEC RID: 51948
		// (get) Token: 0x0602FF14 RID: 196372 RVA: 0x0068527B File Offset: 0x0068347B
		// (set) Token: 0x0602FF15 RID: 196373 RVA: 0x00685283 File Offset: 0x00683483
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700CAED RID: 51949
		// (get) Token: 0x0602FF16 RID: 196374 RVA: 0x0068528C File Offset: 0x0068348C
		// (set) Token: 0x0602FF17 RID: 196375 RVA: 0x00685294 File Offset: 0x00683494
		public float DelayTime { get; set; }

		// Token: 0x1700CAEE RID: 51950
		// (get) Token: 0x0602FF18 RID: 196376 RVA: 0x0068529D File Offset: 0x0068349D
		// (set) Token: 0x0602FF19 RID: 196377 RVA: 0x006852A5 File Offset: 0x006834A5
		public string TipText { get; set; }

		// Token: 0x1700CAEF RID: 51951
		// (get) Token: 0x0602FF1A RID: 196378 RVA: 0x006852AE File Offset: 0x006834AE
		// (set) Token: 0x0602FF1B RID: 196379 RVA: 0x006852B6 File Offset: 0x006834B6
		public byte NullMask { get; set; }

		// Token: 0x0602FF1C RID: 196380 RVA: 0x006852BF File Offset: 0x006834BF
		public IModifyTipTextT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.TipText = null;
			this.NullMask = 0;
		}
	}
}
