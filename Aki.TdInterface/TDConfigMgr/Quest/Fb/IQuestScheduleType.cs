using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001469 RID: 5225
	public class IQuestScheduleType
	{
		// Token: 0x060076E2 RID: 30434 RVA: 0x0011D942 File Offset: 0x0011BB42
		public static IQuestScheduleType Create(IQuestScheduleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x0011D961 File Offset: 0x0011BB61
		public virtual EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x04004441 RID: 17473
		private IQuestScheduleType Instance;
	}
}
