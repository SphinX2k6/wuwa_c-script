using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001718 RID: 5912
	public class ExitOrbitalCamera : ActionParams
	{
		// Token: 0x06007D3D RID: 32061 RVA: 0x0012C92A File Offset: 0x0012AB2A
		[NullableContext(1)]
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

		// Token: 0x04004FF3 RID: 20467
		[Nullable(2)]
		protected new ExitOrbitalCamera FbInstance;
	}
}
