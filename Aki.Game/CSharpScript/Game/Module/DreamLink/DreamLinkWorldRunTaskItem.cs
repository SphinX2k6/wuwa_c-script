using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB7 RID: 23223
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkWorldRunTaskItem : GridProxyAbstract<DreamLinkRunTaskData>
	{
		// Token: 0x0603AD21 RID: 240929 RVA: 0x00E03C6C File Offset: 0x00E01E6C
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

		// Token: 0x0603AD22 RID: 240930 RVA: 0x00E03E40 File Offset: 0x00E02040
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
			base.GetItem(2).SetUIActive(false);
			this.JumpButton = new ButtonItem(base.GetItem(0));
			this.JumpButton.SetFunction(new Action<int>(this.OnClickJump));
		}

		// Token: 0x0603AD23 RID: 240931 RVA: 0x00E03EA4 File Offset: 0x00E020A4
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603AD24 RID: 240932 RVA: 0x00E03EAC File Offset: 0x00E020AC
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

		// Token: 0x0603AD25 RID: 240933 RVA: 0x00E03FE0 File Offset: 0x00E021E0
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

		// Token: 0x0603AD26 RID: 240934 RVA: 0x00E0401C File Offset: 0x00E0221C
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

		// Token: 0x0603AD27 RID: 240935 RVA: 0x00E04062 File Offset: 0x00E02262
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

		// Token: 0x0603AD28 RID: 240936 RVA: 0x00E04096 File Offset: 0x00E02296
		private void OnClickGetButton()
		{
			this.Data.ReceiveDelegate();
		}

		// Token: 0x0401EB20 RID: 125728
		[Nullable(2)]
		protected DreamLinkRunTaskData Data;

		// Token: 0x0401EB21 RID: 125729
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401EB22 RID: 125730
		[Nullable(2)]
		private ButtonItem JumpButton;

		// Token: 0x0401EB23 RID: 125731
		private bool NeedTick;

		// Token: 0x0200BD09 RID: 48393
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04039020 RID: 233504
			public const int JumpBtn = 0;

			// Token: 0x04039021 RID: 233505
			public const int GetBtn = 1;

			// Token: 0x04039022 RID: 233506
			public const int PanelDone = 2;

			// Token: 0x04039023 RID: 233507
			public const int TxtName = 3;

			// Token: 0x04039024 RID: 233508
			public const int PanelLock = 4;

			// Token: 0x04039025 RID: 233509
			public const int TxtLock = 5;

			// Token: 0x04039026 RID: 233510
			public const int RewardScroll = 6;

			// Token: 0x04039027 RID: 233511
			public const int TxtGoing = 7;

			// Token: 0x04039028 RID: 233512
			public const int PanelTime = 8;

			// Token: 0x04039029 RID: 233513
			public const int TxtTime = 9;

			// Token: 0x0403902A RID: 233514
			public const int RedDot = 10;
		}
	}
}
