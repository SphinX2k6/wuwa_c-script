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
	// Token: 0x0200516A RID: 20842
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceTaskTabView : UiTabViewBase
	{
		// Token: 0x0603548C RID: 218252 RVA: 0x00C9E350 File Offset: 0x00C9C550
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603548D RID: 218253 RVA: 0x00C9E3AC File Offset: 0x00C9C5AC
		protected override void OnStart()
		{
			this.ActivityId = (int)this.ExtraParams;
			this.TaskTabLayout = new GenericLayout<PhantomBattleTaskTabItem, int>(base.GetHorizontalLayout(0), new Func<PhantomBattleTaskTabItem>(this.InitTaskItem), null, false, true);
			this.ScrollView = new LoopScrollView<PhantomBattleTaskItem, PhantomArenaTaskData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PhantomBattleTaskItem>(this.OnCreateTaskItem), false);
		}

		// Token: 0x0603548E RID: 218254 RVA: 0x00C9E41B File Offset: 0x00C9C61B
		protected override void OnBeforeDestroy()
		{
			this.TaskTabLayout = null;
			this.ScrollView = null;
		}

		// Token: 0x0603548F RID: 218255 RVA: 0x00C9E42C File Offset: 0x00C9C62C
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

		// Token: 0x06035490 RID: 218256 RVA: 0x00C9E477 File Offset: 0x00C9C677
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x06035491 RID: 218257 RVA: 0x00C9E495 File Offset: 0x00C9C695
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x06035492 RID: 218258 RVA: 0x00C9E4B3 File Offset: 0x00C9C6B3
		private PhantomBattleTaskTabItem InitTaskItem()
		{
			return new PhantomBattleTaskTabItem
			{
				OnClickedCb = new Action<int>(this.OnClickTab),
				ActivityId = this.ActivityId
			};
		}

		// Token: 0x06035493 RID: 218259 RVA: 0x00C9E4D8 File Offset: 0x00C9C6D8
		private void OnClickTab(int index)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TaskTabLayout.GetLayoutItemByIndex(i).SetToggleState(index == this.TabTypeList[i], false);
			}
			this.CurrentTypeIndex = index;
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x06035494 RID: 218260 RVA: 0x00C9E530 File Offset: 0x00C9C730
		private void OnGetRewardUpdate(int activityId)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TaskTabLayout.GetLayoutItemByIndex(i).RefreshRedDot();
			}
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x06035495 RID: 218261 RVA: 0x00C9E571 File Offset: 0x00C9C771
		private PhantomBattleTaskItem OnCreateTaskItem()
		{
			return new PhantomBattleTaskItem();
		}

		// Token: 0x06035496 RID: 218262 RVA: 0x00C9E578 File Offset: 0x00C9C778
		private List<int> CreateTabItemDataList()
		{
			this.TabTypeList = PhantomArenaModel.Instance.GetTaskTabList(this.ActivityId);
			this.CurrentTypeIndex = 0;
			return this.TabTypeList;
		}

		// Token: 0x06035497 RID: 218263 RVA: 0x00C9E5A0 File Offset: 0x00C9C7A0
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

		// Token: 0x0401C57A RID: 116090
		protected int ActivityId;

		// Token: 0x0401C57B RID: 116091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PhantomBattleTaskTabItem, int> TaskTabLayout;

		// Token: 0x0401C57C RID: 116092
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomBattleTaskItem, PhantomArenaTaskData> ScrollView;

		// Token: 0x0401C57D RID: 116093
		private int CurrentTypeIndex;

		// Token: 0x0401C57E RID: 116094
		protected List<int> TabTypeList = new List<int>();

		// Token: 0x0401C57F RID: 116095
		private List<PhantomArenaTaskData> DataList = new List<PhantomArenaTaskData>();

		// Token: 0x0200B2CC RID: 45772
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040362C4 RID: 221892
			public const int PanelHorizon = 0;

			// Token: 0x040362C5 RID: 221893
			public const int SvList = 1;

			// Token: 0x040362C6 RID: 221894
			public const int TaskItem = 2;
		}
	}
}
