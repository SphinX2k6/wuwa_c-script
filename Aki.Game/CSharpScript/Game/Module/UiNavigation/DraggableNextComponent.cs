using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D1 RID: 14545
	public class DraggableNextComponent : DraggableComponent
	{
		// Token: 0x06025B39 RID: 154425 RVA: 0x00A9BE0C File Offset: 0x00A9A00C
		public DraggableNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B3A RID: 154426 RVA: 0x00A9BE15 File Offset: 0x00A9A015
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableComponentNavigate(base.GetBindButtonTag(), true);
		}
	}
}
