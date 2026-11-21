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

// Token: 0x02001A22 RID: 6690
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RewardChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x06010740 RID: 67392 RVA: 0x004CF70C File Offset: 0x004CD90C
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

	// Token: 0x06010741 RID: 67393 RVA: 0x004CF7B5 File Offset: 0x004CD9B5
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010742 RID: 67394 RVA: 0x004CF7E9 File Offset: 0x004CD9E9
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06010743 RID: 67395 RVA: 0x004CF7F0 File Offset: 0x004CD9F0
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

	// Token: 0x06010744 RID: 67396 RVA: 0x004CF8D8 File Offset: 0x004CDAD8
	private void OnGetRewardClick()
	{
		Action onRewardClick = this.OnRewardClick;
		if (onRewardClick == null)
		{
			return;
		}
		onRewardClick();
	}

	// Token: 0x06010745 RID: 67397 RVA: 0x004CF8EC File Offset: 0x004CDAEC
	public UniTask PlayRewardAnimationAsync()
	{
		RewardChatItem.<PlayRewardAnimationAsync>d__9 <PlayRewardAnimationAsync>d__;
		<PlayRewardAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimationAsync>d__.<>4__this = this;
		<PlayRewardAnimationAsync>d__.<>1__state = -1;
		<PlayRewardAnimationAsync>d__.<>t__builder.Start<RewardChatItem.<PlayRewardAnimationAsync>d__9>(ref <PlayRewardAnimationAsync>d__);
		return <PlayRewardAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010746 RID: 67398 RVA: 0x004CF92F File Offset: 0x004CDB2F
	public void StopRewardAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x040091F4 RID: 37364
	[Nullable(2)]
	public Action OnRewardClick;

	// Token: 0x040091F5 RID: 37365
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x040091F6 RID: 37366
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007C4F RID: 31823
	[NullableContext(0)]
	private enum EItemRewardComponent
	{
		// Token: 0x04028427 RID: 164903
		BtnGet,
		// Token: 0x04028428 RID: 164904
		SpriteFinish,
		// Token: 0x04028429 RID: 164905
		RewardScroll,
		// Token: 0x0402842A RID: 164906
		Content,
		// Token: 0x0402842B RID: 164907
		RewardItemBox
	}
}
