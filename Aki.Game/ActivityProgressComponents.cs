using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A03 RID: 2563
[NullableContext(1)]
[Nullable(0)]
public class ActivityProgressComponents : UiPanelBase
{
	// Token: 0x06006FA5 RID: 28581 RVA: 0x00225734 File Offset: 0x00223934
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

	// Token: 0x06006FA6 RID: 28582 RVA: 0x002257DF File Offset: 0x002239DF
	public void SetProgressPercent(float progress)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(progress);
	}

	// Token: 0x06006FA7 RID: 28583 RVA: 0x002257F3 File Offset: 0x002239F3
	public void SetProgressTextByText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06006FA8 RID: 28584 RVA: 0x00225808 File Offset: 0x00223A08
	public void SetTitleByTextId(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x06006FA9 RID: 28585 RVA: 0x0022581D File Offset: 0x00223A1D
	public void SetTitleByText(string text)
	{
		UUIText text2 = base.GetText(2);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06006FAA RID: 28586 RVA: 0x00225832 File Offset: 0x00223A32
	public void SetDescriptionByTextId(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
	}

	// Token: 0x06006FAB RID: 28587 RVA: 0x00225847 File Offset: 0x00223A47
	public void SetDescriptionByText(string text)
	{
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x02006D0B RID: 27915
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023CE0 RID: 146656
		public const int SpriteProgress = 0;

		// Token: 0x04023CE1 RID: 146657
		public const int TextProgress = 1;

		// Token: 0x04023CE2 RID: 146658
		public const int Title = 2;

		// Token: 0x04023CE3 RID: 146659
		public const int TextDescription = 3;
	}
}
