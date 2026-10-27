using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007144 RID: 28996
	[NullableContext(1)]
	public interface IUpdateRotationParams
	{
		// Token: 0x17009D3F RID: 40255
		// (get) Token: 0x06046C86 RID: 289926
		// (set) Token: 0x06046C87 RID: 289927
		float DeltaTimeMs { get; set; }

		// Token: 0x17009D40 RID: 40256
		// (get) Token: 0x06046C88 RID: 289928
		// (set) Token: 0x06046C89 RID: 289929
		float RotationInterpSpeed { get; set; }

		// Token: 0x17009D41 RID: 40257
		// (get) Token: 0x06046C8A RID: 289930
		// (set) Token: 0x06046C8B RID: 289931
		FRotator RotateOffset { get; set; }

		// Token: 0x17009D42 RID: 40258
		// (get) Token: 0x06046C8C RID: 289932
		// (set) Token: 0x06046C8D RID: 289933
		FollowShooterAimTarget AimTarget { get; set; }
	}
}
