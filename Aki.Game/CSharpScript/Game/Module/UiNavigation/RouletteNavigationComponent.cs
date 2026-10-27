using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C0 RID: 18880
	public class RouletteNavigationComponent : HotKeyComponent
	{
		// Token: 0x060311C8 RID: 201160 RVA: 0x00B64CFD File Offset: 0x00B62EFD
		public RouletteNavigationComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311C9 RID: 201161 RVA: 0x00B64D06 File Offset: 0x00B62F06
		protected override void OnPress(HotKeyMap config)
		{
			this.Listener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			this.IsPressSuccess = UiNavigationNewController.Instance.Interact(true, config.Id);
		}

		// Token: 0x060311CA RID: 201162 RVA: 0x00B64D30 File Offset: 0x00B62F30
		protected override void OnRelease(HotKeyMap config)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			bool flag = UiNavigationNewController.Instance.Interact(false, config.Id);
			if (this.Listener == currentNavigationFocusListener && this.IsPressSuccess && flag)
			{
				EventSystem.Instance.Emit(EEventName.RouletteNavigationComponentEmit);
			}
		}

		// Token: 0x060311CB RID: 201163 RVA: 0x00B64D84 File Offset: 0x00B62F84
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

		// Token: 0x0401A4C0 RID: 107712
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;

		// Token: 0x0401A4C1 RID: 107713
		private bool IsPressSuccess;
	}
}
