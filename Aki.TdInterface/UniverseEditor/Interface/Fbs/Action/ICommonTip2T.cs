using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEC RID: 27372
	public class ICommonTip2T
	{
		// Token: 0x1700C907 RID: 51463
		// (get) Token: 0x0602F0E0 RID: 192736 RVA: 0x0066B725 File Offset: 0x00669925
		// (set) Token: 0x0602F0E1 RID: 192737 RVA: 0x0066B72D File Offset: 0x0066992D
		public ICommonTip2PrepareCountdownT TipOption { get; set; }

		// Token: 0x0602F0E2 RID: 192738 RVA: 0x0066B736 File Offset: 0x00669936
		public ICommonTip2T()
		{
			this.TipOption = null;
		}
	}
}
