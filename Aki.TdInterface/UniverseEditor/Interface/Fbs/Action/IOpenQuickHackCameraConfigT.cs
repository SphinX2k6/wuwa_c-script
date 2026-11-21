using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007389 RID: 29577
	public class IOpenQuickHackCameraConfigT
	{
		// Token: 0x1700D8FB RID: 55547
		// (get) Token: 0x06033A47 RID: 211527 RVA: 0x006F620E File Offset: 0x006F440E
		// (set) Token: 0x06033A48 RID: 211528 RVA: 0x006F6216 File Offset: 0x006F4416
		public bool AutoOpenSystem { get; set; }

		// Token: 0x1700D8FC RID: 55548
		// (get) Token: 0x06033A49 RID: 211529 RVA: 0x006F621F File Offset: 0x006F441F
		// (set) Token: 0x06033A4A RID: 211530 RVA: 0x006F6227 File Offset: 0x006F4427
		public IVectorInfoT RelativePos { get; set; }

		// Token: 0x1700D8FD RID: 55549
		// (get) Token: 0x06033A4B RID: 211531 RVA: 0x006F6230 File Offset: 0x006F4430
		// (set) Token: 0x06033A4C RID: 211532 RVA: 0x006F6238 File Offset: 0x006F4438
		public IOpenQuickHackCameraFovConfigT FovConfig { get; set; }

		// Token: 0x1700D8FE RID: 55550
		// (get) Token: 0x06033A4D RID: 211533 RVA: 0x006F6241 File Offset: 0x006F4441
		// (set) Token: 0x06033A4E RID: 211534 RVA: 0x006F6249 File Offset: 0x006F4449
		public IAdjustFixedCameraRotateConfigT RotateConfig { get; set; }

		// Token: 0x1700D8FF RID: 55551
		// (get) Token: 0x06033A4F RID: 211535 RVA: 0x006F6252 File Offset: 0x006F4452
		// (set) Token: 0x06033A50 RID: 211536 RVA: 0x006F625A File Offset: 0x006F445A
		public byte NullMask { get; set; }

		// Token: 0x06033A51 RID: 211537 RVA: 0x006F6263 File Offset: 0x006F4463
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
