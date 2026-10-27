using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017E7 RID: 6119
[NullableContext(1)]
[Nullable(0)]
public class ButtonAndSpriteItem : UiPanelBase
{
	// Token: 0x0600B2FE RID: 45822 RVA: 0x00287579 File Offset: 0x00285779
	public ButtonAndSpriteItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B2FF RID: 45823 RVA: 0x00287590 File Offset: 0x00285790
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

	// Token: 0x0600B300 RID: 45824 RVA: 0x00287658 File Offset: 0x00285858
	public void RefreshSprite(string spritePath)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(spritePath);
		this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, new Action<bool>(this.RefreshAllTransitionSprite));
	}

	// Token: 0x0600B301 RID: 45825 RVA: 0x00287698 File Offset: 0x00285898
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

	// Token: 0x0600B302 RID: 45826 RVA: 0x002876C7 File Offset: 0x002858C7
	public void RefreshEnable(bool isEnable)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(isEnable);
	}

	// Token: 0x0600B303 RID: 45827 RVA: 0x002876DB File Offset: 0x002858DB
	public void BindCallback(Action onCallback)
	{
		this.OnCallback = onCallback;
	}

	// Token: 0x0600B304 RID: 45828 RVA: 0x002876E4 File Offset: 0x002858E4
	private void OnClick()
	{
		if (this.OnCallback != null)
		{
			this.OnCallback();
		}
	}

	// Token: 0x04005115 RID: 20757
	[Nullable(2)]
	private Action OnCallback;

	// Token: 0x02007DD4 RID: 32212
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x0402930B RID: 168715
		public const int Button = 0;

		// Token: 0x0402930C RID: 168716
		public const int Sprite = 1;

		// Token: 0x0402930D RID: 168717
		public const int SpriteTransition = 2;
	}
}
