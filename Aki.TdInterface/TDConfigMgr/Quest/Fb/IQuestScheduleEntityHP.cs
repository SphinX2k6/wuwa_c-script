using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146B RID: 5227
	public class IQuestScheduleEntityHP : IQuestScheduleType
	{
		// Token: 0x060076E8 RID: 30440 RVA: 0x0011D9AA File Offset: 0x0011BBAA
		public static IQuestScheduleEntityHP Create(IQuestScheduleEntityHP? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleEntityHP
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x060076E9 RID: 30441 RVA: 0x0011D9C9 File Offset: 0x0011BBC9
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x060076EA RID: 30442 RVA: 0x0011D9D6 File Offset: 0x0011BBD6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04004443 RID: 17475
		private IQuestScheduleEntityHP Instance;
	}
}
