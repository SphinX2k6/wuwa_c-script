using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2E RID: 10798
	public class ActiveAntiGravitySafePoint : ActionParams
	{
		// Token: 0x0600EDEB RID: 60907 RVA: 0x0022AAE6 File Offset: 0x00228CE6
		[NullableContext(1)]
		public static ActiveAntiGravitySafePoint Create(IActiveAntiGravitySafePoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActiveAntiGravitySafePoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040082F2 RID: 33522
		private IActiveAntiGravitySafePoint Instance;
	}
}
