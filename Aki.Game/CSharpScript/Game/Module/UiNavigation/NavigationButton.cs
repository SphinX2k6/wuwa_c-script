using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004916 RID: 18710
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationButton : NavigationSelectableBase
	{
		// Token: 0x06030E36 RID: 200246 RVA: 0x00B5A437 File Offset: 0x00B58637
		public NavigationButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E37 RID: 200247 RVA: 0x00B5A442 File Offset: 0x00B58642
		protected override void OnInit()
		{
			this.RegisterButtonClick();
		}

		// Token: 0x06030E38 RID: 200248 RVA: 0x00B5A44A File Offset: 0x00B5864A
		protected override void OnClear()
		{
			this.UnRegisterButtonClick();
		}

		// Token: 0x06030E39 RID: 200249 RVA: 0x00B5A454 File Offset: 0x00B58654
		private void RegisterButtonClick()
		{
			if (this.NeedAddButtonClick())
			{
				UUIButtonComponent uuibuttonComponent = this.Selectable as UUIButtonComponent;
				FLGUIButtonDynamicDelegate flguibuttonDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIButtonDynamicDelegate>(new Action(this.ButtonClick));
				this.HandleWrapper = ((uuibuttonComponent != null) ? uuibuttonComponent.RegisterClickEvent(flguibuttonDynamicDelegate) : null);
			}
		}

		// Token: 0x06030E3A RID: 200250 RVA: 0x00B5A49C File Offset: 0x00B5869C
		private void UnRegisterButtonClick()
		{
			if (this.HandleWrapper != null)
			{
				UUIButtonComponent uuibuttonComponent = this.Selectable as UUIButtonComponent;
				if (uuibuttonComponent != null)
				{
					uuibuttonComponent.UnregisterClickEvent(this.HandleWrapper);
				}
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.ButtonClick));
				this.HandleWrapper = null;
			}
		}

		// Token: 0x06030E3B RID: 200251 RVA: 0x00B5A4EB File Offset: 0x00B586EB
		private void ButtonClick()
		{
			this.OnButtonClick();
		}

		// Token: 0x06030E3C RID: 200252 RVA: 0x00B5A4F3 File Offset: 0x00B586F3
		protected virtual void OnButtonClick()
		{
		}

		// Token: 0x06030E3D RID: 200253 RVA: 0x00B5A4F5 File Offset: 0x00B586F5
		protected virtual bool NeedAddButtonClick()
		{
			return base.GetType() != ENavigationSelectableDefine.Button;
		}

		// Token: 0x06030E3E RID: 200254 RVA: 0x00B5A504 File Offset: 0x00B58704
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag;
			if (listener == null)
			{
				flag = (null != null);
			}
			else
			{
				UiNavigationScrollProxy scrollProxy = listener.ScrollProxy;
				flag = (((scrollProxy != null) ? scrollProxy.ScrollView : null) != null);
			}
			if (flag)
			{
				this.Listener.ScrollProxy.ScrollView.ScrollToSelectableComponent(this.Selectable as UUIButtonComponent);
			}
			TsUiNavigationBehaviorListener listener2 = this.Listener;
			NavigationGroup navigationGroup = (listener2 != null) ? listener2.GetNavigationGroup() : null;
			if (((navigationGroup != null) ? navigationGroup.InsideGroupNameSet : new HashSet<string>()).Count > 0)
			{
				TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
				return UiNavigationNewController.Instance.IsInFocusInsideListenerList(this.Listener, currentNavigationFocusListener);
			}
			return false;
		}

		// Token: 0x0401A3D2 RID: 107474
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper HandleWrapper;
	}
}
