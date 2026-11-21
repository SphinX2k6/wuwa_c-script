using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007425 RID: 29733
	public class IPhoneSystemInteractBaseT
	{
		// Token: 0x1700DA66 RID: 55910
		// (get) Token: 0x06034060 RID: 213088 RVA: 0x00702E1E File Offset: 0x0070101E
		// (set) Token: 0x06034061 RID: 213089 RVA: 0x00702E26 File Offset: 0x00701026
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x06034062 RID: 213090 RVA: 0x00702E2F File Offset: 0x0070102F
		public IPhoneSystemInteractBaseT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
		}
	}
}
