using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001497 RID: 5271
public class AccessPathPcView : UiViewBase
{
	// Token: 0x0600D2C0 RID: 53952 RVA: 0x003E80BD File Offset: 0x003E62BD
	[NullableContext(1)]
	public AccessPathPcView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D2C1 RID: 53953 RVA: 0x003E80D4 File Offset: 0x003E62D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedCheckButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedLeaveButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D2C2 RID: 53954 RVA: 0x003E83D9 File Offset: 0x003E65D9
	protected override void OnStart()
	{
		this.RefreshShortcutKey();
		this.RefreshAccessPathButtons();
		this.AddEvents();
	}

	// Token: 0x0600D2C3 RID: 53955 RVA: 0x003E83F0 File Offset: 0x003E65F0
	protected override void OnBeforeDestroy()
	{
		foreach (AccessPathPcButton accessPathPcButton in this.AccessPathButtonList)
		{
			accessPathPcButton.Destroy(null);
		}
		this.AccessPathButtonList.Clear();
		this.RemoveEvents();
	}

	// Token: 0x0600D2C4 RID: 53956 RVA: 0x003E8454 File Offset: 0x003E6654
	public void AddEvents()
	{
	}

	// Token: 0x0600D2C5 RID: 53957 RVA: 0x003E8456 File Offset: 0x003E6656
	public void RemoveEvents()
	{
	}

	// Token: 0x0600D2C6 RID: 53958 RVA: 0x003E8458 File Offset: 0x003E6658
	private void OnClickedCheckButton()
	{
	}

	// Token: 0x0600D2C7 RID: 53959 RVA: 0x003E845A File Offset: 0x003E665A
	private void OnClickedLeaveButton()
	{
		UiManager.Instance.CloseView(EUiViewName.AccessPathPcView, null);
	}

	// Token: 0x0600D2C8 RID: 53960 RVA: 0x003E846C File Offset: 0x003E666C
	private unsafe void RefreshAccessPathButtons()
	{
		Span<int> itemAccess = InventoryModel.Instance.GetSelectedItemData().GetItemDataBase().GetItemAccess();
		UUIItem item = base.GetItem(0);
		Span<int> span = itemAccess;
		for (int i = 0; i < span.Length; i++)
		{
			int accessPathId = *span[i];
			AccessPathPcButton item2 = new AccessPathPcButton(item, accessPathId);
			this.AccessPathButtonList.Add(item2);
		}
	}

	// Token: 0x0600D2C9 RID: 53961 RVA: 0x003E84C8 File Offset: 0x003E66C8
	private void RefreshShortcutKey()
	{
		bool shortcutKeyDisplay = Info.Instance.IsInKeyBoard();
		this.SetShortcutKeyDisplay(shortcutKeyDisplay);
	}

	// Token: 0x0600D2CA RID: 53962 RVA: 0x003E84E8 File Offset: 0x003E66E8
	private void SetShortcutKeyDisplay(bool bPc)
	{
		UUISprite sprite = base.GetSprite(3);
		UUIItem item = base.GetItem(4);
		UUISprite sprite2 = base.GetSprite(5);
		UUIItem item2 = base.GetItem(6);
		UUISprite sprite3 = base.GetSprite(7);
		UUIItem item3 = base.GetItem(8);
		UUISprite sprite4 = base.GetSprite(9);
		UUIItem item4 = base.GetItem(10);
		UUISprite sprite5 = base.GetSprite(11);
		UUIItem item5 = base.GetItem(12);
		UUISprite sprite6 = base.GetSprite(13);
		UUIItem item6 = base.GetItem(14);
		UUISprite sprite7 = base.GetSprite(15);
		UUIItem item7 = base.GetItem(16);
		UUISprite sprite8 = base.GetSprite(17);
		UUIItem item8 = base.GetItem(18);
		sprite.SetUIActive(bPc);
		item.SetUIActive(!bPc);
		sprite2.SetUIActive(bPc);
		item2.SetUIActive(!bPc);
		sprite3.SetUIActive(bPc);
		item3.SetUIActive(!bPc);
		sprite4.SetUIActive(bPc);
		item4.SetUIActive(!bPc);
		sprite5.SetUIActive(bPc);
		item5.SetUIActive(!bPc);
		sprite6.SetUIActive(bPc);
		item6.SetUIActive(!bPc);
		sprite7.SetUIActive(bPc);
		item7.SetUIActive(!bPc);
		sprite8.SetUIActive(bPc);
		item8.SetUIActive(!bPc);
	}

	// Token: 0x04007698 RID: 30360
	[Nullable(1)]
	private readonly List<AccessPathPcButton> AccessPathButtonList = new List<AccessPathPcButton>();

	// Token: 0x0200775C RID: 30556
	private enum EChildComponentType
	{
		// Token: 0x04026C06 RID: 158726
		AccessPathButtonItem,
		// Token: 0x04026C07 RID: 158727
		CheckButton,
		// Token: 0x04026C08 RID: 158728
		LeaveButton,
		// Token: 0x04026C09 RID: 158729
		CheckButtonDisJs,
		// Token: 0x04026C0A RID: 158730
		CheckButtonDisSb,
		// Token: 0x04026C0B RID: 158731
		CheckButtonHlJs,
		// Token: 0x04026C0C RID: 158732
		CheckButtonHlSb,
		// Token: 0x04026C0D RID: 158733
		CheckButtonNorJs,
		// Token: 0x04026C0E RID: 158734
		CheckButtonNorSb,
		// Token: 0x04026C0F RID: 158735
		CheckButtonPreJs,
		// Token: 0x04026C10 RID: 158736
		CheckButtonPreSb,
		// Token: 0x04026C11 RID: 158737
		LeaveButtonDisJs,
		// Token: 0x04026C12 RID: 158738
		LeaveButtonDisSb,
		// Token: 0x04026C13 RID: 158739
		LeaveButtonHlJs,
		// Token: 0x04026C14 RID: 158740
		LeaveButtonHlSb,
		// Token: 0x04026C15 RID: 158741
		LeaveButtonNorJs,
		// Token: 0x04026C16 RID: 158742
		LeaveButtonNorSb,
		// Token: 0x04026C17 RID: 158743
		LeaveButtonPreJs,
		// Token: 0x04026C18 RID: 158744
		LeaveButtonPreSb
	}
}
