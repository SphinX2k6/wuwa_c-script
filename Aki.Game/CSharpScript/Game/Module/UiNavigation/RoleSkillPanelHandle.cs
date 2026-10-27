using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004902 RID: 18690
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkillPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DCB RID: 200139 RVA: 0x00B58FC7 File Offset: 0x00B571C7
		public RoleSkillPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x06030DCC RID: 200140 RVA: 0x00B58FDC File Offset: 0x00B571DC
		public void SetToggleSelectByGroupName(string groupName)
		{
			NavigationGroup navigationGroup = base.GetNavigationGroup(groupName);
			if (navigationGroup == null)
			{
				return;
			}
			this.GroupName = groupName;
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				UUIExtendToggle uuiextendToggle = tsUiNavigationBehaviorListener.GetBehaviorComponent() as UUIExtendToggle;
				if (uuiextendToggle != null)
				{
					uuiextendToggle.bToggleOnSelect = true;
				}
			}
		}

		// Token: 0x06030DCD RID: 200141 RVA: 0x00B59050 File Offset: 0x00B57250
		public void ResetToggleSelect()
		{
			NavigationGroup navigationGroup = base.GetNavigationGroup(this.GroupName);
			if (navigationGroup == null)
			{
				return;
			}
			this.GroupName = "";
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				UUIExtendToggle uuiextendToggle = tsUiNavigationBehaviorListener.GetBehaviorComponent() as UUIExtendToggle;
				if (uuiextendToggle != null)
				{
					uuiextendToggle.bToggleOnSelect = false;
				}
			}
		}

		// Token: 0x06030DCE RID: 200142 RVA: 0x00B590CC File Offset: 0x00B572CC
		public void SetSkillTreeToggleCursorActive(bool isActive)
		{
			NavigationGroup navigationGroup = base.GetNavigationGroup(this.GroupName);
			if (navigationGroup == null)
			{
				return;
			}
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener.Cursor != null)
				{
					tsUiNavigationBehaviorListener.Cursor.Switch = isActive;
				}
			}
			UiNavigationModel.Instance.RefreshCursorActive();
		}

		// Token: 0x0401A3C3 RID: 107459
		public string GroupName = "";

		// Token: 0x0401A3C4 RID: 107460
		public bool IsInPreview;
	}
}
