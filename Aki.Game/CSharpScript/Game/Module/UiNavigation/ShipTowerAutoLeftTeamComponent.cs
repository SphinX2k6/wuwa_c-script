using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200394A RID: 14666
	public class ShipTowerAutoLeftTeamComponent : HotKeyComponent
	{
		// Token: 0x06025D2D RID: 154925 RVA: 0x00AA0100 File Offset: 0x00A9E300
		public ShipTowerAutoLeftTeamComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D2E RID: 154926 RVA: 0x00AA0110 File Offset: 0x00A9E310
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButtonInside(config.BindButtonTag);
			this.AddTickHandle();
		}

		// Token: 0x06025D2F RID: 154927 RVA: 0x00AA0129 File Offset: 0x00A9E329
		protected override void OnUnRegisterMe()
		{
			this.RemoveTickHandle();
		}

		// Token: 0x06025D30 RID: 154928 RVA: 0x00AA0131 File Offset: 0x00A9E331
		private void AddTickHandle()
		{
			if (this.TickHandle == -1)
			{
				this.TickHandle = TickSystem.Instance.Add(new Action<float>(this.OnTick), "NavigationDraggableComponent", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			}
		}

		// Token: 0x06025D31 RID: 154929 RVA: 0x00AA0166 File Offset: 0x00A9E366
		private void RemoveTickHandle()
		{
			if (this.TickHandle != -1)
			{
				TickSystem.Instance.Remove(this.TickHandle);
				this.TickHandle = -1;
			}
		}

		// Token: 0x06025D32 RID: 154930 RVA: 0x00AA018C File Offset: 0x00A9E38C
		private void OnTick(float deltaTime)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener == null)
			{
				return;
			}
			NavigationGroup navigationGroup = currentNavigationFocusListener.GetNavigationGroup();
			string nextGroupName = navigationGroup.NextGroupName;
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			NavigationGroup navigationGroup2 = (currentViewHandle != null) ? currentViewHandle.GetActiveNavigationGroupByNameCheckAll(nextGroupName) : null;
			List<TsUiNavigationBehaviorListener> list = (navigationGroup2 != null) ? navigationGroup2.ActiveListenerList : null;
			if (list != null && list.Count > 0 && list[0].PanelConfig != null)
			{
				UiNavigationNewController.Instance.JumpNavigationGroupByName(navigationGroup.GroupName, nextGroupName);
				this.RemoveTickHandle();
			}
		}

		// Token: 0x06025D33 RID: 154931 RVA: 0x00AA020C File Offset: 0x00A9E40C
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
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = focusListener.GetChildListenerByTag(bindButtonTag);
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsListenerActive(), false);
		}

		// Token: 0x04014D3C RID: 85308
		private int TickHandle = -1;
	}
}
