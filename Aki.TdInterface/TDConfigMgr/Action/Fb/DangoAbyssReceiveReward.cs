using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF5 RID: 11509
	public class DangoAbyssReceiveReward : ActionParams
	{
		// Token: 0x0600FBF8 RID: 64504 RVA: 0x00247614 File Offset: 0x00245814
		public static DangoAbyssReceiveReward Create(IDangoAbyssReceiveReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssReceiveReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400899D RID: 35229
		private IDangoAbyssReceiveReward Instance;
	}
}
