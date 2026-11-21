using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246A RID: 9322
	public class ShowAllHidedGroupInFlow : ActionParams
	{
		// Token: 0x0600CAD3 RID: 51923 RVA: 0x001CEE52 File Offset: 0x001CD052
		public static ShowAllHidedGroupInFlow Create([Nullable(2)] ShowAllHidedGroupInFlow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowAllHidedGroupInFlow
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007835 RID: 30773
		[Nullable(2)]
		protected new ShowAllHidedGroupInFlow FbInstance;
	}
}
