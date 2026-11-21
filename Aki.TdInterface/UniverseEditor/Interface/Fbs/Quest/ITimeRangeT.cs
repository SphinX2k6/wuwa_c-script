using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200462F RID: 17967
	public class ITimeRangeT
	{
		// Token: 0x17007DAB RID: 32171
		// (get) Token: 0x0601A49E RID: 107678 RVA: 0x003BDD72 File Offset: 0x003BBF72
		// (set) Token: 0x0601A49F RID: 107679 RVA: 0x003BDD7A File Offset: 0x003BBF7A
		public IDateTimeT StartTime { get; set; }

		// Token: 0x17007DAC RID: 32172
		// (get) Token: 0x0601A4A0 RID: 107680 RVA: 0x003BDD83 File Offset: 0x003BBF83
		// (set) Token: 0x0601A4A1 RID: 107681 RVA: 0x003BDD8B File Offset: 0x003BBF8B
		public IDateTimeT EndTime { get; set; }

		// Token: 0x0601A4A2 RID: 107682 RVA: 0x003BDD94 File Offset: 0x003BBF94
		public ITimeRangeT()
		{
			this.StartTime = null;
			this.EndTime = null;
		}
	}
}
