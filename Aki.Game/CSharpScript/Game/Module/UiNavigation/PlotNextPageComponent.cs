using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003932 RID: 14642
	public class PlotNextPageComponent : HotKeyComponent
	{
		// Token: 0x06025CE4 RID: 154852 RVA: 0x00A9F8F6 File Offset: 0x00A9DAF6
		public PlotNextPageComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CE5 RID: 154853 RVA: 0x00A9F8FF File Offset: 0x00A9DAFF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.NavigationRefreshPlotNextPage, new Action<bool>(this.NavigationRefreshPlotNextPage));
		}

		// Token: 0x06025CE6 RID: 154854 RVA: 0x00A9F91D File Offset: 0x00A9DB1D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.NavigationRefreshPlotNextPage, new Action<bool>(this.NavigationRefreshPlotNextPage));
		}

		// Token: 0x06025CE7 RID: 154855 RVA: 0x00A9F93B File Offset: 0x00A9DB3B
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06025CE8 RID: 154856 RVA: 0x00A9F950 File Offset: 0x00A9DB50
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			this.Listener = activeListenerByTag;
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag = listener != null && listener.IsListenerActive();
			bool canClick = PlotModel.Instance.CanClick;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, flag && canClick, false);
			this.RefreshNewStyleAlpha();
		}

		// Token: 0x06025CE9 RID: 154857 RVA: 0x00A9F9AC File Offset: 0x00A9DBAC
		private void NavigationRefreshPlotNextPage(bool isActive)
		{
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag = listener != null && listener.IsListenerActive();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, flag && isActive, false);
			this.RefreshNewStyleAlpha();
		}

		// Token: 0x06025CEA RID: 154858 RVA: 0x00A9F9E0 File Offset: 0x00A9DBE0
		private void RefreshNewStyleAlpha()
		{
			bool flag = PlotModel.Instance.IsNewSubtitleStyleActive();
			HotKeyViewDefine.EHotKeyApplicableType applicableType = (HotKeyViewDefine.EHotKeyApplicableType)base.GetHotKeyConfig().Value.ApplicableType;
			bool flag2 = false;
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyKeyboardTransparent || applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyKeyboardTransparentExceptLongPress)
			{
				flag2 = Info.Instance.IsInKeyBoard();
			}
			else if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyHandleTransparent)
			{
				flag2 = Info.Instance.IsInGamepad();
			}
			else if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.KeyboardAndHandleTransparent)
			{
				flag2 = (Info.Instance.IsInKeyBoard() || Info.Instance.IsInGamepad());
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha((float)((flag || flag2) ? 0 : 1));
		}

		// Token: 0x04014D2E RID: 85294
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;
	}
}
