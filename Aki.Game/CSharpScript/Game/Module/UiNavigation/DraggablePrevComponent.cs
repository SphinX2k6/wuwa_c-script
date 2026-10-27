using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004958 RID: 18776
	public class DraggablePrevComponent : DraggableComponent
	{
		// Token: 0x06031007 RID: 200711 RVA: 0x00B60F10 File Offset: 0x00B5F110
		public DraggablePrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031008 RID: 200712 RVA: 0x00B60F19 File Offset: 0x00B5F119
		protected override void TriggerEvent()
		{
			UiNavigationNewController.Instance.DraggableComponentNavigate(base.GetBindButtonTag(), false);
		}
	}
}
