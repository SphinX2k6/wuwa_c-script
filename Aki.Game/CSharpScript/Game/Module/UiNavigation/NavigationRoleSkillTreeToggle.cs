using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A9 RID: 14505
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationRoleSkillTreeToggle : NavigationToggle
	{
		// Token: 0x060259FE RID: 154110 RVA: 0x00A96AEE File Offset: 0x00A94CEE
		public NavigationRoleSkillTreeToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259FF RID: 154111 RVA: 0x00A96AF9 File Offset: 0x00A94CF9
		protected override void OnInit()
		{
			base.OnInit();
			EventSystem.Instance.Add<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.HandleSkillTreeToggleState));
		}

		// Token: 0x06025A00 RID: 154112 RVA: 0x00A96B1D File Offset: 0x00A94D1D
		protected override void OnClear()
		{
			base.OnClear();
			EventSystem.Instance.Remove(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.HandleSkillTreeToggleState));
		}

		// Token: 0x06025A01 RID: 154113 RVA: 0x00A96B41 File Offset: 0x00A94D41
		private void HandleSkillTreeToggleState(EUiTabViewName eUiTabViewName, int i)
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (uuiextendToggle.GetToggleState() == EToggleState.ETT_Checked)
			{
				this.NeedSkipSetToggle = true;
			}
			uuiextendToggle.bToggleOnSelect = false;
		}

		// Token: 0x06025A02 RID: 154114 RVA: 0x00A96B64 File Offset: 0x00A94D64
		protected override void OnToggleClick(EToggleState state)
		{
			RoleSkillPanelHandle roleSkillPanelHandle = this.PanelHandle as RoleSkillPanelHandle;
			if (!StringUtils.IsBlank((roleSkillPanelHandle != null) ? roleSkillPanelHandle.GroupName : null))
			{
				return;
			}
			if (roleSkillPanelHandle != null)
			{
				RoleSkillPanelHandle roleSkillPanelHandle2 = roleSkillPanelHandle;
				TsUiNavigationBehaviorListener listener = this.Listener;
				roleSkillPanelHandle2.SetToggleSelectByGroupName((listener != null) ? listener.GroupName : null);
			}
		}

		// Token: 0x06025A03 RID: 154115 RVA: 0x00A96BAC File Offset: 0x00A94DAC
		protected override bool OnHandlePointerSelectInheritance(ULGUIPointerEventData eventData)
		{
			if (this.NeedSkipSetToggle)
			{
				this.NeedSkipSetToggle = false;
				return false;
			}
			return true;
		}

		// Token: 0x06025A04 RID: 154116 RVA: 0x00A96BC0 File Offset: 0x00A94DC0
		protected override bool OnCheckFindNavigationBefore()
		{
			return !(this.PanelHandle as RoleSkillPanelHandle).IsInPreview;
		}

		// Token: 0x04014C57 RID: 85079
		private bool NeedSkipSetToggle;
	}
}
