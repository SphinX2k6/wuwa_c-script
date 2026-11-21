using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003919 RID: 14617
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NavigationGroupPrevComponentBase : HotKeyComponent
	{
		// Token: 0x06025C85 RID: 154757 RVA: 0x00A9EBD3 File Offset: 0x00A9CDD3
		protected NavigationGroupPrevComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C86 RID: 154758 RVA: 0x00A9EBDC File Offset: 0x00A9CDDC
		private void JumpPrevNavigation(ENavigationDirectionType direction)
		{
			if (direction == this.GetDirection())
			{
				UiNavigationNewController.Instance.JumpNavigationGroup(ELGUINavigationDirection.Prev);
			}
		}

		// Token: 0x06025C87 RID: 154759
		protected abstract ENavigationDirectionType GetDirection();

		// Token: 0x06025C88 RID: 154760 RVA: 0x00A9EBF3 File Offset: 0x00A9CDF3
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.JumpNavigationGroup(ELGUINavigationDirection.Prev);
		}

		// Token: 0x06025C89 RID: 154761 RVA: 0x00A9EC01 File Offset: 0x00A9CE01
		protected override void OnStartInputAxis(string axisName)
		{
			UiNavigationJoystickInput.RegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpPrevNavigation));
		}

		// Token: 0x06025C8A RID: 154762 RVA: 0x00A9EC14 File Offset: 0x00A9CE14
		protected override void OnFinishInputAxis(string axisName)
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpPrevNavigation));
		}

		// Token: 0x06025C8B RID: 154763 RVA: 0x00A9EC27 File Offset: 0x00A9CE27
		protected override void OnClear()
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpPrevNavigation));
		}

		// Token: 0x06025C8C RID: 154764 RVA: 0x00A9EC3C File Offset: 0x00A9CE3C
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup navigationGroup = focusListener.GetNavigationGroup();
			if (string.IsNullOrEmpty(navigationGroup.PrevGroupName))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			NavigationGroup activeNavigationGroupByNameCheckAll = viewHandle.GetActiveNavigationGroupByNameCheckAll(navigationGroup.PrevGroupName);
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
