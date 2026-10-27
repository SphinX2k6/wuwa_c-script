using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6E RID: 23150
	public class IThrowMotionLevitateT
	{
		// Token: 0x1700AE3B RID: 44603
		// (get) Token: 0x0602766B RID: 161387 RVA: 0x0056C0F1 File Offset: 0x0056A2F1
		// (set) Token: 0x0602766C RID: 161388 RVA: 0x0056C0F9 File Offset: 0x0056A2F9
		public EThrowMotion Type { get; set; }

		// Token: 0x1700AE3C RID: 44604
		// (get) Token: 0x0602766D RID: 161389 RVA: 0x0056C102 File Offset: 0x0056A302
		// (set) Token: 0x0602766E RID: 161390 RVA: 0x0056C10A File Offset: 0x0056A30A
		public float Velocity { get; set; }

		// Token: 0x1700AE3D RID: 44605
		// (get) Token: 0x0602766F RID: 161391 RVA: 0x0056C113 File Offset: 0x0056A313
		// (set) Token: 0x06027670 RID: 161392 RVA: 0x0056C11B File Offset: 0x0056A31B
		public string VelocityCurve { get; set; }

		// Token: 0x1700AE3E RID: 44606
		// (get) Token: 0x06027671 RID: 161393 RVA: 0x0056C124 File Offset: 0x0056A324
		// (set) Token: 0x06027672 RID: 161394 RVA: 0x0056C12C File Offset: 0x0056A32C
		public float MoveTime { get; set; }

		// Token: 0x1700AE3F RID: 44607
		// (get) Token: 0x06027673 RID: 161395 RVA: 0x0056C135 File Offset: 0x0056A335
		// (set) Token: 0x06027674 RID: 161396 RVA: 0x0056C13D File Offset: 0x0056A33D
		public float RayRadius { get; set; }

		// Token: 0x1700AE40 RID: 44608
		// (get) Token: 0x06027675 RID: 161397 RVA: 0x0056C146 File Offset: 0x0056A346
		// (set) Token: 0x06027676 RID: 161398 RVA: 0x0056C14E File Offset: 0x0056A34E
		public IRenderTrajectoryConfigT RenderTrajectoryConfig { get; set; }

		// Token: 0x1700AE41 RID: 44609
		// (get) Token: 0x06027677 RID: 161399 RVA: 0x0056C157 File Offset: 0x0056A357
		// (set) Token: 0x06027678 RID: 161400 RVA: 0x0056C15F File Offset: 0x0056A35F
		public byte NullMask { get; set; }

		// Token: 0x06027679 RID: 161401 RVA: 0x0056C168 File Offset: 0x0056A368
		public IThrowMotionLevitateT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = 0f;
			this.VelocityCurve = null;
			this.MoveTime = 0f;
			this.RayRadius = 0f;
			this.RenderTrajectoryConfig = null;
			this.NullMask = 0;
		}
	}
}
