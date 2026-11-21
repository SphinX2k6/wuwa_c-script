using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293A RID: 10554
	public class UnlockTeleportTrigger : ActionParams
	{
		// Token: 0x0600EA88 RID: 60040 RVA: 0x00229AD9 File Offset: 0x00227CD9
		public static UnlockTeleportTrigger Create(IUnlockTeleportTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockTeleportTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x0600EA89 RID: 60041 RVA: 0x00229AF8 File Offset: 0x00227CF8
		public virtual int TeleportId
		{
			get
			{
				return this.Instance.TeleportId;
			}
		}

		// Token: 0x04008142 RID: 33090
		private IUnlockTeleportTrigger Instance;
	}
}
