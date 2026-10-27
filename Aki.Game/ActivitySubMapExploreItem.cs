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

// Token: 0x020012C8 RID: 4808
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivitySubMapExploreItem : GridProxyAbstract<IActivitySubMapExploreItemData>
{
	// Token: 0x0600842B RID: 33835 RVA: 0x001C1E8C File Offset: 0x001C008C
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

	// Token: 0x0600842C RID: 33836 RVA: 0x001C1F98 File Offset: 0x001C0198
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubMapExploreItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubMapExploreItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600842D RID: 33837 RVA: 0x001C1FDC File Offset: 0x001C01DC
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

	// Token: 0x0600842E RID: 33838 RVA: 0x001C2100 File Offset: 0x001C0300
	private void OnClickReward(MediumItemGridExtendCallback _)
	{
		if (this.ItemData.IsCanGet)
		{
			this.OnGetReward(EToggleState.ETT_UnChecked);
			return;
		}
		int rewardItemId = this.ItemData.RewardItemId;
		ItemController.Instance.OpenItemTipsByItemId(rewardItemId, true, null);
	}

	// Token: 0x0600842F RID: 33839 RVA: 0x001C213C File Offset: 0x001C033C
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

	// Token: 0x06008430 RID: 33840 RVA: 0x001C21AD File Offset: 0x001C03AD
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06008431 RID: 33841 RVA: 0x001C21B6 File Offset: 0x001C03B6
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06008432 RID: 33842 RVA: 0x001C21CC File Offset: 0x001C03CC
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003B6C RID: 15212
	private IActivitySubMapExploreItemData ItemData;

	// Token: 0x04003B6D RID: 15213
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IActivitySubMapExploreItemData> ClickCallBack;

	// Token: 0x04003B6E RID: 15214
	[Nullable(2)]
	private SmallItemGrid RewardItem;

	// Token: 0x04003B6F RID: 15215
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IActivitySubMapExploreItemData> GetRewardCallBack;

	// Token: 0x020078DF RID: 30943
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04027D20 RID: 163104
		public const int ToggleGetBtn = 0;

		// Token: 0x04027D21 RID: 163105
		public const int ItemCommonReward = 1;

		// Token: 0x04027D22 RID: 163106
		public const int TextureCanGet = 2;

		// Token: 0x04027D23 RID: 163107
		public const int TxtRewardDesc = 3;

		// Token: 0x04027D24 RID: 163108
		public const int ItemRedDot = 4;
	}
}
