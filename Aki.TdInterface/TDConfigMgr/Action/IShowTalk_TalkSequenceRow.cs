using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209F RID: 8351
	public class IShowTalk_TalkSequenceRow
	{
		// Token: 0x0600B161 RID: 45409 RVA: 0x0018EE50 File Offset: 0x0018D050
		public static IShowTalk_TalkSequenceRow Create([Nullable(2)] IShowTalk_TalkSequenceRow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalk_TalkSequenceRow
			{
				FbInstance = instance
			};
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600B162 RID: 45410 RVA: 0x0018EE63 File Offset: 0x0018D063
		public virtual List<int> Items
		{
			get
			{
				return this.FbInstance.Items;
			}
		}

		// Token: 0x0400696D RID: 26989
		private IShowTalk_TalkSequenceRow FbInstance;
	}
}
