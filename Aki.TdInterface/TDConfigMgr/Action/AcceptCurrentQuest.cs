using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200147F RID: 5247
	public class AcceptCurrentQuest : ActionParams
	{
		// Token: 0x06007769 RID: 30569 RVA: 0x0011EB3B File Offset: 0x0011CD3B
		[NullableContext(1)]
		public static AcceptCurrentQuest Create([Nullable(2)] AcceptCurrentQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AcceptCurrentQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400457C RID: 17788
		[Nullable(2)]
		protected new AcceptCurrentQuest FbInstance;
	}
}
