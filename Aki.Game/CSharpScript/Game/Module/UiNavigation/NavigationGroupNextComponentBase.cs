using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003914 RID: 14612
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NavigationGroupNextComponentBase : HotKeyComponent
	{
		// Token: 0x06025C74 RID: 154740 RVA: 0x00A9EA72 File Offset: 0x00A9CC72
		protected NavigationGroupNextComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C75 RID: 154741 RVA: 0x00A9EA7B File Offset: 0x00A9CC7B
		private void JumpNextNavigation(ENavigationDirectionType direction)
		{
			if (direction == this.GetDirection())
			{
				this.JumpToNextGroupListener();
			}
		}

		// Token: 0x06025C76 RID: 154742 RVA: 0x00A9EA8C File Offset: 0x00A9CC8C
		protected virtual void JumpToNextGroupListener()
		{
			HotKeyMap? hotKeyMap;
			string text = (base.GetHotKeyConfig() != null) ? hotKeyMap.GetValueOrDefault().BindButtonTag : null;
			if (text != null)
			{
				UiNavigationNewController.Instance.JumpNavigationGroupByTag(text);
			}
		}

		// Token: 0x06025C77 RID: 154743
		protected abstract ENavigationDirectionType GetDirection();

		// Token: 0x06025C78 RID: 154744 RVA: 0x00A9EACB File Offset: 0x00A9CCCB
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.JumpNavigationGroupByTag(config.BindButtonTag);
		}

		// Token: 0x06025C79 RID: 154745 RVA: 0x00A9EADF File Offset: 0x00A9CCDF
		protected override void OnStartInputAxis(string axisName)
		{
			UiNavigationJoystickInput.RegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpNextNavigation));
		}

		// Token: 0x06025C7A RID: 154746 RVA: 0x00A9EAF2 File Offset: 0x00A9CCF2
		protected override void OnFinishInputAxis(string axisName)
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpNextNavigation));
		}

		// Token: 0x06025C7B RID: 154747 RVA: 0x00A9EB05 File Offset: 0x00A9CD05
		protected override void OnClear()
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpNextNavigation));
		}

		// Token: 0x06025C7C RID: 154748 RVA: 0x00A9EB18 File Offset: 0x00A9CD18
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup navigationGroup = focusListener.GetNavigationGroup();
			string bindButtonTag = base.GetBindButtonTag();
			string text;
			if (!string.IsNullOrEmpty(bindButtonTag))
			{
				text = navigationGroup.GroupNameMap.GetValueOrDefault(bindButtonTag);
			}
			else
			{
				text = navigationGroup.NextGroupName;
			}
			if (string.IsNullOrEmpty(text))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup activeNavigationGroupByNameCheckAll = viewHandle.GetActiveNavigationGroupByNameCheckAll(text);
			if (activeNavigationGroupByNameCheckAll == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			bool isActive = UiNavigationLogic.HasActiveListenerInGroup(activeNavigationGroupByNameCheckAll);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}
	}
}
