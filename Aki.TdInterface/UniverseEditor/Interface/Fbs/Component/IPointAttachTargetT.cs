using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D56 RID: 23894
	public class IPointAttachTargetT
	{
		// Token: 0x1700AFE9 RID: 45033
		// (get) Token: 0x06027C73 RID: 162931 RVA: 0x00571423 File Offset: 0x0056F623
		// (set) Token: 0x06027C74 RID: 162932 RVA: 0x0057142B File Offset: 0x0056F62B
		public EAttachType Type { get; set; }

		// Token: 0x1700AFEA RID: 45034
		// (get) Token: 0x06027C75 RID: 162933 RVA: 0x00571434 File Offset: 0x0056F634
		// (set) Token: 0x06027C76 RID: 162934 RVA: 0x0057143C File Offset: 0x0056F63C
		public IVectorInfoT RelativePoint { get; set; }

		// Token: 0x06027C77 RID: 162935 RVA: 0x00571445 File Offset: 0x0056F645
		public IPointAttachTargetT()
		{
			this.Type = EAttachType.Actor;
			this.RelativePoint = null;
		}
	}
}
