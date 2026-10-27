using System;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02006A0D RID: 27149
	public class FollowTargetSetting
	{
		// Token: 0x1700989A RID: 39066
		// (get) Token: 0x06043883 RID: 276611 RVA: 0x010842D5 File Offset: 0x010824D5
		// (set) Token: 0x06043884 RID: 276612 RVA: 0x010842DD File Offset: 0x010824DD
		public bool IsFollowTarget { get; set; }

		// Token: 0x1700989B RID: 39067
		// (get) Token: 0x06043885 RID: 276613 RVA: 0x010842E6 File Offset: 0x010824E6
		// (set) Token: 0x06043886 RID: 276614 RVA: 0x010842EE File Offset: 0x010824EE
		public bool IsFollowTargetPitch { get; set; }

		// Token: 0x1700989C RID: 39068
		// (get) Token: 0x06043887 RID: 276615 RVA: 0x010842F7 File Offset: 0x010824F7
		// (set) Token: 0x06043888 RID: 276616 RVA: 0x010842FF File Offset: 0x010824FF
		public float PitchFollowSpeed { get; set; }

		// Token: 0x1700989D RID: 39069
		// (get) Token: 0x06043889 RID: 276617 RVA: 0x01084308 File Offset: 0x01082508
		// (set) Token: 0x0604388A RID: 276618 RVA: 0x01084310 File Offset: 0x01082510
		public bool IsFollowTargetYaw { get; set; }

		// Token: 0x1700989E RID: 39070
		// (get) Token: 0x0604388B RID: 276619 RVA: 0x01084319 File Offset: 0x01082519
		// (set) Token: 0x0604388C RID: 276620 RVA: 0x01084321 File Offset: 0x01082521
		public float YawFollowSpeed { get; set; }

		// Token: 0x1700989F RID: 39071
		// (get) Token: 0x0604388D RID: 276621 RVA: 0x0108432A File Offset: 0x0108252A
		// (set) Token: 0x0604388E RID: 276622 RVA: 0x01084332 File Offset: 0x01082532
		public bool IsFollowTargetAngle { get; set; }

		// Token: 0x170098A0 RID: 39072
		// (get) Token: 0x0604388F RID: 276623 RVA: 0x0108433B File Offset: 0x0108253B
		// (set) Token: 0x06043890 RID: 276624 RVA: 0x01084343 File Offset: 0x01082543
		public float AngleFollowSpeed { get; set; }

		// Token: 0x06043891 RID: 276625 RVA: 0x0108434C File Offset: 0x0108254C
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
