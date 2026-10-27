using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006072 RID: 24690
	public class IActionConfigItemT
	{
		// Token: 0x1700B5F5 RID: 46581
		// (get) Token: 0x06029D00 RID: 171264 RVA: 0x005BCA2B File Offset: 0x005BAC2B
		// (set) Token: 0x06029D01 RID: 171265 RVA: 0x005BCA33 File Offset: 0x005BAC33
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x1700B5F6 RID: 46582
		// (get) Token: 0x06029D02 RID: 171266 RVA: 0x005BCA3C File Offset: 0x005BAC3C
		// (set) Token: 0x06029D03 RID: 171267 RVA: 0x005BCA44 File Offset: 0x005BAC44
		public bool IsDetectScreenOccupation { get; set; }

		// Token: 0x1700B5F7 RID: 46583
		// (get) Token: 0x06029D04 RID: 171268 RVA: 0x005BCA4D File Offset: 0x005BAC4D
		// (set) Token: 0x06029D05 RID: 171269 RVA: 0x005BCA55 File Offset: 0x005BAC55
		public bool IsWithResultOnly { get; set; }

		// Token: 0x1700B5F8 RID: 46584
		// (get) Token: 0x06029D06 RID: 171270 RVA: 0x005BCA5E File Offset: 0x005BAC5E
		// (set) Token: 0x06029D07 RID: 171271 RVA: 0x005BCA66 File Offset: 0x005BAC66
		public bool IsOperatePlayer { get; set; }

		// Token: 0x1700B5F9 RID: 46585
		// (get) Token: 0x06029D08 RID: 171272 RVA: 0x005BCA6F File Offset: 0x005BAC6F
		// (set) Token: 0x06029D09 RID: 171273 RVA: 0x005BCA77 File Offset: 0x005BAC77
		public string CnName { get; set; }

		// Token: 0x1700B5FA RID: 46586
		// (get) Token: 0x06029D0A RID: 171274 RVA: 0x005BCA80 File Offset: 0x005BAC80
		// (set) Token: 0x06029D0B RID: 171275 RVA: 0x005BCA88 File Offset: 0x005BAC88
		public byte NullMask { get; set; }

		// Token: 0x06029D0C RID: 171276 RVA: 0x005BCA91 File Offset: 0x005BAC91
		public IActionConfigItemT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.IsDetectScreenOccupation = false;
			this.IsWithResultOnly = false;
			this.IsOperatePlayer = false;
			this.CnName = null;
			this.NullMask = 0;
		}
	}
}
