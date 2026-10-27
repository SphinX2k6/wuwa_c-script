using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A07 RID: 10759
	public class DangoAbyssActivatePortal : ActionParams
	{
		// Token: 0x0600ED5F RID: 60767 RVA: 0x00229C69 File Offset: 0x00227E69
		[NullableContext(1)]
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

		// Token: 0x040082AB RID: 33451
		private IDangoAbyssActivatePortal Instance;
	}
}
