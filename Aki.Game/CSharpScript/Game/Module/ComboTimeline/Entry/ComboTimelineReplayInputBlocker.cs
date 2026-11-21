using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02004B7C RID: 19324
	public class ComboTimelineReplayInputBlocker
	{
		// Token: 0x06030468 RID: 197736 RVA: 0x00D7324C File Offset: 0x00D7144C
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

		// Token: 0x06030469 RID: 197737 RVA: 0x00D7328D File Offset: 0x00D7148D
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

		// Token: 0x04019961 RID: 104801
		[Nullable(2)]
		private InputLayer Layer;
	}
}
