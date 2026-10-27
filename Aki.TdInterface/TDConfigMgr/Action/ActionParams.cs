using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001484 RID: 5252
	[JsonConverter(typeof(ActionParamsConverter))]
	public class ActionParams
	{
		// Token: 0x0600778D RID: 30605 RVA: 0x0011EF7D File Offset: 0x0011D17D
		[NullableContext(1)]
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

		// Token: 0x0400458C RID: 17804
		[Nullable(2)]
		protected ActionParams FbInstance;
	}
}
