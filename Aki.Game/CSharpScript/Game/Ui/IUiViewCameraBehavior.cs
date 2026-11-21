using System;
using CSharpScript.Game.Module.UiCamera;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200354B RID: 13643
	public interface IUiViewCameraBehavior
	{
		// Token: 0x06022B15 RID: 142101
		void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend);

		// Token: 0x06022B16 RID: 142102
		void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend);
	}
}
