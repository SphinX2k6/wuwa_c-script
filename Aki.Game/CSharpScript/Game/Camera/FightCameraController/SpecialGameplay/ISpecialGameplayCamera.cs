using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200646F RID: 25711
	[NullableContext(1)]
	public interface ISpecialGameplayCamera
	{
		// Token: 0x0603E78E RID: 255886
		void OnInit(ACameraActor camera, CameraModelInstance cameraModel);

		// Token: 0x0603E78F RID: 255887
		void Update(float deltaTime);

		// Token: 0x0603E790 RID: 255888
		void OnDestroy();
	}
}
