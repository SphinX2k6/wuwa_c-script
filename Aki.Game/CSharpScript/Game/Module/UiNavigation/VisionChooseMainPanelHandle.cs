using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200387D RID: 14461
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionChooseMainPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06025928 RID: 153896 RVA: 0x00A94609 File Offset: 0x00A92809
		public VisionChooseMainPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x06025929 RID: 153897 RVA: 0x00A94614 File Offset: 0x00A92814
		public List<TsUiNavigationBehaviorListener> ChangeListenerList
		{
			get
			{
				if (this.ChangeListenerListInternal == null)
				{
					this.ChangeListenerListInternal = new List<TsUiNavigationBehaviorListener>(this.DefaultNavigationListener);
					if (this.ChangeListenerListInternal.Count >= 2)
					{
						List<TsUiNavigationBehaviorListener> changeListenerListInternal = this.ChangeListenerListInternal;
						List<TsUiNavigationBehaviorListener> changeListenerListInternal2 = this.ChangeListenerListInternal;
						TsUiNavigationBehaviorListener value = this.ChangeListenerListInternal[1];
						TsUiNavigationBehaviorListener value2 = this.ChangeListenerListInternal[0];
						changeListenerListInternal[0] = value;
						changeListenerListInternal2[1] = value2;
					}
				}
				return this.ChangeListenerListInternal;
			}
		}

		// Token: 0x0602592A RID: 153898 RVA: 0x00A94684 File Offset: 0x00A92884
		protected override List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			if (this.IsFindChangeListenerList)
			{
				return this.ChangeListenerList;
			}
			if (!isDefault)
			{
				return this.DefaultNavigationListener;
			}
			if (!UiNavigationGlobalData.VisionReplaceViewFindDefault)
			{
				return this.ChangeListenerList;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.FindVisionTabItemListener(this.DefaultNavigationListener[0]);
			if (tsUiNavigationBehaviorListener != null)
			{
				return new List<TsUiNavigationBehaviorListener>
				{
					tsUiNavigationBehaviorListener
				};
			}
			return this.DefaultNavigationListener;
		}

		// Token: 0x0602592B RID: 153899 RVA: 0x00A946E1 File Offset: 0x00A928E1
		protected override void OnNotifyFindResult(FindNavigationResult result)
		{
			if (result.IsInLoopingProcess())
			{
				return;
			}
			UiNavigationGlobalData.VisionReplaceViewFindDefault = true;
			this.IsFindChangeListenerList = false;
		}

		// Token: 0x0602592C RID: 153900 RVA: 0x00A946FC File Offset: 0x00A928FC
		[return: Nullable(2)]
		private TsUiNavigationBehaviorListener FindVisionTabItemListener(TsUiNavigationBehaviorListener listener)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
			NavigationGroup navigationGroup = base.GetNavigationGroup(listener.GroupName);
			if (navigationGroup == null)
			{
				return null;
			}
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
				{
					tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
				}
				if (tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
				{
					return tsUiNavigationBehaviorListener2;
				}
			}
			return tsUiNavigationBehaviorListener;
		}

		// Token: 0x04014C3F RID: 85055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<TsUiNavigationBehaviorListener> ChangeListenerListInternal;

		// Token: 0x04014C40 RID: 85056
		public bool IsFindChangeListenerList;
	}
}
