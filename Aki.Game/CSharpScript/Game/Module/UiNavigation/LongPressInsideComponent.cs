using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038FC RID: 14588
	public class LongPressInsideComponent : HotKeyComponent
	{
		// Token: 0x06025C17 RID: 154647 RVA: 0x00A9DCF2 File Offset: 0x00A9BEF2
		public LongPressInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C18 RID: 154648 RVA: 0x00A9DCFB File Offset: 0x00A9BEFB
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointUpInside(config.BindButtonTag, config.Id, this.PressListener);
		}

		// Token: 0x06025C19 RID: 154649 RVA: 0x00A9DD1B File Offset: 0x00A9BF1B
		protected override void OnPress(HotKeyMap config)
		{
			this.PressListener = UiNavigationNewController.Instance.SimulationPointDownInside(config.BindButtonTag, config.Id);
		}

		// Token: 0x06025C1A RID: 154650 RVA: 0x00A9DD3C File Offset: 0x00A9BF3C
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
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
			TsUiNavigationBehaviorListener childListenerByTag = focusListener.GetChildListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, childListenerByTag != null && childListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x04014D1A RID: 85274
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener PressListener;
	}
}
