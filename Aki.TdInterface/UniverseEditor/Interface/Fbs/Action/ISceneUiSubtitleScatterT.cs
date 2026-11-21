using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EE RID: 30446
	public class ISceneUiSubtitleScatterT
	{
		// Token: 0x1700DF4F RID: 57167
		// (get) Token: 0x060356B5 RID: 218805 RVA: 0x0072A153 File Offset: 0x00728353
		// (set) Token: 0x060356B6 RID: 218806 RVA: 0x0072A15B File Offset: 0x0072835B
		public TSceneUiSubtitlePositionUnion Position { get; set; }

		// Token: 0x1700DF50 RID: 57168
		// (get) Token: 0x060356B7 RID: 218807 RVA: 0x0072A164 File Offset: 0x00728364
		// (set) Token: 0x060356B8 RID: 218808 RVA: 0x0072A16C File Offset: 0x0072836C
		public bool LockFacingCamera { get; set; }

		// Token: 0x1700DF51 RID: 57169
		// (get) Token: 0x060356B9 RID: 218809 RVA: 0x0072A175 File Offset: 0x00728375
		// (set) Token: 0x060356BA RID: 218810 RVA: 0x0072A17D File Offset: 0x0072837D
		public bool IsOccluded { get; set; }

		// Token: 0x1700DF52 RID: 57170
		// (get) Token: 0x060356BB RID: 218811 RVA: 0x0072A186 File Offset: 0x00728386
		// (set) Token: 0x060356BC RID: 218812 RVA: 0x0072A18E File Offset: 0x0072838E
		public ISceneUiSubtitleLocalizationConfigT LocalizationConfig { get; set; }

		// Token: 0x1700DF53 RID: 57171
		// (get) Token: 0x060356BD RID: 218813 RVA: 0x0072A197 File Offset: 0x00728397
		// (set) Token: 0x060356BE RID: 218814 RVA: 0x0072A19F File Offset: 0x0072839F
		public ESceneUiSubtitleStyleType Type { get; set; }

		// Token: 0x1700DF54 RID: 57172
		// (get) Token: 0x060356BF RID: 218815 RVA: 0x0072A1A8 File Offset: 0x007283A8
		// (set) Token: 0x060356C0 RID: 218816 RVA: 0x0072A1B0 File Offset: 0x007283B0
		public byte NullMask { get; set; }

		// Token: 0x060356C1 RID: 218817 RVA: 0x0072A1B9 File Offset: 0x007283B9
		public ISceneUiSubtitleScatterT()
		{
			this.Position = null;
			this.LockFacingCamera = false;
			this.IsOccluded = false;
			this.LocalizationConfig = null;
			this.Type = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
			this.NullMask = 0;
		}
	}
}
