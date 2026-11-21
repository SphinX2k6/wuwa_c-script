using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B3 RID: 5811
	public class DangoAbyssGotoNextFloor : ActionParams
	{
		// Token: 0x0600824F RID: 33359 RVA: 0x00138861 File Offset: 0x00136A61
		public static DangoAbyssGotoNextFloor Create([Nullable(2)] DangoAbyssGotoNextFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssGotoNextFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004ABB RID: 19131
		[Nullable(2)]
		protected new DangoAbyssGotoNextFloor FbInstance;
	}
}
