using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005164 RID: 20836
	public class IOpenDateConditonT
	{
		// Token: 0x17009545 RID: 38213
		// (get) Token: 0x06020C73 RID: 134259 RVA: 0x00489F80 File Offset: 0x00488180
		// (set) Token: 0x06020C74 RID: 134260 RVA: 0x00489F88 File Offset: 0x00488188
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009546 RID: 38214
		// (get) Token: 0x06020C75 RID: 134261 RVA: 0x00489F91 File Offset: 0x00488191
		// (set) Token: 0x06020C76 RID: 134262 RVA: 0x00489F99 File Offset: 0x00488199
		public int DateId { get; set; }

		// Token: 0x17009547 RID: 38215
		// (get) Token: 0x06020C77 RID: 134263 RVA: 0x00489FA2 File Offset: 0x004881A2
		// (set) Token: 0x06020C78 RID: 134264 RVA: 0x00489FAA File Offset: 0x004881AA
		public EQuestOpenDateType OpenType { get; set; }

		// Token: 0x17009548 RID: 38216
		// (get) Token: 0x06020C79 RID: 134265 RVA: 0x00489FB3 File Offset: 0x004881B3
		// (set) Token: 0x06020C7A RID: 134266 RVA: 0x00489FBB File Offset: 0x004881BB
		public byte NullMask { get; set; }

		// Token: 0x06020C7B RID: 134267 RVA: 0x00489FC4 File Offset: 0x004881C4
		public IOpenDateConditonT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.DateId = 0;
			this.OpenType = EQuestOpenDateType.AfterBeginTime;
			this.NullMask = 0;
		}
	}
}
