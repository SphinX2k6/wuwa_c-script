using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200154B RID: 5451
[NullableContext(1)]
[Nullable(0)]
public class ActivityProgressComponents : UiPanelBase
{
	// Token: 0x06009BC7 RID: 39879 RVA: 0x0021B984 File Offset: 0x00219B84
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009BC8 RID: 39880 RVA: 0x0021BA2F File Offset: 0x00219C2F
	public void SetProgressPercent(float progress)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(progress);
	}

	// Token: 0x06009BC9 RID: 39881 RVA: 0x0021BA43 File Offset: 0x00219C43
	public void SetProgressTextByText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06009BCA RID: 39882 RVA: 0x0021BA58 File Offset: 0x00219C58
	public void SetTitleByTextId(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x06009BCB RID: 39883 RVA: 0x0021BA6D File Offset: 0x00219C6D
	public void SetTitleByText(string text)
	{
		UUIText text2 = base.GetText(2);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06009BCC RID: 39884 RVA: 0x0021BA82 File Offset: 0x00219C82
	public void SetDescriptionByTextId(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
	}

	// Token: 0x06009BCD RID: 39885 RVA: 0x0021BA97 File Offset: 0x00219C97
	public void SetDescriptionByText(string text)
	{
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x02007B80 RID: 31616
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040289A5 RID: 166309
		public const int SpriteProgress = 0;

		// Token: 0x040289A6 RID: 166310
		public const int TextProgress = 1;

		// Token: 0x040289A7 RID: 166311
		public const int Title = 2;

		// Token: 0x040289A8 RID: 166312
		public const int TextDescription = 3;
	}
}
