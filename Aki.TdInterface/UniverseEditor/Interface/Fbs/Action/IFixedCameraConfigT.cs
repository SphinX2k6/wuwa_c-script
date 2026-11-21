using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4C RID: 28236
	public class IFixedCameraConfigT
	{
		// Token: 0x1700CEF7 RID: 52983
		// (get) Token: 0x06030C65 RID: 199781 RVA: 0x0069EA7A File Offset: 0x0069CC7A
		// (set) Token: 0x06030C66 RID: 199782 RVA: 0x0069EA82 File Offset: 0x0069CC82
		public float FadeInTime { get; set; }

		// Token: 0x1700CEF8 RID: 52984
		// (get) Token: 0x06030C67 RID: 199783 RVA: 0x0069EA8B File Offset: 0x0069CC8B
		// (set) Token: 0x06030C68 RID: 199784 RVA: 0x0069EA93 File Offset: 0x0069CC93
		public float FadeOutTime { get; set; }

		// Token: 0x1700CEF9 RID: 52985
		// (get) Token: 0x06030C69 RID: 199785 RVA: 0x0069EA9C File Offset: 0x0069CC9C
		// (set) Token: 0x06030C6A RID: 199786 RVA: 0x0069EAA4 File Offset: 0x0069CCA4
		public float Fov { get; set; }

		// Token: 0x1700CEFA RID: 52986
		// (get) Token: 0x06030C6B RID: 199787 RVA: 0x0069EAAD File Offset: 0x0069CCAD
		// (set) Token: 0x06030C6C RID: 199788 RVA: 0x0069EAB5 File Offset: 0x0069CCB5
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700CEFB RID: 52987
		// (get) Token: 0x06030C6D RID: 199789 RVA: 0x0069EABE File Offset: 0x0069CCBE
		// (set) Token: 0x06030C6E RID: 199790 RVA: 0x0069EAC6 File Offset: 0x0069CCC6
		public bool IsDisableDither { get; set; }

		// Token: 0x1700CEFC RID: 52988
		// (get) Token: 0x06030C6F RID: 199791 RVA: 0x0069EACF File Offset: 0x0069CCCF
		// (set) Token: 0x06030C70 RID: 199792 RVA: 0x0069EAD7 File Offset: 0x0069CCD7
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700CEFD RID: 52989
		// (get) Token: 0x06030C71 RID: 199793 RVA: 0x0069EAE0 File Offset: 0x0069CCE0
		// (set) Token: 0x06030C72 RID: 199794 RVA: 0x0069EAE8 File Offset: 0x0069CCE8
		public IVectorInfoT CenterRot { get; set; }

		// Token: 0x1700CEFE RID: 52990
		// (get) Token: 0x06030C73 RID: 199795 RVA: 0x0069EAF1 File Offset: 0x0069CCF1
		// (set) Token: 0x06030C74 RID: 199796 RVA: 0x0069EAF9 File Offset: 0x0069CCF9
		public byte NullMask { get; set; }

		// Token: 0x06030C75 RID: 199797 RVA: 0x0069EB04 File Offset: 0x0069CD04
		public IFixedCameraConfigT()
		{
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.Fov = 0f;
			this.IsDisableCollision = false;
			this.IsDisableDither = false;
			this.CenterPos = null;
			this.CenterRot = null;
			this.NullMask = 0;
		}
	}
}
