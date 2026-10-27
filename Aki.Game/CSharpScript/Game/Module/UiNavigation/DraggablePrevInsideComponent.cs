using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200495B RID: 18779
	public class DraggablePrevInsideComponent : DraggableInsideComponent
	{
		// Token: 0x0603100D RID: 200717 RVA: 0x00B60FA6 File Offset: 0x00B5F1A6
		public DraggablePrevInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603100E RID: 200718 RVA: 0x00B60FAF File Offset: 0x00B5F1AF
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableInsideComponentNavigate(base.GetBindButtonTag(), false);
		}
	}
}
