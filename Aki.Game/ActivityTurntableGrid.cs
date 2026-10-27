using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001535 RID: 5429
public class ActivityTurntableGrid : UiPanelBase
{
	// Token: 0x06009B20 RID: 39712 RVA: 0x002195B0 File Offset: 0x002177B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.ButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009B21 RID: 39713 RVA: 0x002196DC File Offset: 0x002178DC
	[NullableContext(1)]
	public UniTask Refresh(ITurntableReward reward)
	{
		ActivityTurntableGrid.<Refresh>d__7 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.reward = reward;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<ActivityTurntableGrid.<Refresh>d__7>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06009B22 RID: 39714 RVA: 0x00219727 File Offset: 0x00217927
	public void SetRewardClaimed(bool isClaimed)
	{
		base.GetTexture(0).SetUIActive(!isClaimed);
		base.GetItem(3).SetUIActive(isClaimed);
		base.GetItem(4).SetUIActive(!isClaimed);
	}

	// Token: 0x06009B23 RID: 39715 RVA: 0x00219758 File Offset: 0x00217958
	public void Rotate(float changeAngle)
	{
		float inYaw = base.GetItem(4).RelativeRotation.Yaw + changeAngle;
		UUIItem item = base.GetItem(4);
		FRotator frotator = new FRotator(0f, inYaw, 0f);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06009B24 RID: 39716 RVA: 0x00219798 File Offset: 0x00217998
	private void ButtonClicked()
	{
		if (this.ItemId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}
	}

	// Token: 0x04004434 RID: 17460
	public int RewardId;

	// Token: 0x04004435 RID: 17461
	public bool IsGoldenQuality;

	// Token: 0x04004436 RID: 17462
	public bool IsSpecial;

	// Token: 0x04004437 RID: 17463
	private int ItemId;

	// Token: 0x04004438 RID: 17464
	private const int REFRESH_LOADING_COUNT = 2;

	// Token: 0x02007B70 RID: 31600
	private class EGridComponents
	{
		// Token: 0x0402896F RID: 166255
		public const int Icon = 0;

		// Token: 0x04028970 RID: 166256
		public const int SpriteQuality = 1;

		// Token: 0x04028971 RID: 166257
		public const int TxtCount = 2;

		// Token: 0x04028972 RID: 166258
		public const int PanelReward = 3;

		// Token: 0x04028973 RID: 166259
		public const int PanelCount = 4;

		// Token: 0x04028974 RID: 166260
		public const int Button = 5;
	}
}
