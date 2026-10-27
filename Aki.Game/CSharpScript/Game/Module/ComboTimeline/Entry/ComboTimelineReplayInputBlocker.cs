using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02005B9C RID: 23452
	public class ComboTimelineReplayInputBlocker
	{
		// Token: 0x0603B51B RID: 242971 RVA: 0x00E22CFC File Offset: 0x00E20EFC
		public void Enable(int unitId)
		{
			if (unitId != 0)
			{
				InputLayer inputLayer = InputController.Instance.CreateInputLayer(EInputLayer.Swallow);
				if (inputLayer != null)
				{
					InputController.Instance.AddInputLayer(unitId, inputLayer);
					this.Layer = inputLayer;
				}
			}
			InputController.Instance.SetMoveControlEnabled(false, false, false, false);
		}

		// Token: 0x0603B51C RID: 242972 RVA: 0x00E22D3D File Offset: 0x00E20F3D
		public void Disable()
		{
			if (this.Layer != null)
			{
				InputController.Instance.RemoveInputLayer(this.Layer);
				this.Layer.Clear();
				this.Layer = null;
			}
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
		}

		// Token: 0x0401EEB0 RID: 126640
		[Nullable(2)]
		private InputLayer Layer;
	}
}
