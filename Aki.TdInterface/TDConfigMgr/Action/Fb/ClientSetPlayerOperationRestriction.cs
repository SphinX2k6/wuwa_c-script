using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002930 RID: 10544
	public class ClientSetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x0600E9F1 RID: 59889 RVA: 0x0022461F File Offset: 0x0022281F
		[NullableContext(1)]
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

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x0600E9F2 RID: 59890 RVA: 0x0022463E File Offset: 0x0022283E
		public virtual EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400810A RID: 33034
		private IClientSetPlayerOperationRestriction Instance;
	}
}
