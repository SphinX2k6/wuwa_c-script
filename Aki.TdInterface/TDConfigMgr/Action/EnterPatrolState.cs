using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165F RID: 5727
	public class EnterPatrolState : ActionParams
	{
		// Token: 0x06007CDD RID: 31965 RVA: 0x0012BF58 File Offset: 0x0012A158
		[NullableContext(1)]
		public static EnterPatrolState Create([Nullable(2)] EnterPatrolState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterPatrolState
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004CB9 RID: 19641
		[Nullable(2)]
		protected new EnterPatrolState FbInstance;
	}
}
