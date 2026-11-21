using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003996 RID: 14742
	public class UiCameraEmptyHandleData : UiCameraHandleData
	{
		// Token: 0x06025F60 RID: 155488 RVA: 0x00AA8094 File Offset: 0x00AA6294
		public UiCameraEmptyHandleData()
		{
			base.SkipApply = true;
		}

		// Token: 0x06025F61 RID: 155489 RVA: 0x00AA80A3 File Offset: 0x00AA62A3
		[NullableContext(1)]
		public override bool Refresh(UiCameraModel model)
		{
			base.ResetCameraData();
			base.CameraSettings = UiCameraConfig.Instance.GetUiCameraAnimationConfig(base.GetHandleName());
			base.TargetType = EUiCameraAnimationTargetType.None;
			return base.CameraSettings != null;
		}
	}
}
