using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200137D RID: 4989
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemCollectView : UiViewBase
{
	// Token: 0x0600C632 RID: 50738 RVA: 0x003B0294 File Offset: 0x003AE494
	public HonamiStoryItemCollectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C633 RID: 50739 RVA: 0x003B02A0 File Offset: 0x003AE4A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C634 RID: 50740 RVA: 0x003B0414 File Offset: 0x003AE614
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemCollectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemCollectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C635 RID: 50741 RVA: 0x003B0457 File Offset: 0x003AE657
	private HonamiStoryItemCollectItemView InitCollectItem()
	{
		return new HonamiStoryItemCollectItemView
		{
			OnClickToggleBack = new Action<int, HonamiStoryItemCollectionData>(this.OnClickItem),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600C636 RID: 50742 RVA: 0x003B0482 File Offset: 0x003AE682
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHonamiStoryItemCollectGetReward, new Action(this.RefreshView));
	}

	// Token: 0x0600C637 RID: 50743 RVA: 0x003B04A0 File Offset: 0x003AE6A0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryItemCollectGetReward, new Action(this.RefreshView));
	}

	// Token: 0x0600C638 RID: 50744 RVA: 0x003B04C0 File Offset: 0x003AE6C0
	private void RefreshView()
	{
		this.RefreshProgressTxt();
		List<HonamiStoryItemCollectionData> sortDataList = this.GetSortDataList();
		this.PnlCollectItemList.GetGenericLayout().DeselectCurrentGridProxy();
		this.PnlCollectItemList.RefreshByData(sortDataList, null, false);
		this.OnClickItem(0, sortDataList[0]);
	}

	// Token: 0x0600C639 RID: 50745 RVA: 0x003B0508 File Offset: 0x003AE708
	private void RefreshProgressTxt()
	{
		string str = this.GetUnLockItemNum().ToString();
		string str2 = this.ActData.GetItemCollectionDataList().Count.ToString();
		base.GetText(7).SetText(str + "/" + str2, true);
	}

	// Token: 0x0600C63A RID: 50746 RVA: 0x003B0558 File Offset: 0x003AE758
	private int GetUnLockItemNum()
	{
		int num = 0;
		using (List<HonamiStoryItemCollectionData>.Enumerator enumerator = this.ActData.GetItemCollectionDataList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State != EHonamiStoryCollectState.Unfinished)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600C63B RID: 50747 RVA: 0x003B05B8 File Offset: 0x003AE7B8
	private List<HonamiStoryItemCollectionData> GetSortDataList()
	{
		if (this.ActData == null)
		{
			return new List<HonamiStoryItemCollectionData>();
		}
		Dictionary<EHonamiStoryCollectState, int> statePriority = new Dictionary<EHonamiStoryCollectState, int>
		{
			{
				EHonamiStoryCollectState.Finished,
				1
			},
			{
				EHonamiStoryCollectState.GotReward,
				2
			},
			{
				EHonamiStoryCollectState.Unfinished,
				3
			}
		};
		List<HonamiStoryItemCollectionData> list = new List<HonamiStoryItemCollectionData>(this.ActData.GetItemCollectionDataList());
		list.Sort((HonamiStoryItemCollectionData a, HonamiStoryItemCollectionData b) => statePriority[a.State] - statePriority[b.State]);
		return list;
	}

	// Token: 0x0600C63C RID: 50748 RVA: 0x003B0620 File Offset: 0x003AE820
	private void OnClickItem(int gridIndex, HonamiStoryItemCollectionData data)
	{
		this.CurSelectItemData = data;
		this.PnlCollectItemList.SelectGridProxy(gridIndex, false);
		base.SetTextureByPath(data.GetConfig.Icon, base.GetTexture(9), null, null);
		UUIItem texture = base.GetTexture(9);
		bool bUseChangeColor = data.State == EHonamiStoryCollectState.Unfinished;
		FColor? fcolor = new FColor?(base.GetTexture(9).changeColor);
		texture.SetChangeColor(bUseChangeColor, fcolor);
		base.GetItem(8).SetUIActive(data.State == EHonamiStoryCollectState.Unfinished);
		if (this.CurSelectItemData.State != EHonamiStoryCollectState.Unfinished)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.CurSelectItemData.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.CurSelectItemData.Desc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.CurSelectItemData.Desc, Array.Empty<object>());
		}
		bool uiactive = this.CurSelectItemData.State > EHonamiStoryCollectState.Unfinished;
		base.GetItem(2).SetUIActive(uiactive);
		base.GetText(4).SetUIActive(uiactive);
		this.RewardBtn.RefreshView(this.CurSelectItemData);
	}

	// Token: 0x0600C63D RID: 50749 RVA: 0x003B0751 File Offset: 0x003AE951
	private bool CanToggleChange(int gridIndex)
	{
		return gridIndex != this.PnlCollectItemList.GetSelectedIndex();
	}

	// Token: 0x0600C63E RID: 50750 RVA: 0x003B0764 File Offset: 0x003AE964
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(442);
	}

	// Token: 0x0600C63F RID: 50751 RVA: 0x003B0775 File Offset: 0x003AE975
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x040070BB RID: 28859
	[Nullable(2)]
	private HonamiStoryActivityData ActData;

	// Token: 0x040070BC RID: 28860
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070BD RID: 28861
	private GenericScrollViewNew<HonamiStoryItemCollectItemView, HonamiStoryItemCollectionData> PnlCollectItemList;

	// Token: 0x040070BE RID: 28862
	[Nullable(2)]
	private HonamiStoryItemCollectionData CurSelectItemData;

	// Token: 0x040070BF RID: 28863
	[Nullable(2)]
	private HonamiStoryItemCollectRewardBtn RewardBtn;

	// Token: 0x02007629 RID: 30249
	[NullableContext(0)]
	private enum EHonamiStoryItemCollectComponent
	{
		// Token: 0x040265EF RID: 157167
		SvItemInfo,
		// Token: 0x040265F0 RID: 157168
		TogItem,
		// Token: 0x040265F1 RID: 157169
		PnlTxtTitle,
		// Token: 0x040265F2 RID: 157170
		TxtInfoTitle,
		// Token: 0x040265F3 RID: 157171
		TxtInfo,
		// Token: 0x040265F4 RID: 157172
		BtnReward,
		// Token: 0x040265F5 RID: 157173
		ItemCaption,
		// Token: 0x040265F6 RID: 157174
		TxtProgress,
		// Token: 0x040265F7 RID: 157175
		ItemLock,
		// Token: 0x040265F8 RID: 157176
		TexItem
	}
}
