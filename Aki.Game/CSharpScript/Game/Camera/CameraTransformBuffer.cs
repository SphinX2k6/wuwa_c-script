using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200644C RID: 25676
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraTransformBuffer
	{
		// Token: 0x0603E58F RID: 255375 RVA: 0x0121FA5C File Offset: 0x0121DC5C
		public void Init(FightCameraLogicComponent camera)
		{
			this.Camera = camera;
			MotorCycleTransformBuffer motorCycleTransformBuffer = new MotorCycleTransformBuffer();
			motorCycleTransformBuffer.Init(camera);
			this.CameraTransformBufferMap[ECameraTransformBufferType.MotorCycle] = motorCycleTransformBuffer;
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraTransformBuffer] Init", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603E590 RID: 255376 RVA: 0x0121FAA8 File Offset: 0x0121DCA8
		public void BufferPlayerLocation(float second, Vector outPlayerLocation)
		{
			if (this.Camera == null)
			{
				return;
			}
			foreach (IPlayerTransformBuffer playerTransformBuffer in this.CameraTransformBufferMap.Values)
			{
				if (playerTransformBuffer.IsValid())
				{
					playerTransformBuffer.BufferPlayerLocation(second, outPlayerLocation);
					break;
				}
			}
		}

		// Token: 0x0603E591 RID: 255377 RVA: 0x0121FB14 File Offset: 0x0121DD14
		public void StopBufferPlayerLocation()
		{
			foreach (IPlayerTransformBuffer playerTransformBuffer in this.CameraTransformBufferMap.Values)
			{
				playerTransformBuffer.StopBufferPlayerLocation();
			}
		}

		// Token: 0x0603E592 RID: 255378 RVA: 0x0121FB6C File Offset: 0x0121DD6C
		public void Clear()
		{
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraTransformBuffer] Clear", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Camera = null;
		}

		// Token: 0x04021391 RID: 136081
		[Nullable(2)]
		private FightCameraLogicComponent Camera;

		// Token: 0x04021392 RID: 136082
		private readonly Dictionary<ECameraTransformBufferType, IPlayerTransformBuffer> CameraTransformBufferMap = new Dictionary<ECameraTransformBufferType, IPlayerTransformBuffer>();
	}
}
