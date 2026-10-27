using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200131A RID: 4890
	public class IQuestScheduleNone : IQuestScheduleType
	{
		// Token: 0x06007045 RID: 28741 RVA: 0x0010F40A File Offset: 0x0010D60A
		[NullableContext(1)]
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

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x0010F429 File Offset: 0x0010D629
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x040040C6 RID: 16582
		private IQuestScheduleNone Instance;
	}
}
