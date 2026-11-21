using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002185 RID: 8581
[NullableContext(1)]
[Nullable(0)]
public class TowerTitleItem : UiPanelBase
{
	// Token: 0x060150C2 RID: 86210 RVA: 0x00622B7B File Offset: 0x00620D7B
	public TowerTitleItem(UUIItem uiItem, [Nullable(2)] Action onClickBackBtnHandle)
	{
		this.OnClickBackBtnHandle = onClickBackBtnHandle;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060150C3 RID: 86211 RVA: 0x00622B98 File Offset: 0x00620D98
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

	// Token: 0x060150C4 RID: 86212 RVA: 0x00622C80 File Offset: 0x00620E80
	protected override void OnStart()
	{
	}

	// Token: 0x060150C5 RID: 86213 RVA: 0x00622C82 File Offset: 0x00620E82
	public void RefreshText(string textId, params string[] arg)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, arg);
	}

	// Token: 0x060150C6 RID: 86214 RVA: 0x00622C97 File Offset: 0x00620E97
	public void SetTitleText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x060150C7 RID: 86215 RVA: 0x00622CAC File Offset: 0x00620EAC
	private void OnClickBackBtn()
	{
		Action onClickBackBtnHandle = this.OnClickBackBtnHandle;
		if (onClickBackBtnHandle == null)
		{
			return;
		}
		onClickBackBtnHandle();
	}

	// Token: 0x060150C8 RID: 86216 RVA: 0x00622CBE File Offset: 0x00620EBE
	protected override void OnBeforeDestroy()
	{
		this.OnClickBackBtnHandle = null;
	}

	// Token: 0x0400B318 RID: 45848
	[Nullable(2)]
	private Action OnClickBackBtnHandle;

	// Token: 0x02008418 RID: 33816
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A9E7 RID: 174567
		TitleSprite,
		// Token: 0x0402A9E8 RID: 174568
		TitleText,
		// Token: 0x0402A9E9 RID: 174569
		HelpBtn,
		// Token: 0x0402A9EA RID: 174570
		BackBtn
	}
}
