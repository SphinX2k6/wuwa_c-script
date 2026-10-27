using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B5 RID: 18869
	public class PlotMoveForwardComponent : PlotInteractComponentBase
	{
		// Token: 0x060311A5 RID: 201125 RVA: 0x00B64904 File Offset: 0x00B62B04
		public PlotMoveForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311A6 RID: 201126 RVA: 0x00B6490D File Offset: 0x00B62B0D
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerPlotForward, value * 0.7f);
		}

		// Token: 0x060311A7 RID: 201127 RVA: 0x00B64926 File Offset: 0x00B62B26
		protected override bool CheckAxisCanInput()
		{
			return !InputModel.Instance.IsAxisBlock(EInputAxis.LookUp);
		}
	}
}
