using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001357 RID: 4951
	public class IChildQuestConfig
	{
		// Token: 0x06007161 RID: 29025 RVA: 0x001114B6 File Offset: 0x0010F6B6
		[NullableContext(1)]
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

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x06007162 RID: 29026 RVA: 0x001114D8 File Offset: 0x0010F6D8
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

		// Token: 0x0400417D RID: 16765
		private IChildQuestConfig Instance;
	}
}
