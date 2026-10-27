using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D4 RID: 10452
	public class ExitOrbitalCamera : ActionParams
	{
		// Token: 0x0600E821 RID: 59425 RVA: 0x00221206 File Offset: 0x0021F406
		[NullableContext(1)]
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

		// Token: 0x04008050 RID: 32848
		private IExitOrbitalCamera Instance;
	}
}
