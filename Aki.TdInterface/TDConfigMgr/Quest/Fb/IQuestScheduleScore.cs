using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200131C RID: 4892
	public class IQuestScheduleScore : IQuestScheduleType
	{
		// Token: 0x0600704C RID: 28748 RVA: 0x0010F47F File Offset: 0x0010D67F
		[NullableContext(1)]
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

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x0010F49E File Offset: 0x0010D69E
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x040040C8 RID: 16584
		private IQuestScheduleScore Instance;
	}
}
