using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200399A RID: 14746
	public class UiCameraTransformHandleData : UiCameraActorTagHandleData
	{
		// Token: 0x06025FAF RID: 155567 RVA: 0x00AA8D9C File Offset: 0x00AA6F9C
		internal void SetTransform(FTransformDouble? transform)
		{
			this.Transform = transform;
		}

		// Token: 0x06025FB0 RID: 155568 RVA: 0x00AA8DA8 File Offset: 0x00AA6FA8
		[NullableContext(1)]
		public override bool Refresh(UiCameraModel model)
		{
			if (this.Transform == null || this.Transform == null)
			{
				return base.Refresh(model);
			}
			if (!base.RefreshConfigData(model) || base.CameraSettings == null)
			{
				return false;
			}
			base.RefreshCommonCameraData(base.CameraSettings);
			ACineCameraActor acineCameraActor = base.FindReplaceCameraActor();
			if (acineCameraActor != null && acineCameraActor.IsValid() && !base.RefreshReplaceCameraData(acineCameraActor))
			{
				return false;
			}
			base.Location = this.Transform.Value.GetLocation();
			base.Rotation = this.Transform.Value.GetRotation().Rotator();
			return true;
		}

		// Token: 0x04014E1E RID: 85534
		private FTransformDouble? Transform;
	}
}
