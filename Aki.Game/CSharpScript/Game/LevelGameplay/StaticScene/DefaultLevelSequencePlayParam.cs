using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02005B6B RID: 23403
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultLevelSequencePlayParam
	{
		// Token: 0x17006D86 RID: 28038
		// (get) Token: 0x060398DE RID: 235742 RVA: 0x010289AD File Offset: 0x01026BAD
		// (set) Token: 0x060398DF RID: 235743 RVA: 0x010289B5 File Offset: 0x01026BB5
		public float InTime { get; set; }

		// Token: 0x17006D87 RID: 28039
		// (get) Token: 0x060398E0 RID: 235744 RVA: 0x010289BE File Offset: 0x01026BBE
		// (set) Token: 0x060398E1 RID: 235745 RVA: 0x010289C6 File Offset: 0x01026BC6
		public float OutTime { get; set; }

		// Token: 0x17006D88 RID: 28040
		// (get) Token: 0x060398E2 RID: 235746 RVA: 0x010289CF File Offset: 0x01026BCF
		// (set) Token: 0x060398E3 RID: 235747 RVA: 0x010289D7 File Offset: 0x01026BD7
		public float SmoothFactor { get; set; }

		// Token: 0x17006D89 RID: 28041
		// (get) Token: 0x060398E4 RID: 235748 RVA: 0x010289E0 File Offset: 0x01026BE0
		// (set) Token: 0x060398E5 RID: 235749 RVA: 0x010289E8 File Offset: 0x01026BE8
		public float SmoothDelta { get; set; }

		// Token: 0x17006D8A RID: 28042
		// (get) Token: 0x060398E6 RID: 235750 RVA: 0x010289F1 File Offset: 0x01026BF1
		// (set) Token: 0x060398E7 RID: 235751 RVA: 0x010289F9 File Offset: 0x01026BF9
		public BindTargetSetting BindSetting { get; set; }

		// Token: 0x17006D8B RID: 28043
		// (get) Token: 0x060398E8 RID: 235752 RVA: 0x01028A02 File Offset: 0x01026C02
		// (set) Token: 0x060398E9 RID: 235753 RVA: 0x01028A0A File Offset: 0x01026C0A
		public FollowTargetSetting FollowSetting { get; set; }

		// Token: 0x17006D8C RID: 28044
		// (get) Token: 0x060398EA RID: 235754 RVA: 0x01028A13 File Offset: 0x01026C13
		// (set) Token: 0x060398EB RID: 235755 RVA: 0x01028A1B File Offset: 0x01026C1B
		public TsBaseCharacter Target { get; set; }

		// Token: 0x060398EC RID: 235756 RVA: 0x01028A24 File Offset: 0x01026C24
		public DefaultLevelSequencePlayParam(float inTime, float outTime, float smoothFactor, float smoothDelta, BindTargetSetting bindSetting, FollowTargetSetting followSetting, TsBaseCharacter target)
		{
			this.InTime = inTime;
			this.OutTime = outTime;
			this.SmoothFactor = smoothFactor;
			this.SmoothDelta = smoothDelta;
			this.BindSetting = bindSetting;
			this.FollowSetting = followSetting;
			this.Target = target;
		}

		// Token: 0x0401E613 RID: 124435
		public readonly int MaxDelayUpdateFrame = 4;

		// Token: 0x0401E614 RID: 124436
		public Rotator InitPlayerRotator = Rotator.Create();

		// Token: 0x0401E615 RID: 124437
		public Vector InitPlayerFloorLocation = Vector.Create();

		// Token: 0x0401E616 RID: 124438
		public int DelayUpdateFrame;

		// Token: 0x0401E617 RID: 124439
		public float PlayedTime;

		// Token: 0x0401E618 RID: 124440
		public float TimeLength;

		// Token: 0x0401E619 RID: 124441
		public bool HasLastFrameFloorLocationZ;

		// Token: 0x0401E61A RID: 124442
		public double LastFrameFloorLocationZ;
	}
}
