using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003879 RID: 14457
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkillPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258F8 RID: 153848 RVA: 0x00A93E37 File Offset: 0x00A92037
		public RoleSkillPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x060258F9 RID: 153849 RVA: 0x00A93E4C File Offset: 0x00A9204C
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

		// Token: 0x060258FA RID: 153850 RVA: 0x00A93EC0 File Offset: 0x00A920C0
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

		// Token: 0x060258FB RID: 153851 RVA: 0x00A93F3C File Offset: 0x00A9213C
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

		// Token: 0x04014C36 RID: 85046
		public string GroupName = "";

		// Token: 0x04014C37 RID: 85047
		public bool IsInPreview;
	}
}
