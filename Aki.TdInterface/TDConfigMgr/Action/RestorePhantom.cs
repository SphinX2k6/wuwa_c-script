using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C9 RID: 9161
	public class RestorePhantom : ActionParams
	{
		// Token: 0x0600C7B2 RID: 51122 RVA: 0x001C913A File Offset: 0x001C733A
		public static RestorePhantom Create([Nullable(2)] RestorePhantom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePhantom
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400769A RID: 30362
		[Nullable(2)]
		protected new RestorePhantom FbInstance;
	}
}
