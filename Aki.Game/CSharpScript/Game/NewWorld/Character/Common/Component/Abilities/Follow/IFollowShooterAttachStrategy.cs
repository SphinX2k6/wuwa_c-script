using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006374 RID: 25460
	[NullableContext(1)]
	public interface IFollowShooterAttachStrategy
	{
		// Token: 0x0603DAE8 RID: 252648
		void OnAttach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule, USceneComponent targetComponent);

		// Token: 0x0603DAE9 RID: 252649
		void OnDetach(USceneComponent sceneComponent, SLockOnFollowShooterAttachmentRule attachmentRule);

		// Token: 0x0603DAEA RID: 252650
		float? UpdateTransform(USceneComponent sceneComponent, IUpdateRotationParams @params);
	}
}
