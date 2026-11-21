using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C1E RID: 11294
	public class IClientEnableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600F889 RID: 63625 RVA: 0x00241FEE File Offset: 0x002401EE
		public static IClientEnableAllPlayerOperation Create(IClientEnableAllPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEnableAllPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x0600F88A RID: 63626 RVA: 0x0024200D File Offset: 0x0024020D
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040087F6 RID: 34806
		private IClientEnableAllPlayerOperation Instance;
	}
}
