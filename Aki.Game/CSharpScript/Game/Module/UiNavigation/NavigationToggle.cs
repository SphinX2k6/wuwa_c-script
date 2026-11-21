using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003894 RID: 14484
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationToggle : NavigationSelectableBase
	{
		// Token: 0x060259A5 RID: 154021 RVA: 0x00A95C8F File Offset: 0x00A93E8F
		public NavigationToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259A6 RID: 154022 RVA: 0x00A95C9A File Offset: 0x00A93E9A
		protected override void OnInit()
		{
			this.RegisterHotKeyTips();
			this.RegisterToggleClick();
		}

		// Token: 0x060259A7 RID: 154023 RVA: 0x00A95CA8 File Offset: 0x00A93EA8
		protected override void OnClear()
		{
			this.UnRegisterHotKeyTips();
			this.UnRegisterToggleClick();
		}

		// Token: 0x060259A8 RID: 154024 RVA: 0x00A95CB8 File Offset: 0x00A93EB8
		private void RegisterHotKeyTips()
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (this.Listener.HotKeyTipsTextIdMap.Num() > 0)
			{
				uuiextendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnStateChangeEvent));
			}
		}

		// Token: 0x060259A9 RID: 154025 RVA: 0x00A95CFC File Offset: 0x00A93EFC
		private void UnRegisterHotKeyTips()
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (this.Listener.HotKeyTipsTextIdMap.Num() > 0)
			{
				uuiextendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnStateChangeEvent));
			}
		}

		// Token: 0x060259AA RID: 154026 RVA: 0x00A95D3F File Offset: 0x00A93F3F
		private void OnStateChangeEvent(EToggleState state)
		{
			UiNavigationViewManager.Instance.RefreshCurrentHotKeyTextId();
		}

		// Token: 0x060259AB RID: 154027 RVA: 0x00A95D4B File Offset: 0x00A93F4B
		private void RegisterToggleClick()
		{
			if (this.NeedAddToggleClick())
			{
				(this.Selectable as UUIExtendToggle).OnStateChange.Add(new Action<EToggleState>(this.ToggleClick));
			}
		}

		// Token: 0x060259AC RID: 154028 RVA: 0x00A95D76 File Offset: 0x00A93F76
		private void UnRegisterToggleClick()
		{
			if (this.NeedAddToggleClick())
			{
				(this.Selectable as UUIExtendToggle).OnStateChange.Remove(new Action<EToggleState>(this.ToggleClick));
			}
		}

		// Token: 0x060259AD RID: 154029 RVA: 0x00A95DA1 File Offset: 0x00A93FA1
		private void ToggleClick(EToggleState state)
		{
			this.OnToggleClick(state);
		}

		// Token: 0x060259AE RID: 154030 RVA: 0x00A95DAA File Offset: 0x00A93FAA
		protected virtual void OnToggleClick(EToggleState state)
		{
		}

		// Token: 0x060259AF RID: 154031 RVA: 0x00A95DAC File Offset: 0x00A93FAC
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

		// Token: 0x060259B0 RID: 154032 RVA: 0x00A95E03 File Offset: 0x00A94003
		protected virtual bool NeedAddToggleClick()
		{
			return base.GetType() != ENavigationSelectableDefine.Toggle;
		}

		// Token: 0x060259B1 RID: 154033 RVA: 0x00A95E14 File Offset: 0x00A94014
		protected override bool OnCanFocusInScrollOrLayout()
		{
			if (!this.IsInteractive)
			{
				return false;
			}
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			return (uuiextendToggle.ToggleState == EToggleState.ETT_Checked || !uuiextendToggle.bCheckToggleSelected) && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x060259B2 RID: 154034 RVA: 0x00A95E68 File Offset: 0x00A94068
		protected override string OnGetTipsTextId()
		{
			if ((this.Selectable as UUIExtendToggle).ToggleState == EToggleState.ETT_Checked)
			{
				return this.Listener.HotKeyTipsTextIdMap.GetValueOrDefault(EHotKeyNameStateType.ToggleSelected, string.Empty);
			}
			return this.Listener.HotKeyTipsTextIdMap.GetValueOrDefault(EHotKeyNameStateType.Normal, string.Empty);
		}

		// Token: 0x060259B3 RID: 154035 RVA: 0x00A95EB5 File Offset: 0x00A940B5
		protected override bool OnHandlePointerEnter(ULGUIPointerEventData eventData)
		{
			return !(this.Selectable as UUIExtendToggle).bToggleOnSelect;
		}

		// Token: 0x060259B4 RID: 154036 RVA: 0x00A95ECC File Offset: 0x00A940CC
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

		// Token: 0x060259B5 RID: 154037 RVA: 0x00A95F77 File Offset: 0x00A94177
		protected virtual bool OnHandlePointerSelectInheritance(ULGUIPointerEventData eventData)
		{
			return true;
		}
	}
}
