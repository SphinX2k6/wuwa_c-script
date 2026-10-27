using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD9 RID: 10969
	public class PerformAiHideSelf : ActionParams
	{
		// Token: 0x0600F089 RID: 61577 RVA: 0x0022ECAF File Offset: 0x0022CEAF
		[NullableContext(1)]
		public static PerformAiHideSelf Create(IPerformAiHideSelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformAiHideSelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008453 RID: 33875
		private IPerformAiHideSelf Instance;
	}
}
