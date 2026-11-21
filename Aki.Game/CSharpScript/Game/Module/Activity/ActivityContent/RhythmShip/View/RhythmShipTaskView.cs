using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051DB RID: 20955
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipTaskView : UiViewBase
	{
		// Token: 0x0603435F RID: 213855 RVA: 0x00E9BA20 File Offset: 0x00E99C20
		public RhythmShipTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034360 RID: 213856 RVA: 0x00E9BA34 File Offset: 0x00E99C34
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06034361 RID: 213857 RVA: 0x00E9BABA File Offset: 0x00E99CBA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x06034362 RID: 213858 RVA: 0x00E9BAD8 File Offset: 0x00E99CD8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x06034363 RID: 213859 RVA: 0x00E9BAF8 File Offset: 0x00E99CF8
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipTaskView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipTaskView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034364 RID: 213860 RVA: 0x00E9BB3C File Offset: 0x00E99D3C
		protected override void OnStart()
		{
			List<int> rhythmShipTaskIdByTypeAndActivityId = RhythmShipConfig.Instance.GetRhythmShipTaskIdByTypeAndActivityId(0, RhythmShipModel.Instance.ActivityId);
			int num = 0;
			foreach (int num2 in rhythmShipTaskIdByTypeAndActivityId)
			{
				RhythmTask? rhythmTask;
				int? num3 = (RhythmShipConfig.Instance.GetRhythmShipTaskById(num2) != null) ? new int?(rhythmTask.GetValueOrDefault().TaskTab) : null;
				if (num3 != null && num3.Value != 0)
				{
					if (num == 0)
					{
						num = num3.Value;
					}
					List<int> list;
					if (!this.TaskTabMap.TryGetValue(num3.Value, out list))
					{
						list = new List<int>();
					}
					list.Add(num2);
					this.TaskTabMap[num3.Value] = list;
				}
			}
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			LoopScrollView<RhythmShipTaskTabItem, int> taskTabScrollView = this.TaskTabScrollView;
			if (taskTabScrollView == null)
			{
				return;
			}
			taskTabScrollView.RefreshByData(activityData.TaskTabList, true, delegate
			{
				this.TaskTabScrollView.SelectGridProxy(0, false);
			}, true);
		}

		// Token: 0x06034365 RID: 213861 RVA: 0x00E9BC64 File Offset: 0x00E99E64
		private void OnClickTaskTab(int tabId, UUIExtendToggle toggle)
		{
			if (this.CurrentTabId == tabId)
			{
				return;
			}
			this.CurrentTabId = tabId;
			UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
			if (currentSelectToggle != null)
			{
				currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectToggle = toggle;
			this.RefreshTaskScrollView();
		}

		// Token: 0x06034366 RID: 213862 RVA: 0x00E9BC9C File Offset: 0x00E99E9C
		private void RefreshTaskScrollView()
		{
			List<int> list;
			this.TaskTabMap.TryGetValue(this.CurrentTabId, out list);
			list = (list ?? new List<int>());
			List<int> data = RhythmShipModel.Instance.SortTaskItem(list, false);
			GenericScrollViewNew<RhythmShipTaskItem, int> taskScrollView = this.TaskScrollView;
			if (taskScrollView == null)
			{
				return;
			}
			taskScrollView.RefreshByData(data, null, true);
		}

		// Token: 0x06034367 RID: 213863 RVA: 0x00E9BCE8 File Offset: 0x00E99EE8
		private void OnRhythmShipTaskRefresh()
		{
			this.RefreshTaskScrollView();
		}

		// Token: 0x0401BB3B RID: 113467
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BB3C RID: 113468
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RhythmShipTaskItem, int> TaskScrollView;

		// Token: 0x0401BB3D RID: 113469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<RhythmShipTaskTabItem, int> TaskTabScrollView;

		// Token: 0x0401BB3E RID: 113470
		private readonly Dictionary<int, List<int>> TaskTabMap = new Dictionary<int, List<int>>();

		// Token: 0x0401BB3F RID: 113471
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401BB40 RID: 113472
		private int CurrentTabId;
	}
}
