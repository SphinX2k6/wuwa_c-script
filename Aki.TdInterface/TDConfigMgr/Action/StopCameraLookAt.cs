using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221E RID: 8734
	public class StopCameraLookAt : ActionParams
	{
		// Token: 0x0600BFC2 RID: 49090 RVA: 0x001B8D2A File Offset: 0x001B6F2A
		[NullableContext(1)]
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

		// Token: 0x0400725C RID: 29276
		[Nullable(2)]
		protected new StopCameraLookAt FbInstance;
	}
}
