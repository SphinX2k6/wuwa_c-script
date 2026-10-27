using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200491D RID: 18717
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationToggle : NavigationSelectableBase
	{
		// Token: 0x06030E78 RID: 200312 RVA: 0x00B5AE1F File Offset: 0x00B5901F
		public NavigationToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E79 RID: 200313 RVA: 0x00B5AE2A File Offset: 0x00B5902A
		protected override void OnInit()
		{
			this.RegisterHotKeyTips();
			this.RegisterToggleClick();
		}

		// Token: 0x06030E7A RID: 200314 RVA: 0x00B5AE38 File Offset: 0x00B59038
		protected override void OnClear()
		{
			this.UnRegisterHotKeyTips();
			this.UnRegisterToggleClick();
		}

		// Token: 0x06030E7B RID: 200315 RVA: 0x00B5AE48 File Offset: 0x00B59048
		private void RegisterHotKeyTips()
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (this.Listener.HotKeyTipsTextIdMap.Num() > 0)
			{
				uuiextendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnStateChangeEvent));
			}
		}

		// Token: 0x06030E7C RID: 200316 RVA: 0x00B5AE8C File Offset: 0x00B5908C
		private void UnRegisterHotKeyTips()
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (this.Listener.HotKeyTipsTextIdMap.Num() > 0)
			{
				uuiextendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnStateChangeEvent));
			}
		}

		// Token: 0x06030E7D RID: 200317 RVA: 0x00B5AECF File Offset: 0x00B590CF
		private void OnStateChangeEvent(EToggleState state)
		{
			UiNavigationViewManager.Instance.RefreshCurrentHotKeyTextId();
		}

		// Token: 0x06030E7E RID: 200318 RVA: 0x00B5AEDB File Offset: 0x00B590DB
		private void RegisterToggleClick()
		{
			if (this.NeedAddToggleClick())
			{
				(this.Selectable as UUIExtendToggle).OnStateChange.Add(new Action<EToggleState>(this.ToggleClick));
			}
		}

		// Token: 0x06030E7F RID: 200319 RVA: 0x00B5AF06 File Offset: 0x00B59106
		private void UnRegisterToggleClick()
		{
			if (this.NeedAddToggleClick())
			{
				(this.Selectable as UUIExtendToggle).OnStateChange.Remove(new Action<EToggleState>(this.ToggleClick));
			}
		}

		// Token: 0x06030E80 RID: 200320 RVA: 0x00B5AF31 File Offset: 0x00B59131
		private void ToggleClick(EToggleState state)
		{
			this.OnToggleClick(state);
		}

		// Token: 0x06030E81 RID: 200321 RVA: 0x00B5AF3A File Offset: 0x00B5913A
		protected virtual void OnToggleClick(EToggleState state)
		{
		}

		// Token: 0x06030E82 RID: 200322 RVA: 0x00B5AF3C File Offset: 0x00B5913C
		protected void ScrollToSelectableComponent(UUIExtendToggle selectable)
		{
			if (this.Listener.HasDynamicScrollView() || this.Listener.HasMultiTemplateScrollView())
			{
				return;
			}
			UiNavigationScrollProxy scrollProxy = this.Listener.ScrollProxy;
			if (((scrollProxy != null) ? scrollProxy.ScrollView : null) != null)
			{
				this.Listener.ScrollProxy.ScrollView.ScrollToSelectableComponent(selectable);
			}
		}

		// Token: 0x06030E83 RID: 200323 RVA: 0x00B5AF93 File Offset: 0x00B59193
		protected virtual bool NeedAddToggleClick()
		{
			return base.GetType() != ENavigationSelectableDefine.Toggle;
		}

		// Token: 0x06030E84 RID: 200324 RVA: 0x00B5AFA4 File Offset: 0x00B591A4
		protected override bool OnCanFocusInScrollOrLayout()
		{
			if (!this.IsInteractive)
			{
				return false;
			}
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			return (uuiextendToggle.ToggleState == EToggleState.ETT_Checked || !uuiextendToggle.bCheckToggleSelected) && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06030E85 RID: 200325 RVA: 0x00B5AFF8 File Offset: 0x00B591F8
		protected override string OnGetTipsTextId()
		{
			if ((this.Selectable as UUIExtendToggle).ToggleState == EToggleState.ETT_Checked)
			{
				return this.Listener.HotKeyTipsTextIdMap.GetValueOrDefault(EHotKeyNameStateType.ToggleSelected, string.Empty);
			}
			return this.Listener.HotKeyTipsTextIdMap.GetValueOrDefault(EHotKeyNameStateType.Normal, string.Empty);
		}

		// Token: 0x06030E86 RID: 200326 RVA: 0x00B5B045 File Offset: 0x00B59245
		protected override bool OnHandlePointerEnter(ULGUIPointerEventData eventData)
		{
			return !(this.Selectable as UUIExtendToggle).bToggleOnSelect;
		}

		// Token: 0x06030E87 RID: 200327 RVA: 0x00B5B05C File Offset: 0x00B5925C
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			if (!this.OnHandlePointerSelectInheritance(eventData))
			{
				return false;
			}
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (uuiextendToggle.ToggleState == EToggleState.ETT_UnChecked)
			{
				if (eventData != null && eventData.inputType == ELGUIPointerInputType.Navigation && uuiextendToggle.bToggleOnSelect)
				{
					uuiextendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
				}
				this.ScrollToSelectableComponent(uuiextendToggle);
			}
			else if (uuiextendToggle.ToggleState == EToggleState.ETT_UnDetermined)
			{
				this.ScrollToSelectableComponent(uuiextendToggle);
				if (eventData != null && eventData.inputType == ELGUIPointerInputType.Navigation && uuiextendToggle.bToggleOnSelect)
				{
					UiNavigationNewController.Instance.SimulateClickItem(uuiextendToggle.RootUIComp, null);
				}
			}
			else
			{
				this.ScrollToSelectableComponent(uuiextendToggle);
			}
			return base.IsAllowNavigationByGroup();
		}

		// Token: 0x06030E88 RID: 200328 RVA: 0x00B5B107 File Offset: 0x00B59307
		protected virtual bool OnHandlePointerSelectInheritance(ULGUIPointerEventData eventData)
		{
			return true;
		}
	}
}
