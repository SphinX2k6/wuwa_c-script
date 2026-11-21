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
	// Token: 0x0200414D RID: 16717
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRewardView : UiViewBase
	{
		// Token: 0x0602A48A RID: 173194 RVA: 0x00BF0D68 File Offset: 0x00BEEF68
		public PhantomArenaRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602A48B RID: 173195 RVA: 0x00BF0D88 File Offset: 0x00BEEF88
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

		// Token: 0x0602A48C RID: 173196 RVA: 0x00BF0E8B File Offset: 0x00BEF08B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x0602A48D RID: 173197 RVA: 0x00BF0EA9 File Offset: 0x00BEF0A9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(this.OnGetRewardUpdate));
		}

		// Token: 0x0602A48E RID: 173198 RVA: 0x00BF0EC8 File Offset: 0x00BEF0C8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRewardView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRewardView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A48F RID: 173199 RVA: 0x00BF0F0C File Offset: 0x00BEF10C
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

		// Token: 0x0602A490 RID: 173200 RVA: 0x00BF0FD4 File Offset: 0x00BEF1D4
		private void RefreshScrollView(int tabIndex)
		{
			this.DataList.Clear();
			this.DataList = PhantomArenaModel.Instance.GetTaskDataByTabId(tabIndex, this.ActivityId);
			this.TaskLayout.RefreshByData(this.DataList, delegate
			{
				this.TaskLayout.ScrollToTop(0);
			}, true);
		}

		// Token: 0x0602A491 RID: 173201 RVA: 0x00BF1021 File Offset: 0x00BEF221
		private PhantomBattleTaskTabItem CreateTaskTabItem()
		{
			return new PhantomBattleTaskTabItem
			{
				OnClickedCb = new Action<int>(this.OnClickTab),
				ActivityId = this.ActivityId
			};
		}

		// Token: 0x0602A492 RID: 173202 RVA: 0x00BF1048 File Offset: 0x00BEF248
		private void OnClickTab(int index)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TabLayout.GetLayoutItemByIndex(i).SetToggleState(index == this.TabTypeList[i], false);
			}
			this.CurrentTypeIndex = index;
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x0602A493 RID: 173203 RVA: 0x00BF10A0 File Offset: 0x00BEF2A0
		private void OnGetRewardUpdate(int activityId)
		{
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TabLayout.GetLayoutItemByIndex(i).RefreshRedDot();
			}
			this.RefreshScrollView(this.CurrentTypeIndex);
			this.RefreshLeftButton();
		}

		// Token: 0x0602A494 RID: 173204 RVA: 0x00BF10E6 File Offset: 0x00BEF2E6
		private PhantomBattleTaskItem CreateTaskItem()
		{
			return new PhantomBattleTaskItem();
		}

		// Token: 0x0602A495 RID: 173205 RVA: 0x00BF10F0 File Offset: 0x00BEF2F0
		private void OnDetailBtnClick()
		{
			int rewardItemId = PhantomArenaModel.Instance.GetRewardItemId(this.ActivityId);
			ItemController.Instance.OpenItemTipsByItemId(rewardItemId, true, null, false);
		}

		// Token: 0x0602A496 RID: 173206 RVA: 0x00BF111C File Offset: 0x00BEF31C
		private void OnRewardBtnClick()
		{
			if (this.SpecialTask != null)
			{
				PhantomArenaController.Instance.TaskRewardRequest(this.SpecialTask.Id);
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.CXJ, "特殊奖励不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602A497 RID: 173207 RVA: 0x00BF1166 File Offset: 0x00BEF366
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04016FFA RID: 94202
		private int ActivityId;

		// Token: 0x04016FFB RID: 94203
		private GenericLayout<PhantomBattleTaskTabItem, int> TabLayout;

		// Token: 0x04016FFC RID: 94204
		private GenericScrollViewNew<PhantomBattleTaskItem, PhantomArenaTaskData> TaskLayout;

		// Token: 0x04016FFD RID: 94205
		private int CurrentTypeIndex;

		// Token: 0x04016FFE RID: 94206
		protected List<int> TabTypeList = new List<int>();

		// Token: 0x04016FFF RID: 94207
		private List<PhantomArenaTaskData> DataList = new List<PhantomArenaTaskData>();

		// Token: 0x04017000 RID: 94208
		[Nullable(2)]
		private ActivityTask SpecialTask;

		// Token: 0x02009D29 RID: 40233
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030DFB RID: 200187
			public const int ItemCaption = 0;

			// Token: 0x04030DFC RID: 200188
			public const int ScrollLayoutTask = 1;

			// Token: 0x04030DFD RID: 200189
			public const int ItemTask = 2;

			// Token: 0x04030DFE RID: 200190
			public const int LayoutTab = 3;

			// Token: 0x04030DFF RID: 200191
			public const int TextTip = 4;

			// Token: 0x04030E00 RID: 200192
			public const int BtnReward = 5;

			// Token: 0x04030E01 RID: 200193
			public const int BtnDetail = 6;

			// Token: 0x04030E02 RID: 200194
			public const int TextTime = 7;
		}
	}
}
