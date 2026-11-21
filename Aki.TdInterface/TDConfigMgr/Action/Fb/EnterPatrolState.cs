using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DCC RID: 11724
	public class EnterPatrolState : ActionParams
	{
		// Token: 0x0600FF3D RID: 65341 RVA: 0x0024C994 File Offset: 0x0024AB94
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

		// Token: 0x04008B56 RID: 35670
		private IEnterPatrolState Instance;
	}
}
