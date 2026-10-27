using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200267B RID: 9851
	public class UnlockTeleportTrigger : ActionParams
	{
		// Token: 0x0600DCBC RID: 56508 RVA: 0x0020D3C9 File Offset: 0x0020B5C9
		[NullableContext(1)]
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

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x0600DCBD RID: 56509 RVA: 0x0020D3E8 File Offset: 0x0020B5E8
		public virtual int TeleportId
		{
			get
			{
				return this.Instance.TeleportId;
			}
		}

		// Token: 0x04007AAB RID: 31403
		private IUnlockTeleportTrigger Instance;
	}
}
