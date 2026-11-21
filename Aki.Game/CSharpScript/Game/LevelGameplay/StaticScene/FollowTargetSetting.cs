using System;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02005B6A RID: 23402
	public class FollowTargetSetting
	{
		// Token: 0x17006D7F RID: 28031
		// (get) Token: 0x060398CF RID: 235727 RVA: 0x010288F9 File Offset: 0x01026AF9
		// (set) Token: 0x060398D0 RID: 235728 RVA: 0x01028901 File Offset: 0x01026B01
		public bool IsFollowTarget { get; set; }

		// Token: 0x17006D80 RID: 28032
		// (get) Token: 0x060398D1 RID: 235729 RVA: 0x0102890A File Offset: 0x01026B0A
		// (set) Token: 0x060398D2 RID: 235730 RVA: 0x01028912 File Offset: 0x01026B12
		public bool IsFollowTargetPitch { get; set; }

		// Token: 0x17006D81 RID: 28033
		// (get) Token: 0x060398D3 RID: 235731 RVA: 0x0102891B File Offset: 0x01026B1B
		// (set) Token: 0x060398D4 RID: 235732 RVA: 0x01028923 File Offset: 0x01026B23
		public float PitchFollowSpeed { get; set; }

		// Token: 0x17006D82 RID: 28034
		// (get) Token: 0x060398D5 RID: 235733 RVA: 0x0102892C File Offset: 0x01026B2C
		// (set) Token: 0x060398D6 RID: 235734 RVA: 0x01028934 File Offset: 0x01026B34
		public bool IsFollowTargetYaw { get; set; }

		// Token: 0x17006D83 RID: 28035
		// (get) Token: 0x060398D7 RID: 235735 RVA: 0x0102893D File Offset: 0x01026B3D
		// (set) Token: 0x060398D8 RID: 235736 RVA: 0x01028945 File Offset: 0x01026B45
		public float YawFollowSpeed { get; set; }

		// Token: 0x17006D84 RID: 28036
		// (get) Token: 0x060398D9 RID: 235737 RVA: 0x0102894E File Offset: 0x01026B4E
		// (set) Token: 0x060398DA RID: 235738 RVA: 0x01028956 File Offset: 0x01026B56
		public bool IsFollowTargetAngle { get; set; }

		// Token: 0x17006D85 RID: 28037
		// (get) Token: 0x060398DB RID: 235739 RVA: 0x0102895F File Offset: 0x01026B5F
		// (set) Token: 0x060398DC RID: 235740 RVA: 0x01028967 File Offset: 0x01026B67
		public float AngleFollowSpeed { get; set; }

		// Token: 0x060398DD RID: 235741 RVA: 0x01028970 File Offset: 0x01026B70
		public FollowTargetSetting(bool isFollowTarget, bool isFollowTargetPitch, float pitchFollowSpeed, bool isFollowTargetYaw, float yawFollowSpeed, bool isFollowTargetAngle, float angleFollowSpeed)
		{
			this.IsFollowTarget = isFollowTarget;
			this.IsFollowTargetPitch = isFollowTargetPitch;
			this.PitchFollowSpeed = pitchFollowSpeed;
			this.IsFollowTargetYaw = isFollowTargetYaw;
			this.YawFollowSpeed = yawFollowSpeed;
			this.IsFollowTargetAngle = isFollowTargetAngle;
			this.AngleFollowSpeed = angleFollowSpeed;
		}
	}
}
