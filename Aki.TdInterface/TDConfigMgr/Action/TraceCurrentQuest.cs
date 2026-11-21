using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BC RID: 9404
	public class TraceCurrentQuest : ActionParams
	{
		// Token: 0x0600CC76 RID: 52342 RVA: 0x001D1F6F File Offset: 0x001D016F
		public static TraceCurrentQuest Create([Nullable(2)] TraceCurrentQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TraceCurrentQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400792A RID: 31018
		[Nullable(2)]
		protected new TraceCurrentQuest FbInstance;
	}
}
