using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146C RID: 5228
	public class IQuestScheduleScore : IQuestScheduleType
	{
		// Token: 0x060076EC RID: 30444 RVA: 0x0011D9EB File Offset: 0x0011BBEB
		public static IQuestScheduleScore Create(IQuestScheduleScore? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleScore
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x0011DA0A File Offset: 0x0011BC0A
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x04004444 RID: 17476
		private IQuestScheduleScore Instance;
	}
}
