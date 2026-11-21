using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D3 RID: 14547
	public class DraggablePrevInsideComponent : DraggableInsideComponent
	{
		// Token: 0x06025B3D RID: 154429 RVA: 0x00A9BE86 File Offset: 0x00A9A086
		public DraggablePrevInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B3E RID: 154430 RVA: 0x00A9BE8F File Offset: 0x00A9A08F
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableInsideComponentNavigate(base.GetBindButtonTag(), false);
		}
	}
}
