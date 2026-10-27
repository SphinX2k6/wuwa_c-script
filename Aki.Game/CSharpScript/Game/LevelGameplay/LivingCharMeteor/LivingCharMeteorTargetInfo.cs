using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LivingCharMeteor
{
	// Token: 0x02006AC5 RID: 27333
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	internal class LivingCharMeteorTargetInfo
	{
		// Token: 0x17009971 RID: 39281
		// (get) Token: 0x06043EA7 RID: 278183 RVA: 0x010A6CE2 File Offset: 0x010A4EE2
		// (set) Token: 0x06043EA8 RID: 278184 RVA: 0x010A6CEA File Offset: 0x010A4EEA
		[RequiredMember]
		public Entity Entity { get; set; }

		// Token: 0x17009972 RID: 39282
		// (get) Token: 0x06043EA9 RID: 278185 RVA: 0x010A6CF3 File Offset: 0x010A4EF3
		// (set) Token: 0x06043EAA RID: 278186 RVA: 0x010A6CFB File Offset: 0x010A4EFB
		[RequiredMember]
		public AActor Actor { get; set; }

		// Token: 0x17009973 RID: 39283
		// (get) Token: 0x06043EAB RID: 278187 RVA: 0x010A6D04 File Offset: 0x010A4F04
		// (set) Token: 0x06043EAC RID: 278188 RVA: 0x010A6D0C File Offset: 0x010A4F0C
		public double ScreenDistSquared { get; set; }

		// Token: 0x17009974 RID: 39284
		// (get) Token: 0x06043EAD RID: 278189 RVA: 0x010A6D15 File Offset: 0x010A4F15
		// (set) Token: 0x06043EAE RID: 278190 RVA: 0x010A6D1D File Offset: 0x010A4F1D
		public double DistanceSquared { get; set; }

		// Token: 0x06043EAF RID: 278191 RVA: 0x010A6D26 File Offset: 0x010A4F26
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LivingCharMeteorTargetInfo()
		{
		}
	}
}
