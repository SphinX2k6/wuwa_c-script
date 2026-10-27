using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004906 RID: 18694
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionChooseMainPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DFB RID: 200187 RVA: 0x00B59799 File Offset: 0x00B57999
		public VisionChooseMainPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x170079C5 RID: 31173
		// (get) Token: 0x06030DFC RID: 200188 RVA: 0x00B597A4 File Offset: 0x00B579A4
		public List<TsUiNavigationBehaviorListener> ChangeListenerList
		{
			get
			{
				if (this.ChangeListenerListInternal == null)
				{
					this.ChangeListenerListInternal = this.DefaultNavigationListener.ToList<TsUiNavigationBehaviorListener>();
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

		// Token: 0x06030DFD RID: 200189 RVA: 0x00B59814 File Offset: 0x00B57A14
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

		// Token: 0x06030DFE RID: 200190 RVA: 0x00B59871 File Offset: 0x00B57A71
		protected override void OnNotifyFindResult(FindNavigationResult result)
		{
			if (result.IsInLoopingProcess())
			{
				return;
			}
			UiNavigationGlobalData.VisionReplaceViewFindDefault = true;
			this.IsFindChangeListenerList = false;
		}

		// Token: 0x06030DFF RID: 200191 RVA: 0x00B5988C File Offset: 0x00B57A8C
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

		// Token: 0x0401A3CC RID: 107468
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<TsUiNavigationBehaviorListener> ChangeListenerListInternal;

		// Token: 0x0401A3CD RID: 107469
		public bool IsFindChangeListenerList;
	}
}
