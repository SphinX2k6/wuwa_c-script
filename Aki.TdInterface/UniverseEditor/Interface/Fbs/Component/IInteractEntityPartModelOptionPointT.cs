using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D3 RID: 22995
	public class IInteractEntityPartModelOptionPointT
	{
		// Token: 0x1700A71F RID: 42783
		// (get) Token: 0x060258A5 RID: 153765 RVA: 0x00526626 File Offset: 0x00524826
		// (set) Token: 0x060258A6 RID: 153766 RVA: 0x0052662E File Offset: 0x0052482E
		public string UiStyle { get; set; }

		// Token: 0x1700A720 RID: 42784
		// (get) Token: 0x060258A7 RID: 153767 RVA: 0x00526637 File Offset: 0x00524837
		// (set) Token: 0x060258A8 RID: 153768 RVA: 0x0052663F File Offset: 0x0052483F
		public string BindName { get; set; }

		// Token: 0x060258A9 RID: 153769 RVA: 0x00526648 File Offset: 0x00524848
		public IInteractEntityPartModelOptionPointT()
		{
			this.UiStyle = null;
			this.BindName = null;
		}
	}
}
