using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B3 RID: 29619
	public class ITeleportTransitionWithCustomScreenT
	{
		// Token: 0x1700E0DC RID: 57564
		// (get) Token: 0x06035C6A RID: 220266 RVA: 0x00751EA8 File Offset: 0x007500A8
		// (set) Token: 0x06035C6B RID: 220267 RVA: 0x00751EB0 File Offset: 0x007500B0
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0DD RID: 57565
		// (get) Token: 0x06035C6C RID: 220268 RVA: 0x00751EB9 File Offset: 0x007500B9
		// (set) Token: 0x06035C6D RID: 220269 RVA: 0x00751EC1 File Offset: 0x007500C1
		public TCustomScreenUnion ScreenType { get; set; }

		// Token: 0x1700E0DE RID: 57566
		// (get) Token: 0x06035C6E RID: 220270 RVA: 0x00751ECA File Offset: 0x007500CA
		// (set) Token: 0x06035C6F RID: 220271 RVA: 0x00751ED2 File Offset: 0x007500D2
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700E0DF RID: 57567
		// (get) Token: 0x06035C70 RID: 220272 RVA: 0x00751EDB File Offset: 0x007500DB
		// (set) Token: 0x06035C71 RID: 220273 RVA: 0x00751EE3 File Offset: 0x007500E3
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x1700E0E0 RID: 57568
		// (get) Token: 0x06035C72 RID: 220274 RVA: 0x00751EEC File Offset: 0x007500EC
		// (set) Token: 0x06035C73 RID: 220275 RVA: 0x00751EF4 File Offset: 0x007500F4
		public float KeepTime { get; set; }

		// Token: 0x1700E0E1 RID: 57569
		// (get) Token: 0x06035C74 RID: 220276 RVA: 0x00751EFD File Offset: 0x007500FD
		// (set) Token: 0x06035C75 RID: 220277 RVA: 0x00751F05 File Offset: 0x00750105
		public ICustomShowUiT CustomShowUi { get; set; }

		// Token: 0x1700E0E2 RID: 57570
		// (get) Token: 0x06035C76 RID: 220278 RVA: 0x00751F0E File Offset: 0x0075010E
		// (set) Token: 0x06035C77 RID: 220279 RVA: 0x00751F16 File Offset: 0x00750116
		public string StartAkEvent { get; set; }

		// Token: 0x1700E0E3 RID: 57571
		// (get) Token: 0x06035C78 RID: 220280 RVA: 0x00751F1F File Offset: 0x0075011F
		// (set) Token: 0x06035C79 RID: 220281 RVA: 0x00751F27 File Offset: 0x00750127
		public byte NullMask { get; set; }

		// Token: 0x06035C7A RID: 220282 RVA: 0x00751F30 File Offset: 0x00750130
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
