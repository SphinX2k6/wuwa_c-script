using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049DD RID: 18909
	public class SliderInsideComponent : SliderComponent
	{
		// Token: 0x0603121E RID: 201246 RVA: 0x00B655DC File Offset: 0x00B637DC
		public SliderInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603121F RID: 201247 RVA: 0x00B655E5 File Offset: 0x00B637E5
		protected override void SetValue(float value)
		{
			UiNavigationNewController.Instance.SliderInsideComponentSetValue(base.GetBindButtonTag(), value);
		}

		// Token: 0x06031220 RID: 201248 RVA: 0x00B655F8 File Offset: 0x00B637F8
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

		// Token: 0x0401A4D5 RID: 107733
		protected const float INTERVAL = 0.05f;

		// Token: 0x0401A4D6 RID: 107734
		protected const float SLIDER_DEAD_AREA = 0.4f;

		// Token: 0x0401A4D7 RID: 107735
		protected const float DEAD_AREA = 0.073f;

		// Token: 0x0401A4D8 RID: 107736
		protected const float SETTING_INTERVAL = 0.01f;
	}
}
