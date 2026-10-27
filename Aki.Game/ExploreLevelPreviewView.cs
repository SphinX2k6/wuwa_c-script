using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001A95 RID: 6805
[NullableContext(1)]
[Nullable(0)]
public class ExploreLevelPreviewView : UiViewBase
{
	// Token: 0x0600C8F3 RID: 51443 RVA: 0x002DD548 File Offset: 0x002DB748
	public ExploreLevelPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C8F4 RID: 51444 RVA: 0x002DD554 File Offset: 0x002DB754
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

	// Token: 0x0600C8F5 RID: 51445 RVA: 0x002DD74C File Offset: 0x002DB94C
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreLevelPreviewView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreLevelPreviewView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C8F6 RID: 51446 RVA: 0x002DD790 File Offset: 0x002DB990
	private void OnPreviewItemGridClicked(MediumItemGridExtendCallback callbackParameter)
	{
		int itemId = (int)callbackParameter.Data;
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
	}

	// Token: 0x0600C8F7 RID: 51447 RVA: 0x002DD7B6 File Offset: 0x002DB9B6
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(this.PreviewExploreLevelRewardData.GetHelpId());
	}

	// Token: 0x0600C8F8 RID: 51448 RVA: 0x002DD7CD File Offset: 0x002DB9CD
	private void OnClickedLeftButton()
	{
		this.PreviewIndex = Math.Max(0, this.PreviewIndex - 1);
		this.RefreshPreviewDisplay();
	}

	// Token: 0x0600C8F9 RID: 51449 RVA: 0x002DD7E9 File Offset: 0x002DB9E9
	private void OnClickedRightButton()
	{
		this.PreviewIndex = Math.Min(this.PreviewIndex + 1, this.UnlockFunctionExploreLevelRewardDataList.Count - 1);
		this.RefreshPreviewDisplay();
	}

	// Token: 0x0600C8FA RID: 51450 RVA: 0x002DD814 File Offset: 0x002DBA14
	protected override void OnStart()
	{
		this.CountryExploreLevelData = (this.OpenParam as CountryExploreLevelData);
		this.LoopScrollView = new LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData>(base.GetLoopScrollViewComponent(6), base.GetItem(7).GetOwner() as AUIBaseActor, new Func<ExploreLevelPreviewItem>(this.OnCreateExploreLevelPreviewItem), false);
		this.UnlockFunctionExploreLevelRewardDataList = this.CountryExploreLevelData.GetUnlockFunctionExploreLevelRewardDataList();
		this.PreviewIndex = this.GetPreviewExploreLevelRewardDataIndex(this.CountryExploreLevelData.GetExploreLevel()).GetValueOrDefault();
		this.RefreshPreviewDisplay();
		this.RefreshExploreLevelPreviewItemScrollView();
	}

	// Token: 0x0600C8FB RID: 51451 RVA: 0x002DD89E File Offset: 0x002DBA9E
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

	// Token: 0x0600C8FC RID: 51452 RVA: 0x002DD8BF File Offset: 0x002DBABF
	private ExploreLevelPreviewItem OnCreateExploreLevelPreviewItem()
	{
		return new ExploreLevelPreviewItem();
	}

	// Token: 0x0600C8FD RID: 51453 RVA: 0x002DD8C8 File Offset: 0x002DBAC8
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

	// Token: 0x0600C8FE RID: 51454 RVA: 0x002DD93C File Offset: 0x002DBB3C
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

	// Token: 0x0600C8FF RID: 51455 RVA: 0x002DD984 File Offset: 0x002DBB84
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

	// Token: 0x0600C900 RID: 51456 RVA: 0x002DDA40 File Offset: 0x002DBC40
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

	// Token: 0x0600C901 RID: 51457 RVA: 0x002DDA84 File Offset: 0x002DBC84
	private void RefreshButtonVisible()
	{
		int count = this.UnlockFunctionExploreLevelRewardDataList.Count;
		base.GetButton(2).RootUIComp.Get().SetUIActive(this.PreviewIndex < count - 1);
		base.GetButton(1).RootUIComp.Get().SetUIActive(this.PreviewIndex > 0);
	}

	// Token: 0x0600C902 RID: 51458 RVA: 0x002DDAE4 File Offset: 0x002DBCE4
	private void RefreshExploreLevelPreviewItemScrollView()
	{
		List<CountryExploreLevelRewardData> data = this.CountryExploreLevelData.GetAllExploreLevelRewardData().Skip(1).ToList<CountryExploreLevelRewardData>();
		LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.ReloadData(data, false);
	}

	// Token: 0x04005C89 RID: 23689
	[Nullable(2)]
	private CountryExploreLevelData CountryExploreLevelData;

	// Token: 0x04005C8A RID: 23690
	[Nullable(2)]
	private CountryExploreLevelRewardData PreviewExploreLevelRewardData;

	// Token: 0x04005C8B RID: 23691
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ExploreLevelPreviewItem, CountryExploreLevelRewardData> LoopScrollView;

	// Token: 0x04005C8C RID: 23692
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlyList<CountryExploreLevelRewardData> UnlockFunctionExploreLevelRewardDataList;

	// Token: 0x04005C8D RID: 23693
	private int PreviewIndex;

	// Token: 0x04005C8E RID: 23694
	[Nullable(2)]
	private SmallItemGrid PreviewItemGrid;

	// Token: 0x02007FF3 RID: 32755
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029C60 RID: 171104
		HelpButton,
		// Token: 0x04029C61 RID: 171105
		LeftButton,
		// Token: 0x04029C62 RID: 171106
		RightButton,
		// Token: 0x04029C63 RID: 171107
		UnlockNameText,
		// Token: 0x04029C64 RID: 171108
		UnlockDescriptionText,
		// Token: 0x04029C65 RID: 171109
		UnlockSprite,
		// Token: 0x04029C66 RID: 171110
		LoopScrollView,
		// Token: 0x04029C67 RID: 171111
		SourceRewardItem,
		// Token: 0x04029C68 RID: 171112
		LockSprite,
		// Token: 0x04029C69 RID: 171113
		PreviewItemGridItem
	}
}
