using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CF RID: 6095
	public class EnterPatrolState : ActionParams
	{
		// Token: 0x060083BB RID: 33723 RVA: 0x0013B004 File Offset: 0x00139204
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

		// Token: 0x040050B4 RID: 20660
		[Nullable(2)]
		protected new EnterPatrolState FbInstance;
	}
}
