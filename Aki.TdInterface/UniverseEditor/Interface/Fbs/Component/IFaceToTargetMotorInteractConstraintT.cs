using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200521D RID: 21021
	public class IFaceToTargetMotorInteractConstraintT
	{
		// Token: 0x170099F6 RID: 39414
		// (get) Token: 0x060222A1 RID: 139937 RVA: 0x004BD785 File Offset: 0x004BB985
		// (set) Token: 0x060222A2 RID: 139938 RVA: 0x004BD78D File Offset: 0x004BB98D
		public EMotorInteractConstraintType Type { get; set; }

		// Token: 0x170099F7 RID: 39415
		// (get) Token: 0x060222A3 RID: 139939 RVA: 0x004BD796 File Offset: 0x004BB996
		// (set) Token: 0x060222A4 RID: 139940 RVA: 0x004BD79E File Offset: 0x004BB99E
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x170099F8 RID: 39416
		// (get) Token: 0x060222A5 RID: 139941 RVA: 0x004BD7A7 File Offset: 0x004BB9A7
		// (set) Token: 0x060222A6 RID: 139942 RVA: 0x004BD7AF File Offset: 0x004BB9AF
		public float Angle { get; set; }

		// Token: 0x060222A7 RID: 139943 RVA: 0x004BD7B8 File Offset: 0x004BB9B8
		public IFaceToTargetMotorInteractConstraintT()
		{
			this.Type = EMotorInteractConstraintType.FaceToTarget;
			this.Target = null;
			this.Angle = 0f;
		}
	}
}
