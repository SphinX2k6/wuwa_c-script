using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200644A RID: 25674
	[NullableContext(1)]
	public interface IPlayerTransformBuffer
	{
		// Token: 0x0603E57C RID: 255356
		void Init(FightCameraLogicComponent camera);

		// Token: 0x0603E57D RID: 255357
		bool IsValid();

		// Token: 0x0603E57E RID: 255358
		bool IsNeedBufferPlayerLocation();

		// Token: 0x0603E57F RID: 255359
		void BufferPlayerLocation(float second, Vector outPlayerLocation);

		// Token: 0x0603E580 RID: 255360
		void StopBufferPlayerLocation();
	}
}
