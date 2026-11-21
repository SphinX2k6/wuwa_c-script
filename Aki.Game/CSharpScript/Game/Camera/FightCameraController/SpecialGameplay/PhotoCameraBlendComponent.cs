using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200647A RID: 25722
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Blend)]
	public class PhotoCameraBlendComponent : PhotoCameraComponentBase
	{
		// Token: 0x170076FC RID: 30460
		// (get) Token: 0x0603E7C3 RID: 255939 RVA: 0x0122F427 File Offset: 0x0122D627
		public bool IsBlending
		{
			get
			{
				return this.Pending != null;
			}
		}

		// Token: 0x0603E7C4 RID: 255940 RVA: 0x0122F434 File Offset: 0x0122D634
		public void CaptureStart()
		{
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			this.StartCenter.DeepCopy(virtualCamera.CameraCenter);
			virtualCamera.WorldLocation.Subtraction(this.StartCenter, this.StartDir);
			this.StartRadius = (float)this.StartDir.Size();
			this.StartDir.Normalize(9.99999993922529E-09);
			this.StartFov = virtualCamera.Fov;
			virtualCamera.WorldRotation.Quaternion(this.TmpReal);
			this.ComputeDelta(this.TmpReal, virtualCamera.WorldLocation, this.StartCenter, this.StartDelta);
		}

		// Token: 0x0603E7C5 RID: 255941 RVA: 0x0122F4DC File Offset: 0x0122D6DC
		public UniTask Blend()
		{
			PhotoCameraBlendComponent.<Blend>d__31 <Blend>d__;
			<Blend>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Blend>d__.<>4__this = this;
			<Blend>d__.<>1__state = -1;
			<Blend>d__.<>t__builder.Start<PhotoCameraBlendComponent.<Blend>d__31>(ref <Blend>d__);
			return <Blend>d__.<>t__builder.Task;
		}

		// Token: 0x0603E7C6 RID: 255942 RVA: 0x0122F520 File Offset: 0x0122D720
		protected override void OnTick(float deltaTime)
		{
			if (this.Pending == null)
			{
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			this.Elapsed += deltaTime;
			float num = MathUtils.Instance.Clamp(this.Elapsed / this.Duration, 0f, 1f);
			global::Vector.Lerp(this.StartCenter, this.EndCenter, (double)num, this.TmpCenter);
			virtualCamera.CameraCenter.DeepCopy(this.TmpCenter);
			Quat.Slerp(Quat.IdentityProxy, this.StartToEndQuat, num, this.TmpQuat);
			this.TmpQuat.RotateVector(this.StartDir, this.TmpDir);
			float num2 = MathUtils.Instance.Lerp(this.StartRadius, this.EndRadius, num);
			this.TmpDir.Multiply((double)num2, this.TmpLocation);
			this.TmpLocation.Addition(this.TmpCenter, virtualCamera.DesiredWorldLocation);
			this.LookAtQuat(virtualCamera.DesiredWorldLocation, this.TmpCenter, this.TmpLookAt);
			Quat.Slerp(this.StartDelta, this.EndDelta, num, this.TmpDelta);
			this.TmpDelta.Multiply(this.TmpLookAt, this.TmpFinal);
			this.TmpFinal.Rotator(virtualCamera.DesiredWorldRotation);
			if ((double)num2 > 0.0001)
			{
				float from = 2f * (float)Math.Atan((double)(this.DollyConstant / num2)) * 57.29578f;
				float valueOrDefault = ConfigCommonParamById.GetFloatConfig("PhotoCameraDollyConvergePower").GetValueOrDefault(2f);
				float alpha = (float)Math.Pow((double)num, (double)valueOrDefault);
				virtualCamera.Fov = MathUtils.Instance.Lerp(from, this.EndFov, alpha);
			}
			else
			{
				virtualCamera.Fov = MathUtils.Instance.Lerp(this.StartFov, this.EndFov, num);
			}
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			FVector2D? fvector2D = (currentConfig != null) ? new FVector2D?(currentConfig.CommonConfig.FovRange) : null;
			if (fvector2D != null)
			{
				virtualCamera.Fov = MathUtils.Instance.Clamp(virtualCamera.Fov, fvector2D.Value.X, fvector2D.Value.Y);
			}
			if (num >= 1f)
			{
				this.BlendFinish();
			}
		}

		// Token: 0x0603E7C7 RID: 255943 RVA: 0x0122F761 File Offset: 0x0122D961
		protected override void OnDestroy()
		{
			this.BlendFinish();
		}

		// Token: 0x0603E7C8 RID: 255944 RVA: 0x0122F76C File Offset: 0x0122D96C
		private void LookAtQuat(global::Vector from, global::Vector to, Quat @out)
		{
			Rotator tmpRotator = this.TmpRotator;
			FVectorDouble fvectorDouble = from.ToUeVector(false);
			FVectorDouble fvectorDouble2 = to.ToUeVector(false);
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble2);
			tmpRotator.FromUeRotator(frotator);
			this.TmpRotator.Quaternion(@out);
		}

		// Token: 0x0603E7C9 RID: 255945 RVA: 0x0122F7AD File Offset: 0x0122D9AD
		private void ComputeDelta(Quat real, global::Vector camPos, global::Vector center, Quat @out)
		{
			this.LookAtQuat(camPos, center, this.TmpLookAt);
			this.TmpLookAt.Inverse(this.TmpInverse);
			real.Multiply(this.TmpInverse, @out);
		}

		// Token: 0x0603E7CA RID: 255946 RVA: 0x0122F7DC File Offset: 0x0122D9DC
		private void BlendFinish()
		{
			if (this.Pending == null)
			{
				return;
			}
			CustomPromise pending = this.Pending;
			this.Pending = null;
			this.Duration = 0f;
			pending.SetResult();
		}

		// Token: 0x04021542 RID: 136514
		private const float MODE_BLEND_TIME = 2f;

		// Token: 0x04021543 RID: 136515
		private const bool DOLLY_ZOOM = true;

		// Token: 0x04021544 RID: 136516
		private const float DEFAULT_DOLLY_CONVERGE_POWER = 2f;

		// Token: 0x04021545 RID: 136517
		private float Elapsed;

		// Token: 0x04021546 RID: 136518
		private float Duration;

		// Token: 0x04021547 RID: 136519
		private readonly global::Vector StartCenter = global::Vector.Create();

		// Token: 0x04021548 RID: 136520
		private readonly global::Vector EndCenter = global::Vector.Create();

		// Token: 0x04021549 RID: 136521
		private readonly global::Vector StartDir = global::Vector.Create();

		// Token: 0x0402154A RID: 136522
		private float StartRadius;

		// Token: 0x0402154B RID: 136523
		private float StartFov;

		// Token: 0x0402154C RID: 136524
		private readonly global::Vector EndDir = global::Vector.Create();

		// Token: 0x0402154D RID: 136525
		private float EndRadius;

		// Token: 0x0402154E RID: 136526
		private float EndFov;

		// Token: 0x0402154F RID: 136527
		private float DollyConstant;

		// Token: 0x04021550 RID: 136528
		private readonly Quat StartDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021551 RID: 136529
		private readonly Quat EndDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021552 RID: 136530
		private readonly global::Vector TmpCenter = global::Vector.Create();

		// Token: 0x04021553 RID: 136531
		private readonly global::Vector TmpDir = global::Vector.Create();

		// Token: 0x04021554 RID: 136532
		private readonly global::Vector TmpLocation = global::Vector.Create();

		// Token: 0x04021555 RID: 136533
		private readonly Quat StartToEndQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021556 RID: 136534
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021557 RID: 136535
		private readonly Quat TmpLookAt = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021558 RID: 136536
		private readonly Quat TmpInverse = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021559 RID: 136537
		private readonly Quat TmpDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402155A RID: 136538
		private readonly Quat TmpReal = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402155B RID: 136539
		private readonly Quat TmpFinal = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402155C RID: 136540
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x0402155D RID: 136541
		[Nullable(2)]
		private CustomPromise Pending;
	}
}
