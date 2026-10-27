using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x020011CA RID: 4554
public class CheckInRewardItem : ActivitySubViewBase
{
	// Token: 0x06007950 RID: 31056 RVA: 0x00199874 File Offset: 0x00197A74
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

	// Token: 0x06007951 RID: 31057 RVA: 0x00199980 File Offset: 0x00197B80
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

	// Token: 0x06007952 RID: 31058 RVA: 0x00199A4C File Offset: 0x00197C4C
	[NullableContext(1)]
	public void SetTextIcon(string pathId)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(pathId);
		base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
	}

	// Token: 0x06007953 RID: 31059 RVA: 0x00199A7D File Offset: 0x00197C7D
	private void OnClickedButton()
	{
		TimePointRewardData data = this.Data;
		if (data == null || data.RewardState != ETimePointRewardState.UnlockAndUnClaimed)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}
		Action onClickAction = this.OnClickAction;
		if (onClickAction == null)
		{
			return;
		}
		onClickAction();
	}

	// Token: 0x040037D2 RID: 14290
	private int ItemId;

	// Token: 0x040037D3 RID: 14291
	[Nullable(2)]
	private TimePointRewardData Data;

	// Token: 0x040037D4 RID: 14292
	[Nullable(2)]
	public Action OnClickAction;

	// Token: 0x020077BB RID: 30651
	private enum EComponents
	{
		// Token: 0x040277A8 RID: 161704
		BtnReward1,
		// Token: 0x040277A9 RID: 161705
		TexIcon1,
		// Token: 0x040277AA RID: 161706
		TxtNum1,
		// Token: 0x040277AB RID: 161707
		SprNgNor,
		// Token: 0x040277AC RID: 161708
		SprReceive
	}
}
