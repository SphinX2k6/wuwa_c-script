using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200499A RID: 18842
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NavigationGroupNextComponentBase : HotKeyComponent
	{
		// Token: 0x0603113E RID: 201022 RVA: 0x00B63B22 File Offset: 0x00B61D22
		protected NavigationGroupNextComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603113F RID: 201023 RVA: 0x00B63B2B File Offset: 0x00B61D2B
		private void JumpNextNavigation(ENavigationDirectionType direction)
		{
			if (direction == this.GetDirection())
			{
				this.JumpToNextGroupListener();
			}
		}

		// Token: 0x06031140 RID: 201024 RVA: 0x00B63B3C File Offset: 0x00B61D3C
		protected virtual void JumpToNextGroupListener()
		{
			HotKeyMap? hotKeyMap;
			string text = (base.GetHotKeyConfig() != null) ? hotKeyMap.GetValueOrDefault().BindButtonTag : null;
			if (text != null)
			{
				UiNavigationNewController.Instance.JumpNavigationGroupByTag(text);
			}
		}

		// Token: 0x06031141 RID: 201025
		protected abstract ENavigationDirectionType GetDirection();

		// Token: 0x06031142 RID: 201026 RVA: 0x00B63B7B File Offset: 0x00B61D7B
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.JumpNavigationGroupByTag(config.BindButtonTag);
		}

		// Token: 0x06031143 RID: 201027 RVA: 0x00B63B8F File Offset: 0x00B61D8F
		protected override void OnStartInputAxis(string axisName)
		{
			UiNavigationJoystickInput.RegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpNextNavigation));
		}

		// Token: 0x06031144 RID: 201028 RVA: 0x00B63BA2 File Offset: 0x00B61DA2
		protected override void OnFinishInputAxis(string axisName)
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpNextNavigation));
		}

		// Token: 0x06031145 RID: 201029 RVA: 0x00B63BB5 File Offset: 0x00B61DB5
		protected override void OnClear()
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.JumpNextNavigation));
		}

		// Token: 0x06031146 RID: 201030 RVA: 0x00B63BC8 File Offset: 0x00B61DC8
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
