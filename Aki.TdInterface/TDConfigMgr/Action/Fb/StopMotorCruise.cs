using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D9C RID: 11676
	public class StopMotorCruise : ActionParams
	{
		// Token: 0x0600FE7A RID: 65146 RVA: 0x0024B567 File Offset: 0x00249767
		public static StopMotorCruise Create(IStopMotorCruise? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopMotorCruise
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008AEE RID: 35566
		private IStopMotorCruise Instance;
	}
}
