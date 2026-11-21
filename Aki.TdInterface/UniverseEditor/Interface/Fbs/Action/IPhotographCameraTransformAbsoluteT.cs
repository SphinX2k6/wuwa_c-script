using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742E RID: 29742
	public class IPhotographCameraTransformAbsoluteT
	{
		// Token: 0x1700DA74 RID: 55924
		// (get) Token: 0x060340A2 RID: 213154 RVA: 0x0070361C File Offset: 0x0070181C
		// (set) Token: 0x060340A3 RID: 213155 RVA: 0x00703624 File Offset: 0x00701824
		public EPhotographCameraTransform Type { get; set; }

		// Token: 0x1700DA75 RID: 55925
		// (get) Token: 0x060340A4 RID: 213156 RVA: 0x0070362D File Offset: 0x0070182D
		// (set) Token: 0x060340A5 RID: 213157 RVA: 0x00703635 File Offset: 0x00701835
		public IVectorInfoT CameraPos { get; set; }

		// Token: 0x1700DA76 RID: 55926
		// (get) Token: 0x060340A6 RID: 213158 RVA: 0x0070363E File Offset: 0x0070183E
		// (set) Token: 0x060340A7 RID: 213159 RVA: 0x00703646 File Offset: 0x00701846
		public IVectorInfoT CameraRot { get; set; }

		// Token: 0x060340A8 RID: 213160 RVA: 0x0070364F File Offset: 0x0070184F
		public IPhotographCameraTransformAbsoluteT()
		{
			this.Type = EPhotographCameraTransform.Absolute;
			this.CameraPos = null;
			this.CameraRot = null;
		}
	}
}
