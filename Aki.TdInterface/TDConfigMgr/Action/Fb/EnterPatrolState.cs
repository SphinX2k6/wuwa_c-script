using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD8 RID: 10968
	public class EnterPatrolState : ActionParams
	{
		// Token: 0x0600F087 RID: 61575 RVA: 0x0022EC88 File Offset: 0x0022CE88
		[NullableContext(1)]
		public static EnterPatrolState Create(IEnterPatrolState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterPatrolState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008452 RID: 33874
		private IEnterPatrolState Instance;
	}
}
