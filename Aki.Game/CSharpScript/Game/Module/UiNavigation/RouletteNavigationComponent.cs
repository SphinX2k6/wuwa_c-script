using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200393A RID: 14650
	public class RouletteNavigationComponent : HotKeyComponent
	{
		// Token: 0x06025CFE RID: 154878 RVA: 0x00A9FC4D File Offset: 0x00A9DE4D
		public RouletteNavigationComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CFF RID: 154879 RVA: 0x00A9FC56 File Offset: 0x00A9DE56
		protected override void OnPress(HotKeyMap config)
		{
			this.Listener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			this.IsPressSuccess = UiNavigationNewController.Instance.Interact(true, config.Id);
		}

		// Token: 0x06025D00 RID: 154880 RVA: 0x00A9FC80 File Offset: 0x00A9DE80
		protected override void OnRelease(HotKeyMap config)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			bool flag = UiNavigationNewController.Instance.Interact(false, config.Id);
			if (this.Listener == currentNavigationFocusListener && this.IsPressSuccess && flag)
			{
				EventSystem.Instance.Emit(EEventName.RouletteNavigationComponentEmit);
			}
		}

		// Token: 0x06025D01 RID: 154881 RVA: 0x00A9FCD4 File Offset: 0x00A9DED4
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener != null && focusListener.GroupName == "Group1")
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
		}

		// Token: 0x04014D32 RID: 85298
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;

		// Token: 0x04014D33 RID: 85299
		private bool IsPressSuccess;
	}
}
