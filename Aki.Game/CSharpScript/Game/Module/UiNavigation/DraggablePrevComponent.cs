using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D0 RID: 14544
	public class DraggablePrevComponent : DraggableComponent
	{
		// Token: 0x06025B37 RID: 154423 RVA: 0x00A9BDF0 File Offset: 0x00A99FF0
		public DraggablePrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B38 RID: 154424 RVA: 0x00A9BDF9 File Offset: 0x00A99FF9
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableComponentNavigate(base.GetBindButtonTag(), false);
		}
	}
}
