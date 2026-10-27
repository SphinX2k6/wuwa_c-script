using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200156B RID: 5483
	public class DetectTrigger : ActionParams
	{
		// Token: 0x06007BCB RID: 31691 RVA: 0x0012A0CA File Offset: 0x001282CA
		[NullableContext(1)]
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

		// Token: 0x04004743 RID: 18243
		[Nullable(2)]
		protected new DetectTrigger FbInstance;
	}
}
