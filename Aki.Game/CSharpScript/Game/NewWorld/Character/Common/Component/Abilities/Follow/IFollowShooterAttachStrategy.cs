using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007146 RID: 28998
	[NullableContext(1)]
	public interface IFollowShooterAttachStrategy
	{
		// Token: 0x06046C97 RID: 289943
		void OnAttach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule, USceneComponent targetComponent);

		// Token: 0x06046C98 RID: 289944
		void OnDetach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule);

		// Token: 0x06046C99 RID: 289945
		float? UpdateTransform(USceneComponent sceneComponent, IUpdateRotationParams @params);
	}
}
