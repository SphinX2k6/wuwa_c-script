using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2B RID: 10795
	public class IBvbEndTurn : IBvbPlayerOperationType
	{
		// Token: 0x0600EDDF RID: 60895 RVA: 0x0022A9E1 File Offset: 0x00228BE1
		[NullableContext(1)]
		public static IBvbEndTurn Create(IBvbEndTurn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEndTurn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x0022AA00 File Offset: 0x00228C00
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040082ED RID: 33517
		private IBvbEndTurn Instance;
	}
}
