using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004026 RID: 16422
	public class IQuestScheduleMainTitleT
	{
		// Token: 0x17007382 RID: 29570
		// (get) Token: 0x06017BD4 RID: 97236 RVA: 0x0036CB3F File Offset: 0x0036AD3F
		// (set) Token: 0x06017BD5 RID: 97237 RVA: 0x0036CB47 File Offset: 0x0036AD47
		public string TidTitle { get; set; }

		// Token: 0x17007383 RID: 29571
		// (get) Token: 0x06017BD6 RID: 97238 RVA: 0x0036CB50 File Offset: 0x0036AD50
		// (set) Token: 0x06017BD7 RID: 97239 RVA: 0x0036CB58 File Offset: 0x0036AD58
		public TQuestScheduleUnion QuestScheduleType { get; set; }

		// Token: 0x17007384 RID: 29572
		// (get) Token: 0x06017BD8 RID: 97240 RVA: 0x0036CB61 File Offset: 0x0036AD61
		// (set) Token: 0x06017BD9 RID: 97241 RVA: 0x0036CB69 File Offset: 0x0036AD69
		public int CustomIcon { get; set; }

		// Token: 0x17007385 RID: 29573
		// (get) Token: 0x06017BDA RID: 97242 RVA: 0x0036CB72 File Offset: 0x0036AD72
		// (set) Token: 0x06017BDB RID: 97243 RVA: 0x0036CB7A File Offset: 0x0036AD7A
		public byte NullMask { get; set; }

		// Token: 0x06017BDC RID: 97244 RVA: 0x0036CB83 File Offset: 0x0036AD83
		public IQuestScheduleMainTitleT()
		{
			this.TidTitle = null;
			this.QuestScheduleType = null;
			this.CustomIcon = 0;
			this.NullMask = 0;
		}
	}
}
