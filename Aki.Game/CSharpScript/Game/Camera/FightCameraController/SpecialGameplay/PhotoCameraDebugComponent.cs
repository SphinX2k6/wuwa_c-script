using System;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200647E RID: 25726
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Debug)]
	public class PhotoCameraDebugComponent : PhotoCameraComponentBase
	{
		// Token: 0x0603E800 RID: 256000 RVA: 0x01230B2C File Offset: 0x0122ED2C
		protected override void OnTick(float deltaTime)
		{
			if (!this.Host.IsDebugEnable)
			{
				return;
			}
			UWorld world = GlobalData.World;
			if (world == null)
			{
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			FVectorDouble pivotVector = this.PivotVector;
			FVectorDouble desiredVector = this.DesiredVector;
			FVectorDouble worldVector = this.WorldVector;
			pivotVector.X = virtualCamera.CameraCenter.X;
			pivotVector.Y = virtualCamera.CameraCenter.Y;
			pivotVector.Z = virtualCamera.CameraCenter.Z;
			desiredVector.X = virtualCamera.DesiredWorldLocation.X;
			desiredVector.Y = virtualCamera.DesiredWorldLocation.Y;
			desiredVector.Z = virtualCamera.DesiredWorldLocation.Z;
			worldVector.X = virtualCamera.WorldLocation.X;
			worldVector.Y = virtualCamera.WorldLocation.Y;
			worldVector.Z = virtualCamera.WorldLocation.Z;
			UKismetSystemLibrary.D_DrawDebugSphere(world, pivotVector, 8f, 12, new FLinearColor?(PhotoCameraDebugComponent.PivotColor), 0f, 1f);
			UKismetSystemLibrary.D_DrawDebugSphere(world, desiredVector, 8f, 12, new FLinearColor?(PhotoCameraDebugComponent.DesiredColor), 0f, 1f);
			UKismetSystemLibrary.D_DrawDebugSphere(world, worldVector, 8f, 12, new FLinearColor?(PhotoCameraDebugComponent.WorldColor), 0f, 1f);
			UKismetSystemLibrary.D_DrawDebugLine(world, pivotVector, desiredVector, PhotoCameraDebugComponent.DesiredColor, 0f, 1f);
			UKismetSystemLibrary.D_DrawDebugLine(world, pivotVector, worldVector, PhotoCameraDebugComponent.WorldColor, 0f, 1f);
		}

		// Token: 0x0402157C RID: 136572
		private const float POINT_RADIUS = 8f;

		// Token: 0x0402157D RID: 136573
		private const int SPHERE_SEGMENTS = 12;

		// Token: 0x0402157E RID: 136574
		private const float DRAW_DURATION = 0f;

		// Token: 0x0402157F RID: 136575
		private const float LINE_THICKNESS = 1f;

		// Token: 0x04021580 RID: 136576
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor PivotColor = new FLinearColor(1f, 1f, 0f, 1f);

		// Token: 0x04021581 RID: 136577
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor DesiredColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x04021582 RID: 136578
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor WorldColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x04021583 RID: 136579
		private readonly FVectorDouble PivotVector = new FVectorDouble();

		// Token: 0x04021584 RID: 136580
		private readonly FVectorDouble DesiredVector = new FVectorDouble();

		// Token: 0x04021585 RID: 136581
		private readonly FVectorDouble WorldVector = new FVectorDouble();
	}
}
