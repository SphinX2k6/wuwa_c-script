using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x0200067E RID: 1662
public class CheckInRewardItem : ActivitySubViewBase
{
	// Token: 0x06004CE7 RID: 19687 RVA: 0x001A2524 File Offset: 0x001A0724
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004CE8 RID: 19688 RVA: 0x001A2630 File Offset: 0x001A0830
	[NullableContext(1)]
	public void Refresh(TimePointRewardData data, int itemId, int num)
	{
		this.Data = data;
		this.ItemId = itemId;
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		TimePointRewardData data2 = this.Data;
		ETimePointRewardState? etimePointRewardState = (data2 != null) ? new ETimePointRewardState?(data2.RewardState) : null;
		if (etimePointRewardState == null)
		{
			return;
		}
		switch (etimePointRewardState.GetValueOrDefault())
		{
		case ETimePointRewardState.Lock:
			base.GetTexture(1).SetColor(FColor.FromHex("#ffffff"));
			return;
		case ETimePointRewardState.UnlockAndUnClaimed:
			base.GetTexture(1).SetColor(FColor.FromHex("#ffffff"));
			return;
		case ETimePointRewardState.UnlockAndClaimed:
			base.GetTexture(1).SetColor(FColor.FromHex("#5d5d5d"));
			return;
		default:
			return;
		}
	}

	// Token: 0x06004CE9 RID: 19689 RVA: 0x001A26FC File Offset: 0x001A08FC
	[NullableContext(1)]
	public void SetTextIcon(string pathId)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(pathId);
		base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
	}

	// Token: 0x06004CEA RID: 19690 RVA: 0x001A272D File Offset: 0x001A092D
	private void OnClickedButton()
	{
		TimePointRewardData data = this.Data;
		if (data == null || data.RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}
		Action onClickAction = this.OnClickAction;
		if (onClickAction == null)
		{
			return;
		}
		onClickAction();
	}

	// Token: 0x0400386B RID: 14443
	private int ItemId;

	// Token: 0x0400386C RID: 14444
	[Nullable(2)]
	private TimePointRewardData Data;

	// Token: 0x0400386D RID: 14445
	[Nullable(2)]
	public Action OnClickAction;

	// Token: 0x02006946 RID: 26950
	private enum EComponents
	{
		// Token: 0x04022ADA RID: 142042
		BtnReward1,
		// Token: 0x04022ADB RID: 142043
		TexIcon1,
		// Token: 0x04022ADC RID: 142044
		TxtNum1,
		// Token: 0x04022ADD RID: 142045
		SprNgNor,
		// Token: 0x04022ADE RID: 142046
		SprReceive
	}
}
