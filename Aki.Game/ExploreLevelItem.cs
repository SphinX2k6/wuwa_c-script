using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A93 RID: 6803
[NullableContext(1)]
[Nullable(0)]
public class ExploreLevelItem : UiPanelBase, IGridProxy<CountryExploreScoreData>
{
	// Token: 0x17001077 RID: 4215
	// (get) Token: 0x0600C8DC RID: 51420 RVA: 0x002DCE6F File Offset: 0x002DB06F
	// (set) Token: 0x0600C8DD RID: 51421 RVA: 0x002DCE77 File Offset: 0x002DB077
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<CountryExploreScoreData>, CountryExploreScoreData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17001078 RID: 4216
	// (get) Token: 0x0600C8DE RID: 51422 RVA: 0x002DCE80 File Offset: 0x002DB080
	// (set) Token: 0x0600C8DF RID: 51423 RVA: 0x002DCE88 File Offset: 0x002DB088
	public int GridIndex { get; set; }

	// Token: 0x17001079 RID: 4217
	// (get) Token: 0x0600C8E0 RID: 51424 RVA: 0x002DCE91 File Offset: 0x002DB091
	// (set) Token: 0x0600C8E1 RID: 51425 RVA: 0x002DCE99 File Offset: 0x002DB099
	public int DisplayIndex { get; set; }

	// Token: 0x0600C8E2 RID: 51426 RVA: 0x002DCEA4 File Offset: 0x002DB0A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedSkipToButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedReceiveButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C8E3 RID: 51427 RVA: 0x002DD012 File Offset: 0x002DB212
	public void Clear()
	{
	}

	// Token: 0x0600C8E4 RID: 51428 RVA: 0x002DD014 File Offset: 0x002DB214
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C8E5 RID: 51429 RVA: 0x002DD016 File Offset: 0x002DB216
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C8E6 RID: 51430 RVA: 0x002DD018 File Offset: 0x002DB218
	protected override void OnBeforeDestroy()
	{
		this.CountryExploreScoreData = null;
		this.OnClickedReceiveButtonCallback = null;
	}

	// Token: 0x0600C8E7 RID: 51431 RVA: 0x002DD028 File Offset: 0x002DB228
	public void Refresh(CountryExploreScoreData data, bool isSelected, int gridIndex)
	{
		this.CountryExploreScoreData = data;
		this.GridIndex = gridIndex;
		base.SetTextureByPath(ExploreLevelModel.Instance.ExploreScoreItemTexturePath, base.GetTexture(0), null, null);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(data.GetAreaNameTextId(), null);
		int progress = data.Progress;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "AreaExploreProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			progress
		}));
		ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(data.AreaId);
		if (exploreAreaData == null)
		{
			return;
		}
		int progress2 = exploreAreaData.GetProgress();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "CurrentAreaExploreProgress", new <>z__ReadOnlySingleElementList<object>(progress2));
		base.GetText(3).SetText(data.Score.ToString(), true);
		bool isReceived = data.GetIsReceived();
		bool flag = data.CanReceive();
		if (isReceived)
		{
			base.GetSprite(6).SetUIActive(true);
			base.SetButtonUiActive(4, false);
			base.SetButtonUiActive(5, false);
			return;
		}
		if (flag)
		{
			base.GetSprite(6).SetUIActive(false);
			base.SetButtonUiActive(4, false);
			base.SetButtonUiActive(5, true);
			return;
		}
		base.GetSprite(6).SetUIActive(false);
		base.SetButtonUiActive(4, true);
		base.SetButtonUiActive(5, false);
	}

	// Token: 0x0600C8E8 RID: 51432 RVA: 0x002DD169 File Offset: 0x002DB369
	public void BindOnClickedReceiveButton(Action<CountryExploreScoreData> onClickedReceiveButton)
	{
		this.OnClickedReceiveButtonCallback = onClickedReceiveButton;
	}

	// Token: 0x0600C8E9 RID: 51433 RVA: 0x002DD174 File Offset: 0x002DB374
	private void OnClickedSkipToButton()
	{
		CountryExploreScoreData countryExploreScoreData = this.CountryExploreScoreData;
		Area? area = (countryExploreScoreData != null) ? countryExploreScoreData.GetAreaConfig() : null;
		if (area == null)
		{
			return;
		}
		EMarkType deliveryMarkType = (EMarkType)area.Value.DeliveryMarkType;
		int deliveryMarkId = area.Value.DeliveryMarkId;
		if (deliveryMarkType != EMarkType.AreaMark)
		{
			return;
		}
		if (deliveryMarkId <= 0)
		{
			return;
		}
		SkipTaskManager.Run(ESkipName.SkipToWorldMapView, new object[]
		{
			deliveryMarkType.ToString(),
			deliveryMarkId.ToString()
		});
	}

	// Token: 0x0600C8EA RID: 51434 RVA: 0x002DD1F8 File Offset: 0x002DB3F8
	private void OnClickedReceiveButton()
	{
		Action<CountryExploreScoreData> onClickedReceiveButtonCallback = this.OnClickedReceiveButtonCallback;
		if (onClickedReceiveButtonCallback == null)
		{
			return;
		}
		onClickedReceiveButtonCallback(this.CountryExploreScoreData);
	}

	// Token: 0x0600C8EB RID: 51435 RVA: 0x002DD210 File Offset: 0x002DB410
	public object GetKey(CountryExploreScoreData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x04005C86 RID: 23686
	[Nullable(2)]
	private CountryExploreScoreData CountryExploreScoreData;

	// Token: 0x04005C87 RID: 23687
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<CountryExploreScoreData> OnClickedReceiveButtonCallback;

	// Token: 0x02007FF1 RID: 32753
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029C50 RID: 171088
		ScoreItemTexture,
		// Token: 0x04029C51 RID: 171089
		TitleNameText,
		// Token: 0x04029C52 RID: 171090
		CurrentProgressText,
		// Token: 0x04029C53 RID: 171091
		ScoreRewardText,
		// Token: 0x04029C54 RID: 171092
		SkipToButton,
		// Token: 0x04029C55 RID: 171093
		ReceiveButton,
		// Token: 0x04029C56 RID: 171094
		DoneSprite
	}
}
