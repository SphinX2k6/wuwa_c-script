using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.Consume;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CC6 RID: 3270
[NullableContext(1)]
[Nullable(0)]
public class CommonMultipleConsumeComponent : UiPanelBase
{
	// Token: 0x0600886E RID: 34926 RVA: 0x002963A4 File Offset: 0x002945A4
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

	// Token: 0x0600886F RID: 34927 RVA: 0x0029640C File Offset: 0x0029460C
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

	// Token: 0x06008870 RID: 34928 RVA: 0x0029668A File Offset: 0x0029488A
	private void AutoClick()
	{
		if (this.ConsumeFunction.AutoFunction != null)
		{
			this.ConsumeFunction.AutoFunction(this.QualityId);
		}
	}

	// Token: 0x06008871 RID: 34929 RVA: 0x002966AF File Offset: 0x002948AF
	private void ConditionClick()
	{
		this.CommonConditionFilterComponent.UpdateComponent(this.QualityId);
	}

	// Token: 0x06008872 RID: 34930 RVA: 0x002966C4 File Offset: 0x002948C4
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

	// Token: 0x06008873 RID: 34931 RVA: 0x002967A6 File Offset: 0x002949A6
	private void ConditionFunction(int qualityId, string text)
	{
		this.QualityId = qualityId;
		base.GetText(10).ShowTextNew(text);
		if (this.ConditionFilterFunction != null)
		{
			this.ConditionFilterFunction(qualityId);
		}
	}

	// Token: 0x06008874 RID: 34932 RVA: 0x002967D1 File Offset: 0x002949D1
	public void RefreshConditionFilter(int qualityId, string text)
	{
		this.QualityId = qualityId;
		base.GetText(10).ShowTextNew(text);
	}

	// Token: 0x06008875 RID: 34933 RVA: 0x002967E8 File Offset: 0x002949E8
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

	// Token: 0x06008876 RID: 34934 RVA: 0x00296808 File Offset: 0x00294A08
	private TCommonMultipleConsumeData UpdateItem(int gridIndex)
	{
		return this.ConsumeList[gridIndex];
	}

	// Token: 0x06008877 RID: 34935 RVA: 0x00296816 File Offset: 0x00294A16
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

	// Token: 0x06008878 RID: 34936 RVA: 0x00296850 File Offset: 0x00294A50
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

	// Token: 0x06008879 RID: 34937 RVA: 0x002968F4 File Offset: 0x00294AF4
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

	// Token: 0x0600887A RID: 34938 RVA: 0x00296950 File Offset: 0x00294B50
	public void SetStrengthItemText(string text)
	{
		this.StrengthItem.SetLocalText(text, Array.Empty<object>());
	}

	// Token: 0x0600887B RID: 34939 RVA: 0x00296963 File Offset: 0x00294B63
	public void SetStrengthTextCode(string text)
	{
		this.ButtonText = text;
	}

	// Token: 0x0600887C RID: 34940 RVA: 0x0029696C File Offset: 0x00294B6C
	public void SetStrengthItemEnable(bool state)
	{
		this.StrengthItem.SetEnableClick(state);
	}

	// Token: 0x0600887D RID: 34941 RVA: 0x0029697A File Offset: 0x00294B7A
	public int GetConsumeListSize()
	{
		return this.ConsumeList.Count;
	}

	// Token: 0x0600887E RID: 34942 RVA: 0x00296987 File Offset: 0x00294B87
	public bool GetEnoughMoney()
	{
		return this.EnoughMoney;
	}

	// Token: 0x0600887F RID: 34943 RVA: 0x0029698F File Offset: 0x00294B8F
	public void SetIsNeedShowMaterial(bool isNeed)
	{
		this.IsNeedShowMaterial = isNeed;
	}

	// Token: 0x06008880 RID: 34944 RVA: 0x00296998 File Offset: 0x00294B98
	public void ShowMaterialItem(bool show)
	{
		base.GetItem(13).SetUIActive(show);
	}

	// Token: 0x06008881 RID: 34945 RVA: 0x002969A8 File Offset: 0x00294BA8
	public void ShowConditionViewItem(bool show)
	{
		base.GetItem(11).SetUIActive(show);
	}

