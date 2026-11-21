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

// Token: 0x0200224F RID: 8783
public class WeaponBreachSuccessView : UiViewBase
{
	// Token: 0x06015B56 RID: 88918 RVA: 0x0064B9E2 File Offset: 0x00649BE2
	[NullableContext(1)]
	public WeaponBreachSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015B57 RID: 88919 RVA: 0x0064B9EC File Offset: 0x00649BEC
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

	// Token: 0x06015B58 RID: 88920 RVA: 0x0064BAD4 File Offset: 0x00649CD4
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponBreachSuccessView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponBreachSuccessView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015B59 RID: 88921 RVA: 0x0064BB17 File Offset: 0x00649D17
	[NullableContext(1)]
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x06015B5A RID: 88922 RVA: 0x0064BB1E File Offset: 0x00649D1E
	protected override void OnAfterPlayStartSequence()
	{
		CSharpScript.Game.Module.RoleUi.StarItem successStarItem = this.SuccessStarItem;
		if (successStarItem != null)
		{
			successStarItem.PlayActiveSequence();
		}
		this.UiViewSequence.PlaySequencePurely("Loop", false, false);
	}

	// Token: 0x06015B5B RID: 88923 RVA: 0x0064BB43 File Offset: 0x00649D43
	private void ConfirmClick()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.WeaponBreach);
		if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06015B5C RID: 88924 RVA: 0x0064BB6C File Offset: 0x00649D6C
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

	// Token: 0x0400B73A RID: 46906
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400B73B RID: 46907
	[Nullable(2)]
	protected CSharpScript.Game.Module.RoleUi.StarItem SuccessStarItem;

	// Token: 0x0400B73C RID: 46908
	private int WeaponIncId;

	// Token: 0x020084AE RID: 33966
	private enum EComponent
	{
		// Token: 0x0402AC94 RID: 175252
		StarHorizontalLayout,
		// Token: 0x0402AC95 RID: 175253
		ConfirmButton,
		// Token: 0x0402AC96 RID: 175254
		LastLevelText,
		// Token: 0x0402AC97 RID: 175255
		CurLevelText
	}
}
