using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F7 RID: 29431
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Blend)]
	public class PhotoCameraBlendComponent : PhotoCameraComponentBase
	{
		// Token: 0x17009F5E RID: 40798
		// (get) Token: 0x06048377 RID: 295799 RVA: 0x0128CA73 File Offset: 0x0128AC73
		public bool IsBlending
		{
			get
			{
				return this.Pending != null;
			}
		}

		// Token: 0x06048378 RID: 295800 RVA: 0x0128CA80 File Offset: 0x0128AC80
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

		// Token: 0x06048379 RID: 295801 RVA: 0x0128CB28 File Offset: 0x0128AD28
		public UniTask Blend()
		{
			PhotoCameraBlendComponent.<Blend>d__31 <Blend>d__;
			<Blend>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Blend>d__.<>4__this = this;
			<Blend>d__.<>1__state = -1;
			<Blend>d__.<>t__builder.Start<PhotoCameraBlendComponent.<Blend>d__31>(ref <Blend>d__);
			return <Blend>d__.<>t__builder.Task;
		}

		// Token: 0x0604837A RID: 295802 RVA: 0x0128CB6C File Offset: 0x0128AD6C
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

		// Token: 0x0604837B RID: 295803 RVA: 0x0128CDAD File Offset: 0x0128AFAD
		protected override void OnDestroy()
		{
			this.BlendFinish();
		}

		// Token: 0x0604837C RID: 295804 RVA: 0x0128CDB8 File Offset: 0x0128AFB8
		private void LookAtQuat(global::Vector from, global::Vector to, Quat @out)
		{
			Rotator tmpRotator = this.TmpRotator;
			FVectorDouble fvectorDouble = from.ToUeVector(false);
			FVectorDouble fvectorDouble2 = to.ToUeVector(false);
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble2);
			tmpRotator.FromUeRotator(frotator);
			this.TmpRotator.Quaternion(@out);
		}

		// Token: 0x0604837D RID: 295805 RVA: 0x0128CDF9 File Offset: 0x0128AFF9
		private void ComputeDelta(Quat real, global::Vector camPos, global::Vector center, Quat @out)
		{
			this.LookAtQuat(camPos, center, this.TmpLookAt);
			this.TmpLookAt.Inverse(this.TmpInverse);
			real.Multiply(this.TmpInverse, @out);
		}

		// Token: 0x0604837E RID: 295806 RVA: 0x0128CE28 File Offset: 0x0128B028
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

		// Token: 0x04026257 RID: 156247
		private const float MODE_BLEND_TIME = 2f;

		// Token: 0x04026258 RID: 156248
		private const bool DOLLY_ZOOM = true;

		// Token: 0x04026259 RID: 156249
		private const float DEFAULT_DOLLY_CONVERGE_POWER = 2f;

		// Token: 0x0402625A RID: 156250
		private float Elapsed;

		// Token: 0x0402625B RID: 156251
		private float Duration;

		// Token: 0x0402625C RID: 156252
		private readonly global::Vector StartCenter = global::Vector.Create();

		// Token: 0x0402625D RID: 156253
		private readonly global::Vector EndCenter = global::Vector.Create();

		// Token: 0x0402625E RID: 156254
		private readonly global::Vector StartDir = global::Vector.Create();

		// Token: 0x0402625F RID: 156255
		private float StartRadius;

		// Token: 0x04026260 RID: 156256
		private float StartFov;

		// Token: 0x04026261 RID: 156257
		private readonly global::Vector EndDir = global::Vector.Create();

		// Token: 0x04026262 RID: 156258
		private float EndRadius;

		// Token: 0x04026263 RID: 156259
		private float EndFov;

		// Token: 0x04026264 RID: 156260
		private float DollyConstant;

		// Token: 0x04026265 RID: 156261
		private readonly Quat StartDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026266 RID: 156262
		private readonly Quat EndDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026267 RID: 156263
		private readonly global::Vector TmpCenter = global::Vector.Create();

		// Token: 0x04026268 RID: 156264
		private readonly global::Vector TmpDir = global::Vector.Create();

		// Token: 0x04026269 RID: 156265
		private readonly global::Vector TmpLocation = global::Vector.Create();

		// Token: 0x0402626A RID: 156266
		private readonly Quat StartToEndQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402626B RID: 156267
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402626C RID: 156268
		private readonly Quat TmpLookAt = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402626D RID: 156269
		private readonly Quat TmpInverse = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402626E RID: 156270
		private readonly Quat TmpDelta = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402626F RID: 156271
		private readonly Quat TmpReal = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026270 RID: 156272
		private readonly Quat TmpFinal = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026271 RID: 156273
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x04026272 RID: 156274
		[Nullable(2)]
		private CustomPromise Pending;
	}
}
