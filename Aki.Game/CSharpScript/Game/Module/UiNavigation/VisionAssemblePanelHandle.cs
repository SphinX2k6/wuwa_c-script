using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200387C RID: 14460
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionAssemblePanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06025921 RID: 153889 RVA: 0x00A94516 File Offset: 0x00A92716
		public VisionAssemblePanelHandle(string type) : base(type)
		{
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x06025922 RID: 153890 RVA: 0x00A9451F File Offset: 0x00A9271F
		// (set) Token: 0x06025923 RID: 153891 RVA: 0x00A94527 File Offset: 0x00A92727
		public bool IsInCompare { get; set; }

		// Token: 0x06025924 RID: 153892 RVA: 0x00A94530 File Offset: 0x00A92730
		protected override void OnInit()
		{
			EventSystem.Instance.Add(EEventName.OnVisionAssembleNavigationRefresh, new Action<bool>(this.RefreshNavigation));
		}

		// Token: 0x06025925 RID: 153893 RVA: 0x00A9454E File Offset: 0x00A9274E
		protected override void OnClear()
		{
			EventSystem.Instance.Remove(EEventName.OnVisionAssembleNavigationRefresh, new Action<bool>(this.RefreshNavigation));
		}

		// Token: 0x06025926 RID: 153894 RVA: 0x00A9456C File Offset: 0x00A9276C
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

		// Token: 0x06025927 RID: 153895 RVA: 0x00A945F0 File Offset: 0x00A927F0
		private void RefreshNavigation(bool isCompareTrigger)
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			if (isCompareTrigger)
			{
				UiNavigationModel.Instance.MarkMoveInstantly();
			}
		}

		// Token: 0x04014C3D RID: 85053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<TsUiNavigationBehaviorListener> TempListenerList;
	}
}
