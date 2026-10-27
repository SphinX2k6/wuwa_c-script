using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D11 RID: 7441
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleRevivePopupView : UiViewBase
{
	// Token: 0x0600E0F0 RID: 57584 RVA: 0x0034C005 File Offset: 0x0034A205
	public PinballBattleRevivePopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0F1 RID: 57585 RVA: 0x0034C010 File Offset: 0x0034A210
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnLeftClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnRightClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600E0F2 RID: 57586 RVA: 0x0034C13C File Offset: 0x0034A33C
	protected override void OnStart()
	{
		this.Param = (this.OpenParam as IPinballBattleRevivePopupViewParam);
		this.RoleHeadLayout = new GenericLayout<PinballBattleReviveRoleHeadItem, int>(base.GetHorizontalLayout(0), new Func<PinballBattleReviveRoleHeadItem>(this.CreateRoleHeadItem), (AUIBaseActor)base.GetItem(1).GetOwner(), false, true);
		PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
		List<int> list = new List<int>();
		if (pinballBattleSubModel.FormationData != null)
		{
			foreach (PinballFormationRolePb pinballFormationRolePb in pinballBattleSubModel.FormationData)
			{
				list.Add(pinballFormationRolePb.RoleId);
			}
		}
		GenericLayout<PinballBattleReviveRoleHeadItem, int> roleHeadLayout = this.RoleHeadLayout;
		if (roleHeadLayout != null)
		{
			roleHeadLayout.RefreshByData(list, null, false);
		}
		int value = pinballBattleSubModel.MaxReviveTime - pinballBattleSubModel.UsedReviveTime;
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(pinballBattleSubModel.MaxReviveTime);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600E0F3 RID: 57587 RVA: 0x0034C25C File Offset: 0x0034A45C
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			childPopView.SetBackBtnShowState(false);
		}
		IUiPopFrameInterface childPopView2 = this.ChildPopView;
		if (childPopView2 == null)
		{
			return;
		}
		childPopView2.PopItem.SetMaskResponsibleState(false);
	}

	// Token: 0x0600E0F4 RID: 57588 RVA: 0x0034C286 File Offset: 0x0034A486
	private PinballBattleReviveRoleHeadItem CreateRoleHeadItem()
	{
		return new PinballBattleReviveRoleHeadItem();
	}

	// Token: 0x0600E0F5 RID: 57589 RVA: 0x0034C28D File Offset: 0x0034A48D
	private void OnBtnLeftClick()
	{
		IPinballBattleRevivePopupViewParam param = this.Param;
		if (param != null)
		{
			Action cancelCallback = param.CancelCallback;
			if (cancelCallback != null)
			{
				cancelCallback();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x0600E0F6 RID: 57590 RVA: 0x0034C2B2 File Offset: 0x0034A4B2
	private void OnBtnRightClick()
	{
		IPinballBattleRevivePopupViewParam param = this.Param;
		if (param != null)
		{
			Action confirmCallback = param.ConfirmCallback;
			if (confirmCallback != null)
			{
				confirmCallback();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x040067E8 RID: 26600
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PinballBattleReviveRoleHeadItem, int> RoleHeadLayout;

	// Token: 0x040067E9 RID: 26601
	[Nullable(2)]
	private IPinballBattleRevivePopupViewParam Param;
}
