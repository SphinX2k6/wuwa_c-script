using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B7 RID: 18871
	public class PlotZoomComponent : PlotInteractComponentBase
	{
		// Token: 0x060311AB RID: 201131 RVA: 0x00B64970 File Offset: 0x00B62B70
		public PlotZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311AC RID: 201132 RVA: 0x00B64979 File Offset: 0x00B62B79
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerPlotZoom, value * 30f);
		}

		// Token: 0x060311AD RID: 201133 RVA: 0x00B64992 File Offset: 0x00B62B92
		protected override bool CheckAxisCanInput()
		{
			return !InputModel.Instance.IsAxisBlock(EInputAxis.Zoom);
		}
	}
}
