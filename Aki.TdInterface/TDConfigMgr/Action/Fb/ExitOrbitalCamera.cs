using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA9 RID: 11177
	public class ExitOrbitalCamera : ActionParams
	{
		// Token: 0x0600F650 RID: 63056 RVA: 0x0023E186 File Offset: 0x0023C386
		public static ExitOrbitalCamera Create(IExitOrbitalCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitOrbitalCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400870F RID: 34575
		private IExitOrbitalCamera Instance;
	}
}
