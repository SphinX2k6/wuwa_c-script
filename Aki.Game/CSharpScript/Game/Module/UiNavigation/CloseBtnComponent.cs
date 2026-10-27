using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004952 RID: 18770
	public class CloseBtnComponent : HotKeyComponent
	{
		// Token: 0x06030FEC RID: 200684 RVA: 0x00B60B76 File Offset: 0x00B5ED76
		public CloseBtnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FED RID: 200685 RVA: 0x00B60B7F File Offset: 0x00B5ED7F
		protected override void OnPress(HotKeyMap config)
		{
			this.HomeBtnListenerActive = this.CheckHomeBtnListenerActive();
			if (this.HomeBtnListenerActive)
			{
				return;
			}
			UiNavigationNewController.Instance.HotKeyCloseView();
		}

		// Token: 0x06030FEE RID: 200686 RVA: 0x00B60BA0 File Offset: 0x00B5EDA0
		protected override void OnRelease(HotKeyMap config)
		{
			if (!this.HomeBtnListenerActive)
			{
				return;
			}
			UiNavigationNewController.Instance.HotKeyCloseView();
		}

		// Token: 0x06030FEF RID: 200687 RVA: 0x00B60BB8 File Offset: 0x00B5EDB8
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag != null && activeListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x06030FF0 RID: 200688 RVA: 0x00B60BF1 File Offset: 0x00B5EDF1
		private bool CheckHomeBtnListenerActive()
		{
			TsUiNavigationBehaviorListener activeListenerByTag = UiNavigationViewManager.Instance.GetCurrentViewHandle().GetActiveListenerByTag("tag_home");
			return activeListenerByTag != null && activeListenerByTag.IsListenerActive();
		}

		// Token: 0x0401A481 RID: 107649
		private bool HomeBtnListenerActive;
	}
}
