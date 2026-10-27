using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02005793 RID: 22419
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoRewardItem : GridProxyAbstract<KurotatoRewardItemData>
	{
		// Token: 0x06038F0E RID: 233230 RVA: 0x00D88B6C File Offset: 0x00D86D6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickReceive));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038F0F RID: 233231 RVA: 0x00D88CFA File Offset: 0x00D86EFA
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), () => new CommonItemSmallItemGrid(), null, false, null);
		}

		// Token: 0x06038F10 RID: 233232 RVA: 0x00D88D30 File Offset: 0x00D86F30
		public void SetReceiveClickCallback(Action callback)
		{
			this.ReceiveClickCallback = callback;
		}

		// Token: 0x06038F11 RID: 233233 RVA: 0x00D88D39 File Offset: 0x00D86F39
		private void OnClickReceive()
		{
			Action receiveClickCallback = this.ReceiveClickCallback;
			if (receiveClickCallback == null)
			{
				return;
			}
			receiveClickCallback();
		}

		// Token: 0x06038F12 RID: 233234 RVA: 0x00D88D4C File Offset: 0x00D86F4C
		public override void Refresh(KurotatoRewardItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetTitle(), Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(data.GetDropId());
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
			bool uiactive = data.Status == EKurotatoRewardStatus.Doing;
			bool uiactive2 = data.Status == EKurotatoRewardStatus.Taken;
			bool uiactive3 = data.Status == EKurotatoRewardStatus.CanReceive;
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
					uuiitem.SetUIActive(uiactive3);
				}
			}
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive3);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(uiactive3);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive2);
		}

		// Token: 0x0401DD86 RID: 122246
		[Nullable(2)]
		private Action ReceiveClickCallback;

		// Token: 0x0401DD87 RID: 122247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0200B9B9 RID: 47545
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403827B RID: 230011
			TextName,
			// Token: 0x0403827C RID: 230012
			TextProgress,
			// Token: 0x0403827D RID: 230013
			Scroll,
			// Token: 0x0403827E RID: 230014
			GridItem,
			// Token: 0x0403827F RID: 230015
			TextDoing,
			// Token: 0x04038280 RID: 230016
			BtnReceive,
			// Token: 0x04038281 RID: 230017
			SpriteReceive,
			// Token: 0x04038282 RID: 230018
			ItemRedDot,
			// Token: 0x04038283 RID: 230019
			PanelDone
		}
	}
}
