using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004905 RID: 18693
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionAssemblePanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DF4 RID: 200180 RVA: 0x00B596A6 File Offset: 0x00B578A6
		public VisionAssemblePanelHandle(string type) : base(type)
		{
		}

		// Token: 0x170079C4 RID: 31172
		// (get) Token: 0x06030DF5 RID: 200181 RVA: 0x00B596AF File Offset: 0x00B578AF
		// (set) Token: 0x06030DF6 RID: 200182 RVA: 0x00B596B7 File Offset: 0x00B578B7
		public bool IsInCompare { get; set; }

		// Token: 0x06030DF7 RID: 200183 RVA: 0x00B596C0 File Offset: 0x00B578C0
		protected override void OnInit()
		{
			EventSystem.Instance.Add(EEventName.OnVisionAssembleNavigationRefresh, new Action<bool>(this.RefreshNavigation));
		}

		// Token: 0x06030DF8 RID: 200184 RVA: 0x00B596DE File Offset: 0x00B578DE
		protected override void OnClear()
		{
			EventSystem.Instance.Remove(EEventName.OnVisionAssembleNavigationRefresh, new Action<bool>(this.RefreshNavigation));
		}

		// Token: 0x06030DF9 RID: 200185 RVA: 0x00B596FC File Offset: 0x00B578FC
		protected override List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			if (isDefault)
			{
				return base.OnGetSuitableNavigationListenerList(isDefault);
			}
			if (this.TempListenerList == null)
			{
				this.TempListenerList = new List<TsUiNavigationBehaviorListener>();
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in this.DefaultNavigationListener)
				{
					if (tsUiNavigationBehaviorListener.IsScrollOrLayoutActor())
					{
						this.TempListenerList.Add(tsUiNavigationBehaviorListener);
					}
				}
			}
			return this.TempListenerList;
		}

		// Token: 0x06030DFA RID: 200186 RVA: 0x00B59780 File Offset: 0x00B57980
		private void RefreshNavigation(bool isCompareTrigger)
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			if (isCompareTrigger)
			{
				UiNavigationModel.Instance.MarkMoveInstantly();
			}
		}

		// Token: 0x0401A3CA RID: 107466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<TsUiNavigationBehaviorListener> TempListenerList;
	}
}
