using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA8 RID: 10920
	public class StopMotorCruise : ActionParams
	{
		// Token: 0x0600EFC4 RID: 61380 RVA: 0x0022D85B File Offset: 0x0022BA5B
		[NullableContext(1)]
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

		// Token: 0x040083EA RID: 33770
		private IStopMotorCruise Instance;
	}
}
