using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004467 RID: 17511
	public class IQuestScheduleMainTitleT
	{
		// Token: 0x17007984 RID: 31108
		// (get) Token: 0x0601926D RID: 103021 RVA: 0x00396933 File Offset: 0x00394B33
		// (set) Token: 0x0601926E RID: 103022 RVA: 0x0039693B File Offset: 0x00394B3B
		public string TidTitle { get; set; }

		// Token: 0x17007985 RID: 31109
		// (get) Token: 0x0601926F RID: 103023 RVA: 0x00396944 File Offset: 0x00394B44
		// (set) Token: 0x06019270 RID: 103024 RVA: 0x0039694C File Offset: 0x00394B4C
		public TQuestScheduleUnion QuestScheduleType { get; set; }

		// Token: 0x17007986 RID: 31110
		// (get) Token: 0x06019271 RID: 103025 RVA: 0x00396955 File Offset: 0x00394B55
		// (set) Token: 0x06019272 RID: 103026 RVA: 0x0039695D File Offset: 0x00394B5D
		public int CustomIcon { get; set; }

		// Token: 0x17007987 RID: 31111
		// (get) Token: 0x06019273 RID: 103027 RVA: 0x00396966 File Offset: 0x00394B66
		// (set) Token: 0x06019274 RID: 103028 RVA: 0x0039696E File Offset: 0x00394B6E
		public byte NullMask { get; set; }

		// Token: 0x06019275 RID: 103029 RVA: 0x00396977 File Offset: 0x00394B77
		public IQuestScheduleMainTitleT()
		{
			this.TidTitle = null;
			this.QuestScheduleType = null;
			this.CustomIcon = 0;
			this.NullMask = 0;
		}
	}
}
