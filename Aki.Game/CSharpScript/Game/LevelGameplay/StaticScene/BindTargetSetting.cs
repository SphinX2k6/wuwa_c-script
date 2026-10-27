using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02006A0C RID: 27148
	[NullableContext(1)]
	[Nullable(0)]
	public class BindTargetSetting
	{
		// Token: 0x17009892 RID: 39058
		// (get) Token: 0x0604386F RID: 276591 RVA: 0x010841DC File Offset: 0x010823DC
		// (set) Token: 0x06043870 RID: 276592 RVA: 0x010841E4 File Offset: 0x010823E4
		public EMovieCameraSequenceSettingBindTargetType BindTargetType { get; set; }

		// Token: 0x17009893 RID: 39059
		// (get) Token: 0x06043871 RID: 276593 RVA: 0x010841ED File Offset: 0x010823ED
		// (set) Token: 0x06043872 RID: 276594 RVA: 0x010841F5 File Offset: 0x010823F5
		public FName AttachSocketName { get; set; }

		// Token: 0x17009894 RID: 39060
		// (get) Token: 0x06043873 RID: 276595 RVA: 0x010841FE File Offset: 0x010823FE
		// (set) Token: 0x06043874 RID: 276596 RVA: 0x01084206 File Offset: 0x01082406
		public Vector AttachLocationOffset { get; set; }

		// Token: 0x17009895 RID: 39061
		// (get) Token: 0x06043875 RID: 276597 RVA: 0x0108420F File Offset: 0x0108240F
		// (set) Token: 0x06043876 RID: 276598 RVA: 0x01084217 File Offset: 0x01082417
		public Rotator AttachRotatorOffset { get; set; }

		// Token: 0x17009896 RID: 39062
		// (get) Token: 0x06043877 RID: 276599 RVA: 0x01084220 File Offset: 0x01082420
		// (set) Token: 0x06043878 RID: 276600 RVA: 0x01084228 File Offset: 0x01082428
		public Vector SpecificLocationOffset { get; set; }

		// Token: 0x17009897 RID: 39063
		// (get) Token: 0x06043879 RID: 276601 RVA: 0x01084231 File Offset: 0x01082431
		// (set) Token: 0x0604387A RID: 276602 RVA: 0x01084239 File Offset: 0x01082439
		public Rotator SpecificRotatorOffset { get; set; }

		// Token: 0x17009898 RID: 39064
		// (get) Token: 0x0604387B RID: 276603 RVA: 0x01084242 File Offset: 0x01082442
		// (set) Token: 0x0604387C RID: 276604 RVA: 0x0108424A File Offset: 0x0108244A
		public Vector WorldLocation { get; set; }

		// Token: 0x17009899 RID: 39065
		// (get) Token: 0x0604387D RID: 276605 RVA: 0x01084253 File Offset: 0x01082453
		// (set) Token: 0x0604387E RID: 276606 RVA: 0x0108425B File Offset: 0x0108245B
		public Rotator WorldRotation { get; set; }

		// Token: 0x0604387F RID: 276607 RVA: 0x01084264 File Offset: 0x01082464
		public BindTargetSetting(EMovieCameraSequenceSettingBindTargetType bindTargetType, FName attachSocketName, Vector attachLocationOffset, Rotator attachRotatorOffset, Vector specificLocationOffset, Rotator specificRotatorOffset, Vector worldLocation, Rotator worldRotation)
		{
			this.BindTargetType = bindTargetType;
			this.AttachSocketName = attachSocketName;
			this.AttachLocationOffset = attachLocationOffset;
			this.AttachRotatorOffset = attachRotatorOffset;
			this.SpecificLocationOffset = specificLocationOffset;
			this.SpecificRotatorOffset = specificRotatorOffset;
			this.WorldLocation = worldLocation;
			this.WorldRotation = worldRotation;
		}

		// Token: 0x06043880 RID: 276608 RVA: 0x010842B4 File Offset: 0x010824B4
		public bool IsBindToTarget()
		{
			return this.BindTargetType == EMovieCameraSequenceSettingBindTargetType.绑定到目标身上;
		}

		// Token: 0x06043881 RID: 276609 RVA: 0x010842BF File Offset: 0x010824BF
		public bool IsBindToTargetAndPutWorld()
		{
			return this.BindTargetType == EMovieCameraSequenceSettingBindTargetType.根据目标位置放置到世界;
		}

		// Token: 0x06043882 RID: 276610 RVA: 0x010842CA File Offset: 0x010824CA
		public bool IsBindToWorld()
		{
			return this.BindTargetType == EMovieCameraSequenceSettingBindTargetType.放置到世界;
		}
	}
}
