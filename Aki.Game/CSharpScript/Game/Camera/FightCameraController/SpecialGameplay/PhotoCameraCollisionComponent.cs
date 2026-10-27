using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F9 RID: 29433
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Collision)]
	public class PhotoCameraCollisionComponent : PhotoCameraComponentBase
	{
		// Token: 0x06048399 RID: 295833 RVA: 0x0128DD00 File Offset: 0x0128BF00
		protected override void OnInit()
		{
			TsBaseCharacter character = this.Host.Character;
			this.SphereTrace = new UTraceSphereElement();
			this.SphereTrace.bIsSingle = true;
			this.SphereTrace.bTraceComplex = false;
			this.SphereTrace.bIgnoreSelf = true;
			this.SphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.SphereTrace.Radius = 5f;
			if (character != null)
			{
				this.SphereTrace.ActorsToIgnore.Add(character);
			}
		}

		// Token: 0x0604839A RID: 295834 RVA: 0x0128DD7C File Offset: 0x0128BF7C
		protected override void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.WorldLocation.DeepCopy(virtualCamera.DesiredWorldLocation);
			virtualCamera.WorldRotation.DeepCopy(virtualCamera.DesiredWorldRotation);
			this.CurrentArmLength = MathUtils.Instance.VectorDistance(virtualCamera.Pivot, virtualCamera.DesiredWorldLocation);
			this.IsArmRecovering = false;
		}

		// Token: 0x0604839B RID: 295835 RVA: 0x0128DDDC File Offset: 0x0128BFDC
		protected override void OnTick(float deltaTime)
		{
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.WorldRotation.DeepCopy(virtualCamera.DesiredWorldRotation);
			virtualCamera.DesiredWorldLocation.Subtraction(virtualCamera.Pivot, this.ArmVector);
			double num = this.ArmVector.Size();
			if (num <= 1.0)
			{
				virtualCamera.WorldLocation.DeepCopy(virtualCamera.DesiredWorldLocation);
				this.CurrentArmLength = num;
				this.IsArmRecovering = false;
				return;
			}
			this.ArmVector.GetSafeNormal(this.ArmDirection, 9.99999993922529E-09);
			if (this.Sweep(virtualCamera.Pivot, virtualCamera.DesiredWorldLocation, this.SafeLocation))
			{
				this.CurrentArmLength = MathUtils.Instance.VectorDistance(virtualCamera.Pivot, this.SafeLocation);
				this.IsArmRecovering = true;
			}
			else if (!this.IsArmRecovering || num <= this.CurrentArmLength)
			{
				this.CurrentArmLength = num;
				this.IsArmRecovering = false;
			}
			else
			{
				SPhotoCameraCommonConfig commonConfig = currentConfig.CommonConfig;
				if (commonConfig.OpenCameraAdaptive && commonConfig.AdaptiveMoveSpeed > 0f)
				{
					float num2 = MathUtils.Instance.Clamp(commonConfig.AdaptiveMoveSpeed * deltaTime, 0f, 1f);
					this.CurrentArmLength = MathUtils.Instance.Lerp(this.CurrentArmLength, num, (double)num2);
				}
				else
				{
					this.CurrentArmLength = num;
				}
				if (num - this.CurrentArmLength <= 1.0)
				{
					this.CurrentArmLength = num;
					this.IsArmRecovering = false;
				}
			}
			this.ArmDirection.Multiply(this.CurrentArmLength, this.ArmVector);
			virtualCamera.WorldLocation.DeepCopy(virtualCamera.Pivot);
			virtualCamera.WorldLocation.AdditionEqual(this.ArmVector);
		}

		// Token: 0x0604839C RID: 295836 RVA: 0x0128DF9C File Offset: 0x0128C19C
		protected override void OnDestroy()
		{
			if (this.SphereTrace != null)
			{
				this.SphereTrace.Dispose();
				this.SphereTrace = null;
			}
		}

		// Token: 0x0604839D RID: 295837 RVA: 0x0128DFB8 File Offset: 0x0128C1B8
		private bool Sweep(Vector start, Vector end, Vector @out)
		{
			UTraceSphereElement sphereTrace = this.SphereTrace;
			UKuroHitResult hitResult = sphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			sphereTrace.WorldContextObject = GlobalData.World;
			TraceElementCommon.Instance.SetStartLocation(sphereTrace, start);
			TraceElementCommon.Instance.SetEndLocation(sphereTrace, end);
			if (TraceElementCommon.Instance.SphereTrace(sphereTrace, "PhotoCameraCollisionComponent_Sweep"))
			{
				TraceElementCommon.Instance.GetHitLocation(sphereTrace.HitResult, 0, @out);
				return true;
			}
			@out.DeepCopy(end);
			return false;
		}

		// Token: 0x04026284 RID: 156292
		private const float PROBE_RADIUS = 5f;

		// Token: 0x04026285 RID: 156293
		private const string COLLISION_PROFILE_KEY = "PhotoCameraCollisionComponent_Sweep";

		// Token: 0x04026286 RID: 156294
		private const double ARM_RECOVER_TOLERANCE = 1.0;

		// Token: 0x04026287 RID: 156295
		[Nullable(2)]
		private UTraceSphereElement SphereTrace;

		// Token: 0x04026288 RID: 156296
		private readonly Vector SafeLocation = Vector.Create();

		// Token: 0x04026289 RID: 156297
		private readonly Vector ArmVector = Vector.Create();

		// Token: 0x0402628A RID: 156298
		private readonly Vector ArmDirection = Vector.Create();

		// Token: 0x0402628B RID: 156299
		private double CurrentArmLength;

		// Token: 0x0402628C RID: 156300
		private bool IsArmRecovering;
	}
}
