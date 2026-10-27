using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072CA RID: 29386
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraTransformBuffer
	{
		// Token: 0x0604818C RID: 295308 RVA: 0x0127CF60 File Offset: 0x0127B160
		public void Init(FightCameraLogicComponent camera)
		{
			this.Camera = camera;
			MotorCycleTransformBuffer motorCycleTransformBuffer = new MotorCycleTransformBuffer();
			motorCycleTransformBuffer.Init(camera);
			this.CameraTransformBufferMap[ECameraTransformBufferType.MotorCycle] = motorCycleTransformBuffer;
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraTransformBuffer] Init", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0604818D RID: 295309 RVA: 0x0127CFAC File Offset: 0x0127B1AC
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

		// Token: 0x0604818E RID: 295310 RVA: 0x0127D018 File Offset: 0x0127B218
		public void StopBufferPlayerLocation()
		{
			foreach (IPlayerTransformBuffer playerTransformBuffer in this.CameraTransformBufferMap.Values)
			{
				playerTransformBuffer.StopBufferPlayerLocation();
			}
		}

		// Token: 0x0604818F RID: 295311 RVA: 0x0127D070 File Offset: 0x0127B270
		public void Clear()
		{
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraTransformBuffer] Clear", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Camera = null;
		}

		// Token: 0x040260AE RID: 155822
		[Nullable(2)]
		private FightCameraLogicComponent Camera;

		// Token: 0x040260AF RID: 155823
		private readonly Dictionary<ECameraTransformBufferType, IPlayerTransformBuffer> CameraTransformBufferMap = new Dictionary<ECameraTransformBufferType, IPlayerTransformBuffer>();
	}
}
