using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002998 RID: 10648
	public class DetectTrigger : ActionParams
	{
		// Token: 0x0600EC0B RID: 60427 RVA: 0x0022C1E8 File Offset: 0x0022A3E8
		public static DetectTrigger Create(IDetectTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DetectTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040081FC RID: 33276
		private IDetectTrigger Instance;
	}
}
