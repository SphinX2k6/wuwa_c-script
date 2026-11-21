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

// Token: 0x02001D22 RID: 7458
[NullableContext(1)]
[Nullable(0)]
public class RoleBreachSuccessView : UiViewBase
{
	// Token: 0x060127A6 RID: 75686 RVA: 0x0057575F File Offset: 0x0057395F
	public RoleBreachSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060127A7 RID: 75687 RVA: 0x00575774 File Offset: 0x00573974
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
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
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnMaskClickInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060127A8 RID: 75688 RVA: 0x0057585C File Offset: 0x00573A5C
	protected void OnMaskClickInternal()
	{
		Action onMaskClick = this.OnMaskClick;
		if (onMaskClick == null)
		{
			return;
		}
		onMaskClick();
	}

	// Token: 0x060127A9 RID: 75689 RVA: 0x00575870 File Offset: 0x00573A70
	protected override UniTask OnBeforeStartAsync()
	{
		RoleBreachSuccessView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBreachSuccessView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060127AA RID: 75690 RVA: 0x005758B3 File Offset: 0x00573AB3
	protected override void OnAfterPlayStartSequence()
	{
		CSharpScript.Game.Module.RoleUi.StarItem successStarItem = this.SuccessStarItem;
		if (successStarItem == null)
		{
			return;
		}
		successStarItem.PlayActiveSequence();
	}

	// Token: 0x060127AB RID: 75691 RVA: 0x005758C5 File Offset: 0x00573AC5
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x060127AC RID: 75692 RVA: 0x005758CC File Offset: 0x00573ACC
	protected UniTask UpdateStar(int breachLevel, int maxLevel)
	{
		RoleBreachSuccessView.<UpdateStar>d__12 <UpdateStar>d__;
		<UpdateStar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateStar>d__.<>4__this = this;
		<UpdateStar>d__.breachLevel = breachLevel;
		<UpdateStar>d__.maxLevel = maxLevel;
		<UpdateStar>d__.<>1__state = -1;
		<UpdateStar>d__.<>t__builder.Start<RoleBreachSuccessView.<UpdateStar>d__12>(ref <UpdateStar>d__);
		return <UpdateStar>d__.<>t__builder.Task;
	}

	// Token: 0x0400A0C4 RID: 41156
	private int RoleId;

	// Token: 0x0400A0C5 RID: 41157
	[Nullable(2)]
	private Action OnMaskClick;

	// Token: 0x0400A0C6 RID: 41158
	[Nullable(2)]
	protected CSharpScript.Game.Module.RoleUi.StarItem SuccessStarItem;

	// Token: 0x0400A0C7 RID: 41159
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400A0C8 RID: 41160
	protected List<CSharpScript.Game.Module.RoleUi.StarItem> StarList = new List<CSharpScript.Game.Module.RoleUi.StarItem>();

	// Token: 0x0200806A RID: 32874
	[NullableContext(0)]
	public enum ERoleBreachSuccessViewDefine
	{
		// Token: 0x040298DD RID: 170205
		StarHorizontalLayout,
		// Token: 0x040298DE RID: 170206
		MaskBtn,
		// Token: 0x040298DF RID: 170207
		CurLevelText,
		// Token: 0x040298E0 RID: 170208
		MaxLevelText
	}
}
