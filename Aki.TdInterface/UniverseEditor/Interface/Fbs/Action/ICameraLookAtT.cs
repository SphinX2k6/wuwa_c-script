using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FF RID: 26879
	public class ICameraLookAtT
	{
		// Token: 0x1700C5BC RID: 50620
		// (get) Token: 0x0602E092 RID: 188562 RVA: 0x0064ABC8 File Offset: 0x00648DC8
		// (set) Token: 0x0602E093 RID: 188563 RVA: 0x0064ABD0 File Offset: 0x00648DD0
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C5BD RID: 50621
		// (get) Token: 0x0602E094 RID: 188564 RVA: 0x0064ABD9 File Offset: 0x00648DD9
		// (set) Token: 0x0602E095 RID: 188565 RVA: 0x0064ABE1 File Offset: 0x00648DE1
		public int PosEntityId { get; set; }

		// Token: 0x1700C5BE RID: 50622
		// (get) Token: 0x0602E096 RID: 188566 RVA: 0x0064ABEA File Offset: 0x00648DEA
		// (set) Token: 0x0602E097 RID: 188567 RVA: 0x0064ABF2 File Offset: 0x00648DF2
		public float FadeInTime { get; set; }

		// Token: 0x1700C5BF RID: 50623
		// (get) Token: 0x0602E098 RID: 188568 RVA: 0x0064ABFB File Offset: 0x00648DFB
		// (set) Token: 0x0602E099 RID: 188569 RVA: 0x0064AC03 File Offset: 0x00648E03
		public float StayTime { get; set; }

		// Token: 0x1700C5C0 RID: 50624
		// (get) Token: 0x0602E09A RID: 188570 RVA: 0x0064AC0C File Offset: 0x00648E0C
		// (set) Token: 0x0602E09B RID: 188571 RVA: 0x0064AC14 File Offset: 0x00648E14
		public float FadeOutTime { get; set; }

		// Token: 0x1700C5C1 RID: 50625
		// (get) Token: 0x0602E09C RID: 188572 RVA: 0x0064AC1D File Offset: 0x00648E1D
		// (set) Token: 0x0602E09D RID: 188573 RVA: 0x0064AC25 File Offset: 0x00648E25
		public bool LockCamera { get; set; }

		// Token: 0x1700C5C2 RID: 50626
		// (get) Token: 0x0602E09E RID: 188574 RVA: 0x0064AC2E File Offset: 0x00648E2E
		// (set) Token: 0x0602E09F RID: 188575 RVA: 0x0064AC36 File Offset: 0x00648E36
		public IVectorInfoT CameraPos { get; set; }

		// Token: 0x1700C5C3 RID: 50627
		// (get) Token: 0x0602E0A0 RID: 188576 RVA: 0x0064AC3F File Offset: 0x00648E3F
		// (set) Token: 0x0602E0A1 RID: 188577 RVA: 0x0064AC47 File Offset: 0x00648E47
		public int CameraPosEntityId { get; set; }

		// Token: 0x1700C5C4 RID: 50628
		// (get) Token: 0x0602E0A2 RID: 188578 RVA: 0x0064AC50 File Offset: 0x00648E50
		// (set) Token: 0x0602E0A3 RID: 188579 RVA: 0x0064AC58 File Offset: 0x00648E58
		public bool IsLockCameraPos { get; set; }

		// Token: 0x1700C5C5 RID: 50629
		// (get) Token: 0x0602E0A4 RID: 188580 RVA: 0x0064AC61 File Offset: 0x00648E61
		// (set) Token: 0x0602E0A5 RID: 188581 RVA: 0x0064AC69 File Offset: 0x00648E69
		public int Fov { get; set; }

		// Token: 0x1700C5C6 RID: 50630
		// (get) Token: 0x0602E0A6 RID: 188582 RVA: 0x0064AC72 File Offset: 0x00648E72
		// (set) Token: 0x0602E0A7 RID: 188583 RVA: 0x0064AC7A File Offset: 0x00648E7A
		public int ArmLength { get; set; }

		// Token: 0x1700C5C7 RID: 50631
		// (get) Token: 0x0602E0A8 RID: 188584 RVA: 0x0064AC83 File Offset: 0x00648E83
		// (set) Token: 0x0602E0A9 RID: 188585 RVA: 0x0064AC8B File Offset: 0x00648E8B
		public bool BanInput { get; set; }

		// Token: 0x1700C5C8 RID: 50632
		// (get) Token: 0x0602E0AA RID: 188586 RVA: 0x0064AC94 File Offset: 0x00648E94
		// (set) Token: 0x0602E0AB RID: 188587 RVA: 0x0064AC9C File Offset: 0x00648E9C
		public bool HideUi { get; set; }

		// Token: 0x1700C5C9 RID: 50633
		// (get) Token: 0x0602E0AC RID: 188588 RVA: 0x0064ACA5 File Offset: 0x00648EA5
		// (set) Token: 0x0602E0AD RID: 188589 RVA: 0x0064ACAD File Offset: 0x00648EAD
		public bool CancelBuffer { get; set; }

		// Token: 0x1700C5CA RID: 50634
		// (get) Token: 0x0602E0AE RID: 188590 RVA: 0x0064ACB6 File Offset: 0x00648EB6
		// (set) Token: 0x0602E0AF RID: 188591 RVA: 0x0064ACBE File Offset: 0x00648EBE
		public bool CancelBlendOut { get; set; }

		// Token: 0x1700C5CB RID: 50635
		// (get) Token: 0x0602E0B0 RID: 188592 RVA: 0x0064ACC7 File Offset: 0x00648EC7
		// (set) Token: 0x0602E0B1 RID: 188593 RVA: 0x0064ACCF File Offset: 0x00648ECF
		public bool DisableCameraOffSet { get; set; }

		// Token: 0x1700C5CC RID: 50636
		// (get) Token: 0x0602E0B2 RID: 188594 RVA: 0x0064ACD8 File Offset: 0x00648ED8
		// (set) Token: 0x0602E0B3 RID: 188595 RVA: 0x0064ACE0 File Offset: 0x00648EE0
		public ushort NullMask { get; set; }

		// Token: 0x0602E0B4 RID: 188596 RVA: 0x0064ACEC File Offset: 0x00648EEC
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
