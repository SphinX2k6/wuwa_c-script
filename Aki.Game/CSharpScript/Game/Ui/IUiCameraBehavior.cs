using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004622 RID: 17954
	[NullableContext(1)]
	public interface IUiCameraBehavior
	{
		// Token: 0x0602E420 RID: 189472
		void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend);

		// Token: 0x0602E421 RID: 189473
		void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete);
	}
}
