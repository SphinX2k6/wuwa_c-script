using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02006A0E RID: 27150
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultLevelSequencePlayParam
	{
		// Token: 0x170098A1 RID: 39073
		// (get) Token: 0x06043892 RID: 276626 RVA: 0x01084389 File Offset: 0x01082589
		// (set) Token: 0x06043893 RID: 276627 RVA: 0x01084391 File Offset: 0x01082591
		public float InTime { get; set; }

		// Token: 0x170098A2 RID: 39074
		// (get) Token: 0x06043894 RID: 276628 RVA: 0x0108439A File Offset: 0x0108259A
		// (set) Token: 0x06043895 RID: 276629 RVA: 0x010843A2 File Offset: 0x010825A2
		public float OutTime { get; set; }

		// Token: 0x170098A3 RID: 39075
		// (get) Token: 0x06043896 RID: 276630 RVA: 0x010843AB File Offset: 0x010825AB
		// (set) Token: 0x06043897 RID: 276631 RVA: 0x010843B3 File Offset: 0x010825B3
		public float SmoothFactor { get; set; }

		// Token: 0x170098A4 RID: 39076
		// (get) Token: 0x06043898 RID: 276632 RVA: 0x010843BC File Offset: 0x010825BC
		// (set) Token: 0x06043899 RID: 276633 RVA: 0x010843C4 File Offset: 0x010825C4
		public float SmoothDelta { get; set; }

		// Token: 0x170098A5 RID: 39077
		// (get) Token: 0x0604389A RID: 276634 RVA: 0x010843CD File Offset: 0x010825CD
		// (set) Token: 0x0604389B RID: 276635 RVA: 0x010843D5 File Offset: 0x010825D5
		public BindTargetSetting BindSetting { get; set; }

		// Token: 0x170098A6 RID: 39078
		// (get) Token: 0x0604389C RID: 276636 RVA: 0x010843DE File Offset: 0x010825DE
		// (set) Token: 0x0604389D RID: 276637 RVA: 0x010843E6 File Offset: 0x010825E6
		public FollowTargetSetting FollowSetting { get; set; }

		// Token: 0x170098A7 RID: 39079
		// (get) Token: 0x0604389E RID: 276638 RVA: 0x010843EF File Offset: 0x010825EF
		// (set) Token: 0x0604389F RID: 276639 RVA: 0x010843F7 File Offset: 0x010825F7
		public TsBaseCharacter Target { get; set; }

		// Token: 0x060438A0 RID: 276640 RVA: 0x01084400 File Offset: 0x01082600
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

		// Token: 0x04023421 RID: 144417
		public readonly int MaxDelayUpdateFrame = 4;

		// Token: 0x04023422 RID: 144418
		public Rotator InitPlayerRotator = Rotator.Create();

		// Token: 0x04023423 RID: 144419
		public Vector InitPlayerFloorLocation = Vector.Create();

		// Token: 0x04023424 RID: 144420
		public int DelayUpdateFrame;

		// Token: 0x04023425 RID: 144421
		public float PlayedTime;

		// Token: 0x04023426 RID: 144422
		public float TimeLength;

		// Token: 0x04023427 RID: 144423
		public bool HasLastFrameFloorLocationZ;

		// Token: 0x04023428 RID: 144424
		public double LastFrameFloorLocationZ;
	}
}
