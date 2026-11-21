using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003931 RID: 14641
	public class PlotZoomComponent : PlotInteractComponentBase
	{
		// Token: 0x06025CE1 RID: 154849 RVA: 0x00A9F8C0 File Offset: 0x00A9DAC0
		public PlotZoomComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CE2 RID: 154850 RVA: 0x00A9F8C9 File Offset: 0x00A9DAC9
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerPlotZoom, value * 30f);
		}

		// Token: 0x06025CE3 RID: 154851 RVA: 0x00A9F8E2 File Offset: 0x00A9DAE2
		protected override bool CheckAxisCanInput()
		{
			return !InputModel.Instance.IsAxisBlock(EInputAxis.Zoom);
		}
	}
}
