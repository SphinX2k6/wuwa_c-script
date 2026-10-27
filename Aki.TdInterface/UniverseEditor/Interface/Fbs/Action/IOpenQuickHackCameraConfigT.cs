using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C22 RID: 27682
	public class IOpenQuickHackCameraConfigT
	{
		// Token: 0x1700CDE0 RID: 52704
		// (get) Token: 0x06030AF3 RID: 199411 RVA: 0x0069BF12 File Offset: 0x0069A112
		// (set) Token: 0x06030AF4 RID: 199412 RVA: 0x0069BF1A File Offset: 0x0069A11A
		public bool AutoOpenSystem { get; set; }

		// Token: 0x1700CDE1 RID: 52705
		// (get) Token: 0x06030AF5 RID: 199413 RVA: 0x0069BF23 File Offset: 0x0069A123
		// (set) Token: 0x06030AF6 RID: 199414 RVA: 0x0069BF2B File Offset: 0x0069A12B
		public IVectorInfoT RelativePos { get; set; }

		// Token: 0x1700CDE2 RID: 52706
		// (get) Token: 0x06030AF7 RID: 199415 RVA: 0x0069BF34 File Offset: 0x0069A134
		// (set) Token: 0x06030AF8 RID: 199416 RVA: 0x0069BF3C File Offset: 0x0069A13C
		public IOpenQuickHackCameraFovConfigT FovConfig { get; set; }

		// Token: 0x1700CDE3 RID: 52707
		// (get) Token: 0x06030AF9 RID: 199417 RVA: 0x0069BF45 File Offset: 0x0069A145
		// (set) Token: 0x06030AFA RID: 199418 RVA: 0x0069BF4D File Offset: 0x0069A14D
		public IAdjustFixedCameraRotateConfigT RotateConfig { get; set; }

		// Token: 0x1700CDE4 RID: 52708
		// (get) Token: 0x06030AFB RID: 199419 RVA: 0x0069BF56 File Offset: 0x0069A156
		// (set) Token: 0x06030AFC RID: 199420 RVA: 0x0069BF5E File Offset: 0x0069A15E
		public byte NullMask { get; set; }

		// Token: 0x06030AFD RID: 199421 RVA: 0x0069BF67 File Offset: 0x0069A167
		public IOpenQuickHackCameraConfigT()
		{
			this.AutoOpenSystem = false;
			this.RelativePos = null;
			this.FovConfig = null;
			this.RotateConfig = null;
			this.NullMask = 0;
		}
	}
}
