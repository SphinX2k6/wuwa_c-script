using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B0 RID: 30128
	public class IReignsSetUiEffectT
	{
		// Token: 0x1700DD88 RID: 56712
		// (get) Token: 0x06034D9A RID: 216474 RVA: 0x0071AB27 File Offset: 0x00718D27
		// (set) Token: 0x06034D9B RID: 216475 RVA: 0x0071AB2F File Offset: 0x00718D2F
		public string Effect { get; set; }

		// Token: 0x1700DD89 RID: 56713
		// (get) Token: 0x06034D9C RID: 216476 RVA: 0x0071AB38 File Offset: 0x00718D38
		// (set) Token: 0x06034D9D RID: 216477 RVA: 0x0071AB40 File Offset: 0x00718D40
		public bool IsVisible { get; set; }

		// Token: 0x06034D9E RID: 216478 RVA: 0x0071AB49 File Offset: 0x00718D49
		public IReignsSetUiEffectT()
		{
			this.Effect = null;
			this.IsVisible = false;
		}
	}
}
