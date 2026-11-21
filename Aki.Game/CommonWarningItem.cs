using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CB6 RID: 3254
[NullableContext(1)]
[Nullable(0)]
public class CommonWarningItem : UiPanelBase
{
	// Token: 0x060087BA RID: 34746 RVA: 0x0029494C File Offset: 0x00292B4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060087BB RID: 34747 RVA: 0x002949D8 File Offset: 0x00292BD8
	public void SetWarningIcon(string iconPath)
	{
		base.SetTextureByPath(iconPath, base.GetTexture(1), null, null);
	}

	// Token: 0x060087BC RID: 34748 RVA: 0x002949FD File Offset: 0x00292BFD
	public void SetIconVisible(bool visible)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(visible);
	}

	// Token: 0x060087BD RID: 34749 RVA: 0x00294A11 File Offset: 0x00292C11
	public void SetLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x060087BE RID: 34750 RVA: 0x00294A26 File Offset: 0x00292C26
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x060087BF RID: 34751 RVA: 0x00294A3B File Offset: 0x00292C3B
	public void TrySetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x060087C0 RID: 34752 RVA: 0x00294A50 File Offset: 0x00292C50
	public void SetShowText(string text)
	{
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x060087C1 RID: 34753 RVA: 0x00294A60 File Offset: 0x00292C60
	public void SetTextShowState(bool state)
	{
		base.GetText(2).SetUIActive(state);
	}

	// Token: 0x02006F80 RID: 28544
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040246CC RID: 149196
		public const int ItemSelf = 0;

		// Token: 0x040246CD RID: 149197
		public const int TextureIcon = 1;

		// Token: 0x040246CE RID: 149198
		public const int TextTip = 2;
	}
}
