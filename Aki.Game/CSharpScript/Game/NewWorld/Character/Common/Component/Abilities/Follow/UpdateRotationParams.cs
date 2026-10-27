using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007145 RID: 28997
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class UpdateRotationParams : IUpdateRotationParams
	{
		// Token: 0x17009D43 RID: 40259
		// (get) Token: 0x06046C8E RID: 289934 RVA: 0x011D618A File Offset: 0x011D438A
		// (set) Token: 0x06046C8F RID: 289935 RVA: 0x011D6192 File Offset: 0x011D4392
		public float DeltaTimeMs { get; set; }

		// Token: 0x17009D44 RID: 40260
		// (get) Token: 0x06046C90 RID: 289936 RVA: 0x011D619B File Offset: 0x011D439B
		// (set) Token: 0x06046C91 RID: 289937 RVA: 0x011D61A3 File Offset: 0x011D43A3
		public float RotationInterpSpeed { get; set; }

		// Token: 0x17009D45 RID: 40261
		// (get) Token: 0x06046C92 RID: 289938 RVA: 0x011D61AC File Offset: 0x011D43AC
		// (set) Token: 0x06046C93 RID: 289939 RVA: 0x011D61B4 File Offset: 0x011D43B4
		[RequiredMember]
		public FRotator RotateOffset { get; set; }

		// Token: 0x17009D46 RID: 40262
		// (get) Token: 0x06046C94 RID: 289940 RVA: 0x011D61BD File Offset: 0x011D43BD
		// (set) Token: 0x06046C95 RID: 289941 RVA: 0x011D61C5 File Offset: 0x011D43C5
		[RequiredMember]
		public FollowShooterAimTarget AimTarget { get; set; }

		// Token: 0x06046C96 RID: 289942 RVA: 0x011D61CE File Offset: 0x011D43CE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UpdateRotationParams()
		{
		}
	}
}
