using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003872 RID: 14450
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionViewPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258CD RID: 153805 RVA: 0x00A93488 File Offset: 0x00A91688
		public FunctionViewPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x060258CE RID: 153806 RVA: 0x00A934B9 File Offset: 0x00A916B9
		protected override void OnDefaultNavigationListenerList(TArray<AActor> actorArray)
		{
		}

		// Token: 0x060258CF RID: 153807 RVA: 0x00A934BB File Offset: 0x00A916BB
		protected override TsUiNavigationBehaviorListener OnGetLoopOrLayoutListener(TsUiNavigationBehaviorListener listener)
		{
			return listener;
		}

		// Token: 0x060258D0 RID: 153808 RVA: 0x00A934C0 File Offset: 0x00A916C0
		public void AddNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			this.PageListenerSet.Add(listener);
			if (this.PageLayoutActorSet.Contains(listener.LayoutActor))
			{
				return;
			}
			UUIItem parentAsUIItem = (listener.LayoutActor as AUIBaseActor).GetUIItem().GetParentAsUIItem();
			int num = parentAsUIItem.GetParentAsUIItem().UIChildren.FindIndex(parentAsUIItem);
			this.PageLayoutActorSet.Add(listener.LayoutActor);
			this.PageFirstListenerMap[num] = listener;
			if (num == 1)
			{
				this.SetDefaultListener(num, listener);
			}
		}

		// Token: 0x060258D1 RID: 153809 RVA: 0x00A93542 File Offset: 0x00A91742
		private void SetDefaultListener(int index, TsUiNavigationBehaviorListener listener)
		{
			this.CurrentPageIndex = index;
			base.SetNavigationGroupDefaultListener(listener, false);
			this.DefaultNavigationListener.Clear();
			this.DefaultNavigationListener.Add(listener);
		}

		// Token: 0x060258D2 RID: 153810 RVA: 0x00A9356C File Offset: 0x00A9176C
		private void FindFocusListener(int index)
		{
			TsUiNavigationBehaviorListener listener;
			if (!this.PageFirstListenerMap.TryGetValue(index, out listener))
			{
				return;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener == null || !this.PageListenerSet.Contains(currentNavigationFocusListener))
			{
				this.SetDefaultListener(index, listener);
				return;
			}
			this.SetDefaultListener(index, listener);
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			UiNavigationModel.Instance.SetCursorActiveDelayTime(350f);
		}

		// Token: 0x060258D3 RID: 153811 RVA: 0x00A935D0 File Offset: 0x00A917D0
		public void FindNextFocusListener()
		{
			this.FindFocusListener(this.CurrentPageIndex + 1);
		}

		// Token: 0x060258D4 RID: 153812 RVA: 0x00A935E0 File Offset: 0x00A917E0
		public void FindPrevFocusListener()
		{
			this.FindFocusListener(this.CurrentPageIndex - 1);
		}

		// Token: 0x04014C27 RID: 85031
		private readonly HashSet<AActor> PageLayoutActorSet = new HashSet<AActor>();

		// Token: 0x04014C28 RID: 85032
		private readonly Dictionary<int, TsUiNavigationBehaviorListener> PageFirstListenerMap = new Dictionary<int, TsUiNavigationBehaviorListener>();

		// Token: 0x04014C29 RID: 85033
		private readonly HashSet<TsUiNavigationBehaviorListener> PageListenerSet = new HashSet<TsUiNavigationBehaviorListener>();

		// Token: 0x04014C2A RID: 85034
		private int CurrentPageIndex = 1;
	}
}
