using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001319 RID: 4889
	public class IQuestScheduleType
	{
		// Token: 0x06007042 RID: 28738 RVA: 0x0010F3D6 File Offset: 0x0010D5D6
		[NullableContext(1)]
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

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x06007043 RID: 28739 RVA: 0x0010F3F5 File Offset: 0x0010D5F5
		public virtual EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x040040C5 RID: 16581
		private IQuestScheduleType Instance;
	}
}
