using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B9A RID: 31642
	public class ITeleportTransitionWithCustomScreenT
	{
		// Token: 0x1700ECEC RID: 60652
		// (get) Token: 0x06039005 RID: 233477 RVA: 0x007B43E8 File Offset: 0x007B25E8
		// (set) Token: 0x06039006 RID: 233478 RVA: 0x007B43F0 File Offset: 0x007B25F0
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECED RID: 60653
		// (get) Token: 0x06039007 RID: 233479 RVA: 0x007B43F9 File Offset: 0x007B25F9
		// (set) Token: 0x06039008 RID: 233480 RVA: 0x007B4401 File Offset: 0x007B2601
		public TCustomScreenUnion ScreenType { get; set; }

		// Token: 0x1700ECEE RID: 60654
		// (get) Token: 0x06039009 RID: 233481 RVA: 0x007B440A File Offset: 0x007B260A
		// (set) Token: 0x0603900A RID: 233482 RVA: 0x007B4412 File Offset: 0x007B2612
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700ECEF RID: 60655
		// (get) Token: 0x0603900B RID: 233483 RVA: 0x007B441B File Offset: 0x007B261B
		// (set) Token: 0x0603900C RID: 233484 RVA: 0x007B4423 File Offset: 0x007B2623
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x1700ECF0 RID: 60656
		// (get) Token: 0x0603900D RID: 233485 RVA: 0x007B442C File Offset: 0x007B262C
		// (set) Token: 0x0603900E RID: 233486 RVA: 0x007B4434 File Offset: 0x007B2634
		public float KeepTime { get; set; }

		// Token: 0x1700ECF1 RID: 60657
		// (get) Token: 0x0603900F RID: 233487 RVA: 0x007B443D File Offset: 0x007B263D
		// (set) Token: 0x06039010 RID: 233488 RVA: 0x007B4445 File Offset: 0x007B2645
		public ICustomShowUiT CustomShowUi { get; set; }

		// Token: 0x1700ECF2 RID: 60658
		// (get) Token: 0x06039011 RID: 233489 RVA: 0x007B444E File Offset: 0x007B264E
		// (set) Token: 0x06039012 RID: 233490 RVA: 0x007B4456 File Offset: 0x007B2656
		public string StartAkEvent { get; set; }

		// Token: 0x1700ECF3 RID: 60659
		// (get) Token: 0x06039013 RID: 233491 RVA: 0x007B445F File Offset: 0x007B265F
		// (set) Token: 0x06039014 RID: 233492 RVA: 0x007B4467 File Offset: 0x007B2667
		public byte NullMask { get; set; }

		// Token: 0x06039015 RID: 233493 RVA: 0x007B4470 File Offset: 0x007B2670
		public ITeleportTransitionWithCustomScreenT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ScreenType = null;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
			this.KeepTime = 0f;
			this.CustomShowUi = null;
			this.StartAkEvent = null;
			this.NullMask = 0;
		}
	}
}
