using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001456 RID: 5206
	public class IRecallConfig
	{
		// Token: 0x06007658 RID: 30296 RVA: 0x0011AA88 File Offset: 0x00118C88
		[NullableContext(1)]
		public static IRecallConfig Create(IRecallConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06007659 RID: 30297 RVA: 0x0011AAA7 File Offset: 0x00118CA7
		public virtual int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x040044B6 RID: 17590
		private IRecallConfig Instance;
	}
}
