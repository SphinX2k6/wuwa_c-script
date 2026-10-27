using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001165 RID: 4453
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerHardLevelStarItem : UiPanelBase
{
	// Token: 0x06007593 RID: 30099 RVA: 0x001848EC File Offset: 0x00182AEC
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

	// Token: 0x06007594 RID: 30100 RVA: 0x00184A16 File Offset: 0x00182C16
	public void SetLookBtnClickCallback(Action callback)
	{
		this.LookBtnClickCallback = callback;
	}

	// Token: 0x06007595 RID: 30101 RVA: 0x00184A20 File Offset: 0x00182C20
	public void RefreshStar(int starNumber)
	{
		UUIArtText artText = base.GetArtText(1);
		if (artText != null)
		{
			artText.SetText(((starNumber < 10) ? "0" : "") + starNumber.ToString());
		}
	}

	// Token: 0x06007596 RID: 30102 RVA: 0x00184A5C File Offset: 0x00182C5C
	public void SetDifficultyBg(string colorHex)
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			FColor color = FColor.FromHex(colorHex);
			sprite.SetColor(color);
		}
	}

	// Token: 0x06007597 RID: 30103 RVA: 0x00184A84 File Offset: 0x00182C84
	public void SetDifficultyText(string difficultyTextKey)
	{
		UUIText text = base.GetText(3);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, difficultyTextKey, Array.Empty<object>());
		}
	}

	// Token: 0x06007598 RID: 30104 RVA: 0x00184AB0 File Offset: 0x00182CB0
	public void SetDeBuffNum(int deBuffCount)
	{
		UUIText text = base.GetText(4);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "Babel_fuhe", new <>z__ReadOnlySingleElementList<object>(deBuffCount));
		}
	}

	// Token: 0x06007599 RID: 30105 RVA: 0x00184AE4 File Offset: 0x00182CE4
	public void SetNameText(string nameTextKey)
	{
		UUIText text = base.GetText(5);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, nameTextKey, Array.Empty<object>());
		}
	}

	// Token: 0x0600759A RID: 30106 RVA: 0x00184B0D File Offset: 0x00182D0D
	private void OnLookBtnClick()
	{
		Action lookBtnClickCallback = this.LookBtnClickCallback;
		if (lookBtnClickCallback == null)
		{
			return;
		}
		lookBtnClickCallback();
	}

	// Token: 0x040035F8 RID: 13816
	[Nullable(2)]
	private Action LookBtnClickCallback;

	// Token: 0x02007737 RID: 30519
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402753C RID: 161084
		public const int LookBtn = 0;

		// Token: 0x0402753D RID: 161085
		public const int StartNumText = 1;

		// Token: 0x0402753E RID: 161086
		public const int DiffColorBg = 2;

		// Token: 0x0402753F RID: 161087
		public const int DiffColorText = 3;

		// Token: 0x04027540 RID: 161088
		public const int DeBuffNumText = 4;

		// Token: 0x04027541 RID: 161089
		public const int NameText = 5;
	}
}
