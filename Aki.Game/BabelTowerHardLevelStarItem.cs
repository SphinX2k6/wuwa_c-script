using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000619 RID: 1561
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerHardLevelStarItem : UiPanelBase
{
	// Token: 0x0600492A RID: 18730 RVA: 0x0018D468 File Offset: 0x0018B668
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnLookBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600492B RID: 18731 RVA: 0x0018D592 File Offset: 0x0018B792
	public void SetLookBtnClickCallback(Action callback)
	{
		this.LookBtnClickCallback = callback;
	}

	// Token: 0x0600492C RID: 18732 RVA: 0x0018D59C File Offset: 0x0018B79C
	public void RefreshStar(int starNumber)
	{
		UUIArtText artText = base.GetArtText(1);
		if (artText != null)
		{
			artText.SetText(((starNumber < 10) ? "0" : "") + starNumber.ToString());
		}
	}

	// Token: 0x0600492D RID: 18733 RVA: 0x0018D5D8 File Offset: 0x0018B7D8
	public void SetDifficultyBg(string colorHex)
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			FColor color = FColor.FromHex(colorHex);
			sprite.SetColor(color);
		}
	}

	// Token: 0x0600492E RID: 18734 RVA: 0x0018D600 File Offset: 0x0018B800
	public void SetDifficultyText(string difficultyTextKey)
	{
		UUIText text = base.GetText(3);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, difficultyTextKey, Array.Empty<object>());
		}
	}

	// Token: 0x0600492F RID: 18735 RVA: 0x0018D62C File Offset: 0x0018B82C
	public void SetDeBuffNum(int deBuffCount)
	{
		UUIText text = base.GetText(4);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "Babel_fuhe", new <>z__ReadOnlySingleElementList<object>(deBuffCount));
		}
	}

	// Token: 0x06004930 RID: 18736 RVA: 0x0018D660 File Offset: 0x0018B860
	public void SetNameText(string nameTextKey)
	{
		UUIText text = base.GetText(5);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, nameTextKey, Array.Empty<object>());
		}
	}

	// Token: 0x06004931 RID: 18737 RVA: 0x0018D689 File Offset: 0x0018B889
	private void OnLookBtnClick()
	{
		Action lookBtnClickCallback = this.LookBtnClickCallback;
		if (lookBtnClickCallback == null)
		{
			return;
		}
		lookBtnClickCallback();
	}

	// Token: 0x04003691 RID: 13969
	[Nullable(2)]
	private Action LookBtnClickCallback;

	// Token: 0x020068C5 RID: 26821
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402287A RID: 141434
		public const int LookBtn = 0;

		// Token: 0x0402287B RID: 141435
		public const int StartNumText = 1;

		// Token: 0x0402287C RID: 141436
		public const int DiffColorBg = 2;

		// Token: 0x0402287D RID: 141437
		public const int DiffColorText = 3;

		// Token: 0x0402287E RID: 141438
		public const int DeBuffNumText = 4;

		// Token: 0x0402287F RID: 141439
		public const int NameText = 5;
	}
}
