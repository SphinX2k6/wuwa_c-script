using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B6 RID: 18870
	public class PlotMoveRightComponent : PlotInteractComponentBase
	{
		// Token: 0x060311A8 RID: 201128 RVA: 0x00B6493A File Offset: 0x00B62B3A
		public PlotMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311A9 RID: 201129 RVA: 0x00B64943 File Offset: 0x00B62B43
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerPlotRight, value * 0.7f);
		}

		// Token: 0x060311AA RID: 201130 RVA: 0x00B6495C File Offset: 0x00B62B5C
		protected override bool CheckAxisCanInput()
		{
			return !InputModel.Instance.IsAxisBlock(EInputAxis.Turn);
		}
	}
}
