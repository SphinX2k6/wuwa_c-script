using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200387A RID: 14458
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteViewPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258FC RID: 153852 RVA: 0x00A93FC0 File Offset: 0x00A921C0
		public RouletteViewPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x060258FD RID: 153853 RVA: 0x00A93FCC File Offset: 0x00A921CC
		protected override List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			if (isDefault)
			{
				return this.DefaultNavigationListener;
			}
			if (!UiNavigationLogic.HasActiveListenerInGroup(base.GetNavigationGroup("Group2")))
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.DefaultNavigationListener[0];
				NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
				if (((navigationGroup != null) ? navigationGroup.LastSelectListener : null) != null)
				{
					TsUiNavigationBehaviorListener lastSelectListener = tsUiNavigationBehaviorListener.GetNavigationGroup().LastSelectListener;
					this.DefaultNavigationListener[0] = lastSelectListener;
				}
				return this.DefaultNavigationListener;
			}
			if (this.ChangeListenerList == null)
			{
				this.ChangeListenerList = new List<TsUiNavigationBehaviorListener>(this.DefaultNavigationListener);
				if (this.ChangeListenerList.Count >= 2)
				{
					List<TsUiNavigationBehaviorListener> changeListenerList = this.ChangeListenerList;
					List<TsUiNavigationBehaviorListener> changeListenerList2 = this.ChangeListenerList;
					TsUiNavigationBehaviorListener value = this.ChangeListenerList[1];
					TsUiNavigationBehaviorListener value2 = this.ChangeListenerList[0];
					changeListenerList[0] = value;
					changeListenerList2[1] = value2;
				}
			}
			return this.ChangeListenerList;
		}

		// Token: 0x04014C38 RID: 85048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<TsUiNavigationBehaviorListener> ChangeListenerList;
	}
}
