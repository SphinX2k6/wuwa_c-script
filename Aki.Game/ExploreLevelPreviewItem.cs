using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02000F53 RID: 3923
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ExploreLevelPreviewItem : GridProxyAbstract<CountryExploreLevelRewardData>
{
	// Token: 0x06009CFE RID: 40190 RVA: 0x002E835C File Offset: 0x002E655C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009CFF RID: 40191 RVA: 0x002E846A File Offset: 0x002E666A
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollView<CommonItemSmallItemGrid>(base.GetScrollViewWithScrollbar(4), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSmallItemGrid>(this.OnCreateRewardItemGrid), null);
	}

	// Token: 0x06009D00 RID: 40192 RVA: 0x002E848B File Offset: 0x002E668B
	protected override void OnBeforeDestroy()
	{
		this.RewardScrollView = null;
	}

	// Token: 0x06009D01 RID: 40193 RVA: 0x002E8494 File Offset: 0x002E6694
	public override void Refresh(CountryExploreLevelRewardData data, bool isSelected, int gridIndex)
	{
		Dictionary<int, int> dropItemNumMap = data.GetDropItemNumMap();
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		if (dropItemNumMap != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dropItemNumMap)
			{
				list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
			}
		}
		GenericScrollView<CommonItemSmallItemGrid> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.RefreshByData<ValueTuple<int, int>>(list, null);
		}
		base.SetTextureByPath(data.GetScoreTexturePath(), base.GetTexture(0), null, null);
		CountryExploreLevelData currentCountryExploreLevelData = ExploreLevelModel.Instance.GetCurrentCountryExploreLevelData();
		int? num = (currentCountryExploreLevelData != null) ? new int?(currentCountryExploreLevelData.GetExploreLevel()) : null;
		int exploreLevel = data.GetExploreLevel();
		bool flag = num.GetValueOrDefault() >= exploreLevel & num != null;
		base.GetSprite(1).SetUIActive(flag);
		base.GetText(2).SetUIActive(!flag);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.GetScoreNameId(), Array.Empty<object>());
		string rewardNameId = data.GetRewardNameId();
		UUIText text = base.GetText(6);
		if (!string.IsNullOrEmpty(rewardNameId))
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(rewardNameId, null);
			LguiUtil.Instance.SetLocalTextNew(text, "ExploreUnlockPreviewText", new <>z__ReadOnlySingleElementList<object>(localTextNew));
			text.SetUIActive(true);
		}
		else
		{
			text.SetUIActive(false);
		}
		base.GetSprite(5).SetUIActive(data.IsShowUnlockSprite());
	}

	// Token: 0x06009D02 RID: 40194 RVA: 0x002E861C File Offset: 0x002E681C
	private ILayoutItem<CommonItemSmallItemGrid> OnCreateRewardItemGrid(object rawData, UUIItem uiItem, int index)
	{
		ValueTuple<int, int> valueTuple = (ValueTuple<int, int>)rawData;
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.Initialize(uiItem.GetOwner());
		commonItemSmallItemGrid.RefreshByConfigId(valueTuple.Item1, new int?(valueTuple.Item2), null, false, false);
		return new LayoutItem<CommonItemSmallItemGrid>
		{
			Key = index,
			Value = commonItemSmallItemGrid
		};
	}

	// Token: 0x04005D57 RID: 23895
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonItemSmallItemGrid> RewardScrollView;

	// Token: 0x02007181 RID: 29057
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024F92 RID: 151442
		ExploreLevelTexture,
		// Token: 0x04024F93 RID: 151443
		DoneSprite,
		// Token: 0x04024F94 RID: 151444
		NotDoneText,
		// Token: 0x04024F95 RID: 151445
		ExploreLevelNameText,
		// Token: 0x04024F96 RID: 151446
		RewardScrollViewWithScrollBar,
		// Token: 0x04024F97 RID: 151447
		SpecialSprite,
		// Token: 0x04024F98 RID: 151448
		TipsText
	}
}
