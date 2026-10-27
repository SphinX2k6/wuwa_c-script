using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B8 RID: 21944
	public class IMotorHookConfigT
	{
		// Token: 0x1700A22A RID: 41514
		// (get) Token: 0x0602459B RID: 148891 RVA: 0x00504BAA File Offset: 0x00502DAA
		// (set) Token: 0x0602459C RID: 148892 RVA: 0x00504BB2 File Offset: 0x00502DB2
		public IFaceToTargetMotorInteractConstraintT InteractConstraint { get; set; }

		// Token: 0x1700A22B RID: 41515
		// (get) Token: 0x0602459D RID: 148893 RVA: 0x00504BBB File Offset: 0x00502DBB
		// (set) Token: 0x0602459E RID: 148894 RVA: 0x00504BC3 File Offset: 0x00502DC3
		public float Radius { get; set; }

		// Token: 0x1700A22C RID: 41516
		// (get) Token: 0x0602459F RID: 148895 RVA: 0x00504BCC File Offset: 0x00502DCC
		// (set) Token: 0x060245A0 RID: 148896 RVA: 0x00504BD4 File Offset: 0x00502DD4
		public float NonInteractiveInnerRadius { get; set; }

		// Token: 0x1700A22D RID: 41517
		// (get) Token: 0x060245A1 RID: 148897 RVA: 0x00504BDD File Offset: 0x00502DDD
		// (set) Token: 0x060245A2 RID: 148898 RVA: 0x00504BE5 File Offset: 0x00502DE5
		public IMotorHookEndDirT HookEndDir { get; set; }

		// Token: 0x1700A22E RID: 41518
		// (get) Token: 0x060245A3 RID: 148899 RVA: 0x00504BEE File Offset: 0x00502DEE
		// (set) Token: 0x060245A4 RID: 148900 RVA: 0x00504BF6 File Offset: 0x00502DF6
		public IMotorHookAccelerationT MotorHookAcceleration { get; set; }

		// Token: 0x1700A22F RID: 41519
		// (get) Token: 0x060245A5 RID: 148901 RVA: 0x00504BFF File Offset: 0x00502DFF
		// (set) Token: 0x060245A6 RID: 148902 RVA: 0x00504C07 File Offset: 0x00502E07
		public THookLockScreenDetectTypeUnion ScreenDetectType { get; set; }

		// Token: 0x1700A230 RID: 41520
		// (get) Token: 0x060245A7 RID: 148903 RVA: 0x00504C10 File Offset: 0x00502E10
		// (set) Token: 0x060245A8 RID: 148904 RVA: 0x00504C18 File Offset: 0x00502E18
		public bool AutoExit { get; set; }

		// Token: 0x1700A231 RID: 41521
		// (get) Token: 0x060245A9 RID: 148905 RVA: 0x00504C21 File Offset: 0x00502E21
		// (set) Token: 0x060245AA RID: 148906 RVA: 0x00504C29 File Offset: 0x00502E29
		public IMotorHookPerformanceConfigT MotorHookPerformanceConfig { get; set; }

		// Token: 0x1700A232 RID: 41522
		// (get) Token: 0x060245AB RID: 148907 RVA: 0x00504C32 File Offset: 0x00502E32
		// (set) Token: 0x060245AC RID: 148908 RVA: 0x00504C3A File Offset: 0x00502E3A
		public byte NullMask { get; set; }

		// Token: 0x060245AD RID: 148909 RVA: 0x00504C44 File Offset: 0x00502E44
		public IMotorHookConfigT()
		{
			this.InteractConstraint = null;
			this.Radius = 0f;
			this.NonInteractiveInnerRadius = 0f;
			this.HookEndDir = null;
			this.MotorHookAcceleration = null;
			this.ScreenDetectType = null;
			this.AutoExit = false;
			this.MotorHookPerformanceConfig = null;
			this.NullMask = 0;
		}
	}
}
