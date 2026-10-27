using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AD7 RID: 6871
public class FeedbackRewardStartView : UiViewBase
{
	// Token: 0x0600CBE6 RID: 52198 RVA: 0x002E8864 File Offset: 0x002E6A64
	[NullableContext(1)]
	public FeedbackRewardStartView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CBE7 RID: 52199 RVA: 0x002E8870 File Offset: 0x002E6A70
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CBE8 RID: 52200 RVA: 0x002E8938 File Offset: 0x002E6B38
	protected override void OnStart()
	{
		List<int> canFinishRewardId = FeedbackRewardModel.Instance.GetCanFinishRewardId();
		if (canFinishRewardId.Count <= 0)
		{
			return;
		}
		int id = canFinishRewardId[canFinishRewardId.Count - 1];
		GivebackScoreReward? givebackScoreRewardById = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "FeedBackReward_StartView_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			FeedbackRewardModel.Instance.CurrentPointCount,
			(givebackScoreRewardById != null) ? new int?(givebackScoreRewardById.GetValueOrDefault().Target) : null
		}));
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.InitItem), null, false, true);
		List<TItem> list = new List<TItem>();
		foreach (int id2 in canFinishRewardId)
		{
			GivebackScoreReward? givebackScoreRewardById2 = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(id2);
			if (givebackScoreRewardById2 != null)
			{
				DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(givebackScoreRewardById2.Value.DropId);
				if (dropPackage != null)
				{
					using (Dictionary<int, int>.Enumerator enumerator2 = dropPackage.Value.DropPreview().GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							KeyValuePair<int, int> keyValuePair = enumerator2.Current;
							int key = keyValuePair.Key;
							int value = keyValuePair.Value;
							TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
							list.Add(item);
						}
					}
				}
			}
		}
		this.RewardLayout.RefreshByData(list, delegate
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in (((rewardLayout != null) ? rewardLayout.GetLayoutItemList() : null) ?? new List<CommonItemSmallItemGrid>()))
			{
				commonItemSmallItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
				commonItemSmallItemGrid.SetAllowClickBack(false);
			}
		}, false);
	}

	// Token: 0x0600CBE9 RID: 52201 RVA: 0x002E8B10 File Offset: 0x002E6D10
	protected override void OnBeforeShow()
	{
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.FeedbackReward);
	}

	// Token: 0x0600CBEA RID: 52202 RVA: 0x002E8B1D File Offset: 0x002E6D1D
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600CBEB RID: 52203 RVA: 0x002E8B24 File Offset: 0x002E6D24
	private void OnClickBtn()
	{
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.FeedbackRewardMainView, null, null);
	}

	// Token: 0x04005DBF RID: 23999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02008035 RID: 32821
	private enum ECompDefine
	{
		// Token: 0x04029DC0 RID: 171456
		Button,
		// Token: 0x04029DC1 RID: 171457
		PointText,
		// Token: 0x04029DC2 RID: 171458
		RewardLayout
	}
}
