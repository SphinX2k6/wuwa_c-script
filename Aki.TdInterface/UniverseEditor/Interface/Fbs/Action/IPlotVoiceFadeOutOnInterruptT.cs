using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DB RID: 29915
	public class IPlotVoiceFadeOutOnInterruptT
	{
		// Token: 0x1700DC15 RID: 56341
		// (get) Token: 0x06034704 RID: 214788 RVA: 0x0070F7F6 File Offset: 0x0070D9F6
		// (set) Token: 0x06034705 RID: 214789 RVA: 0x0070F7FE File Offset: 0x0070D9FE
		public float FadeDuration { get; set; }

		// Token: 0x1700DC16 RID: 56342
		// (get) Token: 0x06034706 RID: 214790 RVA: 0x0070F807 File Offset: 0x0070DA07
		// (set) Token: 0x06034707 RID: 214791 RVA: 0x0070F80F File Offset: 0x0070DA0F
		public EAudioFadeCurveType FadeCurve { get; set; }

		// Token: 0x1700DC17 RID: 56343
		// (get) Token: 0x06034708 RID: 214792 RVA: 0x0070F818 File Offset: 0x0070DA18
		// (set) Token: 0x06034709 RID: 214793 RVA: 0x0070F820 File Offset: 0x0070DA20
		public byte NullMask { get; set; }

		// Token: 0x0603470A RID: 214794 RVA: 0x0070F829 File Offset: 0x0070DA29
		public IPlotVoiceFadeOutOnInterruptT()
		{
			this.FadeDuration = 0f;
			this.FadeCurve = EAudioFadeCurveType.Log3;
			this.NullMask = 0;
		}
	}
}
