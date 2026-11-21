using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E2 RID: 17634
	public class IReceiveTelecomChildQuestConditionT
	{
		// Token: 0x17007AC1 RID: 31425
		// (get) Token: 0x06019802 RID: 104450 RVA: 0x003A2F25 File Offset: 0x003A1125
		// (set) Token: 0x06019803 RID: 104451 RVA: 0x003A2F2D File Offset: 0x003A112D
		public EChildQuest Type { get; set; }

		// Token: 0x17007AC2 RID: 31426
		// (get) Token: 0x06019804 RID: 104452 RVA: 0x003A2F36 File Offset: 0x003A1136
		// (set) Token: 0x06019805 RID: 104453 RVA: 0x003A2F3E File Offset: 0x003A113E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007AC3 RID: 31427
		// (get) Token: 0x06019806 RID: 104454 RVA: 0x003A2F47 File Offset: 0x003A1147
		// (set) Token: 0x06019807 RID: 104455 RVA: 0x003A2F4F File Offset: 0x003A114F
		public int TelecomId { get; set; }

		// Token: 0x17007AC4 RID: 31428
		// (get) Token: 0x06019808 RID: 104456 RVA: 0x003A2F58 File Offset: 0x003A1158
		// (set) Token: 0x06019809 RID: 104457 RVA: 0x003A2F60 File Offset: 0x003A1160
		public bool IsAutoAnswer { get; set; }

		// Token: 0x17007AC5 RID: 31429
		// (get) Token: 0x0601980A RID: 104458 RVA: 0x003A2F69 File Offset: 0x003A1169
		// (set) Token: 0x0601980B RID: 104459 RVA: 0x003A2F71 File Offset: 0x003A1171
		public byte NullMask { get; set; }

		// Token: 0x0601980C RID: 104460 RVA: 0x003A2F7A File Offset: 0x003A117A
		public IReceiveTelecomChildQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TelecomId = 0;
			this.IsAutoAnswer = false;
			this.NullMask = 0;
		}
	}
}
