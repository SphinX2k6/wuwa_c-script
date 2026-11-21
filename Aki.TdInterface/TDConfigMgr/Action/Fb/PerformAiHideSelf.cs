using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DCD RID: 11725
	public class PerformAiHideSelf : ActionParams
	{
		// Token: 0x0600FF3F RID: 65343 RVA: 0x0024C9BB File Offset: 0x0024ABBB
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

		// Token: 0x04008B57 RID: 35671
		private IPerformAiHideSelf Instance;
	}
}
