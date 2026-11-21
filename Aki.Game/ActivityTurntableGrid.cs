using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009ED RID: 2541
public class ActivityTurntableGrid : UiPanelBase
{
	// Token: 0x06006EFE RID: 28414 RVA: 0x00223350 File Offset: 0x00221550
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

	// Token: 0x06006EFF RID: 28415 RVA: 0x0022347C File Offset: 0x0022167C
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

	// Token: 0x06006F00 RID: 28416 RVA: 0x002234C7 File Offset: 0x002216C7
	public void SetRewardClaimed(bool isClaimed)
	{
		base.GetTexture(0).SetUIActive(!isClaimed);
		base.GetItem(3).SetUIActive(isClaimed);
		base.GetItem(4).SetUIActive(!isClaimed);
	}

	// Token: 0x06006F01 RID: 28417 RVA: 0x002234F8 File Offset: 0x002216F8
	public void Rotate(float changeAngle)
	{
		float inYaw = base.GetItem(4).RelativeRotation.Yaw + changeAngle;
		UUIItem item = base.GetItem(4);
		FRotator frotator = new FRotator(0f, inYaw, 0f);
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06006F02 RID: 28418 RVA: 0x00223538 File Offset: 0x00221738
	private void ButtonClicked()
	{
		if (this.ItemId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}
	}

	// Token: 0x040044DA RID: 17626
	public int RewardId;

	// Token: 0x040044DB RID: 17627
	public bool IsGoldenQuality;

	// Token: 0x040044DC RID: 17628
	public bool IsSpecial;

	// Token: 0x040044DD RID: 17629
	private int ItemId;

	// Token: 0x040044DE RID: 17630
	private const int REFRESH_LOADING_COUNT = 2;

	// Token: 0x02006CFB RID: 27899
	private class EGridComponents
	{
		// Token: 0x04023CAA RID: 146602
		public const int Icon = 0;

		// Token: 0x04023CAB RID: 146603
		public const int SpriteQuality = 1;

		// Token: 0x04023CAC RID: 146604
		public const int TxtCount = 2;

		// Token: 0x04023CAD RID: 146605
		public const int PanelReward = 3;

		// Token: 0x04023CAE RID: 146606
		public const int PanelCount = 4;

		// Token: 0x04023CAF RID: 146607
		public const int Button = 5;
	}
}
