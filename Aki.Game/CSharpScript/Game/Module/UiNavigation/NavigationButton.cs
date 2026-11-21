using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200388D RID: 14477
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationButton : NavigationSelectableBase
	{
		// Token: 0x06025963 RID: 153955 RVA: 0x00A952A7 File Offset: 0x00A934A7
		public NavigationButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025964 RID: 153956 RVA: 0x00A952B2 File Offset: 0x00A934B2
		protected override void OnInit()
		{
			this.RegisterButtonClick();
		}

		// Token: 0x06025965 RID: 153957 RVA: 0x00A952BA File Offset: 0x00A934BA
		protected override void OnClear()
		{
			this.UnRegisterButtonClick();
		}

		// Token: 0x06025966 RID: 153958 RVA: 0x00A952C4 File Offset: 0x00A934C4
		private void RegisterButtonClick()
		{
			if (this.NeedAddButtonClick())
			{
				UUIButtonComponent uuibuttonComponent = this.Selectable as UUIButtonComponent;
				FLGUIButtonDynamicDelegate flguibuttonDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIButtonDynamicDelegate>(new Action(this.ButtonClick));
				this.HandleWrapper = ((uuibuttonComponent != null) ? uuibuttonComponent.RegisterClickEvent(flguibuttonDynamicDelegate) : null);
			}
		}

		// Token: 0x06025967 RID: 153959 RVA: 0x00A9530C File Offset: 0x00A9350C
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

		// Token: 0x06025968 RID: 153960 RVA: 0x00A9535B File Offset: 0x00A9355B
		private void ButtonClick()
		{
			this.OnButtonClick();
		}

		// Token: 0x06025969 RID: 153961 RVA: 0x00A95363 File Offset: 0x00A93563
		protected virtual void OnButtonClick()
		{
		}

		// Token: 0x0602596A RID: 153962 RVA: 0x00A95365 File Offset: 0x00A93565
		protected virtual bool NeedAddButtonClick()
		{
			return base.GetType() != ENavigationSelectableDefine.Button;
		}

		// Token: 0x0602596B RID: 153963 RVA: 0x00A95374 File Offset: 0x00A93574
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

		// Token: 0x04014C45 RID: 85061
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper HandleWrapper;
	}
}
