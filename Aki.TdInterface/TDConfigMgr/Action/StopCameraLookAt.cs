using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002489 RID: 9353
	public class StopCameraLookAt : ActionParams
	{
		// Token: 0x0600CB80 RID: 52096 RVA: 0x001D03F6 File Offset: 0x001CE5F6
		public static StopCameraLookAt Create([Nullable(2)] StopCameraLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopCameraLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x040078A6 RID: 30886
		[Nullable(2)]
		protected new StopCameraLookAt FbInstance;
	}
}
