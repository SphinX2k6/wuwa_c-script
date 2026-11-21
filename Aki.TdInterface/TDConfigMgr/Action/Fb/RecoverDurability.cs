using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C0A RID: 11274
	public class RecoverDurability : ActionParams
	{
		// Token: 0x0600F83D RID: 63549 RVA: 0x0024190F File Offset: 0x0023FB0F
		public static RecoverDurability Create(IRecoverDurability? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RecoverDurability
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x0600F83E RID: 63550 RVA: 0x0024192E File Offset: 0x0023FB2E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040087D6 RID: 34774
		private IRecoverDurability Instance;
	}
}
