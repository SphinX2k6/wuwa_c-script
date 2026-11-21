using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CAC RID: 3244
public class CommonEquippedItem : UiPanelBase
{
	// Token: 0x0600876B RID: 34667 RVA: 0x00293958 File Offset: 0x00291B58
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

	// Token: 0x0600876C RID: 34668 RVA: 0x002939E4 File Offset: 0x00291BE4
	[NullableContext(1)]
	public void SetEquipIcon(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x0600876D RID: 34669 RVA: 0x00293A09 File Offset: 0x00291C09
	[NullableContext(1)]
	public void SetEquipText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x0600876E RID: 34670 RVA: 0x00293A1E File Offset: 0x00291C1E
	public void SetCurrentEquippedState(bool state)
	{
		base.GetItem(0).SetUIActive(state);
	}

	// Token: 0x0600876F RID: 34671 RVA: 0x00293A2D File Offset: 0x00291C2D
	public void SetIconRootItemState(bool state)
	{
		this.RootItem.SetUIActive(state);
	}

	// Token: 0x02006F6F RID: 28527
	private class ECommonEquippedItem
	{
		// Token: 0x04024680 RID: 149120
		public const int CurrentEquippedItem = 0;

		// Token: 0x04024681 RID: 149121
		public const int Icon = 1;

		// Token: 0x04024682 RID: 149122
		public const int Text = 2;
	}
}
