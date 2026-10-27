using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D69 RID: 11625
public class WorldLevelChangeConfirmView : UiViewBase
{
	// Token: 0x0601872B RID: 100139 RVA: 0x006391A9 File Offset: 0x006373A9
	[NullableContext(1)]
	public WorldLevelChangeConfirmView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601872C RID: 100140 RVA: 0x006391B4 File Offset: 0x006373B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnCloseBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnCancelBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnConfirmBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601872D RID: 100141 RVA: 0x00639345 File Offset: 0x00637545
	protected override void OnStart()
	{
		this.SetTitleText();
		this.SetWorldLevelChangeText();
		this.SetDescribeText();
	}

	// Token: 0x0601872E RID: 100142 RVA: 0x00639359 File Offset: 0x00637559
	private void SetTitleText()
	{
		base.GetText(6).SetText(WorldLevelModel.Instance.WorldLevelMultilingualText, true);
	}

	// Token: 0x0601872F RID: 100143 RVA: 0x00639374 File Offset: 0x00637574
	private void SetWorldLevelChangeText()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "LvString", new <>z__ReadOnlySingleElementList<object>(WorldLevelModel.Instance.CurWorldLevel));
		LguiUtil.Instance.SetLocalText(base.GetText(1), "LvString", new <>z__ReadOnlySingleElementList<object>(WorldLevelModel.Instance.WorldLevelChangeTarget));
	}

	// Token: 0x06018730 RID: 100144 RVA: 0x006393D8 File Offset: 0x006375D8
	private void SetDescribeText()
	{
		string textById = TextConfig.Instance.GetTextById("WorldLevelINotice");
		base.GetText(2).SetText(textById ?? "", true);
	}

	// Token: 0x06018731 RID: 100145 RVA: 0x0063940C File Offset: 0x0063760C
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WorldLevelChangeConfirmView, null);
	}

	// Token: 0x06018732 RID: 100146 RVA: 0x0063941E File Offset: 0x0063761E
	private void OnCancelBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WorldLevelChangeConfirmView, null);
	}

	// Token: 0x06018733 RID: 100147 RVA: 0x00639430 File Offset: 0x00637630
	private void OnConfirmBtnClick()
	{
		if (WorldLevelModel.Instance.CurWorldLevel > WorldLevelModel.Instance.WorldLevelChangeTarget)
		{
			if (Global.BaseCharacter.CharacterActorComponent.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
			{
				ScrollingTipsController.Instance.ShowTipsByText(TextConfig.Instance.GetTextById("WorldLevelDownReject") ?? "");
			}
			else
			{
				WorldLevelController.Instance.SendWorldLevelDownRequest();
			}
		}
		else
		{
			WorldLevelController.Instance.SendWorldLevelRegainRequest();
		}
		UiManager.Instance.CloseView(EUiViewName.WorldLevelChangeConfirmView, null);
	}
}
