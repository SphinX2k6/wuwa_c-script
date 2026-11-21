using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A93 RID: 19091
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkWorldRunTaskItem : GridProxyAbstract<DreamLinkRunTaskData>
	{
		// Token: 0x0602FC6D RID: 195693 RVA: 0x00D54234 File Offset: 0x00D52434
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FC6E RID: 195694 RVA: 0x00D54408 File Offset: 0x00D52608
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
			base.GetItem(2).SetUIActive(false);
			this.JumpButton = new ButtonItem(base.GetItem(0));
			this.JumpButton.SetFunction(new Action<int>(this.OnClickJump));
		}

		// Token: 0x0602FC6F RID: 195695 RVA: 0x00D5446C File Offset: 0x00D5266C
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0602FC70 RID: 195696 RVA: 0x00D54474 File Offset: 0x00D52674
		public override void Refresh(DreamLinkRunTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TitleTextId, Array.Empty<object>());
			this.RewardScrollView.RefreshByData(data.GetRewardData(), null, false);
			bool flag = data.Status == EDreamLinkRunTaskState.Lock;
			bool flag2 = data.Status == EDreamLinkRunTaskState.Active;
			bool flag3 = data.Status == EDreamLinkRunTaskState.FinishedAndClaimed;
			bool flag4 = data.Status == EDreamLinkRunTaskState.FinishedAndUnclaimed;
			base.GetItem(4).SetUIActive(flag);
			if (flag)
			{
				base.GetText(5).SetText(data.GetLockTxt(), true);
			}
			base.GetItem(8).SetUIActive(flag3 || flag4);
			if (flag3 || flag4)
			{
				base.GetText(9).SetText(TimeUtil.Instance.GetTimeString((double)Math.Max(data.PlayTime, 0)), true);
			}
			if (flag2)
			{
				this.JumpButton.SetLocalTextNew("WorldRun_Button_State1", Array.Empty<object>());
			}
			else if (flag3)
			{
				this.JumpButton.SetLocalTextNew("WorldRun_Button_State2", Array.Empty<object>());
			}
			this.NeedTick = data.IsTimeLock();
			this.JumpButton.SetActive(flag2 || flag3);
			base.GetButton(1).RootUIComp.Get().SetUIActive(flag4);
			this.RefreshRedDot();
		}

		// Token: 0x0602FC71 RID: 195697 RVA: 0x00D545A8 File Offset: 0x00D527A8
		public void RefreshLockText()
		{
			if (this.Data == null || this.Data.Status != EDreamLinkRunTaskState.Lock)
			{
				return;
			}
			if (!this.NeedTick)
			{
				return;
			}
			base.GetText(5).SetText(this.Data.GetLockTxt(), true);
		}

		// Token: 0x0602FC72 RID: 195698 RVA: 0x00D545E4 File Offset: 0x00D527E4
		private void RefreshRedDot()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			bool flag = this.Data.Status == EDreamLinkRunTaskState.Active;
			bool runRedDotState = currentActivityData.GetRunRedDotState(this.Data.Id);
			if (flag)
			{
				this.JumpButton.SetRedDotVisible(runRedDotState);
			}
		}

		// Token: 0x0602FC73 RID: 195699 RVA: 0x00D5462A File Offset: 0x00D5282A
		private void OnClickJump(int _)
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData != null)
			{
				currentActivityData.SaveFirstCheckRedDotState(1, this.Data.Id);
			}
			this.RefreshRedDot();
			this.Data.JumpDelegate();
		}

		// Token: 0x0602FC74 RID: 195700 RVA: 0x00D5465E File Offset: 0x00D5285E
		private void OnClickGetButton()
		{
			this.Data.ReceiveDelegate();
		}

		// Token: 0x040195C7 RID: 103879
		[Nullable(2)]
		protected DreamLinkRunTaskData Data;

		// Token: 0x040195C8 RID: 103880
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x040195C9 RID: 103881
		[Nullable(2)]
		private ButtonItem JumpButton;

		// Token: 0x040195CA RID: 103882
		private bool NeedTick;

		// Token: 0x0200A711 RID: 42769
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040339EA RID: 211434
			public const int JumpBtn = 0;

			// Token: 0x040339EB RID: 211435
			public const int GetBtn = 1;

			// Token: 0x040339EC RID: 211436
			public const int PanelDone = 2;

			// Token: 0x040339ED RID: 211437
			public const int TxtName = 3;

			// Token: 0x040339EE RID: 211438
			public const int PanelLock = 4;

			// Token: 0x040339EF RID: 211439
			public const int TxtLock = 5;

			// Token: 0x040339F0 RID: 211440
			public const int RewardScroll = 6;

			// Token: 0x040339F1 RID: 211441
			public const int TxtGoing = 7;

			// Token: 0x040339F2 RID: 211442
			public const int PanelTime = 8;

			// Token: 0x040339F3 RID: 211443
			public const int TxtTime = 9;

			// Token: 0x040339F4 RID: 211444
			public const int RedDot = 10;
		}
	}
}
