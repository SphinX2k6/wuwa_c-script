using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF1 RID: 15857
	public class IBlackBoardFloatT
	{
		// Token: 0x17006B1C RID: 27420
		// (get) Token: 0x060154B7 RID: 87223 RVA: 0x00314321 File Offset: 0x00312521
		// (set) Token: 0x060154B8 RID: 87224 RVA: 0x00314329 File Offset: 0x00312529
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B1D RID: 27421
		// (get) Token: 0x060154B9 RID: 87225 RVA: 0x00314332 File Offset: 0x00312532
		// (set) Token: 0x060154BA RID: 87226 RVA: 0x0031433A File Offset: 0x0031253A
		public string Key { get; set; }

		// Token: 0x17006B1E RID: 27422
		// (get) Token: 0x060154BB RID: 87227 RVA: 0x00314343 File Offset: 0x00312543
		// (set) Token: 0x060154BC RID: 87228 RVA: 0x0031434B File Offset: 0x0031254B
		public float Value { get; set; }

		// Token: 0x060154BD RID: 87229 RVA: 0x00314354 File Offset: 0x00312554
		public IBlackBoardFloatT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = 0f;
		}
	}
}
