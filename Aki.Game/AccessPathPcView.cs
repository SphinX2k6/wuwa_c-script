using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FC4 RID: 8132
public class AccessPathPcView : UiViewBase
{
	// Token: 0x0600FE58 RID: 65112 RVA: 0x003DBAE1 File Offset: 0x003D9CE1
	[NullableContext(1)]
	public AccessPathPcView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FE59 RID: 65113 RVA: 0x003DBAF8 File Offset: 0x003D9CF8
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

	// Token: 0x0600FE5A RID: 65114 RVA: 0x003DBDFD File Offset: 0x003D9FFD
	protected override void OnStart()
	{
		this.RefreshShortcutKey();
		this.RefreshAccessPathButtons();
		this.AddEvents();
	}

	// Token: 0x0600FE5B RID: 65115 RVA: 0x003DBE14 File Offset: 0x003DA014
	protected override void OnBeforeDestroy()
	{
		foreach (AccessPathPcButton accessPathPcButton in this.AccessPathButtonList)
		{
			accessPathPcButton.Destroy(null);
		}
		this.AccessPathButtonList.Clear();
		this.RemoveEvents();
	}

	// Token: 0x0600FE5C RID: 65116 RVA: 0x003DBE78 File Offset: 0x003DA078
	public void AddEvents()
	{
	}

	// Token: 0x0600FE5D RID: 65117 RVA: 0x003DBE7A File Offset: 0x003DA07A
	public void RemoveEvents()
	{
	}

	// Token: 0x0600FE5E RID: 65118 RVA: 0x003DBE7C File Offset: 0x003DA07C
	private void OnClickedCheckButton()
	{
	}

	// Token: 0x0600FE5F RID: 65119 RVA: 0x003DBE7E File Offset: 0x003DA07E
	private void OnClickedLeaveButton()
	{
		UiManager.Instance.CloseView(EUiViewName.AccessPathPcView, null);
	}

	// Token: 0x0600FE60 RID: 65120 RVA: 0x003DBE90 File Offset: 0x003DA090
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

	// Token: 0x0600FE61 RID: 65121 RVA: 0x003DBEEC File Offset: 0x003DA0EC
	private void RefreshShortcutKey()
	{
		bool shortcutKeyDisplay = Info.Instance.IsInKeyBoard();
		this.SetShortcutKeyDisplay(shortcutKeyDisplay);
	}

	// Token: 0x0600FE62 RID: 65122 RVA: 0x003DBF0C File Offset: 0x003DA10C
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

	// Token: 0x040075AF RID: 30127
	[Nullable(1)]
	private readonly List<AccessPathPcButton> AccessPathButtonList = new List<AccessPathPcButton>();

	// Token: 0x020085D5 RID: 34261
	private enum EChildComponentType
	{
		// Token: 0x0402B8F7 RID: 178423
		AccessPathButtonItem,
		// Token: 0x0402B8F8 RID: 178424
		CheckButton,
		// Token: 0x0402B8F9 RID: 178425
		LeaveButton,
		// Token: 0x0402B8FA RID: 178426
		CheckButtonDisJs,
		// Token: 0x0402B8FB RID: 178427
		CheckButtonDisSb,
		// Token: 0x0402B8FC RID: 178428
		CheckButtonHlJs,
		// Token: 0x0402B8FD RID: 178429
		CheckButtonHlSb,
		// Token: 0x0402B8FE RID: 178430
		CheckButtonNorJs,
		// Token: 0x0402B8FF RID: 178431
		CheckButtonNorSb,
		// Token: 0x0402B900 RID: 178432
		CheckButtonPreJs,
		// Token: 0x0402B901 RID: 178433
		CheckButtonPreSb,
		// Token: 0x0402B902 RID: 178434
		LeaveButtonDisJs,
		// Token: 0x0402B903 RID: 178435
		LeaveButtonDisSb,
		// Token: 0x0402B904 RID: 178436
		LeaveButtonHlJs,
		// Token: 0x0402B905 RID: 178437
		LeaveButtonHlSb,
		// Token: 0x0402B906 RID: 178438
		LeaveButtonNorJs,
		// Token: 0x0402B907 RID: 178439
		LeaveButtonNorSb,
		// Token: 0x0402B908 RID: 178440
		LeaveButtonPreJs,
		// Token: 0x0402B909 RID: 178441
		LeaveButtonPreSb
	}
}
