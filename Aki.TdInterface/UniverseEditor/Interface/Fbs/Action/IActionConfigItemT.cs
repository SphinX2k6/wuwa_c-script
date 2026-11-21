using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D4 RID: 26324
	public class IActionConfigItemT
	{
		// Token: 0x1700BF60 RID: 48992
		// (get) Token: 0x0602C3B4 RID: 181172 RVA: 0x00605F0F File Offset: 0x0060410F
		// (set) Token: 0x0602C3B5 RID: 181173 RVA: 0x00605F17 File Offset: 0x00604117
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x1700BF61 RID: 48993
		// (get) Token: 0x0602C3B6 RID: 181174 RVA: 0x00605F20 File Offset: 0x00604120
		// (set) Token: 0x0602C3B7 RID: 181175 RVA: 0x00605F28 File Offset: 0x00604128
		public bool IsDetectScreenOccupation { get; set; }

		// Token: 0x1700BF62 RID: 48994
		// (get) Token: 0x0602C3B8 RID: 181176 RVA: 0x00605F31 File Offset: 0x00604131
		// (set) Token: 0x0602C3B9 RID: 181177 RVA: 0x00605F39 File Offset: 0x00604139
		public bool IsWithResultOnly { get; set; }

		// Token: 0x1700BF63 RID: 48995
		// (get) Token: 0x0602C3BA RID: 181178 RVA: 0x00605F42 File Offset: 0x00604142
		// (set) Token: 0x0602C3BB RID: 181179 RVA: 0x00605F4A File Offset: 0x0060414A
		public bool IsOperatePlayer { get; set; }

		// Token: 0x1700BF64 RID: 48996
		// (get) Token: 0x0602C3BC RID: 181180 RVA: 0x00605F53 File Offset: 0x00604153
		// (set) Token: 0x0602C3BD RID: 181181 RVA: 0x00605F5B File Offset: 0x0060415B
		public string CnName { get; set; }

		// Token: 0x1700BF65 RID: 48997
		// (get) Token: 0x0602C3BE RID: 181182 RVA: 0x00605F64 File Offset: 0x00604164
		// (set) Token: 0x0602C3BF RID: 181183 RVA: 0x00605F6C File Offset: 0x0060416C
		public byte NullMask { get; set; }

		// Token: 0x0602C3C0 RID: 181184 RVA: 0x00605F75 File Offset: 0x00604175
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
