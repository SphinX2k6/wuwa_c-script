using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D4 RID: 14548
	public class DraggableNextInsideComponent : DraggableInsideComponent
	{
		// Token: 0x06025B3F RID: 154431 RVA: 0x00A9BEA2 File Offset: 0x00A9A0A2
		public DraggableNextInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B40 RID: 154432 RVA: 0x00A9BEAB File Offset: 0x00A9A0AB
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableInsideComponentNavigate(base.GetBindButtonTag(), true);
		}
	}
}
