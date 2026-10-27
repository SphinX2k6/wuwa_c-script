using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001282 RID: 4738
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoTaskItem : GridProxyAbstract<FightPhotoTaskData>
{
	// Token: 0x06008161 RID: 33121 RVA: 0x001B7248 File Offset: 0x001B5448
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

	// Token: 0x06008162 RID: 33122 RVA: 0x001B7307 File Offset: 0x001B5507
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x06008163 RID: 33123 RVA: 0x001B732C File Offset: 0x001B552C
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

	// Token: 0x06008164 RID: 33124 RVA: 0x001B73CE File Offset: 0x001B55CE
	private void OnRewardBtnClickHandler()
	{
		Action onRewardBtnClick = this.OnRewardBtnClick;
		if (onRewardBtnClick == null)
		{
			return;
		}
		onRewardBtnClick();
	}

	// Token: 0x06008165 RID: 33125 RVA: 0x001B73E0 File Offset: 0x001B55E0
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x04003AA1 RID: 15009
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x04003AA2 RID: 15010
	[Nullable(2)]
	public Action OnRewardBtnClick;

	// Token: 0x02007899 RID: 30873
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027BC6 RID: 162758
		BtnReward,
		// Token: 0x04027BC7 RID: 162759
		TextDoing,
		// Token: 0x04027BC8 RID: 162760
		ItemFinish,
		// Token: 0x04027BC9 RID: 162761
		TextName,
		// Token: 0x04027BCA RID: 162762
		ScrollReward,
		// Token: 0x04027BCB RID: 162763
		ItemLockPanel,
		// Token: 0x04027BCC RID: 162764
		ItemRedDot
	}
}
