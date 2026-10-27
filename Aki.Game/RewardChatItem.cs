using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002539 RID: 9529
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RewardChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x0601326D RID: 78445 RVA: 0x004C1148 File Offset: 0x004BF348
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnGetRewardClick))
		};
	}

	// Token: 0x0601326E RID: 78446 RVA: 0x004C11F1 File Offset: 0x004BF3F1
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0601326F RID: 78447 RVA: 0x004C1225 File Offset: 0x004BF425
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06013270 RID: 78448 RVA: 0x004C122C File Offset: 0x004BF42C
	public override void Refresh(PhoneMsgChatData data)
	{
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(data.DropId);
		if (dropPackage == null)
		{
			return;
		}
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dropPackage.Value.DropPreview())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
			list.Add(item);
		}
		this.RewardScroll.RefreshByData(list, null, false);
		base.GetButton(0).RootUIComp.Get().SetUIActive(!data.IsFinish);
		base.GetSprite(1).SetUIActive(data.IsFinish);
	}

	// Token: 0x06013271 RID: 78449 RVA: 0x004C1314 File Offset: 0x004BF514
	private void OnGetRewardClick()
	{
		Action onRewardClick = this.OnRewardClick;
		if (onRewardClick == null)
		{
			return;
		}
		onRewardClick();
	}

	// Token: 0x06013272 RID: 78450 RVA: 0x004C1328 File Offset: 0x004BF528
	public UniTask PlayRewardAnimationAsync()
	{
		RewardChatItem.<PlayRewardAnimationAsync>d__9 <PlayRewardAnimationAsync>d__;
		<PlayRewardAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimationAsync>d__.<>4__this = this;
		<PlayRewardAnimationAsync>d__.<>1__state = -1;
		<PlayRewardAnimationAsync>d__.<>t__builder.Start<RewardChatItem.<PlayRewardAnimationAsync>d__9>(ref <PlayRewardAnimationAsync>d__);
		return <PlayRewardAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013273 RID: 78451 RVA: 0x004C136B File Offset: 0x004BF56B
	public void StopRewardAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x0400909A RID: 37018
	[Nullable(2)]
	public Action OnRewardClick;

	// Token: 0x0400909B RID: 37019
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x0400909C RID: 37020
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008AC6 RID: 35526
	[NullableContext(0)]
	private enum EItemRewardComponent
	{
		// Token: 0x0402D107 RID: 184583
		BtnGet,
		// Token: 0x0402D108 RID: 184584
		SpriteFinish,
		// Token: 0x0402D109 RID: 184585
		RewardScroll,
		// Token: 0x0402D10A RID: 184586
		Content,
		// Token: 0x0402D10B RID: 184587
		RewardItemBox
	}
}
