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
	// Token: 0x02005796 RID: 22422
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRewardItem : GridProxyAbstract<DangoBrawlTaskData>
	{
		// Token: 0x06037566 RID: 226662 RVA: 0x00F74B58 File Offset: 0x00F72D58
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

		// Token: 0x06037567 RID: 226663 RVA: 0x00F74CC4 File Offset: 0x00F72EC4
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x06037568 RID: 226664 RVA: 0x00F74CE7 File Offset: 0x00F72EE7
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.IsTaken)
			};
		}

		// Token: 0x06037569 RID: 226665 RVA: 0x00F74D00 File Offset: 0x00F72F00
		public void SetReceiveClickCallback(Action callback)
		{
			this.ReceiveClickCallback = callback;
		}

		// Token: 0x0603756A RID: 226666 RVA: 0x00F74D09 File Offset: 0x00F72F09
		private void OnClickReceive()
		{
			Action receiveClickCallback = this.ReceiveClickCallback;
			if (receiveClickCallback == null)
			{
				return;
			}
			receiveClickCallback();
		}

		// Token: 0x0603756B RID: 226667 RVA: 0x00F74D1C File Offset: 0x00F72F1C
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

		// Token: 0x0401D39A RID: 119706
		[Nullable(2)]
		private Action ReceiveClickCallback;

		// Token: 0x0401D39B RID: 119707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401D39C RID: 119708
		private bool IsTaken;

		// Token: 0x0200B3D7 RID: 46039
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040379CF RID: 227791
			TxtName,
			// Token: 0x040379D0 RID: 227792
			TxtNum,
			// Token: 0x040379D1 RID: 227793
			SvItem,
			// Token: 0x040379D2 RID: 227794
			GridItem,
			// Token: 0x040379D3 RID: 227795
			TxtDoing,
			// Token: 0x040379D4 RID: 227796
			BtnReceive,
			// Token: 0x040379D5 RID: 227797
			RedDot,
			// Token: 0x040379D6 RID: 227798
			PnlDone
		}
	}
}
