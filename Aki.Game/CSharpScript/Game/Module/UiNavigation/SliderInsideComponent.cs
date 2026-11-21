using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003957 RID: 14679
	public class SliderInsideComponent : SliderComponent
	{
		// Token: 0x06025D54 RID: 154964 RVA: 0x00AA052C File Offset: 0x00A9E72C
		public SliderInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D55 RID: 154965 RVA: 0x00AA0535 File Offset: 0x00A9E735
		protected override void SetValue(float value)
		{
			UiNavigationNewController.Instance.SliderInsideComponentSetValue(base.GetBindButtonTag(), value);
		}

		// Token: 0x06025D56 RID: 154966 RVA: 0x00AA0548 File Offset: 0x00A9E748
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
			if (!base.IsLinkListener(focusListener.GetOwner()))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (focusListenerInsideListenerByTag == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListenerInsideListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x04014D47 RID: 85319
		protected const float INTERVAL = 0.05f;

		// Token: 0x04014D48 RID: 85320
		protected const float SLIDER_DEAD_AREA = 0.4f;

		// Token: 0x04014D49 RID: 85321
		protected const float DEAD_AREA = 0.073f;

		// Token: 0x04014D4A RID: 85322
		protected const float SETTING_INTERVAL = 0.01f;
	}
}
