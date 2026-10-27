using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200131B RID: 4891
	public class IQuestScheduleEntityHP : IQuestScheduleType
	{
		// Token: 0x06007048 RID: 28744 RVA: 0x0010F43E File Offset: 0x0010D63E
		[NullableContext(1)]
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

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x0010F45D File Offset: 0x0010D65D
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x0010F46A File Offset: 0x0010D66A
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040040C7 RID: 16583
		private IQuestScheduleEntityHP Instance;
	}
}
