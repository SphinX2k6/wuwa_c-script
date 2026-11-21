using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003930 RID: 14640
	public class PlotMoveRightComponent : PlotInteractComponentBase
	{
		// Token: 0x06025CDE RID: 154846 RVA: 0x00A9F88A File Offset: 0x00A9DA8A
		public PlotMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CDF RID: 154847 RVA: 0x00A9F893 File Offset: 0x00A9DA93
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerPlotRight, value * 0.7f);
		}

		// Token: 0x06025CE0 RID: 154848 RVA: 0x00A9F8AC File Offset: 0x00A9DAAC
		protected override bool CheckAxisCanInput()
		{
			return !InputModel.Instance.IsAxisBlock(EInputAxis.Turn);
		}
	}
}
