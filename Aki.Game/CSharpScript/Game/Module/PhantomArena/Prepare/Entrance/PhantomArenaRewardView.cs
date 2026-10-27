using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200517D RID: 20861
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRewardView : UiViewBase
	{
		// Token: 0x0603558F RID: 218511 RVA: 0x00CA37B0 File Offset: 0x00CA19B0
		public PhantomArenaRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035590 RID: 218512 RVA: 0x00CA37D0 File Offset: 0x00CA19D0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnDetailBtnClick)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnRewardBtnClick))
			};
		}

		// Token: 0x06035591 RID: 218513 RVA: 0x00CA38D3 File Offset: 0x00CA1AD3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x06035592 RID: 218514 RVA: 0x00CA38F1 File Offset: 0x00CA1AF1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x06035593 RID: 218515 RVA: 0x00CA3910 File Offset: 0x00CA1B10
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRewardView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRewardView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035594 RID: 218516 RVA: 0x00CA3954 File Offset: 0x00CA1B54
		private void RefreshLeftButton()
		{
			this.SpecialTask = PhantomArenaModel.Instance.GetSpecialTask(this.ActivityId);
			if (this.SpecialTask != null)
			{
				UUIButtonComponent button = base.GetButton(6);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(this.SpecialTask.Status != ActivityTaskState.ActivityTaskFinish);
				}
				UUIButtonComponent button2 = base.GetButton(5);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(this.SpecialTask.Status == ActivityTaskState.ActivityTaskFinish);
				}
				PhantomBattleTask? taskConfigById = PhantomArenaConfig.Instance.GetTaskConfigById(this.SpecialTask.Id);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), taskConfigById.Value.Desc, Array.Empty<object>());
			}
		}

		// Token: 0x06035595 RID: 218517 RVA: 0x00CA3A1C File Offset: 0x00CA1C1C
		private void RefreshScrollView(int tabIndex)
		{
			this.DataList.Clear();
			this.DataList = PhantomArenaModel.Instance.GetTaskDataByTabId(tabIndex, this.ActivityId);
			this.TaskLayout.RefreshByData(this.DataList, delegate
			{
				this.TaskLayout.ScrollToTop(0);
			}, true);
		}

		// Token: 0x06035596 RID: 218518 RVA: 0x00CA3A69 File Offset: 0x00CA1C69
		private PhantomBattleTaskTabItem CreateTaskTabItem()
		{
			return new PhantomBattleTaskTabItem
			{
				OnClickedCb = new Action<int>(this.OnClickTab),
				ActivityId = this.ActivityId
			};
		}

		// Token: 0x06035597 RID: 218519 RVA: 0x00CA3A90 File Offset: 0x00CA1C90
		private void OnClickTab(int index)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TabLayout.GetLayoutItemByIndex(i).SetToggleState(index == this.TabTypeList[i], false);
			}
			this.CurrentTypeIndex = index;
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x06035598 RID: 218520 RVA: 0x00CA3AE8 File Offset: 0x00CA1CE8
		private void OnGetRewardUpdate(int activityId)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TabLayout.GetLayoutItemByIndex(i).RefreshRedDot();
			}
			this.RefreshScrollView(this.CurrentTypeIndex);
			this.RefreshLeftButton();
		}

		// Token: 0x06035599 RID: 218521 RVA: 0x00CA3B2E File Offset: 0x00CA1D2E
		private PhantomBattleTaskItem CreateTaskItem()
		{
			return new PhantomBattleTaskItem();
		}

		// Token: 0x0603559A RID: 218522 RVA: 0x00CA3B38 File Offset: 0x00CA1D38
		private void OnDetailBtnClick()
		{
			int rewardItemId = PhantomArenaModel.Instance.GetRewardItemId(this.ActivityId);
			ItemController.Instance.OpenItemTipsByItemId(rewardItemId, true, null);
		}

		// Token: 0x0603559B RID: 218523 RVA: 0x00CA3B64 File Offset: 0x00CA1D64
		private void OnRewardBtnClick()
		{
			if (this.SpecialTask != null)
			{
				PhantomArenaController.Instance.TaskRewardRequest(this.SpecialTask.Id);
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.CXJ, "特殊奖励不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603559C RID: 218524 RVA: 0x00CA3BAE File Offset: 0x00CA1DAE
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C5C5 RID: 116165
		private int ActivityId;

		// Token: 0x0401C5C6 RID: 116166
		private GenericLayout<PhantomBattleTaskTabItem, int> TabLayout;

		// Token: 0x0401C5C7 RID: 116167
		private GenericScrollViewNew<PhantomBattleTaskItem, PhantomArenaTaskData> TaskLayout;

		// Token: 0x0401C5C8 RID: 116168
		private int CurrentTypeIndex;

		// Token: 0x0401C5C9 RID: 116169
		protected List<int> TabTypeList = new List<int>();

		// Token: 0x0401C5CA RID: 116170
		private List<PhantomArenaTaskData> DataList = new List<PhantomArenaTaskData>();

		// Token: 0x0401C5CB RID: 116171
		[Nullable(2)]
		private ActivityTask SpecialTask;

		// Token: 0x0200B2F0 RID: 45808
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040363A6 RID: 222118
			public const int ItemCaption = 0;

			// Token: 0x040363A7 RID: 222119
			public const int ScrollLayoutTask = 1;

			// Token: 0x040363A8 RID: 222120
			public const int ItemTask = 2;

			// Token: 0x040363A9 RID: 222121
			public const int LayoutTab = 3;

			// Token: 0x040363AA RID: 222122
			public const int TextTip = 4;

			// Token: 0x040363AB RID: 222123
			public const int BtnReward = 5;

			// Token: 0x040363AC RID: 222124
			public const int BtnDetail = 6;

			// Token: 0x040363AD RID: 222125
			public const int TextTime = 7;
		}
	}
}
