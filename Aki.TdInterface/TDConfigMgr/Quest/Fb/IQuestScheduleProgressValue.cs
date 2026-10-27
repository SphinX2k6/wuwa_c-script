using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001329 RID: 4905
	public class IQuestScheduleProgressValue : IQuestScheduleType
	{
		// Token: 0x06007087 RID: 28807 RVA: 0x0010FABB File Offset: 0x0010DCBB
		[NullableContext(1)]
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

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06007088 RID: 28808 RVA: 0x0010FADA File Offset: 0x0010DCDA
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x0010FAE7 File Offset: 0x0010DCE7
		public virtual int TargetProgressEntity
		{
			get
			{
				return this.Instance.TargetProgressEntity;
			}
		}

		// Token: 0x040040E9 RID: 16617
		private IQuestScheduleProgressValue Instance;
	}
}
