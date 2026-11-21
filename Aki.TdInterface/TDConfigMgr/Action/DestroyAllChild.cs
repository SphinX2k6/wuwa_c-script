using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B9 RID: 5817
	public class DestroyAllChild : ActionParams
	{
		// Token: 0x06008265 RID: 33381 RVA: 0x00138A64 File Offset: 0x00136C64
		public static DestroyAllChild Create([Nullable(2)] DestroyAllChild instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyAllChild
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004AC4 RID: 19140
		[Nullable(2)]
		protected new DestroyAllChild FbInstance;
	}
}
