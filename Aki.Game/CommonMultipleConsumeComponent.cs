using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.Consume;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200180D RID: 6157
[NullableContext(1)]
[Nullable(0)]
public class CommonMultipleConsumeComponent : UiPanelBase
{
	// Token: 0x0600B483 RID: 46211 RVA: 0x0028BC84 File Offset: 0x00289E84
	public CommonMultipleConsumeComponent(UUIItem uiItem, CommonMultipleConsumeFunction consumeFunction, bool needConditionFilter = true, EUiViewName? belongView = null)
	{
		this.ConsumeFunction = consumeFunction;
		this.NeedConditionFilter = needConditionFilter;
		this.BelongView = belongView;
		this.ConsumeList = new List<TCommonMultipleConsumeData>();
		this.MaxCount = 0;
		this.EnoughMoney = true;
		this.QualityId = 0;
		this.IsNeedShowMaterial = true;
		this.ButtonText = "WeaponLevelUpText";
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B484 RID: 46212 RVA: 0x0028BCEC File Offset: 0x00289EEC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.AutoClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.ConditionClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B485 RID: 46213 RVA: 0x0028BF6A File Offset: 0x0028A16A
	private void AutoClick()
	{
		if (this.ConsumeFunction.AutoFunction != null)
		{
			this.ConsumeFunction.AutoFunction(this.QualityId);
		}
	}

	// Token: 0x0600B486 RID: 46214 RVA: 0x0028BF8F File Offset: 0x0028A18F
	private void ConditionClick()
	{
		this.CommonConditionFilterComponent.UpdateComponent(this.QualityId);
	}

	// Token: 0x0600B487 RID: 46215 RVA: 0x0028BFA4 File Offset: 0x0028A1A4
	protected override void OnStart()
	{
		this.StrengthItem = new ButtonItem(base.GetItem(7));
		this.StrengthItem.SetFunction(delegate(int data)
		{
			TCommonMultipleConsumeFunction strengthFunction = this.ConsumeFunction.StrengthFunction;
			if (strengthFunction == null)
			{
				return;
			}
			strengthFunction(data);
		});
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(4);
		AUIBaseActor gridActor = base.GetItem(8).GetOwner() as AUIBaseActor;
		this.LoopScrollView = new LoopScrollView<ConsumeItem, TCommonMultipleConsumeData>(loopScrollViewComponent, gridActor, new Func<ConsumeItem>(this.InitItem), false);
		base.GetButton(9).RootUIComp.Get().SetUIActive(this.NeedConditionFilter);
		if (this.NeedConditionFilter)
		{
			this.CommonConditionFilterComponent = new CommonConditionFilterComponent(base.GetItem(11), new CSharpScript.Game.Module.Common.Consume.TCommonConditionFilterFunction(this.ConditionFunction));
			this.CommonConditionFilterComponent.RefreshQualityList(CommonConfig.Instance.GetItemQualityList());
			this.CommonConditionFilterComponent.SetActive(false);
		}
		this.MaxCount = WeaponConfig.Instance.GetMaterialItemMaxCount();
	}

	// Token: 0x0600B488 RID: 46216 RVA: 0x0028C086 File Offset: 0x0028A286
	private void ConditionFunction(int qualityId, string text)
	{
		this.QualityId = qualityId;
		base.GetText(10).ShowTextNew(text);
		if (this.ConditionFilterFunction != null)
		{
			this.ConditionFilterFunction(qualityId);
		}
	}

	// Token: 0x0600B489 RID: 46217 RVA: 0x0028C0B1 File Offset: 0x0028A2B1
	public void RefreshConditionFilter(int qualityId, string text)
	{
		this.QualityId = qualityId;
		base.GetText(10).ShowTextNew(text);
	}

	// Token: 0x0600B48A RID: 46218 RVA: 0x0028C0C8 File Offset: 0x0028A2C8
	private ConsumeItem InitItem()
	{
		ConsumeItem consumeItem = new ConsumeItem(null, this.BelongView);
		consumeItem.SetButtonFunction(delegate(int? incId, int? itemId)
		{
			TCommonMultipleConsumeFunctionWithInt materialItemFunction = this.ConsumeFunction.MaterialItemFunction;
			if (materialItemFunction == null)
			{
				return;
			}
			materialItemFunction(incId, itemId);
		});
		return consumeItem;
	}

	// Token: 0x0600B48B RID: 46219 RVA: 0x0028C0E8 File Offset: 0x0028A2E8
	private TCommonMultipleConsumeData UpdateItem(int gridIndex)
	{
		return this.ConsumeList[gridIndex];
	}

	// Token: 0x0600B48C RID: 46220 RVA: 0x0028C0F6 File Offset: 0x0028A2F6
	protected override void OnBeforeDestroy()
	{
		if (this.StrengthItem != null)
		{
			this.StrengthItem.Destroy(null);
			this.StrengthItem = null;
		}
		if (this.CommonConditionFilterComponent != null)
		{
			this.CommonConditionFilterComponent.Destroy(null);
			this.CommonConditionFilterComponent = null;
		}
	}

	// Token: 0x0600B48D RID: 46221 RVA: 0x0028C130 File Offset: 0x0028A330
	public void UpdateComponent(int moneyId, int costCount, List<TCommonMultipleConsumeData> consumeList)
	{
		this.SetMaxState(false);
		this.ConsumeList = consumeList;
		this.LoopScrollView.ReloadProxyData(new Func<int, TCommonMultipleConsumeData>(this.UpdateItem), this.MaxCount, true, false);
		LguiUtil.Instance.SetLocalText(base.GetText(6), "WeaponMaterialLengthText", new <>z__ReadOnlyArray<object>(new object[]
		{
			consumeList.Count,
			this.MaxCount
		}));
		UUIText text = base.GetText(1);
		UUIText text2 = base.GetText(3);
		int playerMoney = PlayerInfoModel.Instance.GetPlayerMoney(moneyId);
		this.EnoughMoney = UiComponentUtil.SetMoneyState(text, text2, costCount, playerMoney);
	}

	// Token: 0x0600B48E RID: 46222 RVA: 0x0028C1D4 File Offset: 0x0028A3D4
	public void SetMaxState(bool inMax)
	{
		base.GetItem(12).SetUIActive(!inMax);
		if (this.IsNeedShowMaterial)
		{
			base.GetItem(13).SetUIActive(!inMax);
		}
		this.SetStrengthItemEnable(!inMax);
		if (inMax)
		{
			this.SetStrengthItemText("LevelUpMax");
			return;
		}
		this.SetStrengthItemText(this.ButtonText);
	}

	// Token: 0x0600B48F RID: 46223 RVA: 0x0028C230 File Offset: 0x0028A430
	public void SetStrengthItemText(string text)
	{
		this.StrengthItem.SetLocalText(text, Array.Empty<object>());
	}

	// Token: 0x0600B490 RID: 46224 RVA: 0x0028C243 File Offset: 0x0028A443
	public void SetStrengthTextCode(string text)
	{
		this.ButtonText = text;
	}

	// Token: 0x0600B491 RID: 46225 RVA: 0x0028C24C File Offset: 0x0028A44C
	public void SetStrengthItemEnable(bool state)
	{
		this.StrengthItem.SetEnableClick(state);
	}

	// Token: 0x0600B492 RID: 46226 RVA: 0x0028C25A File Offset: 0x0028A45A
	public int GetConsumeListSize()
	{
		return this.ConsumeList.Count;
	}

	// Token: 0x0600B493 RID: 46227 RVA: 0x0028C267 File Offset: 0x0028A467
	public bool GetEnoughMoney()
	{
		return this.EnoughMoney;
	}

	// Token: 0x0600B494 RID: 46228 RVA: 0x0028C26F File Offset: 0x0028A46F
	public void SetIsNeedShowMaterial(bool isNeed)
	{
		this.IsNeedShowMaterial = isNeed;
	}

	// Token: 0x0600B495 RID: 46229 RVA: 0x0028C278 File Offset: 0x0028A478
	public void ShowMaterialItem(bool show)
	{
		base.GetItem(13).SetUIActive(show);
	}

	// Token: 0x0600B496 RID: 46230 RVA: 0x0028C288 File Offset: 0x0028A488
	public void ShowConditionViewItem(bool show)
	{
		base.GetItem(11).SetUIActive(show);
	}

	// Token: 0x0600B497 RID: 46231 RVA: 0x0028C298 File Offset: 0x0028A498
	public void SetIsNeedShowTitleLayout(bool isNeed)
	{
		base.GetItem(14).SetUIActive(isNeed);
	}

	// Token: 0x0600B498 RID: 46232 RVA: 0x0028C2A8 File Offset: 0x0028A4A8
	public void SetMaxCount(int count)
	{
		this.MaxCount = count;
	}

	// Token: 0x0600B499 RID: 46233 RVA: 0x0028C2B4 File Offset: 0x0028A4B4
	public void SetConsumeTexture(int itemId)
	{
		base.SetItemIcon(base.GetTexture(0), itemId, null, null);
		base.SetItemIcon(base.GetTexture(2), itemId, null, null);
	}

	// Token: 0x0600B49A RID: 46234 RVA: 0x0028C2F1 File Offset: 0x0028A4F1
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public LoopScrollView<ConsumeItem, TCommonMultipleConsumeData> GetSelfLoopScroll()
	{
		return this.LoopScrollView;
	}

	// Token: 0x0600B49B RID: 46235 RVA: 0x0028C2F9 File Offset: 0x0028A4F9
	public void SetConditionFilterFunction(global::TCommonConditionFilterFunction filterFunc)
	{
		this.ConditionFilterFunction = filterFunc;
	}

	// Token: 0x04005172 RID: 20850
	[Nullable(2)]
	protected ButtonItem StrengthItem;

	// Token: 0x04005173 RID: 20851
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected LoopScrollView<ConsumeItem, TCommonMultipleConsumeData> LoopScrollView;

	// Token: 0x04005174 RID: 20852
	protected List<TCommonMultipleConsumeData> ConsumeList;

	// Token: 0x04005175 RID: 20853
	[Nullable(2)]
	protected CommonConditionFilterComponent CommonConditionFilterComponent;

	// Token: 0x04005176 RID: 20854
	protected int MaxCount;

	// Token: 0x04005177 RID: 20855
	protected bool EnoughMoney;

	// Token: 0x04005178 RID: 20856
	protected int QualityId;

	// Token: 0x04005179 RID: 20857
	private bool IsNeedShowMaterial;

	// Token: 0x0400517A RID: 20858
	private string ButtonText;

	// Token: 0x0400517B RID: 20859
	[Nullable(2)]
	private global::TCommonConditionFilterFunction ConditionFilterFunction;

	// Token: 0x0400517C RID: 20860
	protected CommonMultipleConsumeFunction ConsumeFunction;

	// Token: 0x0400517D RID: 20861
	public bool NeedConditionFilter;

	// Token: 0x0400517E RID: 20862
	public EUiViewName? BelongView;

	// Token: 0x02007DFE RID: 32254
	[NullableContext(0)]
	private class ECommonMultipleConsumeComponent
	{
		// Token: 0x040293AA RID: 168874
		public const int ConsumeTexture = 0;

		// Token: 0x040293AB RID: 168875
		public const int ConsumeText = 1;

		// Token: 0x040293AC RID: 168876
		public const int OwnTexture = 2;

		// Token: 0x040293AD RID: 168877
		public const int OwnText = 3;

		// Token: 0x040293AE RID: 168878
		public const int LoopScrollView = 4;

		// Token: 0x040293AF RID: 168879
		public const int AutoButton = 5;

		// Token: 0x040293B0 RID: 168880
		public const int AddMaterialText = 6;

		// Token: 0x040293B1 RID: 168881
		public const int StrengthItem = 7;

		// Token: 0x040293B2 RID: 168882
		public const int MaterialItem = 8;

		// Token: 0x040293B3 RID: 168883
		public const int ConditionButton = 9;

		// Token: 0x040293B4 RID: 168884
		public const int ConditionText = 10;

		// Token: 0x040293B5 RID: 168885
		public const int ConditionViewItem = 11;

		// Token: 0x040293B6 RID: 168886
		public const int CostRootItem = 12;

		// Token: 0x040293B7 RID: 168887
		public const int MaterialRootItem = 13;

		// Token: 0x040293B8 RID: 168888
		public const int TitleLayoutItem = 14;
	}
}
