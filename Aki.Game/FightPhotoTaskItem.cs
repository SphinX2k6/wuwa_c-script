using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000736 RID: 1846
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoTaskItem : GridProxyAbstract<FightPhotoTaskData>
{
	// Token: 0x060054F8 RID: 21752 RVA: 0x001BFF18 File Offset: 0x001BE118
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnRewardBtnClickHandler))
		};
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x001BFFD7 File Offset: 0x001BE1D7
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x001BFFFC File Offset: 0x001BE1FC
	public override void Refresh(FightPhotoTaskData data, bool isSelected, int gridIndex)
	{
		this.RewardScroll.RefreshByData(data.RewardList, delegate
		{
			this.RewardScroll.ScrollToLeft(0);
		}, false);
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(data.IsUnclaimed);
		}
		base.GetButton(0).RootUIComp.Get().SetUIActive(data.IsUnclaimed);
		base.GetItem(2).SetUIActive(data.IsFinished);
		base.GetText(1).SetUIActive(data.IsDoing);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TaskName, Array.Empty<object>());
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x001C009E File Offset: 0x001BE29E
	private void OnRewardBtnClickHandler()
	{
		Action onRewardBtnClick = this.OnRewardBtnClick;
		if (onRewardBtnClick == null)
		{
			return;
		}
		onRewardBtnClick();
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x001C00B0 File Offset: 0x001BE2B0
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x04003B39 RID: 15161
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x04003B3A RID: 15162
	[Nullable(2)]
	public Action OnRewardBtnClick;

	// Token: 0x02006A24 RID: 27172
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022EF7 RID: 143095
		BtnReward,
		// Token: 0x04022EF8 RID: 143096
		TextDoing,
		// Token: 0x04022EF9 RID: 143097
		ItemFinish,
		// Token: 0x04022EFA RID: 143098
		TextName,
		// Token: 0x04022EFB RID: 143099
		ScrollReward,
		// Token: 0x04022EFC RID: 143100
		ItemLockPanel,
		// Token: 0x04022EFD RID: 143101
		ItemRedDot
	}
}
