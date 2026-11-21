using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200077C RID: 1916
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivitySubMapExploreItem : GridProxyAbstract<IActivitySubMapExploreItemData>
{
	// Token: 0x060057C6 RID: 22470 RVA: 0x001CACE8 File Offset: 0x001C8EE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnGetReward));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060057C7 RID: 22471 RVA: 0x001CADF4 File Offset: 0x001C8FF4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubMapExploreItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubMapExploreItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060057C8 RID: 22472 RVA: 0x001CAE38 File Offset: 0x001C9038
	public override void Refresh(IActivitySubMapExploreItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		string rewardDesc = this.ItemData.RewardDesc;
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(rewardDesc, rewardDesc);
		base.GetText(3).SetText(multiTextByKey, true);
		int? num;
		this.RewardItem.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = this.ItemData,
			ItemConfigId = new int?(this.ItemData.RewardItemId),
			BottomText = (((this.ItemData.RewardItemCount != null) ? num.GetValueOrDefault().ToString() : null) ?? string.Empty),
			IsReceivedVisible = new bool?(this.ItemData.IsComplete),
			IsReceivableVisible = new bool?(this.ItemData.IsCanGet)
		});
		base.GetTexture(2).SetUIActive(this.ItemData.IsCanGet);
		base.GetItem(4).SetUIActive(this.ItemData.IsCanGet);
		EToggleState state = this.ItemData.IsComplete ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked;
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x060057C9 RID: 22473 RVA: 0x001CAF5C File Offset: 0x001C915C
	private void OnClickReward(MediumItemGridExtendCallback _)
	{
		if (this.ItemData.IsCanGet)
		{
			this.OnGetReward(EToggleState.ETT_UnChecked);
			return;
		}
		int rewardItemId = this.ItemData.RewardItemId;
		ItemController.Instance.OpenItemTipsByItemId(rewardItemId, true, null, false);
	}

	// Token: 0x060057CA RID: 22474 RVA: 0x001CAF98 File Offset: 0x001C9198
	private void OnGetReward(EToggleState _)
	{
		if (this.ItemData.IsComplete)
		{
			return;
		}
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle != null)
		{
			itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		IScrollViewDelegate<IGridProxy<IActivitySubMapExploreItemData>, IActivitySubMapExploreItemData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate != null)
		{
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
		if (this.ItemData.IsCanGet)
		{
			Action<IActivitySubMapExploreItemData> getRewardCallBack = this.GetRewardCallBack;
			if (getRewardCallBack == null)
			{
				return;
			}
			getRewardCallBack(this.ItemData);
		}
	}

	// Token: 0x060057CB RID: 22475 RVA: 0x001CB009 File Offset: 0x001C9209
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x060057CC RID: 22476 RVA: 0x001CB012 File Offset: 0x001C9212
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060057CD RID: 22477 RVA: 0x001CB028 File Offset: 0x001C9228
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003C04 RID: 15364
	private IActivitySubMapExploreItemData ItemData;

	// Token: 0x04003C05 RID: 15365
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IActivitySubMapExploreItemData> ClickCallBack;

	// Token: 0x04003C06 RID: 15366
	[Nullable(2)]
	private SmallItemGrid RewardItem;

	// Token: 0x04003C07 RID: 15367
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IActivitySubMapExploreItemData> GetRewardCallBack;

	// Token: 0x02006A69 RID: 27241
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402304E RID: 143438
		public const int ToggleGetBtn = 0;

		// Token: 0x0402304F RID: 143439
		public const int ItemCommonReward = 1;

		// Token: 0x04023050 RID: 143440
		public const int TextureCanGet = 2;

		// Token: 0x04023051 RID: 143441
		public const int TxtRewardDesc = 3;

		// Token: 0x04023052 RID: 143442
		public const int ItemRedDot = 4;
	}
}
