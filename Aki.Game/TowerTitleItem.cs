using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C0A RID: 11274
[NullableContext(1)]
[Nullable(0)]
public class TowerTitleItem : UiPanelBase
{
	// Token: 0x06017691 RID: 95889 RVA: 0x005F6057 File Offset: 0x005F4257
	public TowerTitleItem(UUIItem uiItem, [Nullable(2)] Action onClickBackBtnHandle)
	{
		this.OnClickBackBtnHandle = onClickBackBtnHandle;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06017692 RID: 95890 RVA: 0x005F6074 File Offset: 0x005F4274
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBackBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017693 RID: 95891 RVA: 0x005F615C File Offset: 0x005F435C
	protected override void OnStart()
	{
	}

	// Token: 0x06017694 RID: 95892 RVA: 0x005F615E File Offset: 0x005F435E
	public void RefreshText(string textId, params string[] arg)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, arg);
	}

	// Token: 0x06017695 RID: 95893 RVA: 0x005F6173 File Offset: 0x005F4373
	public void SetTitleText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06017696 RID: 95894 RVA: 0x005F6188 File Offset: 0x005F4388
	private void OnClickBackBtn()
	{
		Action onClickBackBtnHandle = this.OnClickBackBtnHandle;
		if (onClickBackBtnHandle == null)
		{
			return;
		}
		onClickBackBtnHandle();
	}

	// Token: 0x06017697 RID: 95895 RVA: 0x005F619A File Offset: 0x005F439A
	protected override void OnBeforeDestroy()
	{
		this.OnClickBackBtnHandle = null;
	}

	// Token: 0x0400AF13 RID: 44819
	[Nullable(2)]
	private Action OnClickBackBtnHandle;

	// Token: 0x020091D5 RID: 37333
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F2E6 RID: 193254
		TitleSprite,
		// Token: 0x0402F2E7 RID: 193255
		TitleText,
		// Token: 0x0402F2E8 RID: 193256
		HelpBtn,
		// Token: 0x0402F2E9 RID: 193257
		BackBtn
	}
}
