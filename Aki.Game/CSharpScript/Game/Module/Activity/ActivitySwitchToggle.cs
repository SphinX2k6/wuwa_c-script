using System;
using System.Collections.Generic;
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
	// Token: 0x02004EE8 RID: 20200
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySwitchToggle : UiPanelBase, IDynamicScrollItem<IActivityCategoryTabData>
	{
		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x06032C5C RID: 207964 RVA: 0x00E42577 File Offset: 0x00E40777
		// (set) Token: 0x06032C5D RID: 207965 RVA: 0x00E4257F File Offset: 0x00E4077F
		private IActivityCategoryTabData Data { get; set; }

		// Token: 0x170062C2 RID: 25282
		// (get) Token: 0x06032C5E RID: 207966 RVA: 0x00E42588 File Offset: 0x00E40788
		// (set) Token: 0x06032C5F RID: 207967 RVA: 0x00E42590 File Offset: 0x00E40790
		private TOnToggleClickCb OnToggleClick { get; set; }

		// Token: 0x170062C3 RID: 25283
		// (get) Token: 0x06032C60 RID: 207968 RVA: 0x00E42599 File Offset: 0x00E40799
		// (set) Token: 0x06032C61 RID: 207969 RVA: 0x00E425A1 File Offset: 0x00E407A1
		private CategoryToggleItem TabItem { get; set; }

		// Token: 0x06032C62 RID: 207970 RVA: 0x00E425AC File Offset: 0x00E407AC
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

		// Token: 0x06032C63 RID: 207971 RVA: 0x00E42618 File Offset: 0x00E40818
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

		// Token: 0x06032C64 RID: 207972 RVA: 0x00E42663 File Offset: 0x00E40863
		protected override void OnBeforeShow()
		{
			this.RefreshRedDotIds();
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshRedDot));
		}

		// Token: 0x06032C65 RID: 207973 RVA: 0x00E42687 File Offset: 0x00E40887
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshRedDot));
		}

		// Token: 0x06032C66 RID: 207974 RVA: 0x00E426A5 File Offset: 0x00E408A5
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data = null;
			}
			this.RedDotStateMap.Clear();
		}

		// Token: 0x06032C67 RID: 207975 RVA: 0x00E426C1 File Offset: 0x00E408C1
		private void OnTabItemClicked(EToggleState state)
		{
			TOnToggleClickCb onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this.Data, this.TabItem.GetTabToggle(), state);
		}

		// Token: 0x06032C68 RID: 207976 RVA: 0x00E426E5 File Offset: 0x00E408E5
		public void ClearItem()
		{
		}

		// Token: 0x06032C69 RID: 207977 RVA: 0x00E426E7 File Offset: 0x00E408E7
		[NullableContext(1)]
		public AUIBaseActor GetUsingItem(IActivityCategoryTabData data)
		{
			if (data.IsLineType)
			{
				return base.GetItem(1).GetOwner() as AUIBaseActor;
			}
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x06032C6A RID: 207978 RVA: 0x00E42714 File Offset: 0x00E40914
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
			List<int> list = new List<int>();
			foreach (ActivityBaseData activityBaseData in data.Activities)
			{
				list.Add(activityBaseData.Id);
			}
			this.BindRedDotIds(list);
		}

		// Token: 0x06032C6B RID: 207979 RVA: 0x00E42798 File Offset: 0x00E40998
		[NullableContext(1)]
		public void InitData(IActivityCategoryTabData data)
		{
			this.Data = data;
		}

		// Token: 0x06032C6C RID: 207980 RVA: 0x00E427A1 File Offset: 0x00E409A1
		[NullableContext(1)]
		public void SetOnToggleClicked(TOnToggleClickCb onToggleSelected)
		{
			this.OnToggleClick = onToggleSelected;
		}

		// Token: 0x06032C6D RID: 207981 RVA: 0x00E427AA File Offset: 0x00E409AA
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

		// Token: 0x06032C6E RID: 207982 RVA: 0x00E427CA File Offset: 0x00E409CA
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

		// Token: 0x06032C6F RID: 207983 RVA: 0x00E42806 File Offset: 0x00E40A06
		public void OnSelected(bool fireEvent)
		{
			CategoryToggleItem tabItem = this.TabItem;
			if (tabItem == null)
			{
				return;
			}
			tabItem.GetTabToggle().SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x170062C4 RID: 25284
		// (get) Token: 0x06032C70 RID: 207984 RVA: 0x00E42821 File Offset: 0x00E40A21
		// (set) Token: 0x06032C71 RID: 207985 RVA: 0x00E42829 File Offset: 0x00E40A29
		[Nullable(1)]
		private Dictionary<int, bool> RedDotStateMap { [NullableContext(1)] get; [NullableContext(1)] set; } = new Dictionary<int, bool>();

		// Token: 0x170062C5 RID: 25285
		// (get) Token: 0x06032C72 RID: 207986 RVA: 0x00E42832 File Offset: 0x00E40A32
		// (set) Token: 0x06032C73 RID: 207987 RVA: 0x00E4283A File Offset: 0x00E40A3A
		private int RedDotCount { get; set; }

		// Token: 0x06032C74 RID: 207988 RVA: 0x00E42844 File Offset: 0x00E40A44
		private void RefreshRedDotIds()
		{
			foreach (int activityId in this.RedDotStateMap.Keys)
			{
				this.RefreshRedDot(activityId);
			}
		}

		// Token: 0x06032C75 RID: 207989 RVA: 0x00E4289C File Offset: 0x00E40A9C
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

		// Token: 0x06032C76 RID: 207990 RVA: 0x00E428FC File Offset: 0x00E40AFC
		public void SetRedDotState(bool bVisible)
		{
			this.TabItem.SetRedDotState(bVisible);
		}

		// Token: 0x06032C77 RID: 207991 RVA: 0x00E4290C File Offset: 0x00E40B0C
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

		// Token: 0x06032C78 RID: 207992 RVA: 0x00E4295B File Offset: 0x00E40B5B
		private bool GetActivityRedDotState(int id)
		{
			return ActivityModel.Instance.GetActivityRedDotState(id);
		}

		// Token: 0x06032C79 RID: 207993 RVA: 0x00E42968 File Offset: 0x00E40B68
		[NullableContext(1)]
		public void BindRedDotIds(IEnumerable<int> redDotIds)
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

		// Token: 0x0200AC42 RID: 44098
		[NullableContext(0)]
		private class ECategoryComponents
		{
			// Token: 0x040354C9 RID: 218313
			public const int ItemTypeTitle = 1;

			// Token: 0x040354CA RID: 218314
			public const int PanelTab = 0;
		}
	}
}
