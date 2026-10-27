using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6A RID: 7786
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalk_TalkSequenceRow
	{
		// Token: 0x0600A6A9 RID: 42665 RVA: 0x00179150 File Offset: 0x00177350
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

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600A6AA RID: 42666 RVA: 0x00179163 File Offset: 0x00177363
		public virtual List<int> Items
		{
			get
			{
				return this.FbInstance.Items;
			}
		}

		// Token: 0x04006389 RID: 25481
		private IShowTalk_TalkSequenceRow FbInstance;
	}
}
