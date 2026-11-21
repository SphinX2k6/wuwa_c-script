using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235B RID: 9051
	public class PerformAiHideSelf : ActionParams
	{
		// Token: 0x0600C54C RID: 50508 RVA: 0x001C48C2 File Offset: 0x001C2AC2
		public static PerformAiHideSelf Create([Nullable(2)] PerformAiHideSelf instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformAiHideSelf
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007574 RID: 30068
		[Nullable(2)]
		protected new PerformAiHideSelf FbInstance;
	}
}
