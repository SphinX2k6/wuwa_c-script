using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070BC RID: 28860
	[NullableContext(1)]
	[Nullable(0)]
	public class ReplaySample
	{
		// Token: 0x060465E8 RID: 288232 RVA: 0x011A3008 File Offset: 0x011A1208
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

		// Token: 0x04024DE5 RID: 151013
		public global::Vector Location = global::Vector.Create();

		// Token: 0x04024DE6 RID: 151014
		public global::Rotator Rotation = global::Rotator.Create();

		// Token: 0x04024DE7 RID: 151015
		public global::Vector LinearVelocity = global::Vector.Create();

		// Token: 0x04024DE8 RID: 151016
		public global::Vector SlideForward = global::Vector.Create();

		// Token: 0x04024DE9 RID: 151017
		public float ControllerPitch;

		// Token: 0x04024DEA RID: 151018
		public int MovementMode;

		// Token: 0x04024DEB RID: 151019
		public int Input;

		// Token: 0x04024DEC RID: 151020
		public double TimeStamp;

		// Token: 0x04024DED RID: 151021
		[Nullable(2)]
		public RelativeMove RelativeMove;

		// Token: 0x04024DEE RID: 151022
		public int ControllerPlayerId;

		// Token: 0x04024DEF RID: 151023
		public float TimeScale;

		// Token: 0x04024DF0 RID: 151024
		public long ServerTimeStamp;

		// Token: 0x04024DF1 RID: 151025
		public int Rtt;
	}
}
