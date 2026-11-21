using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200413A RID: 16698
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceTaskTabView : UiTabViewBase
	{
		// Token: 0x0602A388 RID: 172936 RVA: 0x00BEB89C File Offset: 0x00BE9A9C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602A389 RID: 172937 RVA: 0x00BEB8F8 File Offset: 0x00BE9AF8
		protected override void OnStart()
		{
			this.ActivityId = (int)this.ExtraParams;
			this.TaskTabLayout = new GenericLayout<PhantomBattleTaskTabItem, int>(base.GetHorizontalLayout(0), new Func<PhantomBattleTaskTabItem>(this.InitTaskItem), null, false, true);
			this.ScrollView = new LoopScrollView<PhantomBattleTaskItem, PhantomArenaTaskData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PhantomBattleTaskItem>(this.OnCreateTaskItem), false);
		}

		// Token: 0x0602A38A RID: 172938 RVA: 0x00BEB967 File Offset: 0x00BE9B67
		protected override void OnBeforeDestroy()
		{
			this.TaskTabLayout = null;
			this.ScrollView = null;
		}

		// Token: 0x0602A38B RID: 172939 RVA: 0x00BEB978 File Offset: 0x00BE9B78
		protected override void OnBeforeShow()
		{
			List<int> list = this.CreateTabItemDataList();
			this.CurrentTypeIndex = ((list.Count > 0) ? list[0] : 0);
			GenericLayout<PhantomBattleTaskTabItem, int> taskTabLayout = this.TaskTabLayout;
			if (taskTabLayout == null)
			{
				return;
			}
			taskTabLayout.RefreshByData(list, delegate
			{
				this.OnClickTab(this.CurrentTypeIndex);
			}, false);
		}

		// Token: 0x0602A38C RID: 172940 RVA: 0x00BEB9C3 File Offset: 0x00BE9BC3
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x0602A38D RID: 172941 RVA: 0x00BEB9E1 File Offset: 0x00BE9BE1
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x0602A38E RID: 172942 RVA: 0x00BEB9FF File Offset: 0x00BE9BFF
		private PhantomBattleTaskTabItem InitTaskItem()
		{
			return new PhantomBattleTaskTabItem
			{
				OnClickedCb = new Action<int>(this.OnClickTab),
				ActivityId = this.ActivityId
			};
		}

		// Token: 0x0602A38F RID: 172943 RVA: 0x00BEBA24 File Offset: 0x00BE9C24
		private void OnClickTab(int index)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TaskTabLayout.GetLayoutItemByIndex(i).SetToggleState(index == this.TabTypeList[i], false);
			}
			this.CurrentTypeIndex = index;
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x0602A390 RID: 172944 RVA: 0x00BEBA7C File Offset: 0x00BE9C7C
		private void OnGetRewardUpdate(int activityId)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TaskTabLayout.GetLayoutItemByIndex(i).RefreshRedDot();
			}
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x0602A391 RID: 172945 RVA: 0x00BEBABD File Offset: 0x00BE9CBD
		private PhantomBattleTaskItem OnCreateTaskItem()
		{
			return new PhantomBattleTaskItem();
		}

		// Token: 0x0602A392 RID: 172946 RVA: 0x00BEBAC4 File Offset: 0x00BE9CC4
		private List<int> CreateTabItemDataList()
		{
			this.TabTypeList = PhantomArenaModel.Instance.GetTaskTabList(this.ActivityId);
			this.CurrentTypeIndex = 0;
			return this.TabTypeList;
		}

		// Token: 0x0602A393 RID: 172947 RVA: 0x00BEBAEC File Offset: 0x00BE9CEC
		private UniTask RefreshScrollView(int tabIndex)
		{
			PhantomArenaEntranceTaskTabView.<RefreshScrollView>d__18 <RefreshScrollView>d__;
			<RefreshScrollView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshScrollView>d__.<>4__this = this;
			<RefreshScrollView>d__.tabIndex = tabIndex;
			<RefreshScrollView>d__.<>1__state = -1;
			<RefreshScrollView>d__.<>t__builder.Start<PhantomArenaEntranceTaskTabView.<RefreshScrollView>d__18>(ref <RefreshScrollView>d__);
			return <RefreshScrollView>d__.<>t__builder.Task;
		}

		// Token: 0x04016FAF RID: 94127
		protected int ActivityId;

		// Token: 0x04016FB0 RID: 94128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PhantomBattleTaskTabItem, int> TaskTabLayout;

		// Token: 0x04016FB1 RID: 94129
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomBattleTaskItem, PhantomArenaTaskData> ScrollView;

		// Token: 0x04016FB2 RID: 94130
		private int CurrentTypeIndex;

		// Token: 0x04016FB3 RID: 94131
		protected List<int> TabTypeList = new List<int>();

		// Token: 0x04016FB4 RID: 94132
		private List<PhantomArenaTaskData> DataList = new List<PhantomArenaTaskData>();

		// Token: 0x02009D06 RID: 40198
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04030D1B RID: 199963
			public const int PanelHorizon = 0;

			// Token: 0x04030D1C RID: 199964
			public const int SvList = 1;

			// Token: 0x04030D1D RID: 199965
			public const int TaskItem = 2;
		}
	}
}
