using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C8 RID: 29384
	[NullableContext(1)]
	public interface IPlayerTransformBuffer
	{
		// Token: 0x06048179 RID: 295289
		void Init(FightCameraLogicComponent camera);

		// Token: 0x0604817A RID: 295290
		bool IsValid();

		// Token: 0x0604817B RID: 295291
		bool IsNeedBufferPlayerLocation();

		// Token: 0x0604817C RID: 295292
		void BufferPlayerLocation(float second, Vector outPlayerLocation);

		// Token: 0x0604817D RID: 295293
		void StopBufferPlayerLocation();
	}
}
