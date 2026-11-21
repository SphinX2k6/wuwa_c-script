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
	// Token: 0x0200476A RID: 18282
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoRewardItem : GridProxyAbstract<KurotatoRewardItemData>
	{
		// Token: 0x0602DE1E RID: 187934 RVA: 0x00CD78BC File Offset: 0x00CD5ABC
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

		// Token: 0x0602DE1F RID: 187935 RVA: 0x00CD7A4A File Offset: 0x00CD5C4A
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), () => new CommonItemSmallItemGrid(), null, false, null);
		}

		// Token: 0x0602DE20 RID: 187936 RVA: 0x00CD7A80 File Offset: 0x00CD5C80
		public void SetReceiveClickCallback(Action callback)
		{
			this.ReceiveClickCallback = callback;
		}

		// Token: 0x0602DE21 RID: 187937 RVA: 0x00CD7A89 File Offset: 0x00CD5C89
		private void OnClickReceive()
		{
			Action receiveClickCallback = this.ReceiveClickCallback;
			if (receiveClickCallback == null)
			{
				return;
			}
			receiveClickCallback();
		}

		// Token: 0x0602DE22 RID: 187938 RVA: 0x00CD7A9C File Offset: 0x00CD5C9C
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

		// Token: 0x0401881C RID: 100380
		[Nullable(2)]
		private Action ReceiveClickCallback;

		// Token: 0x0401881D RID: 100381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0200A3CF RID: 41935
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032C6C RID: 207980
			TextName,
			// Token: 0x04032C6D RID: 207981
			TextProgress,
			// Token: 0x04032C6E RID: 207982
			Scroll,
			// Token: 0x04032C6F RID: 207983
			GridItem,
			// Token: 0x04032C70 RID: 207984
			TextDoing,
			// Token: 0x04032C71 RID: 207985
			BtnReceive,
			// Token: 0x04032C72 RID: 207986
			SpriteReceive,
			// Token: 0x04032C73 RID: 207987
			ItemRedDot,
			// Token: 0x04032C74 RID: 207988
			PanelDone
		}
	}
}
