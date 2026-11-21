using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CA0 RID: 3232
[NullableContext(1)]
[Nullable(0)]
public class ButtonAndSpriteItem : UiPanelBase
{
	// Token: 0x060086E8 RID: 34536 RVA: 0x00291C4D File Offset: 0x0028FE4D
	public ButtonAndSpriteItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x00291C64 File Offset: 0x0028FE64
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISpriteTransition));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x00291D2C File Offset: 0x0028FF2C
	public void RefreshSprite(string spritePath)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(spritePath);
		this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, new Action<bool>(this.RefreshAllTransitionSprite));
	}

	// Token: 0x060086EB RID: 34539 RVA: 0x00291D6C File Offset: 0x0028FF6C
	public void RefreshAllTransitionSprite(bool arg)
	{
		UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(2);
		if (uiSpriteTransition != null)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				uiSpriteTransition.SetAllTransitionSprite(sprite.GetSprite());
			}
		}
	}

	// Token: 0x060086EC RID: 34540 RVA: 0x00291D9B File Offset: 0x0028FF9B
	public void RefreshEnable(bool isEnable)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(isEnable);
	}

	// Token: 0x060086ED RID: 34541 RVA: 0x00291DAF File Offset: 0x0028FFAF
	public void BindCallback(Action onCallback)
	{
		this.OnCallback = onCallback;
	}

	// Token: 0x060086EE RID: 34542 RVA: 0x00291DB8 File Offset: 0x0028FFB8
	private void OnClick()
	{
		if (this.OnCallback != null)
		{
			this.OnCallback();
		}
	}

	// Token: 0x040051C0 RID: 20928
	[Nullable(2)]
	private Action OnCallback;

	// Token: 0x02006F5A RID: 28506
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x04024636 RID: 149046
		public const int Button = 0;

		// Token: 0x04024637 RID: 149047
		public const int Sprite = 1;

		// Token: 0x04024638 RID: 149048
		public const int SpriteTransition = 2;
	}
}
