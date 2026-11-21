using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005379 RID: 21369
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourRewardView : UiTickViewBase
	{
		// Token: 0x060352AE RID: 217774 RVA: 0x00ED92DA File Offset: 0x00ED74DA
		public MotorParkourRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060352AF RID: 217775 RVA: 0x00ED92F0 File Offset: 0x00ED74F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060352B0 RID: 217776 RVA: 0x00ED93DD File Offset: 0x00ED75DD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060352B1 RID: 217777 RVA: 0x00ED93FB File Offset: 0x00ED75FB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060352B2 RID: 217778 RVA: 0x00ED941C File Offset: 0x00ED761C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourRewardView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourRewardView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352B3 RID: 217779 RVA: 0x00ED9460 File Offset: 0x00ED7660
		protected override void OnTick(float delta)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, localTextNew);
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x060352B4 RID: 217780 RVA: 0x00ED94A4 File Offset: 0x00ED76A4
		private void RefreshTaskLayout()
		{
			List<MotorParkourTaskData> taskList = this.CurLevelData.TaskList;
			this.TaskScrollView.RefreshByData(taskList, false, delegate
			{
				this.TaskScrollView.ScrollToGridIndex(0, true);
			}, true);
		}

		// Token: 0x060352B5 RID: 217781 RVA: 0x00ED94D7 File Offset: 0x00ED76D7
		private void OnRefreshCommonActivityRedDot(int _)
		{
			this.TabScrollView.RefreshAllGridProxies();
			this.RefreshTaskLayout();
		}

		// Token: 0x060352B6 RID: 217782 RVA: 0x00ED94EC File Offset: 0x00ED76EC
		private void OnTabClickCallBack(MotorParkourLevelData tab)
		{
			this.CurLevelData = tab2;
			int gridIndex = this.TabList.FindIndex((MotorParkourLevelData tab) => tab.Id == this.CurLevelData.Id);
			this.TabScrollView.SelectGridProxy(gridIndex, false);
			this.RefreshTaskLayout();
		}

		// Token: 0x060352B7 RID: 217783 RVA: 0x00ED952B File Offset: 0x00ED772B
		private MotorParkourTaskTabItem CreateTabItem()
		{
			return new MotorParkourTaskTabItem
			{
				OnToggleCallback = new Action<MotorParkourLevelData>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x060352B8 RID: 217784 RVA: 0x00ED9544 File Offset: 0x00ED7744
		private MotorParkourTaskItem OnCreateTaskItem()
		{
			return new MotorParkourTaskItem();
		}

		// Token: 0x060352B9 RID: 217785 RVA: 0x00ED954B File Offset: 0x00ED774B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C0DE RID: 114910
		private MotorParkourActivityData ActivityData;

		// Token: 0x0401C0DF RID: 114911
		private List<MotorParkourLevelData> TabList = new List<MotorParkourLevelData>();

		// Token: 0x0401C0E0 RID: 114912
		private MotorParkourLevelData CurLevelData;

		// Token: 0x0401C0E1 RID: 114913
		private LoopScrollView<MotorParkourTaskTabItem, MotorParkourLevelData> TabScrollView;

		// Token: 0x0401C0E2 RID: 114914
		private LoopScrollView<MotorParkourTaskItem, MotorParkourTaskData> TaskScrollView;

		// Token: 0x0200B002 RID: 45058
		public interface IMotorParkourRewardViewData
		{
			// Token: 0x17007A1F RID: 31263
			// (get) Token: 0x06047182 RID: 291202
			// (set) Token: 0x06047183 RID: 291203
			MotorParkourActivityData ActivityData { get; set; }

			// Token: 0x17007A20 RID: 31264
			// (get) Token: 0x06047184 RID: 291204
			// (set) Token: 0x06047185 RID: 291205
			MotorParkourLevelData SelectLevelData { get; set; }
		}

		// Token: 0x0200B003 RID: 45059
		[Nullable(0)]
		public class MotorParkourRewardViewData : MotorParkourRewardView.IMotorParkourRewardViewData
		{
			// Token: 0x17007A21 RID: 31265
			// (get) Token: 0x06047186 RID: 291206 RVA: 0x01583B0A File Offset: 0x01581D0A
			// (set) Token: 0x06047187 RID: 291207 RVA: 0x01583B12 File Offset: 0x01581D12
			public MotorParkourActivityData ActivityData { get; set; }

			// Token: 0x17007A22 RID: 31266
			// (get) Token: 0x06047188 RID: 291208 RVA: 0x01583B1B File Offset: 0x01581D1B
			// (set) Token: 0x06047189 RID: 291209 RVA: 0x01583B23 File Offset: 0x01581D23
			public MotorParkourLevelData SelectLevelData { get; set; }
		}

		// Token: 0x0200B004 RID: 45060
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403665A RID: 222810
			public const int ItemCaption = 0;

			// Token: 0x0403665B RID: 222811
			public const int LoopScrollLayoutTab = 1;

			// Token: 0x0403665C RID: 222812
			public const int ItemContent = 2;

			// Token: 0x0403665D RID: 222813
			public const int ItemTab = 3;

			// Token: 0x0403665E RID: 222814
			public const int LoopScrollLayoutTask = 4;

			// Token: 0x0403665F RID: 222815
			public const int ItemContent2 = 5;

			// Token: 0x04036660 RID: 222816
			public const int ItemTask = 6;

			// Token: 0x04036661 RID: 222817
			public const int TextRemainTime = 7;
		}
	}
}
