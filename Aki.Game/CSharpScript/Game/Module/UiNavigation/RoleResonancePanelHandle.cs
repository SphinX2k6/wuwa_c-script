using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003878 RID: 14456
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleResonancePanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258EF RID: 153839 RVA: 0x00A93BBC File Offset: 0x00A91DBC
		public RoleResonancePanelHandle(string type) : base(type)
		{
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x060258F0 RID: 153840 RVA: 0x00A93BE8 File Offset: 0x00A91DE8
		private IReadOnlyList<TsUiNavigationBehaviorListener> LockList
		{
			get
			{
				if (this.SortLockListDirty)
				{
					this.SortLockListDirty = false;
					this.LockListInternal.Sort(delegate(TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener)
					{
						int num = aListener.IsValid() ? aListener.RootUIComp.Get().GetFlattenHierarchyIndex() : 0;
						int value2 = bListener.IsValid() ? bListener.RootUIComp.Get().GetFlattenHierarchyIndex() : 0;
						return num.CompareTo(value2);
					});
				}
				return this.LockListInternal;
			}
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x060258F1 RID: 153841 RVA: 0x00A93C34 File Offset: 0x00A91E34
		private IReadOnlyList<TsUiNavigationBehaviorListener> UnLockList
		{
			get
			{
				if (this.SortUnLockListDirty)
				{
					this.SortUnLockListDirty = false;
					this.UnLockListInternal.Sort(delegate(TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener)
					{
						int num = aListener.IsValid() ? aListener.RootUIComp.Get().GetFlattenHierarchyIndex() : 0;
						int value2 = bListener.IsValid() ? bListener.RootUIComp.Get().GetFlattenHierarchyIndex() : 0;
						return num.CompareTo(value2);
					});
				}
				return this.UnLockListInternal;
			}
		}

		// Token: 0x060258F2 RID: 153842 RVA: 0x00A93C80 File Offset: 0x00A91E80
		protected override List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			if (this.DefaultListener == null)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			if (this.DefaultListener.IsCanFocus())
			{
				return new List<TsUiNavigationBehaviorListener>
				{
					this.DefaultListener
				};
			}
			int num = 6 - this.LockList.Count;
			int num2 = 0;
			for (int i = 0; i < this.LockList.Count; i++)
			{
				if (this.LockList[i] == this.DefaultListener)
				{
					num2 = i;
					break;
				}
			}
			return new List<TsUiNavigationBehaviorListener>
			{
				this.UnLockList[num + num2]
			};
		}

		// Token: 0x060258F3 RID: 153843 RVA: 0x00A93D14 File Offset: 0x00A91F14
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

		// Token: 0x060258F4 RID: 153844 RVA: 0x00A93D88 File Offset: 0x00A91F88
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

		// Token: 0x060258F5 RID: 153845 RVA: 0x00A93E04 File Offset: 0x00A92004
		[NullableContext(2)]
		public void SetDefaultNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.DefaultListener = listener;
		}

		// Token: 0x060258F6 RID: 153846 RVA: 0x00A93E0D File Offset: 0x00A9200D
		public void AddLockNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.LockListInternal.Add(listener);
			this.SortLockListDirty = true;
		}

		// Token: 0x060258F7 RID: 153847 RVA: 0x00A93E22 File Offset: 0x00A92022
		public void AddUnLockNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.UnLockListInternal.Add(listener);
			this.SortUnLockListDirty = true;
		}

		// Token: 0x04014C2F RID: 85039
		private const int MAX_NUM = 6;

		// Token: 0x04014C30 RID: 85040
		public string GroupName = "";

		// Token: 0x04014C31 RID: 85041
		[Nullable(2)]
		private TsUiNavigationBehaviorListener DefaultListener;

		// Token: 0x04014C32 RID: 85042
		private readonly List<TsUiNavigationBehaviorListener> LockListInternal = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x04014C33 RID: 85043
		private bool SortLockListDirty;

		// Token: 0x04014C34 RID: 85044
		private readonly List<TsUiNavigationBehaviorListener> UnLockListInternal = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x04014C35 RID: 85045
		private bool SortUnLockListDirty;
	}
}
