using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143F RID: 5183
	public class IQuestFailedConfig
	{
		// Token: 0x060075DD RID: 30173 RVA: 0x0011989E File Offset: 0x00117A9E
		[NullableContext(1)]
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

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x060075DE RID: 30174 RVA: 0x001198C0 File Offset: 0x00117AC0
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

		// Token: 0x0400445F RID: 17503
		private IQuestFailedConfig Instance;
	}
}
