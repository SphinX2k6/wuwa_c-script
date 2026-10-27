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

// Token: 0x02001EBB RID: 7867
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemCollectView : UiViewBase
{
	// Token: 0x0600F213 RID: 61971 RVA: 0x003A4794 File Offset: 0x003A2994
	public HonamiStoryItemCollectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F214 RID: 61972 RVA: 0x003A47A0 File Offset: 0x003A29A0
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

	// Token: 0x0600F215 RID: 61973 RVA: 0x003A4914 File Offset: 0x003A2B14
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemCollectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemCollectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F216 RID: 61974 RVA: 0x003A4957 File Offset: 0x003A2B57
	private HonamiStoryItemCollectItemView InitCollectItem()
	{
		return new HonamiStoryItemCollectItemView
		{
			OnClickToggleBack = new Action<int, HonamiStoryItemCollectionData>(this.OnClickItem),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600F217 RID: 61975 RVA: 0x003A4982 File Offset: 0x003A2B82
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHonamiStoryItemCollectGetReward, new Action(this.RefreshView));
	}

	// Token: 0x0600F218 RID: 61976 RVA: 0x003A49A0 File Offset: 0x003A2BA0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryItemCollectGetReward, new Action(this.RefreshView));
	}

	// Token: 0x0600F219 RID: 61977 RVA: 0x003A49C0 File Offset: 0x003A2BC0
	private void RefreshView()
	{
		this.RefreshProgressTxt();
		List<HonamiStoryItemCollectionData> sortDataList = this.GetSortDataList();
		this.PnlCollectItemList.GetGenericLayout().DeselectCurrentGridProxy();
		this.PnlCollectItemList.RefreshByData(sortDataList, null, false);
		this.OnClickItem(0, sortDataList[0]);
	}

	// Token: 0x0600F21A RID: 61978 RVA: 0x003A4A08 File Offset: 0x003A2C08
	private void RefreshProgressTxt()
	{
		string str = this.GetUnLockItemNum().ToString();
		string str2 = this.ActData.GetItemCollectionDataList().Count.ToString();
		base.GetText(7).SetText(str + "/" + str2, true);
	}

	// Token: 0x0600F21B RID: 61979 RVA: 0x003A4A58 File Offset: 0x003A2C58
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

	// Token: 0x0600F21C RID: 61980 RVA: 0x003A4AB8 File Offset: 0x003A2CB8
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

	// Token: 0x0600F21D RID: 61981 RVA: 0x003A4B20 File Offset: 0x003A2D20
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

	// Token: 0x0600F21E RID: 61982 RVA: 0x003A4C51 File Offset: 0x003A2E51
	private bool CanToggleChange(int gridIndex)
	{
		return gridIndex != this.PnlCollectItemList.GetSelectedIndex();
	}

	// Token: 0x0600F21F RID: 61983 RVA: 0x003A4C64 File Offset: 0x003A2E64
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(442);
	}

	// Token: 0x0600F220 RID: 61984 RVA: 0x003A4C75 File Offset: 0x003A2E75
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006FDA RID: 28634
	[Nullable(2)]
	private HonamiStoryActivityData ActData;

	// Token: 0x04006FDB RID: 28635
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006FDC RID: 28636
	private GenericScrollViewNew<HonamiStoryItemCollectItemView, HonamiStoryItemCollectionData> PnlCollectItemList;

	// Token: 0x04006FDD RID: 28637
	[Nullable(2)]
	private HonamiStoryItemCollectionData CurSelectItemData;

	// Token: 0x04006FDE RID: 28638
	[Nullable(2)]
	private HonamiStoryItemCollectRewardBtn RewardBtn;

	// Token: 0x020084A4 RID: 33956
	[NullableContext(0)]
	private enum EHonamiStoryItemCollectComponent
	{
		// Token: 0x0402B2CB RID: 176843
		SvItemInfo,
		// Token: 0x0402B2CC RID: 176844
		TogItem,
		// Token: 0x0402B2CD RID: 176845
		PnlTxtTitle,
		// Token: 0x0402B2CE RID: 176846
		TxtInfoTitle,
		// Token: 0x0402B2CF RID: 176847
		TxtInfo,
		// Token: 0x0402B2D0 RID: 176848
		BtnReward,
		// Token: 0x0402B2D1 RID: 176849
		ItemCaption,
		// Token: 0x0402B2D2 RID: 176850
		TxtProgress,
		// Token: 0x0402B2D3 RID: 176851
		ItemLock,
		// Token: 0x0402B2D4 RID: 176852
		TexItem
	}
}
