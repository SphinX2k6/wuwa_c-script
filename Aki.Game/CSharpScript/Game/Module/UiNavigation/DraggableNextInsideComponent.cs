using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200495C RID: 18780
	public class DraggableNextInsideComponent : DraggableInsideComponent
	{
		// Token: 0x0603100F RID: 200719 RVA: 0x00B60FC2 File Offset: 0x00B5F1C2
		public DraggableNextInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031010 RID: 200720 RVA: 0x00B60FCB File Offset: 0x00B5F1CB
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableInsideComponentNavigate(base.GetBindButtonTag(), true);
		}
	}
}
