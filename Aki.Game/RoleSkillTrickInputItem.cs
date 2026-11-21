using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E45 RID: 7749
public class RoleSkillTrickInputItem : UiPanelBase
{
	// Token: 0x06013304 RID: 78596 RVA: 0x0059CF84 File Offset: 0x0059B184
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06013305 RID: 78597 RVA: 0x0059CFED File Offset: 0x0059B1ED
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RoleSkillInputItem, IRoleSkillInputParam>(base.GetVerticalLayout(0), new Func<RoleSkillInputItem>(this.InitRoleSkillInputItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06013306 RID: 78598 RVA: 0x0059D020 File Offset: 0x0059B220
	[NullableContext(1)]
	private RoleSkillInputItem InitRoleSkillInputItem()
	{
		return new RoleSkillInputItem();
	}

	// Token: 0x06013307 RID: 78599 RVA: 0x0059D028 File Offset: 0x0059B228
	[NullableContext(1)]
	public UniTask RefreshAsync(List<IRoleSkillInputParam> param)
	{
		RoleSkillTrickInputItem.<RefreshAsync>d__5 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.param = param;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleSkillTrickInputItem.<RefreshAsync>d__5>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400A475 RID: 42101
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillInputItem, IRoleSkillInputParam> Layout;

	// Token: 0x02008126 RID: 33062
	private enum ESkillInputComponent
	{
		// Token: 0x04029C49 RID: 171081
		Layout,
		// Token: 0x04029C4A RID: 171082
		InputItem
	}
}
