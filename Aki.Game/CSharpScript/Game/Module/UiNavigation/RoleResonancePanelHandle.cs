using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004901 RID: 18689
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleResonancePanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DC2 RID: 200130 RVA: 0x00B58D4C File Offset: 0x00B56F4C
		public RoleResonancePanelHandle(string type) : base(type)
		{
		}

		// Token: 0x170079C2 RID: 31170
		// (get) Token: 0x06030DC3 RID: 200131 RVA: 0x00B58D78 File Offset: 0x00B56F78
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

		// Token: 0x170079C3 RID: 31171
		// (get) Token: 0x06030DC4 RID: 200132 RVA: 0x00B58DC4 File Offset: 0x00B56FC4
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

		// Token: 0x06030DC5 RID: 200133 RVA: 0x00B58E10 File Offset: 0x00B57010
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

		// Token: 0x06030DC6 RID: 200134 RVA: 0x00B58EA4 File Offset: 0x00B570A4
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

		// Token: 0x06030DC7 RID: 200135 RVA: 0x00B58F18 File Offset: 0x00B57118
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

		// Token: 0x06030DC8 RID: 200136 RVA: 0x00B58F94 File Offset: 0x00B57194
		[NullableContext(2)]
		public void SetDefaultNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.DefaultListener = listener;
		}

		// Token: 0x06030DC9 RID: 200137 RVA: 0x00B58F9D File Offset: 0x00B5719D
		public void AddLockNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.LockListInternal.Add(listener);
			this.SortLockListDirty = true;
		}

		// Token: 0x06030DCA RID: 200138 RVA: 0x00B58FB2 File Offset: 0x00B571B2
		public void AddUnLockNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.UnLockListInternal.Add(listener);
			this.SortUnLockListDirty = true;
		}

		// Token: 0x0401A3BC RID: 107452
		private const int MAX_NUM = 6;

		// Token: 0x0401A3BD RID: 107453
		public string GroupName = "";

		// Token: 0x0401A3BE RID: 107454
		[Nullable(2)]
		private TsUiNavigationBehaviorListener DefaultListener;

		// Token: 0x0401A3BF RID: 107455
		private readonly List<TsUiNavigationBehaviorListener> LockListInternal = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3C0 RID: 107456
		private bool SortLockListDirty;

		// Token: 0x0401A3C1 RID: 107457
		private readonly List<TsUiNavigationBehaviorListener> UnLockListInternal = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3C2 RID: 107458
		private bool SortUnLockListDirty;
	}
}
