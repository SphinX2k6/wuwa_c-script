using System;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072FB RID: 29435
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Debug)]
	public class PhotoCameraDebugComponent : PhotoCameraComponentBase
	{
		// Token: 0x060483B4 RID: 295860 RVA: 0x0128E178 File Offset: 0x0128C378
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

		// Token: 0x04026291 RID: 156305
		private const float POINT_RADIUS = 8f;

		// Token: 0x04026292 RID: 156306
		private const int SPHERE_SEGMENTS = 12;

		// Token: 0x04026293 RID: 156307
		private const float DRAW_DURATION = 0f;

		// Token: 0x04026294 RID: 156308
		private const float LINE_THICKNESS = 1f;

		// Token: 0x04026295 RID: 156309
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor PivotColor = new FLinearColor(1f, 1f, 0f, 1f);

		// Token: 0x04026296 RID: 156310
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor DesiredColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x04026297 RID: 156311
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor WorldColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x04026298 RID: 156312
		private readonly FVectorDouble PivotVector = new FVectorDouble();

		// Token: 0x04026299 RID: 156313
		private readonly FVectorDouble DesiredVector = new FVectorDouble();

		// Token: 0x0402629A RID: 156314
		private readonly FVectorDouble WorldVector = new FVectorDouble();
	}
}
