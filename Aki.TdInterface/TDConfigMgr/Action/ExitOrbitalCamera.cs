using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001895 RID: 6293
	public class ExitOrbitalCamera : ActionParams
	{
		// Token: 0x0600841B RID: 33819 RVA: 0x0013B9D6 File Offset: 0x00139BD6
		public static ExitOrbitalCamera Create([Nullable(2)] ExitOrbitalCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitOrbitalCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x04005422 RID: 21538
		[Nullable(2)]
		protected new ExitOrbitalCamera FbInstance;
	}
}
