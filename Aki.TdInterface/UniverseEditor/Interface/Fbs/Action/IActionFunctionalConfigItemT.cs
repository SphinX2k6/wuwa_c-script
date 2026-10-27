using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200607B RID: 24699
	public class IActionFunctionalConfigItemT
	{
		// Token: 0x1700B606 RID: 46598
		// (get) Token: 0x06029D50 RID: 171344 RVA: 0x005BD246 File Offset: 0x005BB446
		// (set) Token: 0x06029D51 RID: 171345 RVA: 0x005BD24E File Offset: 0x005BB44E
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x1700B607 RID: 46599
		// (get) Token: 0x06029D52 RID: 171346 RVA: 0x005BD257 File Offset: 0x005BB457
		// (set) Token: 0x06029D53 RID: 171347 RVA: 0x005BD25F File Offset: 0x005BB45F
		public bool IsDetectScreenOccupation { get; set; }

		// Token: 0x1700B608 RID: 46600
		// (get) Token: 0x06029D54 RID: 171348 RVA: 0x005BD268 File Offset: 0x005BB468
		// (set) Token: 0x06029D55 RID: 171349 RVA: 0x005BD270 File Offset: 0x005BB470
		public bool IsWithResultOnly { get; set; }

		// Token: 0x1700B609 RID: 46601
		// (get) Token: 0x06029D56 RID: 171350 RVA: 0x005BD279 File Offset: 0x005BB479
		// (set) Token: 0x06029D57 RID: 171351 RVA: 0x005BD281 File Offset: 0x005BB481
		public bool IsOperatePlayer { get; set; }

		// Token: 0x1700B60A RID: 46602
		// (get) Token: 0x06029D58 RID: 171352 RVA: 0x005BD28A File Offset: 0x005BB48A
		// (set) Token: 0x06029D59 RID: 171353 RVA: 0x005BD292 File Offset: 0x005BB492
		public byte NullMask { get; set; }

		// Token: 0x06029D5A RID: 171354 RVA: 0x005BD29B File Offset: 0x005BB49B
		public IActionFunctionalConfigItemT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.IsDetectScreenOccupation = false;
			this.IsWithResultOnly = false;
			this.IsOperatePlayer = false;
			this.NullMask = 0;
		}
	}
}
