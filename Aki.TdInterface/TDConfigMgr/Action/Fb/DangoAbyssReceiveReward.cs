using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A08 RID: 10760
	public class DangoAbyssReceiveReward : ActionParams
	{
		// Token: 0x0600ED61 RID: 60769 RVA: 0x00229C90 File Offset: 0x00227E90
		[NullableContext(1)]
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

		// Token: 0x040082AC RID: 33452
		private IDangoAbyssReceiveReward Instance;
	}
}
