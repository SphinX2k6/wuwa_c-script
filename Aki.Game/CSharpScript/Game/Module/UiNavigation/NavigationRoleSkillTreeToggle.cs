using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004932 RID: 18738
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationRoleSkillTreeToggle : NavigationToggle
	{
		// Token: 0x06030ED1 RID: 200401 RVA: 0x00B5BC7E File Offset: 0x00B59E7E
		public NavigationRoleSkillTreeToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030ED2 RID: 200402 RVA: 0x00B5BC89 File Offset: 0x00B59E89
		protected override void OnInit()
		{
			base.OnInit();
			EventSystem.Instance.Add<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.HandleSkillTreeToggleState));
		}

		// Token: 0x06030ED3 RID: 200403 RVA: 0x00B5BCAD File Offset: 0x00B59EAD
		protected override void OnClear()
		{
			base.OnClear();
			EventSystem.Instance.Remove(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.HandleSkillTreeToggleState));
		}

		// Token: 0x06030ED4 RID: 200404 RVA: 0x00B5BCD1 File Offset: 0x00B59ED1
		private void HandleSkillTreeToggleState(EUiTabViewName eUiTabViewName, int i)
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (uuiextendToggle.GetToggleState() == EToggleState.ETT_Checked)
			{
				this.NeedSkipSetToggle = true;
			}
			uuiextendToggle.bToggleOnSelect = false;
		}

		// Token: 0x06030ED5 RID: 200405 RVA: 0x00B5BCF4 File Offset: 0x00B59EF4
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

		// Token: 0x06030ED6 RID: 200406 RVA: 0x00B5BD3C File Offset: 0x00B59F3C
		protected override bool OnHandlePointerSelectInheritance(ULGUIPointerEventData eventData)
		{
			if (this.NeedSkipSetToggle)
			{
				this.NeedSkipSetToggle = false;
				return false;
			}
			return true;
		}

		// Token: 0x06030ED7 RID: 200407 RVA: 0x00B5BD50 File Offset: 0x00B59F50
		protected override bool OnCheckFindNavigationBefore()
		{
			return !(this.PanelHandle as RoleSkillPanelHandle).IsInPreview;
		}

		// Token: 0x0401A3E4 RID: 107492
		private bool NeedSkipSetToggle;
	}
}
