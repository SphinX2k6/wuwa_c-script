using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048FB RID: 18683
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionViewPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DA0 RID: 200096 RVA: 0x00B58618 File Offset: 0x00B56818
		public FunctionViewPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x06030DA1 RID: 200097 RVA: 0x00B58649 File Offset: 0x00B56849
		protected override void OnDefaultNavigationListenerList(TArray<AActor> actorArray)
		{
		}

		// Token: 0x06030DA2 RID: 200098 RVA: 0x00B5864B File Offset: 0x00B5684B
		protected override TsUiNavigationBehaviorListener OnGetLoopOrLayoutListener(TsUiNavigationBehaviorListener listener)
		{
			return listener;
		}

		// Token: 0x06030DA3 RID: 200099 RVA: 0x00B58650 File Offset: 0x00B56850
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

		// Token: 0x06030DA4 RID: 200100 RVA: 0x00B586D2 File Offset: 0x00B568D2
		private void SetDefaultListener(int index, TsUiNavigationBehaviorListener listener)
		{
			this.CurrentPageIndex = index;
			base.SetNavigationGroupDefaultListener(listener, false);
			this.DefaultNavigationListener.Clear();
			this.DefaultNavigationListener.Add(listener);
		}

		// Token: 0x06030DA5 RID: 200101 RVA: 0x00B586FC File Offset: 0x00B568FC
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

		// Token: 0x06030DA6 RID: 200102 RVA: 0x00B58760 File Offset: 0x00B56960
		public void FindNextFocusListener()
		{
			this.FindFocusListener(this.CurrentPageIndex + 1);
		}

		// Token: 0x06030DA7 RID: 200103 RVA: 0x00B58770 File Offset: 0x00B56970
		public void FindPrevFocusListener()
		{
			this.FindFocusListener(this.CurrentPageIndex - 1);
		}

		// Token: 0x0401A3B4 RID: 107444
		private readonly HashSet<AActor> PageLayoutActorSet = new HashSet<AActor>();

		// Token: 0x0401A3B5 RID: 107445
		private readonly Dictionary<int, TsUiNavigationBehaviorListener> PageFirstListenerMap = new Dictionary<int, TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3B6 RID: 107446
		private readonly HashSet<TsUiNavigationBehaviorListener> PageListenerSet = new HashSet<TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3B7 RID: 107447
		private int CurrentPageIndex = 1;
	}
}
