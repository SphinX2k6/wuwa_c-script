using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146A RID: 5226
	public class IQuestScheduleNone : IQuestScheduleType
	{
		// Token: 0x060076E5 RID: 30437 RVA: 0x0011D976 File Offset: 0x0011BB76
		public static IQuestScheduleNone Create(IQuestScheduleNone? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleNone
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x060076E6 RID: 30438 RVA: 0x0011D995 File Offset: 0x0011BB95
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x04004442 RID: 17474
		private IQuestScheduleNone Instance;
	}
}
