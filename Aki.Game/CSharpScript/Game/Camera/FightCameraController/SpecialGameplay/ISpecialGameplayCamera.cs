using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072EC RID: 29420
	[NullableContext(1)]
	public interface ISpecialGameplayCamera
	{
		// Token: 0x06048342 RID: 295746
		void OnInit(ACameraActor camera, CameraModelInstance cameraModel);

		// Token: 0x06048343 RID: 295747
		void Update(float deltaTime);

		// Token: 0x06048344 RID: 295748
		void OnDestroy();
	}
}
