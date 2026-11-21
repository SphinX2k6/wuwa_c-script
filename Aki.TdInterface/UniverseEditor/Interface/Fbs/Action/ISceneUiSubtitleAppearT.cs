using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D0 RID: 30416
	public class ISceneUiSubtitleAppearT
	{
		// Token: 0x1700DF17 RID: 57111
		// (get) Token: 0x060355BD RID: 218557 RVA: 0x00728357 File Offset: 0x00726557
		// (set) Token: 0x060355BE RID: 218558 RVA: 0x0072835F File Offset: 0x0072655F
		public TSceneUiSubtitlePositionUnion Position { get; set; }

		// Token: 0x1700DF18 RID: 57112
		// (get) Token: 0x060355BF RID: 218559 RVA: 0x00728368 File Offset: 0x00726568
		// (set) Token: 0x060355C0 RID: 218560 RVA: 0x00728370 File Offset: 0x00726570
		public bool LockFacingCamera { get; set; }

		// Token: 0x1700DF19 RID: 57113
		// (get) Token: 0x060355C1 RID: 218561 RVA: 0x00728379 File Offset: 0x00726579
		// (set) Token: 0x060355C2 RID: 218562 RVA: 0x00728381 File Offset: 0x00726581
		public bool IsOccluded { get; set; }

		// Token: 0x1700DF1A RID: 57114
		// (get) Token: 0x060355C3 RID: 218563 RVA: 0x0072838A File Offset: 0x0072658A
		// (set) Token: 0x060355C4 RID: 218564 RVA: 0x00728392 File Offset: 0x00726592
		public ISceneUiSubtitleLocalizationConfigT LocalizationConfig { get; set; }

		// Token: 0x1700DF1B RID: 57115
		// (get) Token: 0x060355C5 RID: 218565 RVA: 0x0072839B File Offset: 0x0072659B
		// (set) Token: 0x060355C6 RID: 218566 RVA: 0x007283A3 File Offset: 0x007265A3
		public ESceneUiSubtitleStyleType Type { get; set; }

		// Token: 0x1700DF1C RID: 57116
		// (get) Token: 0x060355C7 RID: 218567 RVA: 0x007283AC File Offset: 0x007265AC
		// (set) Token: 0x060355C8 RID: 218568 RVA: 0x007283B4 File Offset: 0x007265B4
		public byte NullMask { get; set; }

		// Token: 0x060355C9 RID: 218569 RVA: 0x007283BD File Offset: 0x007265BD
		public ISceneUiSubtitleAppearT()
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
