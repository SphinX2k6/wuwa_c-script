using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D0 RID: 18896
	public class ShipTowerAutoLeftTeamComponent : HotKeyComponent
	{
		// Token: 0x060311F7 RID: 201207 RVA: 0x00B651B0 File Offset: 0x00B633B0
		public ShipTowerAutoLeftTeamComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311F8 RID: 201208 RVA: 0x00B651C0 File Offset: 0x00B633C0
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButtonInside(config.BindButtonTag);
			this.AddTickHandle();
		}

		// Token: 0x060311F9 RID: 201209 RVA: 0x00B651D9 File Offset: 0x00B633D9
		protected override void OnUnRegisterMe()
		{
			this.RemoveTickHandle();
		}

		// Token: 0x060311FA RID: 201210 RVA: 0x00B651E1 File Offset: 0x00B633E1
		private void AddTickHandle()
		{
			if (this.TickHandle == -1)
			{
				this.TickHandle = TickSystem.Instance.Add(new Action<float>(this.OnTick), "NavigationDraggableComponent", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			}
		}

		// Token: 0x060311FB RID: 201211 RVA: 0x00B65216 File Offset: 0x00B63416
		private void RemoveTickHandle()
		{
			if (this.TickHandle != -1)
			{
				TickSystem.Instance.Remove(this.TickHandle);
				this.TickHandle = -1;
			}
		}

		// Token: 0x060311FC RID: 201212 RVA: 0x00B6523C File Offset: 0x00B6343C
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
			bool flag;
			if (navigationGroup2 == null)
			{
				flag = (null != null);
			}
			else
			{
				List<TsUiNavigationBehaviorListener> activeListenerList = navigationGroup2.ActiveListenerList;
				if (activeListenerList == null)
				{
					flag = (null != null);
				}
				else
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = activeListenerList.ElementAtOrDefault(0);
					flag = (((tsUiNavigationBehaviorListener != null) ? tsUiNavigationBehaviorListener.PanelConfig : null) != null);
				}
			}
			if (flag)
			{
				UiNavigationNewController.Instance.JumpNavigationGroupByName(navigationGroup.GroupName, nextGroupName);
				this.RemoveTickHandle();
			}
		}

		// Token: 0x060311FD RID: 201213 RVA: 0x00B652BC File Offset: 0x00B634BC
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

		// Token: 0x0401A4CA RID: 107722
		private int TickHandle = -1;
	}
}
