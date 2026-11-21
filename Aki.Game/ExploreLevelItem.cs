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

// Token: 0x02000F52 RID: 3922
[NullableContext(1)]
[Nullable(0)]
public class ExploreLevelItem : UiPanelBase, IGridProxy<CountryExploreScoreData>
{
	// Token: 0x1700109C RID: 4252
	// (get) Token: 0x06009CED RID: 40173 RVA: 0x002E7FA3 File Offset: 0x002E61A3
	// (set) Token: 0x06009CEE RID: 40174 RVA: 0x002E7FAB File Offset: 0x002E61AB
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

	// Token: 0x1700109D RID: 4253
	// (get) Token: 0x06009CEF RID: 40175 RVA: 0x002E7FB4 File Offset: 0x002E61B4
	// (set) Token: 0x06009CF0 RID: 40176 RVA: 0x002E7FBC File Offset: 0x002E61BC
	public int GridIndex { get; set; }

	// Token: 0x1700109E RID: 4254
	// (get) Token: 0x06009CF1 RID: 40177 RVA: 0x002E7FC5 File Offset: 0x002E61C5
	// (set) Token: 0x06009CF2 RID: 40178 RVA: 0x002E7FCD File Offset: 0x002E61CD
	public int DisplayIndex { get; set; }

	// Token: 0x06009CF3 RID: 40179 RVA: 0x002E7FD8 File Offset: 0x002E61D8
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

	// Token: 0x06009CF4 RID: 40180 RVA: 0x002E8146 File Offset: 0x002E6346
	public void Clear()
	{
	}

	// Token: 0x06009CF5 RID: 40181 RVA: 0x002E8148 File Offset: 0x002E6348
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06009CF6 RID: 40182 RVA: 0x002E814A File Offset: 0x002E634A
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06009CF7 RID: 40183 RVA: 0x002E814C File Offset: 0x002E634C
	protected override void OnBeforeDestroy()
	{
		this.CountryExploreScoreData = null;
		this.OnClickedReceiveButtonCallback = null;
	}

	// Token: 0x06009CF8 RID: 40184 RVA: 0x002E815C File Offset: 0x002E635C
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

	// Token: 0x06009CF9 RID: 40185 RVA: 0x002E829D File Offset: 0x002E649D
	public void BindOnClickedReceiveButton(Action<CountryExploreScoreData> onClickedReceiveButton)
	{
		this.OnClickedReceiveButtonCallback = onClickedReceiveButton;
	}

	// Token: 0x06009CFA RID: 40186 RVA: 0x002E82A8 File Offset: 0x002E64A8
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

	// Token: 0x06009CFB RID: 40187 RVA: 0x002E832C File Offset: 0x002E652C
	private void OnClickedReceiveButton()
	{
		Action<CountryExploreScoreData> onClickedReceiveButtonCallback = this.OnClickedReceiveButtonCallback;
		if (onClickedReceiveButtonCallback == null)
		{
			return;
		}
		onClickedReceiveButtonCallback(this.CountryExploreScoreData);
	}

	// Token: 0x06009CFC RID: 40188 RVA: 0x002E8344 File Offset: 0x002E6544
	public object GetKey(CountryExploreScoreData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x04005D55 RID: 23893
	[Nullable(2)]
	private CountryExploreScoreData CountryExploreScoreData;

	// Token: 0x04005D56 RID: 23894
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<CountryExploreScoreData> OnClickedReceiveButtonCallback;

	// Token: 0x02007180 RID: 29056
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024F8A RID: 151434
		ScoreItemTexture,
		// Token: 0x04024F8B RID: 151435
		TitleNameText,
		// Token: 0x04024F8C RID: 151436
		CurrentProgressText,
		// Token: 0x04024F8D RID: 151437
		ScoreRewardText,
		// Token: 0x04024F8E RID: 151438
		SkipToButton,
		// Token: 0x04024F8F RID: 151439
		ReceiveButton,
		// Token: 0x04024F90 RID: 151440
		DoneSprite
	}
}
