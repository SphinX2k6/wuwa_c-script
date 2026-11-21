using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002180 RID: 8576
public class TowerRewardView : UiViewBase
{
	// Token: 0x060150AC RID: 86188 RVA: 0x006225CC File Offset: 0x006207CC
	[NullableContext(1)]
	public TowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060150AD RID: 86189 RVA: 0x006225D8 File Offset: 0x006207D8
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

	// Token: 0x060150AE RID: 86190 RVA: 0x00622641 File Offset: 0x00620841
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<TowerRewardItem, TowerReward>(base.GetScrollViewWithScrollbar(0), new Func<TowerRewardItem>(this.RefreshItem), null, false, null);
		this.RefreshView();
	}

	// Token: 0x060150AF RID: 86191 RVA: 0x0062266A File Offset: 0x0062086A
	protected override void OnBeforeDestroy()
	{
		this.RewardScroll = null;
	}

	// Token: 0x060150B0 RID: 86192 RVA: 0x00622673 File Offset: 0x00620873
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.OnTowerRewardReceived));
	}

	// Token: 0x060150B1 RID: 86193 RVA: 0x00622691 File Offset: 0x00620891
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.OnTowerRewardReceived));
	}

	// Token: 0x060150B2 RID: 86194 RVA: 0x006226B0 File Offset: 0x006208B0
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

	// Token: 0x060150B3 RID: 86195 RVA: 0x0062275E File Offset: 0x0062095E
	[NullableContext(1)]
	private TowerRewardItem RefreshItem()
	{
		return new TowerRewardItem();
	}

	// Token: 0x060150B4 RID: 86196 RVA: 0x00622765 File Offset: 0x00620965
	private void OnTowerRewardReceived()
	{
		this.RefreshView();
	}

	// Token: 0x0400B317 RID: 45847
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerRewardItem, TowerReward> RewardScroll;

	// Token: 0x02008412 RID: 33810
	private enum EChildType
	{
		// Token: 0x0402A9D4 RID: 174548
		ScrollView,
		// Token: 0x0402A9D5 RID: 174549
		ReceivedStarText
	}
}
