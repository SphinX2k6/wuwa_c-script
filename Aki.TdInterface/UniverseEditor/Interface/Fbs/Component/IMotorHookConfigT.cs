using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B56 RID: 23382
	public class IMotorHookConfigT
	{
		// Token: 0x1700AAB2 RID: 43698
		// (get) Token: 0x060267A8 RID: 157608 RVA: 0x00545122 File Offset: 0x00543322
		// (set) Token: 0x060267A9 RID: 157609 RVA: 0x0054512A File Offset: 0x0054332A
		public IFaceToTargetMotorInteractConstraintT InteractConstraint { get; set; }

		// Token: 0x1700AAB3 RID: 43699
		// (get) Token: 0x060267AA RID: 157610 RVA: 0x00545133 File Offset: 0x00543333
		// (set) Token: 0x060267AB RID: 157611 RVA: 0x0054513B File Offset: 0x0054333B
		public float Radius { get; set; }

		// Token: 0x1700AAB4 RID: 43700
		// (get) Token: 0x060267AC RID: 157612 RVA: 0x00545144 File Offset: 0x00543344
		// (set) Token: 0x060267AD RID: 157613 RVA: 0x0054514C File Offset: 0x0054334C
		public float NonInteractiveInnerRadius { get; set; }

		// Token: 0x1700AAB5 RID: 43701
		// (get) Token: 0x060267AE RID: 157614 RVA: 0x00545155 File Offset: 0x00543355
		// (set) Token: 0x060267AF RID: 157615 RVA: 0x0054515D File Offset: 0x0054335D
		public IMotorHookEndDirT HookEndDir { get; set; }

		// Token: 0x1700AAB6 RID: 43702
		// (get) Token: 0x060267B0 RID: 157616 RVA: 0x00545166 File Offset: 0x00543366
		// (set) Token: 0x060267B1 RID: 157617 RVA: 0x0054516E File Offset: 0x0054336E
		public IMotorHookAccelerationT MotorHookAcceleration { get; set; }

		// Token: 0x1700AAB7 RID: 43703
		// (get) Token: 0x060267B2 RID: 157618 RVA: 0x00545177 File Offset: 0x00543377
		// (set) Token: 0x060267B3 RID: 157619 RVA: 0x0054517F File Offset: 0x0054337F
		public THookLockScreenDetectTypeUnion ScreenDetectType { get; set; }

		// Token: 0x1700AAB8 RID: 43704
		// (get) Token: 0x060267B4 RID: 157620 RVA: 0x00545188 File Offset: 0x00543388
		// (set) Token: 0x060267B5 RID: 157621 RVA: 0x00545190 File Offset: 0x00543390
		public bool AutoExit { get; set; }

		// Token: 0x1700AAB9 RID: 43705
		// (get) Token: 0x060267B6 RID: 157622 RVA: 0x00545199 File Offset: 0x00543399
		// (set) Token: 0x060267B7 RID: 157623 RVA: 0x005451A1 File Offset: 0x005433A1
		public IMotorHookPerformanceConfigT MotorHookPerformanceConfig { get; set; }

		// Token: 0x1700AABA RID: 43706
		// (get) Token: 0x060267B8 RID: 157624 RVA: 0x005451AA File Offset: 0x005433AA
		// (set) Token: 0x060267B9 RID: 157625 RVA: 0x005451B2 File Offset: 0x005433B2
		public byte NullMask { get; set; }

		// Token: 0x060267BA RID: 157626 RVA: 0x005451BC File Offset: 0x005433BC
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
