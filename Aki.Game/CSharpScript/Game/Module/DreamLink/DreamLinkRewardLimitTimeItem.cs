using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005ABD RID: 23229
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkRewardLimitTimeItem : GridProxyAbstract<DreamLinkRewardData>
	{
		// Token: 0x0603AD5C RID: 240988 RVA: 0x00E05224 File Offset: 0x00E03424
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
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
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AD5D RID: 240989 RVA: 0x00E053B4 File Offset: 0x00E035B4
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0603AD5E RID: 240990 RVA: 0x00E05409 File Offset: 0x00E03609
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603AD5F RID: 240991 RVA: 0x00E05410 File Offset: 0x00E03610
		public override void Refresh(DreamLinkRewardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RogueLimitTimeReward? limitTimeRewardConfig = DreamLinkConfig.Instance.GetLimitTimeRewardConfig(data.Id);
			if (limitTimeRewardConfig == null)
			{
				return;
			}
			bool uiactive = data.Status == EActivityTaskState.Active;
			bool flag = data.Status == EActivityTaskState.FinishedAndClaimed;
			bool uiactive2 = data.Status == EActivityTaskState.FinishedAndUnclaimed;
			this.RefreshReward(limitTimeRewardConfig.Value.TargetReward, flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), limitTimeRewardConfig.Value.TargetName, Array.Empty<object>());
			base.GetText(7).SetUIActive(uiactive);
			base.GetItem(2).SetUIActive(flag);
			base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive2);
			int current = data.Current;
			int target = data.Target;
			UUIText text = base.GetText(8);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(current, target));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603AD60 RID: 240992 RVA: 0x00E05524 File Offset: 0x00E03724
		private void RefreshReward(int dropId, bool hasClaimed)
		{
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in dropPackagePreviewItemList)
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = hasClaimed
				};
				list.Add(item2);
			}
			this.RewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0603AD61 RID: 240993 RVA: 0x00E055A4 File Offset: 0x00E037A4
		private void OnClickGetButton()
		{
			DreamLinkController.Instance.LimitTimeRewardRequest(this.Data.Id);
		}

		// Token: 0x0401EB39 RID: 125753
		[Nullable(2)]
		protected DreamLinkRewardData Data;

		// Token: 0x0401EB3A RID: 125754
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0200BD10 RID: 48400
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04039051 RID: 233553
			public const int Button = 0;

			// Token: 0x04039052 RID: 233554
			public const int RewardButton = 1;

			// Token: 0x04039053 RID: 233555
			public const int PanelDone = 2;

			// Token: 0x04039054 RID: 233556
			public const int Text = 3;

			// Token: 0x04039055 RID: 233557
			public const int PanelLock = 4;

			// Token: 0x04039056 RID: 233558
			public const int TextLock = 5;

			// Token: 0x04039057 RID: 233559
			public const int RewardLayout = 6;

			// Token: 0x04039058 RID: 233560
			public const int TextGoing = 7;

			// Token: 0x04039059 RID: 233561
			public const int TextProgress = 8;
		}
	}
}
