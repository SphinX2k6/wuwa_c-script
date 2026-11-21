using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200392F RID: 14639
	public class PlotMoveForwardComponent : PlotInteractComponentBase
	{
		// Token: 0x06025CDB RID: 154843 RVA: 0x00A9F854 File Offset: 0x00A9DA54
		public PlotMoveForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CDC RID: 154844 RVA: 0x00A9F85D File Offset: 0x00A9DA5D
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerPlotForward, value * 0.7f);
		}

		// Token: 0x06025CDD RID: 154845 RVA: 0x00A9F876 File Offset: 0x00A9DA76
		protected override bool CheckAxisCanInput()
		{
			return !InputModel.Instance.IsAxisBlock(EInputAxis.LookUp);
		}
	}
}
