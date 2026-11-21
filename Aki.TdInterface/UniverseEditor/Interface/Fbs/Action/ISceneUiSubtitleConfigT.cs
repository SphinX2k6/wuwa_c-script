using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D3 RID: 30419
	public class ISceneUiSubtitleConfigT
	{
		// Token: 0x1700DF23 RID: 57123
		// (get) Token: 0x060355E5 RID: 218597 RVA: 0x0072892D File Offset: 0x00726B2D
		// (set) Token: 0x060355E6 RID: 218598 RVA: 0x00728935 File Offset: 0x00726B35
		public TSceneUiSubtitlePositionUnion Position { get; set; }

		// Token: 0x1700DF24 RID: 57124
		// (get) Token: 0x060355E7 RID: 218599 RVA: 0x0072893E File Offset: 0x00726B3E
		// (set) Token: 0x060355E8 RID: 218600 RVA: 0x00728946 File Offset: 0x00726B46
		public bool LockFacingCamera { get; set; }

		// Token: 0x1700DF25 RID: 57125
		// (get) Token: 0x060355E9 RID: 218601 RVA: 0x0072894F File Offset: 0x00726B4F
		// (set) Token: 0x060355EA RID: 218602 RVA: 0x00728957 File Offset: 0x00726B57
		public bool IsOccluded { get; set; }

		// Token: 0x1700DF26 RID: 57126
		// (get) Token: 0x060355EB RID: 218603 RVA: 0x00728960 File Offset: 0x00726B60
		// (set) Token: 0x060355EC RID: 218604 RVA: 0x00728968 File Offset: 0x00726B68
		public ISceneUiSubtitleLocalizationConfigT LocalizationConfig { get; set; }

		// Token: 0x1700DF27 RID: 57127
		// (get) Token: 0x060355ED RID: 218605 RVA: 0x00728971 File Offset: 0x00726B71
		// (set) Token: 0x060355EE RID: 218606 RVA: 0x00728979 File Offset: 0x00726B79
		public byte NullMask { get; set; }

		// Token: 0x060355EF RID: 218607 RVA: 0x00728982 File Offset: 0x00726B82
		public ISceneUiSubtitleConfigT()
		{
			this.Position = null;
			this.LockFacingCamera = false;
			this.IsOccluded = false;
			this.LocalizationConfig = null;
			this.NullMask = 0;
		}
	}
}
