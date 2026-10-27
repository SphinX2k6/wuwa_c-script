using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FF RID: 8703
	public class ShowAllHidedGroupInFlow : ActionParams
	{
		// Token: 0x0600BF17 RID: 48919 RVA: 0x001B77C6 File Offset: 0x001B59C6
		[NullableContext(1)]
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

		// Token: 0x040071EC RID: 29164
		[Nullable(2)]
		protected new ShowAllHidedGroupInFlow FbInstance;
	}
}
