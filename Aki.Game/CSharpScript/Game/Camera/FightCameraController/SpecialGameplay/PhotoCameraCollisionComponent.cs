using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200647C RID: 25724
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Collision)]
	public class PhotoCameraCollisionComponent : PhotoCameraComponentBase
	{
		// Token: 0x0603E7E5 RID: 255973 RVA: 0x012306B4 File Offset: 0x0122E8B4
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

		// Token: 0x0603E7E6 RID: 255974 RVA: 0x01230730 File Offset: 0x0122E930
		protected override void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.WorldLocation.DeepCopy(virtualCamera.DesiredWorldLocation);
			virtualCamera.WorldRotation.DeepCopy(virtualCamera.DesiredWorldRotation);
			this.CurrentArmLength = MathUtils.Instance.VectorDistance(virtualCamera.Pivot, virtualCamera.DesiredWorldLocation);
			this.IsArmRecovering = false;
		}

		// Token: 0x0603E7E7 RID: 255975 RVA: 0x01230790 File Offset: 0x0122E990
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

		// Token: 0x0603E7E8 RID: 255976 RVA: 0x01230950 File Offset: 0x0122EB50
		protected override void OnDestroy()
		{
			if (this.SphereTrace != null)
			{
				this.SphereTrace.Dispose();
				this.SphereTrace = null;
			}
		}

		// Token: 0x0603E7E9 RID: 255977 RVA: 0x0123096C File Offset: 0x0122EB6C
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

		// Token: 0x0402156F RID: 136559
		private const float PROBE_RADIUS = 5f;

		// Token: 0x04021570 RID: 136560
		private const string COLLISION_PROFILE_KEY = "PhotoCameraCollisionComponent_Sweep";

		// Token: 0x04021571 RID: 136561
		private const double ARM_RECOVER_TOLERANCE = 1.0;

		// Token: 0x04021572 RID: 136562
		[Nullable(2)]
		private UTraceSphereElement SphereTrace;

		// Token: 0x04021573 RID: 136563
		private readonly Vector SafeLocation = Vector.Create();

		// Token: 0x04021574 RID: 136564
		private readonly Vector ArmVector = Vector.Create();

		// Token: 0x04021575 RID: 136565
		private readonly Vector ArmDirection = Vector.Create();

		// Token: 0x04021576 RID: 136566
		private double CurrentArmLength;

		// Token: 0x04021577 RID: 136567
		private bool IsArmRecovering;
	}
}
