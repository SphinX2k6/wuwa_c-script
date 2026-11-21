using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F54 RID: 3924
[NullableContext(1)]
[Nullable(0)]
public class ExploreLevelPreviewView : UiViewBase
{
	// Token: 0x06009D04 RID: 40196 RVA: 0x002E867C File Offset: 0x002E687C
	public ExploreLevelPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009D05 RID: 40197 RVA: 0x002E8688 File Offset: 0x002E6888
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedHelpButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedLeftButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedRightButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009D06 RID: 40198 RVA: 0x002E8880 File Offset: 0x002E6A80
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreLevelPreviewView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreLevelPreviewView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D07 RID: 40199 RVA: 0x002E88C4 File Offset: 0x002E6AC4
	private void OnPreviewItemGridClicked(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = (int)callbackParameter.Data;
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
	}

	// Token: 0x06009D08 RID: 40200 RVA: 0x002E88EB File Offset: 0x002E6AEB
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(this.PreviewExploreLevelRewardData.GetHelpId());
	}

	// Token: 0x06009D09 RID: 40201 RVA: 0x002E8902 File Offset: 0x002E6B02
	private void OnClickedLeftButton()
	{
		this.PreviewIndex = Math.Max(0, this.PreviewIndex - 1);
		this.RefreshPreviewDisplay();
	}

	// Token: 0x06009D0A RID: 40202 RVA: 0x002E891E File Offset: 0x002E6B1E
	private void OnClickedRightButton()
	{
		this.PreviewIndex = Math.Min(this.PreviewIndex + 1, this.UnlockFunctionExploreLevelRewardDataList.Count - 1);
		this.RefreshPreviewDisplay();
	}

	// Token: 0x06009D0B RID: 40203 RVA: 0x002E8948 File Offset: 0x002E6B48
	protected override void OnStart()
	{
		this.CountryExploreLevelData = (this.OpenParam as CountryExploreLevelData);
		this.LoopScrollView = new LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData>(base.GetLoopScrollViewComponent(6), base.GetItem(7).GetOwner() as AUIBaseActor, new Func<ExploreLevelPreviewItem>(this.OnCreateExploreLevelPreviewItem), false);
		this.UnlockFunctionExploreLevelRewardDataList = this.CountryExploreLevelData.GetUnlockFunctionExploreLevelRewardDataList();
		this.PreviewIndex = this.GetPreviewExploreLevelRewardDataIndex(this.CountryExploreLevelData.GetExploreLevel()).GetValueOrDefault();
		this.RefreshPreviewDisplay();
		this.RefreshExploreLevelPreviewItemScrollView();
	}

	// Token: 0x06009D0C RID: 40204 RVA: 0x002E89D2 File Offset: 0x002E6BD2
	protected override void OnBeforeDestroy()
	{
		this.CountryExploreLevelData = null;
		LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData> loopScrollView = this.LoopScrollView;
		if (loopScrollView != null)
		{
			loopScrollView.ClearGridProxies();
		}
		this.LoopScrollView = null;
	}

	// Token: 0x06009D0D RID: 40205 RVA: 0x002E89F3 File Offset: 0x002E6BF3
	private ExploreLevelPreviewItem OnCreateExploreLevelPreviewItem()
	{
		return new ExploreLevelPreviewItem();
	}

	// Token: 0x06009D0E RID: 40206 RVA: 0x002E89FC File Offset: 0x002E6BFC
	private int? GetPreviewExploreLevelRewardDataIndex(int fromExploreLevel)
	{
		int count = this.UnlockFunctionExploreLevelRewardDataList.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.UnlockFunctionExploreLevelRewardDataList[i].GetExploreLevel() > fromExploreLevel)
			{
				return new int?(i);
			}
		}
		for (int j = count - 1; j > 0; j--)
		{
			if (this.UnlockFunctionExploreLevelRewardDataList[j].GetExploreLevel() < fromExploreLevel)
			{
				return new int?(j);
			}
		}
		return null;
	}

	// Token: 0x06009D0F RID: 40207 RVA: 0x002E8A70 File Offset: 0x002E6C70
	private void RefreshPreviewDisplay()
	{
		if (this.UnlockFunctionExploreLevelRewardDataList.Count > this.PreviewIndex)
		{
			CountryExploreLevelRewardData exploreLevelRewardData = this.UnlockFunctionExploreLevelRewardDataList[this.PreviewIndex];
			this.RefreshUnlockDisplay(exploreLevelRewardData);
			this.RefreshPreviewItemGrid(exploreLevelRewardData);
		}
		this.RefreshButtonVisible();
	}

	// Token: 0x06009D10 RID: 40208 RVA: 0x002E8AB8 File Offset: 0x002E6CB8
	private void RefreshUnlockDisplay(CountryExploreLevelRewardData exploreLevelRewardData)
	{
		this.PreviewExploreLevelRewardData = exploreLevelRewardData;
		if (!exploreLevelRewardData.IsShowUnlockSprite())
		{
			return;
		}
		this.SetSpriteByPath(exploreLevelRewardData.GetUnlockSpritePath(), base.GetSprite(5), false, null, null);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(exploreLevelRewardData.GetScoreNameId(), null);
		UUIText text = base.GetText(4);
		bool flag = exploreLevelRewardData.GetExploreLevel() <= this.CountryExploreLevelData.GetExploreLevel();
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "ExploreUnlockRewardText", new <>z__ReadOnlySingleElementList<object>(localTextNew));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text, "ExploreLockRewardText", new <>z__ReadOnlySingleElementList<object>(localTextNew));
		}
		base.GetSprite(8).SetUIActive(!flag);
		base.GetText(3).ShowTextNew(exploreLevelRewardData.GetRewardNameId());
	}

	// Token: 0x06009D11 RID: 40209 RVA: 0x002E8B74 File Offset: 0x002E6D74
	private void RefreshPreviewItemGrid(CountryExploreLevelRewardData exploreLevelRewardData)
	{
		int previewItemConfigId = exploreLevelRewardData.GetPreviewItemConfigId();
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = previewItemConfigId,
			ItemConfigId = new int?(previewItemConfigId)
		};
		SmallItemGrid previewItemGrid = this.PreviewItemGrid;
		if (previewItemGrid == null)
		{
			return;
		}
		previewItemGrid.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06009D12 RID: 40210 RVA: 0x002E8BB8 File Offset: 0x002E6DB8
	private void RefreshButtonVisible()
	{
		int count = this.UnlockFunctionExploreLevelRewardDataList.Count;
		base.GetButton(2).RootUIComp.Get().SetUIActive(this.PreviewIndex < count - 1);
		base.GetButton(1).RootUIComp.Get().SetUIActive(this.PreviewIndex > 0);
	}

	// Token: 0x06009D13 RID: 40211 RVA: 0x002E8C18 File Offset: 0x002E6E18
	private void RefreshExploreLevelPreviewItemScrollView()
	{
		List<CountryExploreLevelRewardData> allExploreLevelRewardData = this.CountryExploreLevelData.GetAllExploreLevelRewardData();
		List<CountryExploreLevelRewardData> list = new List<CountryExploreLevelRewardData>();
		for (int i = 1; i < allExploreLevelRewardData.Count; i++)
		{
			list.Add(allExploreLevelRewardData[i]);
		}
		LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.ReloadData(list, false);
	}

	// Token: 0x04005D58 RID: 23896
	[Nullable(2)]
	private CountryExploreLevelData CountryExploreLevelData;

	// Token: 0x04005D59 RID: 23897
	[Nullable(2)]
	private CountryExploreLevelRewardData PreviewExploreLevelRewardData;

	// Token: 0x04005D5A RID: 23898
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData> LoopScrollView;

	// Token: 0x04005D5B RID: 23899
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlyList<CountryExploreLevelRewardData> UnlockFunctionExploreLevelRewardDataList;

	// Token: 0x04005D5C RID: 23900
	private int PreviewIndex;

	// Token: 0x04005D5D RID: 23901
	[Nullable(2)]
	private SmallItemGrid PreviewItemGrid;

	// Token: 0x02007182 RID: 29058
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024F9A RID: 151450
		HelpButton,
		// Token: 0x04024F9B RID: 151451
		LeftButton,
		// Token: 0x04024F9C RID: 151452
		RightButton,
		// Token: 0x04024F9D RID: 151453
		UnlockNameText,
		// Token: 0x04024F9E RID: 151454
		UnlockDescriptionText,
		// Token: 0x04024F9F RID: 151455
		UnlockSprite,
		// Token: 0x04024FA0 RID: 151456
		LoopScrollView,
		// Token: 0x04024FA1 RID: 151457
		SourceRewardItem,
		// Token: 0x04024FA2 RID: 151458
		LockSprite,
		// Token: 0x04024FA3 RID: 151459
		PreviewItemGridItem
	}
}
