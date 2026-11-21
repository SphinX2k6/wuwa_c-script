using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E3 RID: 26339
	public class IActionMontageT
	{
		// Token: 0x1700BF8A RID: 49034
		// (get) Token: 0x0602C452 RID: 181330 RVA: 0x00607023 File Offset: 0x00605223
		// (set) Token: 0x0602C453 RID: 181331 RVA: 0x0060702B File Offset: 0x0060522B
		public EActionMontageType MontageType { get; set; }

		// Token: 0x1700BF8B RID: 49035
		// (get) Token: 0x0602C454 RID: 181332 RVA: 0x00607034 File Offset: 0x00605234
		// (set) Token: 0x0602C455 RID: 181333 RVA: 0x0060703C File Offset: 0x0060523C
		public string Path { get; set; }

		// Token: 0x0602C456 RID: 181334 RVA: 0x00607045 File Offset: 0x00605245
		public IActionMontageT()
		{
			this.MontageType = EActionMontageType.Normal;
			this.Path = null;
		}
	}
}
