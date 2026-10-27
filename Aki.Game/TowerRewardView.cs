using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C05 RID: 11269
public class TowerRewardView : UiViewBase
{
	// Token: 0x0601767B RID: 95867 RVA: 0x005F5AA8 File Offset: 0x005F3CA8
	[NullableContext(1)]
	public TowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601767C RID: 95868 RVA: 0x005F5AB4 File Offset: 0x005F3CB4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601767D RID: 95869 RVA: 0x005F5B1D File Offset: 0x005F3D1D
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<TowerRewardItem, TowerReward>(base.GetScrollViewWithScrollbar(0), new Func<TowerRewardItem>(this.RefreshItem), null, false, null);
		this.RefreshView();
	}

	// Token: 0x0601767E RID: 95870 RVA: 0x005F5B46 File Offset: 0x005F3D46
	protected override void OnBeforeDestroy()
	{
		this.RewardScroll = null;
	}

	// Token: 0x0601767F RID: 95871 RVA: 0x005F5B4F File Offset: 0x005F3D4F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.OnTowerRewardReceived));
	}

	// Token: 0x06017680 RID: 95872 RVA: 0x005F5B6D File Offset: 0x005F3D6D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.OnTowerRewardReceived));
	}

	// Token: 0x06017681 RID: 95873 RVA: 0x005F5B8C File Offset: 0x005F3D8C
	private void RefreshView()
	{
		int difficulty = (int)(this.OpenParam ?? TowerModel.Instance.CurrentSelectDifficulties);
		List<TowerReward> difficultyReward = TowerModel.Instance.GetDifficultyReward(difficulty);
		if (difficultyReward == null)
		{
			return;
		}
		difficultyReward.Sort(delegate(TowerReward a, TowerReward b)
		{
			int num = (a.IsReceived.GetValueOrDefault() > false) ? 1 : 0;
			int num2 = (b.IsReceived.GetValueOrDefault() > false) ? 1 : 0;
			if (num != num2)
			{
				return num - num2;
			}
			return a.Index - b.Index;
		});
		this.RewardScroll.RefreshByData(difficultyReward, null, false);
		base.GetText(1).SetText(TowerModel.Instance.GetDifficultyMaxStars(difficulty, false).ToString() + "/" + TowerModel.Instance.GetDifficultyAllStars(difficulty, false).ToString(), true);
	}

	// Token: 0x06017682 RID: 95874 RVA: 0x005F5C3A File Offset: 0x005F3E3A
	[NullableContext(1)]
	private TowerRewardItem RefreshItem()
	{
		return new TowerRewardItem();
	}

	// Token: 0x06017683 RID: 95875 RVA: 0x005F5C41 File Offset: 0x005F3E41
	private void OnTowerRewardReceived()
	{
		this.RefreshView();
	}

	// Token: 0x0400AF12 RID: 44818
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerRewardItem, TowerReward> RewardScroll;

	// Token: 0x020091CF RID: 37327
	private enum EChildType
	{
		// Token: 0x0402F2D3 RID: 193235
		ScrollView,
		// Token: 0x0402F2D4 RID: 193236
		ReceivedStarText
	}
}
