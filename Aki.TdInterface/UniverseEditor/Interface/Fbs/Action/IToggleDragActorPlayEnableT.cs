using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FE RID: 29694
	public class IToggleDragActorPlayEnableT
	{
		// Token: 0x1700E18B RID: 57739
		// (get) Token: 0x06035F29 RID: 220969 RVA: 0x007575E9 File Offset: 0x007557E9
		// (set) Token: 0x06035F2A RID: 220970 RVA: 0x007575F1 File Offset: 0x007557F1
		public EToggleDragActorPlayType Type { get; set; }

		// Token: 0x1700E18C RID: 57740
		// (get) Token: 0x06035F2B RID: 220971 RVA: 0x007575FA File Offset: 0x007557FA
		// (set) Token: 0x06035F2C RID: 220972 RVA: 0x00757602 File Offset: 0x00755802
		public IFixedCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700E18D RID: 57741
		// (get) Token: 0x06035F2D RID: 220973 RVA: 0x0075760B File Offset: 0x0075580B
		// (set) Token: 0x06035F2E RID: 220974 RVA: 0x00757613 File Offset: 0x00755813
		public string TidMainText { get; set; }

		// Token: 0x1700E18E RID: 57742
		// (get) Token: 0x06035F2F RID: 220975 RVA: 0x0075761C File Offset: 0x0075581C
		// (set) Token: 0x06035F30 RID: 220976 RVA: 0x00757624 File Offset: 0x00755824
		public string TidSubText { get; set; }

		// Token: 0x1700E18F RID: 57743
		// (get) Token: 0x06035F31 RID: 220977 RVA: 0x0075762D File Offset: 0x0075582D
		// (set) Token: 0x06035F32 RID: 220978 RVA: 0x00757635 File Offset: 0x00755835
		public string TidHintText { get; set; }

		// Token: 0x1700E190 RID: 57744
		// (get) Token: 0x06035F33 RID: 220979 RVA: 0x0075763E File Offset: 0x0075583E
		// (set) Token: 0x06035F34 RID: 220980 RVA: 0x00757646 File Offset: 0x00755846
		public bool KeepDialog { get; set; }

		// Token: 0x1700E191 RID: 57745
		// (get) Token: 0x06035F35 RID: 220981 RVA: 0x0075764F File Offset: 0x0075584F
		// (set) Token: 0x06035F36 RID: 220982 RVA: 0x00757657 File Offset: 0x00755857
		public bool DisableExit { get; set; }

		// Token: 0x1700E192 RID: 57746
		// (get) Token: 0x06035F37 RID: 220983 RVA: 0x00757660 File Offset: 0x00755860
		// (set) Token: 0x06035F38 RID: 220984 RVA: 0x00757668 File Offset: 0x00755868
		public byte NullMask { get; set; }

		// Token: 0x06035F39 RID: 220985 RVA: 0x00757671 File Offset: 0x00755871
		public IToggleDragActorPlayEnableT()
		{
			this.Type = EToggleDragActorPlayType.Enable;
			this.CameraConfig = null;
			this.TidMainText = null;
			this.TidSubText = null;
			this.TidHintText = null;
			this.KeepDialog = false;
			this.DisableExit = false;
			this.NullMask = 0;
		}
	}
}
