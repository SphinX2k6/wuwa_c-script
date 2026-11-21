using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020A0 RID: 8352
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SurvivorsItemTabView : SurvivorsTabViewBase<SurvivorsItemTabItem, SurvivorsRogueItemCard>
{
	// Token: 0x17001EF4 RID: 7924
	// (get) Token: 0x0601491E RID: 84254 RVA: 0x005FEC6B File Offset: 0x005FCE6B
	protected override ESurvivorsRogueItemType ItemType
	{
		get
		{
			return ESurvivorsRogueItemType.Normal;
		}
	}

	// Token: 0x0601491F RID: 84255 RVA: 0x005FEC70 File Offset: 0x005FCE70
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

	// Token: 0x06014920 RID: 84256 RVA: 0x005FED18 File Offset: 0x005FCF18
	protected override UniTask InitSubComponents()
	{
		SurvivorsItemTabView.<InitSubComponents>d__4 <InitSubComponents>d__;
		<InitSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubComponents>d__.<>4__this = this;
		<InitSubComponents>d__.<>1__state = -1;
		<InitSubComponents>d__.<>t__builder.Start<SurvivorsItemTabView.<InitSubComponents>d__4>(ref <InitSubComponents>d__);
		return <InitSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06014921 RID: 84257 RVA: 0x005FED5B File Offset: 0x005FCF5B
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCardBase propDetailItem = this.PropDetailItem;
		if (propDetailItem != null)
		{
			propDetailItem.Destroy(null);
		}
		this.PropDetailItem = null;
	}

	// Token: 0x06014922 RID: 84258 RVA: 0x005FED76 File Offset: 0x005FCF76
	protected override int GetLoopItemIndex()
	{
		return 3;
	}

	// Token: 0x06014923 RID: 84259 RVA: 0x005FED79 File Offset: 0x005FCF79
	protected override int GetLoopScrollComponentIndex()
	{
		return 1;
	}

	// Token: 0x06014924 RID: 84260 RVA: 0x005FED7C File Offset: 0x005FCF7C
	protected override SurvivorsItemTabItem CreateLoopItem()
	{
		SurvivorsItemTabItem survivorsItemTabItem = new SurvivorsItemTabItem();
		survivorsItemTabItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(base.OnCanClickItem));
		survivorsItemTabItem.OnClickCallBack = new Action<SurvivorsRogueItemCard, SurvivorsItemTabItem>(base.OnItemClick);
		return survivorsItemTabItem;
	}

	// Token: 0x06014925 RID: 84261 RVA: 0x005FEDA8 File Offset: 0x005FCFA8
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

	// Token: 0x06014926 RID: 84262 RVA: 0x005FEEB0 File Offset: 0x005FD0B0
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

	// Token: 0x06014927 RID: 84263 RVA: 0x005FEF2B File Offset: 0x005FD12B
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

	// Token: 0x0400AEB8 RID: 44728
	[Nullable(2)]
	private SurvivorsRogueCardBase PropDetailItem;
}
