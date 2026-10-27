using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200495A RID: 18778
	public class DraggableInsideComponent : DraggableComponent
	{
		// Token: 0x0603100B RID: 200715 RVA: 0x00B60F48 File Offset: 0x00B5F148
		public DraggableInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603100C RID: 200716 RVA: 0x00B60F54 File Offset: 0x00B5F154
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListenerInsideListenerByTag != null && focusListenerInsideListenerByTag.IsListenerActive(), false);
		}
	}
}
