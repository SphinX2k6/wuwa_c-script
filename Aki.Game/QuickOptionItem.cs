using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200060B RID: 1547
public class QuickOptionItem : GridProxyAbstract<BabelTowerQuick>
{
	// Token: 0x06004861 RID: 18529 RVA: 0x0018834C File Offset: 0x0018654C
	public BabelTowerQuick? GetCurrentData()
	{
		return this.CurrentData;
	}

	// Token: 0x06004862 RID: 18530 RVA: 0x00188354 File Offset: 0x00186554
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

	// Token: 0x06004863 RID: 18531 RVA: 0x001883A0 File Offset: 0x001865A0
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

	// Token: 0x06004864 RID: 18532 RVA: 0x001884CA File Offset: 0x001866CA
	[NullableContext(2)]
	public UUIExtendToggle GetQuickToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06004865 RID: 18533 RVA: 0x001884D4 File Offset: 0x001866D4
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

	// Token: 0x06004866 RID: 18534 RVA: 0x00188538 File Offset: 0x00186738
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

	// Token: 0x06004867 RID: 18535 RVA: 0x001885D4 File Offset: 0x001867D4
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

	// Token: 0x06004868 RID: 18536 RVA: 0x001886A1 File Offset: 0x001868A1
	[NullableContext(1)]
	private void SetDifficultyText(string textKey)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textKey, Array.Empty<object>());
	}

	// Token: 0x0400364D RID: 13901
	public int QuickId;

	// Token: 0x0400364E RID: 13902
	[Nullable(2)]
	public Action<BabelTowerQuick, int> OnQuickOptionClickWithIndex;

	// Token: 0x0400364F RID: 13903
	private BabelTowerQuick? CurrentData;

	// Token: 0x04003650 RID: 13904
	private bool IsLocked;

	// Token: 0x020068A4 RID: 26788
	private class EBuffItemSubComponent
	{
		// Token: 0x040227C7 RID: 141255
		public const int QuickItem = 0;

		// Token: 0x040227C8 RID: 141256
		public const int ColorSprite = 1;

		// Token: 0x040227C9 RID: 141257
		public const int TitleText = 2;

		// Token: 0x040227CA RID: 141258
		public const int DescText = 3;

		// Token: 0x040227CB RID: 141259
		public const int DeLevelArt = 4;

		// Token: 0x040227CC RID: 141260
		public const int LockItem = 5;
	}
}
