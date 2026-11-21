using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C0B RID: 11275
	public class SetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x0600F840 RID: 63552 RVA: 0x00241943 File Offset: 0x0023FB43
		public static SetPlayerOperationRestriction Create(ISetPlayerOperationRestriction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerOperationRestriction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x0600F841 RID: 63553 RVA: 0x00241962 File Offset: 0x0023FB62
		public virtual EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040087D7 RID: 34775
		private ISetPlayerOperationRestriction Instance;
	}
}
