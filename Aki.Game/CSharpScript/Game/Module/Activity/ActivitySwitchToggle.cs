using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005F01 RID: 24321
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySwitchToggle : UiPanelBase, IDynamicScrollItem<IActivityCategoryTabData>
	{
		// Token: 0x17008EEF RID: 36591
		// (get) Token: 0x0603DCC1 RID: 253121 RVA: 0x00EF08B3 File Offset: 0x00EEEAB3
		// (set) Token: 0x0603DCC2 RID: 253122 RVA: 0x00EF08BB File Offset: 0x00EEEABB
		private IActivityCategoryTabData Data { get; set; }

		// Token: 0x17008EF0 RID: 36592
		// (get) Token: 0x0603DCC3 RID: 253123 RVA: 0x00EF08C4 File Offset: 0x00EEEAC4
		// (set) Token: 0x0603DCC4 RID: 253124 RVA: 0x00EF08CC File Offset: 0x00EEEACC
		private TOnToggleClickCb OnToggleClick { get; set; }

		// Token: 0x17008EF1 RID: 36593
		// (get) Token: 0x0603DCC5 RID: 253125 RVA: 0x00EF08D5 File Offset: 0x00EEEAD5
		// (set) Token: 0x0603DCC6 RID: 253126 RVA: 0x00EF08DD File Offset: 0x00EEEADD
		private CategoryToggleItem TabItem { get; set; }

		// Token: 0x0603DCC7 RID: 253127 RVA: 0x00EF08E8 File Offset: 0x00EEEAE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DCC8 RID: 253128 RVA: 0x00EF0954 File Offset: 0x00EEEB54
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			ActivitySwitchToggle.<Init>d__14 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ActivitySwitchToggle.<Init>d__14>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603DCC9 RID: 253129 RVA: 0x00EF099F File Offset: 0x00EEEB9F
		protected override void OnBeforeShow()
		{
			this.RefreshRedDotIds();
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshRedDot));
		}

		// Token: 0x0603DCCA RID: 253130 RVA: 0x00EF09C3 File Offset: 0x00EEEBC3
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshRedDot));
		}

		// Token: 0x0603DCCB RID: 253131 RVA: 0x00EF09E1 File Offset: 0x00EEEBE1
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data = null;
			}
			this.RedDotStateMap.Clear();
		}

		// Token: 0x0603DCCC RID: 253132 RVA: 0x00EF09FD File Offset: 0x00EEEBFD
		private void OnTabItemClicked(EToggleState state)
		{
			TOnToggleClickCb onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this.Data, this.TabItem.GetTabToggle(), state);
		}

		// Token: 0x0603DCCD RID: 253133 RVA: 0x00EF0A21 File Offset: 0x00EEEC21
		public void ClearItem()
		{
		}

		// Token: 0x0603DCCE RID: 253134 RVA: 0x00EF0A23 File Offset: 0x00EEEC23
		[NullableContext(1)]
		public AUIBaseActor GetUsingItem(IActivityCategoryTabData data)
		{
			if (data.IsLineType)
			{
				return base.GetItem(1).GetOwner() as AUIBaseActor;
			}
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603DCCF RID: 253135 RVA: 0x00EF0A50 File Offset: 0x00EEEC50
		[NullableContext(1)]
		public void Update(IActivityCategoryTabData data, int index)
		{
			this.Data = data;
			if (data.IsLineType)
			{
				this.RefreshLineItem();
				return;
			}
			this.RefreshTabItem();
			this.BindRedDotIds((from x in data.Activities
			select x.Id).ToArray<int>());
		}

		// Token: 0x0603DCD0 RID: 253136 RVA: 0x00EF0AAE File Offset: 0x00EEECAE
		[NullableContext(1)]
		public void InitData(IActivityCategoryTabData data)
		{
			this.Data = data;
		}

		// Token: 0x0603DCD1 RID: 253137 RVA: 0x00EF0AB7 File Offset: 0x00EEECB7
		[NullableContext(1)]
		public void SetOnToggleClicked(TOnToggleClickCb onToggleSelected)
		{
			this.OnToggleClick = onToggleSelected;
		}

		// Token: 0x0603DCD2 RID: 253138 RVA: 0x00EF0AC0 File Offset: 0x00EEECC0
		private void RefreshLineItem()
		{
			base.GetItem(1).SetUIActive(true);
			CategoryToggleItem tabItem = this.TabItem;
			if (tabItem == null)
			{
				return;
			}
			tabItem.SetUiActive(false);
		}

		// Token: 0x0603DCD3 RID: 253139 RVA: 0x00EF0AE0 File Offset: 0x00EEECE0
		private void RefreshTabItem()
		{
			base.GetItem(1).SetUIActive(false);
			CategoryToggleItem tabItem = this.TabItem;
			if (tabItem != null)
			{
				tabItem.SetUiActive(true);
			}
			CategoryToggleItem tabItem2 = this.TabItem;
			if (tabItem2 == null)
			{
				return;
			}
			tabItem2.SetIcon(this.Data.IconPath);
		}

		// Token: 0x0603DCD4 RID: 253140 RVA: 0x00EF0B1C File Offset: 0x00EEED1C
		public void OnSelected(bool fireEvent)
		{
			CategoryToggleItem tabItem = this.TabItem;
			if (tabItem == null)
			{
				return;
			}
			tabItem.GetTabToggle().SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x17008EF2 RID: 36594
		// (get) Token: 0x0603DCD5 RID: 253141 RVA: 0x00EF0B37 File Offset: 0x00EEED37
		// (set) Token: 0x0603DCD6 RID: 253142 RVA: 0x00EF0B3F File Offset: 0x00EEED3F
		[Nullable(1)]
		private Dictionary<int, bool> RedDotStateMap { [NullableContext(1)] get; [NullableContext(1)] set; } = new Dictionary<int, bool>();

		// Token: 0x17008EF3 RID: 36595
		// (get) Token: 0x0603DCD7 RID: 253143 RVA: 0x00EF0B48 File Offset: 0x00EEED48
		// (set) Token: 0x0603DCD8 RID: 253144 RVA: 0x00EF0B50 File Offset: 0x00EEED50
		private int RedDotCount { get; set; }

		// Token: 0x0603DCD9 RID: 253145 RVA: 0x00EF0B5C File Offset: 0x00EEED5C
		private void RefreshRedDotIds()
		{
			foreach (int activityId in this.RedDotStateMap.Keys)
			{
				this.RefreshRedDot(activityId);
			}
		}

		// Token: 0x0603DCDA RID: 253146 RVA: 0x00EF0BB4 File Offset: 0x00EEEDB4
		private void ChangeRedDotCount(bool addOrRemove)
		{
			int redDotCount = this.RedDotCount;
			if (addOrRemove)
			{
				int redDotCount2 = this.RedDotCount;
				this.RedDotCount = redDotCount2 + 1;
			}
			else
			{
				int redDotCount2 = this.RedDotCount;
				this.RedDotCount = redDotCount2 - 1;
			}
			if ((redDotCount > 0 && this.RedDotCount == 0) || (redDotCount == 0 && this.RedDotCount > 0))
			{
				this.SetRedDotState(this.RedDotCount > 0);
			}
		}

		// Token: 0x0603DCDB RID: 253147 RVA: 0x00EF0C14 File Offset: 0x00EEEE14
		public void SetRedDotState(bool bVisible)
		{
			this.TabItem.SetRedDotState(bVisible);
		}

		// Token: 0x0603DCDC RID: 253148 RVA: 0x00EF0C24 File Offset: 0x00EEEE24
		private void RefreshRedDot(int activityId)
		{
			bool flag;
			if (this.RedDotStateMap.TryGetValue(activityId, out flag))
			{
				bool activityRedDotState = this.GetActivityRedDotState(activityId);
				this.RedDotStateMap[activityId] = activityRedDotState;
				if (flag && !activityRedDotState)
				{
					this.ChangeRedDotCount(false);
					return;
				}
				if (!flag && activityRedDotState)
				{
					this.ChangeRedDotCount(true);
				}
			}
		}

		// Token: 0x0603DCDD RID: 253149 RVA: 0x00EF0C73 File Offset: 0x00EEEE73
		private bool GetActivityRedDotState(int id)
		{
			return ActivityModel.Instance.GetActivityRedDotState(id);
		}

		// Token: 0x0603DCDE RID: 253150 RVA: 0x00EF0C80 File Offset: 0x00EEEE80
		[NullableContext(1)]
		public void BindRedDotIds(int[] redDotIds)
		{
			this.RedDotStateMap = new Dictionary<int, bool>();
			this.RedDotCount = 0;
			foreach (int num in redDotIds)
			{
				bool activityRedDotState = this.GetActivityRedDotState(num);
				this.RedDotStateMap[num] = activityRedDotState;
				if (activityRedDotState)
				{
					int redDotCount = this.RedDotCount;
					this.RedDotCount = redDotCount + 1;
				}
			}
			this.SetRedDotState(this.RedDotCount > 0);
		}

		// Token: 0x0200C234 RID: 49716
		[NullableContext(0)]
		private class ECategoryComponents
		{
			// Token: 0x0403AAD5 RID: 240341
			public const int ItemTypeTitle = 1;

			// Token: 0x0403AAD6 RID: 240342
			public const int PanelTab = 0;
		}
	}
}
