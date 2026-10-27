using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200499F RID: 18847
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NavigationGroupPrevComponentBase : HotKeyComponent
	{
		// Token: 0x0603114F RID: 201039 RVA: 0x00B63C83 File Offset: 0x00B61E83
		protected NavigationGroupPrevComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031150 RID: 201040 RVA: 0x00B63C8C File Offset: 0x00B61E8C
		private void JumpPrevNavigation(ENavigationDirectionType direction)
		{
			if (direction == this.GetDirection())
			{
				UiNavigationNewController.Instance.JumpNavigationGroup(ELGUINavigationDirection.Prev);
			}
		}

		// Token: 0x06031151 RID: 201041
		protected abstract ENavigationDirectionType GetDirection();

		// Token: 0x06031152 RID: 201042 RVA: 0x00B63CA3 File Offset: 0x00B61EA3
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.JumpNavigationGroup(ELGUINavigationDirection.Prev);
		}

		// Token: 0x06031153 RID: 201043 RVA: 0x00B63CB1 File Offset: 0x00B61EB1
		protected override void OnStartInputAxis(string axisName)
		{
			UiNavigationJoystickInput.RegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpPrevNavigation));
		}

		// Token: 0x06031154 RID: 201044 RVA: 0x00B63CC4 File Offset: 0x00B61EC4
		protected override void OnFinishInputAxis(string axisName)
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpPrevNavigation));
		}

		// Token: 0x06031155 RID: 201045 RVA: 0x00B63CD7 File Offset: 0x00B61ED7
		protected override void OnClear()
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpPrevNavigation));
		}

		// Token: 0x06031156 RID: 201046 RVA: 0x00B63CEC File Offset: 0x00B61EEC
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
