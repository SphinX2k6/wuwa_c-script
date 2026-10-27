using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200628E RID: 25230
	public class ICameraLookAtT
	{
		// Token: 0x1700BC34 RID: 48180
		// (get) Token: 0x0602B931 RID: 178481 RVA: 0x005FFDC0 File Offset: 0x005FDFC0
		// (set) Token: 0x0602B932 RID: 178482 RVA: 0x005FFDC8 File Offset: 0x005FDFC8
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700BC35 RID: 48181
		// (get) Token: 0x0602B933 RID: 178483 RVA: 0x005FFDD1 File Offset: 0x005FDFD1
		// (set) Token: 0x0602B934 RID: 178484 RVA: 0x005FFDD9 File Offset: 0x005FDFD9
		public int PosEntityId { get; set; }

		// Token: 0x1700BC36 RID: 48182
		// (get) Token: 0x0602B935 RID: 178485 RVA: 0x005FFDE2 File Offset: 0x005FDFE2
		// (set) Token: 0x0602B936 RID: 178486 RVA: 0x005FFDEA File Offset: 0x005FDFEA
		public float FadeInTime { get; set; }

		// Token: 0x1700BC37 RID: 48183
		// (get) Token: 0x0602B937 RID: 178487 RVA: 0x005FFDF3 File Offset: 0x005FDFF3
		// (set) Token: 0x0602B938 RID: 178488 RVA: 0x005FFDFB File Offset: 0x005FDFFB
		public float StayTime { get; set; }

		// Token: 0x1700BC38 RID: 48184
		// (get) Token: 0x0602B939 RID: 178489 RVA: 0x005FFE04 File Offset: 0x005FE004
		// (set) Token: 0x0602B93A RID: 178490 RVA: 0x005FFE0C File Offset: 0x005FE00C
		public float FadeOutTime { get; set; }

		// Token: 0x1700BC39 RID: 48185
		// (get) Token: 0x0602B93B RID: 178491 RVA: 0x005FFE15 File Offset: 0x005FE015
		// (set) Token: 0x0602B93C RID: 178492 RVA: 0x005FFE1D File Offset: 0x005FE01D
		public bool LockCamera { get; set; }

		// Token: 0x1700BC3A RID: 48186
		// (get) Token: 0x0602B93D RID: 178493 RVA: 0x005FFE26 File Offset: 0x005FE026
		// (set) Token: 0x0602B93E RID: 178494 RVA: 0x005FFE2E File Offset: 0x005FE02E
		public IVectorInfoT CameraPos { get; set; }

		// Token: 0x1700BC3B RID: 48187
		// (get) Token: 0x0602B93F RID: 178495 RVA: 0x005FFE37 File Offset: 0x005FE037
		// (set) Token: 0x0602B940 RID: 178496 RVA: 0x005FFE3F File Offset: 0x005FE03F
		public int CameraPosEntityId { get; set; }

		// Token: 0x1700BC3C RID: 48188
		// (get) Token: 0x0602B941 RID: 178497 RVA: 0x005FFE48 File Offset: 0x005FE048
		// (set) Token: 0x0602B942 RID: 178498 RVA: 0x005FFE50 File Offset: 0x005FE050
		public bool IsLockCameraPos { get; set; }

		// Token: 0x1700BC3D RID: 48189
		// (get) Token: 0x0602B943 RID: 178499 RVA: 0x005FFE59 File Offset: 0x005FE059
		// (set) Token: 0x0602B944 RID: 178500 RVA: 0x005FFE61 File Offset: 0x005FE061
		public int Fov { get; set; }

		// Token: 0x1700BC3E RID: 48190
		// (get) Token: 0x0602B945 RID: 178501 RVA: 0x005FFE6A File Offset: 0x005FE06A
		// (set) Token: 0x0602B946 RID: 178502 RVA: 0x005FFE72 File Offset: 0x005FE072
		public int ArmLength { get; set; }

		// Token: 0x1700BC3F RID: 48191
		// (get) Token: 0x0602B947 RID: 178503 RVA: 0x005FFE7B File Offset: 0x005FE07B
		// (set) Token: 0x0602B948 RID: 178504 RVA: 0x005FFE83 File Offset: 0x005FE083
		public bool BanInput { get; set; }

		// Token: 0x1700BC40 RID: 48192
		// (get) Token: 0x0602B949 RID: 178505 RVA: 0x005FFE8C File Offset: 0x005FE08C
		// (set) Token: 0x0602B94A RID: 178506 RVA: 0x005FFE94 File Offset: 0x005FE094
		public bool HideUi { get; set; }

		// Token: 0x1700BC41 RID: 48193
		// (get) Token: 0x0602B94B RID: 178507 RVA: 0x005FFE9D File Offset: 0x005FE09D
		// (set) Token: 0x0602B94C RID: 178508 RVA: 0x005FFEA5 File Offset: 0x005FE0A5
		public bool CancelBuffer { get; set; }

		// Token: 0x1700BC42 RID: 48194
		// (get) Token: 0x0602B94D RID: 178509 RVA: 0x005FFEAE File Offset: 0x005FE0AE
		// (set) Token: 0x0602B94E RID: 178510 RVA: 0x005FFEB6 File Offset: 0x005FE0B6
		public bool CancelBlendOut { get; set; }

		// Token: 0x1700BC43 RID: 48195
		// (get) Token: 0x0602B94F RID: 178511 RVA: 0x005FFEBF File Offset: 0x005FE0BF
		// (set) Token: 0x0602B950 RID: 178512 RVA: 0x005FFEC7 File Offset: 0x005FE0C7
		public bool DisableCameraOffSet { get; set; }

		// Token: 0x1700BC44 RID: 48196
		// (get) Token: 0x0602B951 RID: 178513 RVA: 0x005FFED0 File Offset: 0x005FE0D0
		// (set) Token: 0x0602B952 RID: 178514 RVA: 0x005FFED8 File Offset: 0x005FE0D8
		public ushort NullMask { get; set; }

		// Token: 0x0602B953 RID: 178515 RVA: 0x005FFEE4 File Offset: 0x005FE0E4
		public ICameraLookAtT()
		{
			this.Pos = null;
			this.PosEntityId = 0;
			this.FadeInTime = 0f;
			this.StayTime = 0f;
			this.FadeOutTime = 0f;
			this.LockCamera = false;
			this.CameraPos = null;
			this.CameraPosEntityId = 0;
			this.IsLockCameraPos = false;
			this.Fov = 0;
			this.ArmLength = 0;
			this.BanInput = false;
			this.HideUi = false;
			this.CancelBuffer = false;
			this.CancelBlendOut = false;
			this.DisableCameraOffSet = false;
			this.NullMask = 0;
		}
	}
}
