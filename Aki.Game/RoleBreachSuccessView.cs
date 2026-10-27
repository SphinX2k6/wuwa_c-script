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

// Token: 0x020027A7 RID: 10151
[NullableContext(1)]
[Nullable(0)]
public class RoleBreachSuccessView : UiViewBase
{
	// Token: 0x06014DAC RID: 85420 RVA: 0x0054ABD7 File Offset: 0x00548DD7
	public RoleBreachSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014DAD RID: 85421 RVA: 0x0054ABEC File Offset: 0x00548DEC
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

	// Token: 0x06014DAE RID: 85422 RVA: 0x0054ACD4 File Offset: 0x00548ED4
	protected void OnMaskClickInternal()
	{
		Action onMaskClick = this.OnMaskClick;
		if (onMaskClick == null)
		{
			return;
		}
		onMaskClick();
	}

	// Token: 0x06014DAF RID: 85423 RVA: 0x0054ACE8 File Offset: 0x00548EE8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleBreachSuccessView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBreachSuccessView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DB0 RID: 85424 RVA: 0x0054AD2B File Offset: 0x00548F2B
	protected override void OnAfterPlayStartSequence()
	{
		CSharpScript.Game.Module.RoleUi.StarItem successStarItem = this.SuccessStarItem;
		if (successStarItem == null)
		{
			return;
		}
		successStarItem.PlayActiveSequence();
	}

	// Token: 0x06014DB1 RID: 85425 RVA: 0x0054AD3D File Offset: 0x00548F3D
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x06014DB2 RID: 85426 RVA: 0x0054AD44 File Offset: 0x00548F44
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

	// Token: 0x04009CE1 RID: 40161
	private int RoleId;

	// Token: 0x04009CE2 RID: 40162
	[Nullable(2)]
	private Action OnMaskClick;

	// Token: 0x04009CE3 RID: 40163
	[Nullable(2)]
	protected CSharpScript.Game.Module.RoleUi.StarItem SuccessStarItem;

	// Token: 0x04009CE4 RID: 40164
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x04009CE5 RID: 40165
	protected List<CSharpScript.Game.Module.RoleUi.StarItem> StarList = new List<CSharpScript.Game.Module.RoleUi.StarItem>();

	// Token: 0x02008E21 RID: 36385
	[NullableContext(0)]
	public enum ERoleBreachSuccessViewDefine
	{
		// Token: 0x0402E1E1 RID: 188897
		StarHorizontalLayout,
		// Token: 0x0402E1E2 RID: 188898
		MaskBtn,
		// Token: 0x0402E1E3 RID: 188899
		CurLevelText,
		// Token: 0x0402E1E4 RID: 188900
		MaxLevelText
	}
}
