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
	// Token: 0x0200625D RID: 25181
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipTaskView : UiViewBase
	{
		// Token: 0x0603F69E RID: 259742 RVA: 0x00F54AC4 File Offset: 0x00F52CC4
		public RhythmShipTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F69F RID: 259743 RVA: 0x00F54AD8 File Offset: 0x00F52CD8
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

		// Token: 0x0603F6A0 RID: 259744 RVA: 0x00F54B5E File Offset: 0x00F52D5E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x0603F6A1 RID: 259745 RVA: 0x00F54B7C File Offset: 0x00F52D7C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x0603F6A2 RID: 259746 RVA: 0x00F54B9C File Offset: 0x00F52D9C
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipTaskView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipTaskView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F6A3 RID: 259747 RVA: 0x00F54BE0 File Offset: 0x00F52DE0
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

		// Token: 0x0603F6A4 RID: 259748 RVA: 0x00F54D08 File Offset: 0x00F52F08
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

		// Token: 0x0603F6A5 RID: 259749 RVA: 0x00F54D40 File Offset: 0x00F52F40
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

		// Token: 0x0603F6A6 RID: 259750 RVA: 0x00F54D8C File Offset: 0x00F52F8C
		private void OnRhythmShipTaskRefresh()
		{
			this.RefreshTaskScrollView();
		}

		// Token: 0x0402120C RID: 135692
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402120D RID: 135693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RhythmShipTaskItem, int> TaskScrollView;

		// Token: 0x0402120E RID: 135694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<RhythmShipTaskTabItem, int> TaskTabScrollView;

		// Token: 0x0402120F RID: 135695
		private readonly Dictionary<int, List<int>> TaskTabMap = new Dictionary<int, List<int>>();

		// Token: 0x04021210 RID: 135696
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x04021211 RID: 135697
		private int CurrentTabId;
	}
}
