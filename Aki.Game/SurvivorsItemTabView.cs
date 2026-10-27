using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B24 RID: 11044
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SurvivorsItemTabView : SurvivorsTabViewBase<SurvivorsItemTabItem, SurvivorsRogueItemCard>
{
	// Token: 0x17001E9C RID: 7836
	// (get) Token: 0x06016EED RID: 93933 RVA: 0x005D20EF File Offset: 0x005D02EF
	protected override ESurvivorsRogueItemType ItemType
	{
		get
		{
			return ESurvivorsRogueItemType.Normal;
		}
	}

	// Token: 0x06016EEE RID: 93934 RVA: 0x005D20F4 File Offset: 0x005D02F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06016EEF RID: 93935 RVA: 0x005D219C File Offset: 0x005D039C
	protected override UniTask InitSubComponents()
	{
		SurvivorsItemTabView.<InitSubComponents>d__4 <InitSubComponents>d__;
		<InitSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubComponents>d__.<>4__this = this;
		<InitSubComponents>d__.<>1__state = -1;
		<InitSubComponents>d__.<>t__builder.Start<SurvivorsItemTabView.<InitSubComponents>d__4>(ref <InitSubComponents>d__);
		return <InitSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06016EF0 RID: 93936 RVA: 0x005D21DF File Offset: 0x005D03DF
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCardBase propDetailItem = this.PropDetailItem;
		if (propDetailItem != null)
		{
			propDetailItem.Destroy(null);
		}
		this.PropDetailItem = null;
	}

	// Token: 0x06016EF1 RID: 93937 RVA: 0x005D21FA File Offset: 0x005D03FA
	protected override int GetLoopItemIndex()
	{
		return 3;
	}

	// Token: 0x06016EF2 RID: 93938 RVA: 0x005D21FD File Offset: 0x005D03FD
	protected override int GetLoopScrollComponentIndex()
	{
		return 1;
	}

	// Token: 0x06016EF3 RID: 93939 RVA: 0x005D2200 File Offset: 0x005D0400
	protected override SurvivorsItemTabItem CreateLoopItem()
	{
		SurvivorsItemTabItem survivorsItemTabItem = new SurvivorsItemTabItem();
		survivorsItemTabItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(base.OnCanClickItem));
		survivorsItemTabItem.OnClickCallBack = new Action<SurvivorsRogueItemCard, SurvivorsItemTabItem>(base.OnItemClick);
		return survivorsItemTabItem;
	}

	// Token: 0x06016EF4 RID: 93940 RVA: 0x005D222C File Offset: 0x005D042C
	protected override IReadOnlyList<SurvivorsRogueItemCard> GenerateItemUiDataList()
	{
		int actId = SurvivorsRogueModel.Instance.ActivityData.ActId;
		IEnumerable<SurvivorsItem> allSurvivorsItemByActId = SurvivorsRogueConfig.Instance.GetAllSurvivorsItemByActId(actId);
		List<SurvivorsRogueItemCard> list = new List<SurvivorsRogueItemCard>();
		foreach (SurvivorsItem survivorsItem in allSurvivorsItemByActId)
		{
			SurvivorsRogueItemCard survivorsRogueItemCard = SurvivorsRogueCardDataFactory.CreateGeneralItem(survivorsItem.Id);
			if (survivorsRogueItemCard == null)
			{
				return Array.Empty<SurvivorsRogueItemCard>();
			}
			survivorsRogueItemCard.LockState = new bool?(SurvivorsRogueModel.Instance.GetItemIsLock(this.ItemType, survivorsItem.Id));
			survivorsRogueItemCard.IsNew = new bool?(SurvivorsRogueModel.Instance.GetItemIsNew(this.ItemType, survivorsItem.Id));
			if (survivorsRogueItemCard.LockState.GetValueOrDefault())
			{
				survivorsRogueItemCard.TitleId = "Text_Unknown_Text";
				survivorsRogueItemCard.DescId = "SurvivorsItem_Lock_Desc";
			}
			list.Add(survivorsRogueItemCard);
		}
		this.SortUiDataList(list);
		return list;
	}

	// Token: 0x06016EF5 RID: 93941 RVA: 0x005D2334 File Offset: 0x005D0534
	protected override void OnSelectItem(SurvivorsRogueItemCard data, bool isFromClick = true)
	{
		SurvivorsItemTabView.<>c__DisplayClass10_0 CS$<>8__locals1 = new SurvivorsItemTabView.<>c__DisplayClass10_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		UiAsyncTask task = new UiAsyncTask("SurvivorsRogueCardBase.Apply", delegate()
		{
			SurvivorsItemTabView.<>c__DisplayClass10_0.<<OnSelectItem>b__0>d <<OnSelectItem>b__0>d;
			<<OnSelectItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSelectItem>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnSelectItem>b__0>d.<>1__state = -1;
			<<OnSelectItem>b__0>d.<>t__builder.Start<SurvivorsItemTabView.<>c__DisplayClass10_0.<<OnSelectItem>b__0>d>(ref <<OnSelectItem>b__0>d);
			return <<OnSelectItem>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
		if (isFromClick)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Switch", false, false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.PlaySequence("Switch", false, null);
		}
	}

	// Token: 0x06016EF6 RID: 93942 RVA: 0x005D23AF File Offset: 0x005D05AF
	private void SortUiDataList(List<SurvivorsRogueItemCard> uiDataList)
	{
		if (uiDataList == null)
		{
			return;
		}
		uiDataList.Sort(delegate(SurvivorsRogueItemCard a, SurvivorsRogueItemCard b)
		{
			bool? lockState = a.LockState;
			bool? lockState2 = b.LockState;
			if (!(lockState.GetValueOrDefault() == lockState2.GetValueOrDefault() & lockState != null == (lockState2 != null)))
			{
				if (a.LockState == null || b.LockState == null)
				{
					return 0;
				}
				if (!a.LockState.Value)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (a.QualityId != b.QualityId)
				{
					return b.QualityId - a.QualityId;
				}
				return a.Id - b.Id;
			}
		});
	}

	// Token: 0x0400AAB2 RID: 43698
	[Nullable(2)]
	private SurvivorsRogueCardBase PropDetailItem;
}
