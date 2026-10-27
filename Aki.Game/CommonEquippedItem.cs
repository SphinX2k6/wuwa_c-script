using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017F3 RID: 6131
public class CommonEquippedItem : UiPanelBase
{
	// Token: 0x0600B381 RID: 45953 RVA: 0x0028925C File Offset: 0x0028745C
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

	// Token: 0x0600B382 RID: 45954 RVA: 0x002892E8 File Offset: 0x002874E8
	[NullableContext(1)]
	public void SetEquipIcon(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x0600B383 RID: 45955 RVA: 0x0028930D File Offset: 0x0028750D
	[NullableContext(1)]
	public void SetEquipText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x0600B384 RID: 45956 RVA: 0x00289322 File Offset: 0x00287522
	public void SetCurrentEquippedState(bool state)
	{
		base.GetItem(0).SetUIActive(state);
	}

	// Token: 0x0600B385 RID: 45957 RVA: 0x00289331 File Offset: 0x00287531
	public void SetIconRootItemState(bool state)
	{
		this.RootItem.SetUIActive(state);
	}

	// Token: 0x02007DE9 RID: 32233
	private class ECommonEquippedItem
	{
		// Token: 0x04029355 RID: 168789
		public const int CurrentEquippedItem = 0;

		// Token: 0x04029356 RID: 168790
		public const int Icon = 1;

		// Token: 0x04029357 RID: 168791
		public const int Text = 2;
	}
}
