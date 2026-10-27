using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007126 RID: 28966
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcyclePlatformRotationDriver : IClear
	{
		// Token: 0x06046BB7 RID: 289719 RVA: 0x011D1D78 File Offset: 0x011CFF78
		public bool Begin(MotorcycleExploreComponent exploreComp, GrapplingHookPointComponent hook)
		{
			this.End();
			BaseActorComponent component = hook.Entity.GetComponent<BaseActorComponent>();
			BaseActorComponent actorComponent = exploreComp.ActorComponent;
			if (component == null || actorComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.WRY;
				string log_CONTEXT = MotorcyclePlatformRotationDriver.LOG_CONTEXT;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", "初始化所需的关键引用缺失");
				instance.Warn(module, author, log_CONTEXT, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.PlatformActorComp = component;
			this.MotorActorComp = actorComponent;
			this.PlatformYawInterpSpeed = hook.GetMotorEjectHookInterpSpeed();
			this.CaptureMotorAnchor();
			this.IsActive = true;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.WRY;
			string message = "[摩托弹射钩锁启动跟随相机]";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("InterpSpeed", this.PlatformYawInterpSpeed);
			instance2.Info(module2, author2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return true;
		}

		// Token: 0x06046BB8 RID: 289720 RVA: 0x011D1E30 File Offset: 0x011D0030
		private void CaptureMotorAnchor()
		{
			if (this.PlatformActorComp == null || this.MotorActorComp == null)
			{
				return;
			}
			Rotator actorRotationProxy = this.PlatformActorComp.ActorRotationProxy;
			Vector actorLocationProxy = this.PlatformActorComp.ActorLocationProxy;
			Rotator actorRotationProxy2 = this.MotorActorComp.ActorRotationProxy;
			Vector actorLocationProxy2 = this.MotorActorComp.ActorLocationProxy;
			this.InitialMotorYawOffset = Rotator.NormalizeAxis(actorRotationProxy2.Yaw - actorRotationProxy.Yaw);
			double num = actorLocationProxy2.X - actorLocationProxy.X;
			double num2 = actorLocationProxy2.Y - actorLocationProxy.Y;
			float num3 = actorRotationProxy.Yaw * 0.017453292f;
			double num4 = Math.Cos((double)num3);
			double num5 = Math.Sin((double)num3);
			this.MotorLocalX = num * num4 + num2 * num5;
			this.MotorLocalY = -num * num5 + num2 * num4;
			this.InitialMotorPitch = actorRotationProxy2.Pitch;
			this.InitialMotorRoll = actorRotationProxy2.Roll;
		}

		// Token: 0x06046BB9 RID: 289721 RVA: 0x011D1F08 File Offset: 0x011D0108
		public void Tick(float deltaMs)
		{
			if (!this.IsActive)
			{
				return;
			}
			if (this.PlatformActorComp == null || this.MotorActorComp == null)
			{
				return;
			}
			CameraController.Instance.GetCameraRotation(this.TmpRotator, "MainCamera");
			float yaw = this.TmpRotator.Yaw;
			float yaw2 = this.PlatformActorComp.ActorRotationProxy.Yaw;
			float targetYaw = Rotator.NormalizeAxis(yaw - this.InitialMotorYawOffset);
			float num = this.RInterpYawTo(yaw2, targetYaw, deltaMs);
			Rotator actorRotationProxy = this.PlatformActorComp.ActorRotationProxy;
			this.TmpRotator.Pitch = actorRotationProxy.Pitch;
			this.TmpRotator.Yaw = num;
			this.TmpRotator.Roll = actorRotationProxy.Roll;
			this.PlatformActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), MotorcyclePlatformRotationDriver.LOG_CONTEXT, false);
			this.SyncMotorToPlatform(num);
		}

		// Token: 0x06046BBA RID: 289722 RVA: 0x011D1FD8 File Offset: 0x011D01D8
		private float RInterpYawTo(float currentYaw, float targetYaw, float deltaMs)
		{
			float num = Rotator.NormalizeAxis(targetYaw - currentYaw);
			if (Math.Abs(num) < 0.01f)
			{
				return targetYaw;
			}
			float num2 = deltaMs / (float)TimeUtil.Instance.InverseMillisecond;
			double num3 = 1.0 - Math.Exp((double)(-(double)this.PlatformYawInterpSpeed * num2));
			return Rotator.NormalizeAxis((float)((double)currentYaw + (double)num * num3));
		}

		// Token: 0x06046BBB RID: 289723 RVA: 0x011D2034 File Offset: 0x011D0234
		private void SyncMotorToPlatform(float platformYaw)
		{
			if (this.PlatformActorComp == null || this.MotorActorComp == null)
			{
				return;
			}
			Vector actorLocationProxy = this.PlatformActorComp.ActorLocationProxy;
			Vector actorLocationProxy2 = this.MotorActorComp.ActorLocationProxy;
			float yaw = Rotator.NormalizeAxis(platformYaw + this.InitialMotorYawOffset);
			float num = platformYaw * 0.017453292f;
			double num2 = Math.Cos((double)num);
			double num3 = Math.Sin((double)num);
			double inX = actorLocationProxy.X + this.MotorLocalX * num2 - this.MotorLocalY * num3;
			double inY = actorLocationProxy.Y + this.MotorLocalX * num3 + this.MotorLocalY * num2;
			this.TmpVector.Set(inX, inY, actorLocationProxy2.Z);
			this.TmpRotator.Pitch = this.InitialMotorPitch;
			this.TmpRotator.Yaw = yaw;
			this.TmpRotator.Roll = this.InitialMotorRoll;
			this.MotorActorComp.SetActorLocationAndRotation(this.TmpVector.ToUeVector(false), this.TmpRotator.ToUeRotator(), MotorcyclePlatformRotationDriver.LOG_CONTEXT, false, null);
		}

		// Token: 0x06046BBC RID: 289724 RVA: 0x011D2136 File Offset: 0x011D0336
		public void End()
		{
			this.IsActive = false;
			this.PlatformActorComp = null;
			this.MotorActorComp = null;
		}

		// Token: 0x06046BBD RID: 289725 RVA: 0x011D214D File Offset: 0x011D034D
		public bool ClearObject()
		{
			this.End();
			return true;
		}

		// Token: 0x04025226 RID: 152102
		private static readonly string LOG_CONTEXT = "MotorcyclePlatformRotationDriver";

		// Token: 0x04025227 RID: 152103
		private const float PLATFORM_YAW_ALIGNED_EPSILON = 0.01f;

		// Token: 0x04025228 RID: 152104
		private bool IsActive;

		// Token: 0x04025229 RID: 152105
		[Nullable(2)]
		private BaseActorComponent PlatformActorComp;

		// Token: 0x0402522A RID: 152106
		[Nullable(2)]
		private BaseActorComponent MotorActorComp;

		// Token: 0x0402522B RID: 152107
		private float InitialMotorYawOffset;

		// Token: 0x0402522C RID: 152108
		private double MotorLocalX;

		// Token: 0x0402522D RID: 152109
		private double MotorLocalY;

		// Token: 0x0402522E RID: 152110
		private float InitialMotorPitch;

		// Token: 0x0402522F RID: 152111
		private float InitialMotorRoll;

		// Token: 0x04025230 RID: 152112
		private float PlatformYawInterpSpeed;

		// Token: 0x04025231 RID: 152113
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x04025232 RID: 152114
		private readonly Rotator TmpRotator = Rotator.Create();
	}
}
