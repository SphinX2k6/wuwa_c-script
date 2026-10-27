using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FA RID: 8442
	public class PerformAiHideSelf : ActionParams
	{
		// Token: 0x0600B9C0 RID: 47552 RVA: 0x001AD762 File Offset: 0x001AB962
		[NullableContext(1)]
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

		// Token: 0x04006F40 RID: 28480
		[Nullable(2)]
		protected new PerformAiHideSelf FbInstance;
	}
}
