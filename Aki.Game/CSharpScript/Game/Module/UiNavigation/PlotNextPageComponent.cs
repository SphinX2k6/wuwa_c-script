using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B8 RID: 18872
	public class PlotNextPageComponent : HotKeyComponent
	{
		// Token: 0x060311AE RID: 201134 RVA: 0x00B649A6 File Offset: 0x00B62BA6
		public PlotNextPageComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311AF RID: 201135 RVA: 0x00B649AF File Offset: 0x00B62BAF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.NavigationRefreshPlotNextPage, new Action<bool>(this.NavigationRefreshPlotNextPage));
		}

		// Token: 0x060311B0 RID: 201136 RVA: 0x00B649CD File Offset: 0x00B62BCD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.NavigationRefreshPlotNextPage, new Action<bool>(this.NavigationRefreshPlotNextPage));
		}

		// Token: 0x060311B1 RID: 201137 RVA: 0x00B649EB File Offset: 0x00B62BEB
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButton(config.BindButtonTag);
		}

		// Token: 0x060311B2 RID: 201138 RVA: 0x00B64A00 File Offset: 0x00B62C00
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

		// Token: 0x060311B3 RID: 201139 RVA: 0x00B64A5C File Offset: 0x00B62C5C
		private void NavigationRefreshPlotNextPage(bool isActive)
		{
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag = listener != null && listener.IsListenerActive();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, flag && isActive, false);
			this.RefreshNewStyleAlpha();
		}

		// Token: 0x060311B4 RID: 201140 RVA: 0x00B64A90 File Offset: 0x00B62C90
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

		// Token: 0x0401A4BC RID: 107708
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;
	}
}