	// Token: 0x06008882 RID: 34946 RVA: 0x002969B8 File Offset: 0x00294BB8
	public void SetIsNeedShowTitleLayout(bool isNeed)
	{
		base.GetItem(14).SetUIActive(isNeed);
	}

	// Token: 0x06008883 RID: 34947 RVA: 0x002969C8 File Offset: 0x00294BC8
	public void SetMaxCount(int count)
	{
		this.MaxCount = count;
	}

	// Token: 0x06008884 RID: 34948 RVA: 0x002969D4 File Offset: 0x00294BD4
	public void SetConsumeTexture(int itemId)
	{
		base.SetItemIcon(base.GetTexture(0), itemId, null, null);
		base.SetItemIcon(base.GetTexture(2), itemId, null, null);
	}

	// Token: 0x06008885 RID: 34949 RVA: 0x00296A11 File Offset: 0x00294C11
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public LoopScrollView<ConsumeItem, TCommonMultipleConsumeData> GetSelfLoopScroll()
	{
		return this.LoopScrollView;
	}

	// Token: 0x06008886 RID: 34950 RVA: 0x00296A19 File Offset: 0x00294C19
	public void SetConditionFilterFunction(global::TCommonConditionFilterFunction filterFunc)
	{
		this.ConditionFilterFunction = filterFunc;
	}

	// Token: 0x0400521D RID: 21021
	[Nullable(2)]
	protected ButtonItem StrengthItem;

	// Token: 0x0400521E RID: 21022
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected LoopScrollView<ConsumeItem, TCommonMultipleConsumeData> LoopScrollView;

	// Token: 0x0400521F RID: 21023
	protected List<TCommonMultipleConsumeData> ConsumeList;

	// Token: 0x04005220 RID: 21024
	[Nullable(2)]
	protected CommonConditionFilterComponent CommonConditionFilterComponent;

	// Token: 0x04005221 RID: 21025
	protected int MaxCount;

	// Token: 0x04005222 RID: 21026
	protected bool EnoughMoney;

	// Token: 0x04005223 RID: 21027
	protected int QualityId;

	// Token: 0x04005224 RID: 21028
	private bool IsNeedShowMaterial;

	// Token: 0x04005225 RID: 21029
	private string ButtonText;

	// Token: 0x04005226 RID: 21030
	[Nullable(2)]
	private global::TCommonConditionFilterFunction ConditionFilterFunction;

	// Token: 0x04005227 RID: 21031
	protected CommonMultipleConsumeFunction ConsumeFunction;

	// Token: 0x04005228 RID: 21032
	public bool NeedConditionFilter;

	// Token: 0x04005229 RID: 21033
	public EUiViewName? BelongView;

	// Token: 0x02006F84 RID: 28548
	[NullableContext(0)]
	private class ECommonMultipleConsumeComponent
	{
		// Token: 0x040246D5 RID: 149205
		public const int ConsumeTexture = 0;

		// Token: 0x040246D6 RID: 149206
		public const int ConsumeText = 1;

		// Token: 0x040246D7 RID: 149207
		public const int OwnTexture = 2;

		// Token: 0x040246D8 RID: 149208
		public const int OwnText = 3;

		// Token: 0x040246D9 RID: 149209
		public const int LoopScrollView = 4;

		// Token: 0x040246DA RID: 149210
		public const int AutoButton = 5;

		// Token: 0x040246DB RID: 149211
		public const int AddMaterialText = 6;

		// Token: 0x040246DC RID: 149212
		public const int StrengthItem = 7;

		// Token: 0x040246DD RID: 149213
		public const int MaterialItem = 8;

		// Token: 0x040246DE RID: 149214
		public const int ConditionButton = 9;

		// Token: 0x040246DF RID: 149215
		public const int ConditionText = 10;

		// Token: 0x040246E0 RID: 149216
		public const int ConditionViewItem = 11;

		// Token: 0x040246E1 RID: 149217
		public const int CostRootItem = 12;

		// Token: 0x040246E2 RID: 149218
		public const int MaterialRootItem = 13;

		// Token: 0x040246E3 RID: 149219
		public const int TitleLayoutItem = 14;
	}
}
