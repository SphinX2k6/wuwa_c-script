using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A7 RID: 5287
	public class IChildQuestConfig
	{
		// Token: 0x06007801 RID: 30721 RVA: 0x0011FA22 File Offset: 0x0011DC22
		public static IChildQuestConfig Create(IChildQuestConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildQuestConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x06007802 RID: 30722 RVA: 0x0011FA44 File Offset: 0x0011DC44
		public virtual EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EOnlineParticipateRule?((EOnlineParticipateRule)this.Instance.OnlineParticipateRule);
			}
		}

		// Token: 0x040044F9 RID: 17657
		private IChildQuestConfig Instance;
	}
}
