using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Rewards
{
	// Token: 0x02006846 RID: 26694
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRewardItem : GridProxyAbstract<DangoBrawlTaskData>
	{
		// Token: 0x06042A12 RID: 272914 RVA: 0x0103364C File Offset: 0x0103184C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickReceive));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042A13 RID: 272915 RVA: 0x010337B8 File Offset: 0x010319B8
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x06042A14 RID: 272916 RVA: 0x010337DB File Offset: 0x010319DB
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.IsTaken)
			};
		}

		// Token: 0x06042A15 RID: 272917 RVA: 0x010337F4 File Offset: 0x010319F4
		public void SetReceiveClickCallback(Action callback)
		{
			this.ReceiveClickCallback = callback;
		}

		// Token: 0x06042A16 RID: 272918 RVA: 0x010337FD File Offset: 0x010319FD
		private void OnClickReceive()
		{
			Action receiveClickCallback = this.ReceiveClickCallback;
			if (receiveClickCallback == null)
			{
				return;
			}
			receiveClickCallback();
		}

		// Token: 0x06042A17 RID: 272919 RVA: 0x01033810 File Offset: 0x01031A10
		public override void Refresh(DangoBrawlTaskData data, bool isSelected, int gridIndex)
		{
			DangoBrawlReward? rewardConfigById = DangoBrawlConfig.Instance.GetRewardConfigById(data.ConfigId);
			if (rewardConfigById == null)
			{
				return;
			}
			EActivityTaskState status = data.Status;
			bool uiactive = status == EActivityTaskState.Active;
			bool flag = status == EActivityTaskState.FinishedAndClaimed;
			bool uiactive2 = status == EActivityTaskState.FinishedAndUnclaimed;
			this.IsTaken = flag;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rewardConfigById.Value.Title, Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardConfigById.Value.DropId);
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScroll = this.RewardScroll;
			if (rewardScroll != null)
			{
				rewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
			}
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScroll2 = this.RewardScroll;
			if (rewardScroll2 != null)
			{
				rewardScroll2.LateScrollToLeft(0);
			}
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetUIActive(uiactive);
			}
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(uiactive2);
				}
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(uiactive2);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x04022B3D RID: 142141
		[Nullable(2)]
		private Action ReceiveClickCallback;

		// Token: 0x04022B3E RID: 142142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04022B3F RID: 142143
		private bool IsTaken;

		// Token: 0x0200CA0B RID: 51723
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403D0E6 RID: 250086
			TxtName,
			// Token: 0x0403D0E7 RID: 250087
			TxtNum,
			// Token: 0x0403D0E8 RID: 250088
			SvItem,
			// Token: 0x0403D0E9 RID: 250089
			GridItem,
			// Token: 0x0403D0EA RID: 250090
			TxtDoing,
			// Token: 0x0403D0EB RID: 250091
			BtnReceive,
			// Token: 0x0403D0EC RID: 250092
			RedDot,
			// Token: 0x0403D0ED RID: 250093
			PnlDone
		}
	}
}
