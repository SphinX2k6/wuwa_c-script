using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015D8 RID: 5592
	public class AcceptCurrentQuest : ActionParams
	{
		// Token: 0x06007E36 RID: 32310 RVA: 0x0012D787 File Offset: 0x0012B987
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

		// Token: 0x04004917 RID: 18711
		[Nullable(2)]
		protected new AcceptCurrentQuest FbInstance;
	}
}
