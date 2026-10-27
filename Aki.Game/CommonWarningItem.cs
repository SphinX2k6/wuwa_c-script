using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017FD RID: 6141
[NullableContext(1)]
[Nullable(0)]
public class CommonWarningItem : UiPanelBase
{
	// Token: 0x0600B3D0 RID: 46032 RVA: 0x0028A250 File Offset: 0x00288450
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

	// Token: 0x0600B3D1 RID: 46033 RVA: 0x0028A2DC File Offset: 0x002884DC
	public void SetWarningIcon(string iconPath)
	{
		base.SetTextureByPath(iconPath, base.GetTexture(1), null, null);
	}

	// Token: 0x0600B3D2 RID: 46034 RVA: 0x0028A301 File Offset: 0x00288501
	public void SetIconVisible(bool visible)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(visible);
	}

	// Token: 0x0600B3D3 RID: 46035 RVA: 0x0028A315 File Offset: 0x00288515
	public void SetLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x0600B3D4 RID: 46036 RVA: 0x0028A32A File Offset: 0x0028852A
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x0600B3D5 RID: 46037 RVA: 0x0028A33F File Offset: 0x0028853F
	public void TrySetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x0600B3D6 RID: 46038 RVA: 0x0028A354 File Offset: 0x00288554
	public void SetShowText(string text)
	{
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x0600B3D7 RID: 46039 RVA: 0x0028A364 File Offset: 0x00288564
	public void SetTextShowState(bool state)
	{
		base.GetText(2).SetUIActive(state);
	}

	// Token: 0x02007DFA RID: 32250
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040293A1 RID: 168865
		public const int ItemSelf = 0;

		// Token: 0x040293A2 RID: 168866
		public const int TextureIcon = 1;

		// Token: 0x040293A3 RID: 168867
		public const int TextTip = 2;
	}
}
