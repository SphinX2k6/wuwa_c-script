using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F1 RID: 30449
	public class ISceneUiSubtitleStyleBaseT
	{
		// Token: 0x1700DF5C RID: 57180
		// (get) Token: 0x060356DF RID: 218847 RVA: 0x0072A79B File Offset: 0x0072899B
		// (set) Token: 0x060356E0 RID: 218848 RVA: 0x0072A7A3 File Offset: 0x007289A3
		public TSceneUiSubtitlePositionUnion Position { get; set; }

		// Token: 0x1700DF5D RID: 57181
		// (get) Token: 0x060356E1 RID: 218849 RVA: 0x0072A7AC File Offset: 0x007289AC
		// (set) Token: 0x060356E2 RID: 218850 RVA: 0x0072A7B4 File Offset: 0x007289B4
		public bool LockFacingCamera { get; set; }

		// Token: 0x1700DF5E RID: 57182
		// (get) Token: 0x060356E3 RID: 218851 RVA: 0x0072A7BD File Offset: 0x007289BD
		// (set) Token: 0x060356E4 RID: 218852 RVA: 0x0072A7C5 File Offset: 0x007289C5
		public bool IsOccluded { get; set; }

		// Token: 0x1700DF5F RID: 57183
		// (get) Token: 0x060356E5 RID: 218853 RVA: 0x0072A7CE File Offset: 0x007289CE
		// (set) Token: 0x060356E6 RID: 218854 RVA: 0x0072A7D6 File Offset: 0x007289D6
		public ISceneUiSubtitleLocalizationConfigT LocalizationConfig { get; set; }

		// Token: 0x1700DF60 RID: 57184
		// (get) Token: 0x060356E7 RID: 218855 RVA: 0x0072A7DF File Offset: 0x007289DF
		// (set) Token: 0x060356E8 RID: 218856 RVA: 0x0072A7E7 File Offset: 0x007289E7
		public ESceneUiSubtitleStyleType Type { get; set; }

		// Token: 0x1700DF61 RID: 57185
		// (get) Token: 0x060356E9 RID: 218857 RVA: 0x0072A7F0 File Offset: 0x007289F0
		// (set) Token: 0x060356EA RID: 218858 RVA: 0x0072A7F8 File Offset: 0x007289F8
		public byte NullMask { get; set; }

		// Token: 0x060356EB RID: 218859 RVA: 0x0072A801 File Offset: 0x00728A01
		public ISceneUiSubtitleStyleBaseT()
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
