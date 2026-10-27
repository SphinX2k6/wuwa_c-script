using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02001A94 RID: 6804
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ExploreLevelPreviewItem : GridProxyAbstract<CountryExploreLevelRewardData>
{
	// Token: 0x0600C8ED RID: 51437 RVA: 0x002DD228 File Offset: 0x002DB428
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

	// Token: 0x0600C8EE RID: 51438 RVA: 0x002DD336 File Offset: 0x002DB536
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollView<CommonItemSmallItemGrid>(base.GetScrollViewWithScrollbar(4), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSmallItemGrid>(this.OnCreateRewardItemGrid), null);
	}

	// Token: 0x0600C8EF RID: 51439 RVA: 0x002DD357 File Offset: 0x002DB557
	protected override void OnBeforeDestroy()
	{
		this.RewardScrollView = null;
	}

	// Token: 0x0600C8F0 RID: 51440 RVA: 0x002DD360 File Offset: 0x002DB560
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

	// Token: 0x0600C8F1 RID: 51441 RVA: 0x002DD4E8 File Offset: 0x002DB6E8
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

	// Token: 0x04005C88 RID: 23688
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonItemSmallItemGrid> RewardScrollView;

	// Token: 0x02007FF2 RID: 32754
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029C58 RID: 171096
		ExploreLevelTexture,
		// Token: 0x04029C59 RID: 171097
		DoneSprite,
		// Token: 0x04029C5A RID: 171098
		NotDoneText,
		// Token: 0x04029C5B RID: 171099
		ExploreLevelNameText,
		// Token: 0x04029C5C RID: 171100
		RewardScrollViewWithScrollBar,
		// Token: 0x04029C5D RID: 171101
		SpecialSprite,
		// Token: 0x04029C5E RID: 171102
		TipsText
	}
}
