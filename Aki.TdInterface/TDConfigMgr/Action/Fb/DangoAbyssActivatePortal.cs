using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF4 RID: 11508
	public class DangoAbyssActivatePortal : ActionParams
	{
		// Token: 0x0600FBF6 RID: 64502 RVA: 0x002475ED File Offset: 0x002457ED
		public static DangoAbyssActivatePortal Create(IDangoAbyssActivatePortal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssActivatePortal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400899C RID: 35228
		private IDangoAbyssActivatePortal Instance;
	}
}
