using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001157 RID: 4439
public class QuickOptionItem : GridProxyAbstract<BabelTowerQuick>
{
	// Token: 0x060074CA RID: 29898 RVA: 0x0017F800 File Offset: 0x0017DA00
	public BabelTowerQuick? GetCurrentData()
	{
		return this.CurrentData;
	}

	// Token: 0x060074CB RID: 29899 RVA: 0x0017F808 File Offset: 0x0017DA08
	private bool CheckIfLocked(BabelTowerQuick data)
	{
		for (int i = 0; i < data.BuffGroupLength; i++)
		{
			int key = data.BuffGroup(i);
			IBabelTowerSelectInfo valueOrDefault = BabelTowerModel.Instance.DeTermSelectInfo.GetValueOrDefault(key);
			if (valueOrDefault != null && valueOrDefault.State == EBabelTowerDeTermState.Lock)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060074CC RID: 29900 RVA: 0x0017F854 File Offset: 0x0017DA54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnQuickItemClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060074CD RID: 29901 RVA: 0x0017F97E File Offset: 0x0017DB7E
	[NullableContext(2)]
	public UUIExtendToggle GetQuickToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x060074CE RID: 29902 RVA: 0x0017F988 File Offset: 0x0017DB88
	private void OnQuickItemClick(EToggleState state)
	{
		if (this.IsLocked)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelQuickLevelUnlock", Array.Empty<object>());
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			return;
		}
		if (state == EToggleState.ETT_Checked)
		{
			Action<BabelTowerQuick, int> onQuickOptionClickWithIndex = this.OnQuickOptionClickWithIndex;
			if (onQuickOptionClickWithIndex == null)
			{
				return;
			}
			onQuickOptionClickWithIndex(this.CurrentData.Value, base.GridIndex);
		}
	}

	// Token: 0x060074CF RID: 29903 RVA: 0x0017F9EC File Offset: 0x0017DBEC
	public override void Refresh(BabelTowerQuick data, bool isSelected, int gridIndex)
	{
		this.QuickId = data.Id;
		this.CurrentData = new BabelTowerQuick?(data);
		this.IsLocked = this.CheckIfLocked(data);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Des, Array.Empty<object>());
		this.SetDeLevelArt(data, isSelected);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLocked);
	}

	// Token: 0x060074D0 RID: 29904 RVA: 0x0017FA88 File Offset: 0x0017DC88
	private void SetDeLevelArt(BabelTowerQuick data, bool isSelected)
	{
		UUIArtText artText = base.GetArtText(4);
		if (artText == null)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < data.BuffGroupLength; i++)
		{
			int id = data.BuffGroup(i);
			BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(id);
			num += babelTowerDeTerm.Star;
		}
		artText.SetText(((num < 10) ? "0" : "") + num.ToString());
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(data.ActivityId, num);
		if (babelTowerDifficulty != null)
		{
			FColor color = FColor.FromHex(babelTowerDifficulty.GetValueOrDefault().TextBgColor);
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetColor(color);
			}
			this.SetDifficultyText(data.DifficultyTextKey);
			return;
		}
	}

	// Token: 0x060074D1 RID: 29905 RVA: 0x0017FB55 File Offset: 0x0017DD55
	[NullableContext(1)]
	private void SetDifficultyText(string textKey)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textKey, Array.Empty<object>());
	}

	// Token: 0x040035B4 RID: 13748
	public int QuickId;

	// Token: 0x040035B5 RID: 13749
	[Nullable(2)]
	public Action<BabelTowerQuick, int> OnQuickOptionClickWithIndex;

	// Token: 0x040035B6 RID: 13750
	private BabelTowerQuick? CurrentData;

	// Token: 0x040035B7 RID: 13751
	private bool IsLocked;

	// Token: 0x02007715 RID: 30485
	private class EBuffItemSubComponent
	{
		// Token: 0x04027486 RID: 160902
		public const int QuickItem = 0;

		// Token: 0x04027487 RID: 160903
		public const int ColorSprite = 1;

		// Token: 0x04027488 RID: 160904
		public const int TitleText = 2;

		// Token: 0x04027489 RID: 160905
		public const int DescText = 3;

		// Token: 0x0402748A RID: 160906
		public const int DeLevelArt = 4;

		// Token: 0x0402748B RID: 160907
		public const int LockItem = 5;
	}
}
