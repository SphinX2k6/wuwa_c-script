using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02005B69 RID: 23401
	[NullableContext(1)]
	[Nullable(0)]
	public class BindTargetSetting
	{
		// Token: 0x17006D77 RID: 28023
		// (get) Token: 0x060398BB RID: 235707 RVA: 0x01028800 File Offset: 0x01026A00
		// (set) Token: 0x060398BC RID: 235708 RVA: 0x01028808 File Offset: 0x01026A08
		public EMovieCameraSequenceSettingBindTargetType BindTargetType { get; set; }

		// Token: 0x17006D78 RID: 28024
		// (get) Token: 0x060398BD RID: 235709 RVA: 0x01028811 File Offset: 0x01026A11
		// (set) Token: 0x060398BE RID: 235710 RVA: 0x01028819 File Offset: 0x01026A19
		public FName AttachSocketName { get; set; }

		// Token: 0x17006D79 RID: 28025
		// (get) Token: 0x060398BF RID: 235711 RVA: 0x01028822 File Offset: 0x01026A22
		// (set) Token: 0x060398C0 RID: 235712 RVA: 0x0102882A File Offset: 0x01026A2A
		public Vector AttachLocationOffset { get; set; }

		// Token: 0x17006D7A RID: 28026
		// (get) Token: 0x060398C1 RID: 235713 RVA: 0x01028833 File Offset: 0x01026A33
		// (set) Token: 0x060398C2 RID: 235714 RVA: 0x0102883B File Offset: 0x01026A3B
		public Rotator AttachRotatorOffset { get; set; }

		// Token: 0x17006D7B RID: 28027
		// (get) Token: 0x060398C3 RID: 235715 RVA: 0x01028844 File Offset: 0x01026A44
		// (set) Token: 0x060398C4 RID: 235716 RVA: 0x0102884C File Offset: 0x01026A4C
		public Vector SpecificLocationOffset { get; set; }

		// Token: 0x17006D7C RID: 28028
		// (get) Token: 0x060398C5 RID: 235717 RVA: 0x01028855 File Offset: 0x01026A55
		// (set) Token: 0x060398C6 RID: 235718 RVA: 0x0102885D File Offset: 0x01026A5D
		public Rotator SpecificRotatorOffset { get; set; }

		// Token: 0x17006D7D RID: 28029
		// (get) Token: 0x060398C7 RID: 235719 RVA: 0x01028866 File Offset: 0x01026A66
		// (set) Token: 0x060398C8 RID: 235720 RVA: 0x0102886E File Offset: 0x01026A6E
		public Vector WorldLocation { get; set; }

		// Token: 0x17006D7E RID: 28030
		// (get) Token: 0x060398C9 RID: 235721 RVA: 0x01028877 File Offset: 0x01026A77
		// (set) Token: 0x060398CA RID: 235722 RVA: 0x0102887F File Offset: 0x01026A7F
		public Rotator WorldRotation { get; set; }

		// Token: 0x060398CB RID: 235723 RVA: 0x01028888 File Offset: 0x01026A88
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

		// Token: 0x060398CC RID: 235724 RVA: 0x010288D8 File Offset: 0x01026AD8
		public bool IsBindToTarget()
		{
			return this.BindTargetType == EMovieCameraSequenceSettingBindTargetType.绑定到目标身上;
		}

		// Token: 0x060398CD RID: 235725 RVA: 0x010288E3 File Offset: 0x01026AE3
		public bool IsBindToTargetAndPutWorld()
		{
			return this.BindTargetType == EMovieCameraSequenceSettingBindTargetType.根据目标位置放置到世界;
		}

		// Token: 0x060398CE RID: 235726 RVA: 0x010288EE File Offset: 0x01026AEE
		public bool IsBindToWorld()
		{
			return this.BindTargetType == EMovieCameraSequenceSettingBindTargetType.放置到世界;
		}
	}
}
