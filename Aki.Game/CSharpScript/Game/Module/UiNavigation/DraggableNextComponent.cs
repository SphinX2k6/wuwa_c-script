using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004959 RID: 18777
	public class DraggableNextComponent : DraggableComponent
	{
		// Token: 0x06031009 RID: 200713 RVA: 0x00B60F2C File Offset: 0x00B5F12C
		public DraggableNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603100A RID: 200714 RVA: 0x00B60F35 File Offset: 0x00B5F135
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableComponentNavigate(base.GetBindButtonTag(), true);
		}
	}
}
