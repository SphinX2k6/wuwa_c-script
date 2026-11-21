using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DD RID: 5597
	[JsonConverter(typeof(ActionParamsConverter))]
	public class ActionParams
	{
		// Token: 0x06007E5A RID: 32346 RVA: 0x0012DBC9 File Offset: 0x0012BDC9
		public static ActionParams Create([Nullable(2)] ActionParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActionParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004927 RID: 18727
		[Nullable(2)]
		protected ActionParams FbInstance;
	}
}
