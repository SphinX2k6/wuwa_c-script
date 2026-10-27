using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB8 RID: 27832
	public class IPhotographCameraTransformAbsoluteT
	{
		// Token: 0x1700CF37 RID: 53047
		// (get) Token: 0x060310CB RID: 200907 RVA: 0x006A83E8 File Offset: 0x006A65E8
		// (set) Token: 0x060310CC RID: 200908 RVA: 0x006A83F0 File Offset: 0x006A65F0
		public EPhotographCameraTransform Type { get; set; }

		// Token: 0x1700CF38 RID: 53048
		// (get) Token: 0x060310CD RID: 200909 RVA: 0x006A83F9 File Offset: 0x006A65F9
		// (set) Token: 0x060310CE RID: 200910 RVA: 0x006A8401 File Offset: 0x006A6601
		public IVectorInfoT CameraPos { get; set; }

		// Token: 0x1700CF39 RID: 53049
		// (get) Token: 0x060310CF RID: 200911 RVA: 0x006A840A File Offset: 0x006A660A
		// (set) Token: 0x060310D0 RID: 200912 RVA: 0x006A8412 File Offset: 0x006A6612
		public IVectorInfoT CameraRot { get; set; }

		// Token: 0x060310D1 RID: 200913 RVA: 0x006A841B File Offset: 0x006A661B
		public IPhotographCameraTransformAbsoluteT()
		{
			this.Type = EPhotographCameraTransform.Absolute;
			this.CameraPos = null;
			this.CameraRot = null;
		}
	}
}
