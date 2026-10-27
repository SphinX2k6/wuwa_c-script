using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002CF5 RID: 11509
public class WeaponBreachSuccessView : UiViewBase
{
	// Token: 0x060182B5 RID: 98997 RVA: 0x00625A16 File Offset: 0x00623C16
	[NullableContext(1)]
	public WeaponBreachSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060182B6 RID: 98998 RVA: 0x00625A20 File Offset: 0x00623C20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060182B7 RID: 98999 RVA: 0x00625B08 File Offset: 0x00623D08
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponBreachSuccessView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponBreachSuccessView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060182B8 RID: 99000 RVA: 0x00625B4B File Offset: 0x00623D4B
	[NullableContext(1)]
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x060182B9 RID: 99001 RVA: 0x00625B52 File Offset: 0x00623D52
	protected override void OnAfterPlayStartSequence()
	{
		CSharpScript.Game.Module.RoleUi.StarItem successStarItem = this.SuccessStarItem;
		if (successStarItem != null)
		{
			successStarItem.PlayActiveSequence();
		}
		this.UiViewSequence.PlaySequencePurely("Loop", false, false);
	}

	// Token: 0x060182BA RID: 99002 RVA: 0x00625B77 File Offset: 0x00623D77
	private void ConfirmClick()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.WeaponBreach);
		if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x060182BB RID: 99003 RVA: 0x00625BA0 File Offset: 0x00623DA0
	protected UniTask UpdateStar(int breachLevel, int maxLevel)
	{
		WeaponBreachSuccessView.<UpdateStar>d__10 <UpdateStar>d__;
		<UpdateStar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateStar>d__.<>4__this = this;
		<UpdateStar>d__.breachLevel = breachLevel;
		<UpdateStar>d__.maxLevel = maxLevel;
		<UpdateStar>d__.<>1__state = -1;
		<UpdateStar>d__.<>t__builder.Start<WeaponBreachSuccessView.<UpdateStar>d__10>(ref <UpdateStar>d__);
		return <UpdateStar>d__.<>t__builder.Task;
	}

	// Token: 0x0400B3C5 RID: 46021
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400B3C6 RID: 46022
	[Nullable(2)]
	protected CSharpScript.Game.Module.RoleUi.StarItem SuccessStarItem;

	// Token: 0x0400B3C7 RID: 46023
	private int WeaponIncId;

	// Token: 0x02009286 RID: 37510
	private enum EComponent
	{
		// Token: 0x0402F60A RID: 194058
		StarHorizontalLayout,
		// Token: 0x0402F60B RID: 194059
		ConfirmButton,
		// Token: 0x0402F60C RID: 194060
		LastLevelText,
		// Token: 0x0402F60D RID: 194061
		CurLevelText
	}
}
