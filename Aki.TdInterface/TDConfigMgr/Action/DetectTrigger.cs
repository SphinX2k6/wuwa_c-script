using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016C9 RID: 5833
	public class DetectTrigger : ActionParams
	{
		// Token: 0x060082A9 RID: 33449 RVA: 0x00139176 File Offset: 0x00137376
		public static DetectTrigger Create([Nullable(2)] DetectTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DetectTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004AE3 RID: 19171
		[Nullable(2)]
		protected new DetectTrigger FbInstance;
	}
}
