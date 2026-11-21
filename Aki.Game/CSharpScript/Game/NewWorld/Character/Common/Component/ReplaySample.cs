using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006320 RID: 25376
	[NullableContext(1)]
	[Nullable(0)]
	public class ReplaySample
	{
		// Token: 0x0603D6C1 RID: 251585 RVA: 0x011C2CEC File Offset: 0x011C0EEC
		public ReplaySample(MoveReplaySample moveInfo, int controllerPlayerId, double time)
		{
			Aki.Protocol.Vector location = moveInfo.Location;
			Aki.Protocol.Rotator rotation = moveInfo.Rotation;
			Aki.Protocol.Vector linearVelocity = moveInfo.LinearVelocity;
			Aki.Protocol.Vector slideForward = moveInfo.SlideForward;
			this.Location.Set((double)location.X, (double)location.Y, (double)location.Z);
			this.Rotation.Set(rotation.Pitch, rotation.Yaw, rotation.Roll);
			if (linearVelocity != null)
			{
				this.LinearVelocity.Set((double)linearVelocity.X, (double)linearVelocity.Y, (double)linearVelocity.Z);
			}
			if (slideForward != null)
			{
				this.SlideForward.Set((double)slideForward.X, (double)slideForward.Y, (double)slideForward.Z);
			}
			this.ControllerPitch = moveInfo.ControllerPitch;
			this.MovementMode = moveInfo.MovementMode;
			this.Input = moveInfo.InputDirection;
			this.TimeScale = moveInfo.TimeScale;
			this.TimeStamp = time;
			this.ControllerPlayerId = controllerPlayerId;
			this.ServerTimeStamp = moveInfo.ServerTimeStamp;
			this.Rtt = moveInfo.RTT;
			RelativeMoveReplaySample relativeMoveReplaySample = moveInfo.RelativeMoveReplaySample;
			if (relativeMoveReplaySample != null)
			{
				this.RelativeMove = new RelativeMove
				{
					BaseMovementEntityId = relativeMoveReplaySample.BaseMovementEntityId
				};
				Aki.Protocol.Rotator relativeRotation = relativeMoveReplaySample.RelativeRotation;
				Aki.Protocol.Vector relativeLocation = relativeMoveReplaySample.RelativeLocation;
				this.RelativeMove.RelativeRotation = global::Rotator.Create(relativeRotation.Pitch, relativeRotation.Yaw, relativeRotation.Roll);
				this.RelativeMove.RelativeLocation = global::Vector.Create((double)relativeLocation.X, (double)relativeLocation.Y, (double)relativeLocation.Z);
			}
		}

		// Token: 0x04020923 RID: 133411
		public global::Vector Location = global::Vector.Create();

		// Token: 0x04020924 RID: 133412
		public global::Rotator Rotation = global::Rotator.Create();

		// Token: 0x04020925 RID: 133413
		public global::Vector LinearVelocity = global::Vector.Create();

		// Token: 0x04020926 RID: 133414
		public global::Vector SlideForward = global::Vector.Create();

		// Token: 0x04020927 RID: 133415
		public float ControllerPitch;

		// Token: 0x04020928 RID: 133416
		public int MovementMode;

		// Token: 0x04020929 RID: 133417
		public int Input;

		// Token: 0x0402092A RID: 133418
		public double TimeStamp;

		// Token: 0x0402092B RID: 133419
		[Nullable(2)]
		public RelativeMove RelativeMove;

		// Token: 0x0402092C RID: 133420
		public int ControllerPlayerId;

		// Token: 0x0402092D RID: 133421
		public float TimeScale;

		// Token: 0x0402092E RID: 133422
		public long ServerTimeStamp;

		// Token: 0x0402092F RID: 133423
		public int Rtt;
	}
}
