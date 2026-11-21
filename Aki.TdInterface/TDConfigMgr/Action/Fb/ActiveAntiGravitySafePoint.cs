using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D1B RID: 11547
	public class ActiveAntiGravitySafePoint : ActionParams
	{
		// Token: 0x0600FC83 RID: 64643 RVA: 0x0024849A File Offset: 0x0024669A
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

		// Token: 0x040089E5 RID: 35301
		private IActiveAntiGravitySafePoint Instance;
	}
}
