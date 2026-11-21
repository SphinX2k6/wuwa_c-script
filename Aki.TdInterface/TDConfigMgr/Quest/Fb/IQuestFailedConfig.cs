using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001597 RID: 5527
	public class IQuestFailedConfig
	{
		// Token: 0x06007CA4 RID: 31908 RVA: 0x001282F9 File Offset: 0x001264F9
		public static IQuestFailedConfig Create(IQuestFailedConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x06007CA5 RID: 31909 RVA: 0x00128318 File Offset: 0x00126518
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

		// Token: 0x040047F3 RID: 18419
		private IQuestFailedConfig Instance;
	}
}
