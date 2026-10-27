using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED5 RID: 20181
	public class IAudioFadeT
	{
		// Token: 0x170090DB RID: 37083
		// (get) Token: 0x0601FCE7 RID: 130279 RVA: 0x0046D348 File Offset: 0x0046B548
		// (set) Token: 0x0601FCE8 RID: 130280 RVA: 0x0046D350 File Offset: 0x0046B550
		public EAudioFadeCurveType FadeCurve { get; set; }

		// Token: 0x170090DC RID: 37084
		// (get) Token: 0x0601FCE9 RID: 130281 RVA: 0x0046D359 File Offset: 0x0046B559
		// (set) Token: 0x0601FCEA RID: 130282 RVA: 0x0046D361 File Offset: 0x0046B561
		public int FadeDuration { get; set; }

		// Token: 0x0601FCEB RID: 130283 RVA: 0x0046D36A File Offset: 0x0046B56A
		public IAudioFadeT()
		{
			this.FadeCurve = EAudioFadeCurveType.Log3;
			this.FadeDuration = 0;
		}
	}
}
