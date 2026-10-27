using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002168 RID: 8552
	public class RestorePhantom : ActionParams
	{
		// Token: 0x0600BC24 RID: 48164 RVA: 0x001B1F86 File Offset: 0x001B0186
		[NullableContext(1)]
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

		// Token: 0x04007065 RID: 28773
		[Nullable(2)]
		protected new RestorePhantom FbInstance;
	}
}
