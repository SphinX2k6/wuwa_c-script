using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001479 RID: 5241
	public class IQuestScheduleProgressValue : IQuestScheduleType
	{
		// Token: 0x06007727 RID: 30503 RVA: 0x0011E027 File Offset: 0x0011C227
		public static IQuestScheduleProgressValue Create(IQuestScheduleProgressValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleProgressValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06007728 RID: 30504 RVA: 0x0011E046 File Offset: 0x0011C246
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06007729 RID: 30505 RVA: 0x0011E053 File Offset: 0x0011C253
		public virtual int TargetProgressEntity
		{
			get
			{
				return this.Instance.TargetProgressEntity;
			}
		}

		// Token: 0x04004465 RID: 17509
		private IQuestScheduleProgressValue Instance;
	}
}
