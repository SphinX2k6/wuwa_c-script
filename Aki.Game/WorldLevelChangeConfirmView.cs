using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022C3 RID: 8899
public class WorldLevelChangeConfirmView : UiViewBase
{
	// Token: 0x06015FCD RID: 90061 RVA: 0x0065F1C1 File Offset: 0x0065D3C1
	[NullableContext(1)]
	public WorldLevelChangeConfirmView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015FCE RID: 90062 RVA: 0x0065F1CC File Offset: 0x0065D3CC
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

	// Token: 0x06015FCF RID: 90063 RVA: 0x0065F35D File Offset: 0x0065D55D
	protected override void OnStart()
	{
		this.SetTitleText();
		this.SetWorldLevelChangeText();
		this.SetDescribeText();
	}

	// Token: 0x06015FD0 RID: 90064 RVA: 0x0065F371 File Offset: 0x0065D571
	private void SetTitleText()
	{
		base.GetText(6).SetText(WorldLevelModel.Instance.WorldLevelMultilingualText, true);
	}

	// Token: 0x06015FD1 RID: 90065 RVA: 0x0065F38C File Offset: 0x0065D58C
	private void SetWorldLevelChangeText()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "LvString", new <>z__ReadOnlySingleElementList<object>(WorldLevelModel.Instance.CurWorldLevel));
		LguiUtil.Instance.SetLocalText(base.GetText(1), "LvString", new <>z__ReadOnlySingleElementList<object>(WorldLevelModel.Instance.WorldLevelChangeTarget));
	}

	// Token: 0x06015FD2 RID: 90066 RVA: 0x0065F3F0 File Offset: 0x0065D5F0
	private void SetDescribeText()
	{
		string textById = TextConfig.Instance.GetTextById("WorldLevelINotice");
		base.GetText(2).SetText(textById ?? "", true);
	}

	// Token: 0x06015FD3 RID: 90067 RVA: 0x0065F424 File Offset: 0x0065D624
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WorldLevelChangeConfirmView, null);
	}

	// Token: 0x06015FD4 RID: 90068 RVA: 0x0065F436 File Offset: 0x0065D636
	private void OnCancelBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WorldLevelChangeConfirmView, null);
	}

	// Token: 0x06015FD5 RID: 90069 RVA: 0x0065F448 File Offset: 0x0065D648
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
