using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C0C RID: 11276
	public class ClientSetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x0600F843 RID: 63555 RVA: 0x00241977 File Offset: 0x0023FB77
		public static ClientSetPlayerOperationRestriction Create(IClientSetPlayerOperationRestriction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientSetPlayerOperationRestriction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x0600F844 RID: 63556 RVA: 0x00241996 File Offset: 0x0023FB96
		public virtual EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040087D8 RID: 34776
		private IClientSetPlayerOperationRestriction Instance;
	}
}
