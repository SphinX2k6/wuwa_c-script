using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E44 RID: 7748
public class RoleSkillTrickDescItem : UiPanelBase
{
	// Token: 0x060132FF RID: 78591 RVA: 0x0059CE9C File Offset: 0x0059B09C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06013300 RID: 78592 RVA: 0x0059CF05 File Offset: 0x0059B105
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RoleSkillInputDescItem, string>(base.GetVerticalLayout(0), new Func<RoleSkillInputDescItem>(this.InitRoleSkillInputDescItem), null, false, true);
	}

	// Token: 0x06013301 RID: 78593 RVA: 0x0059CF28 File Offset: 0x0059B128
	[NullableContext(1)]
	private RoleSkillInputDescItem InitRoleSkillInputDescItem()
	{
		return new RoleSkillInputDescItem();
	}

	// Token: 0x06013302 RID: 78594 RVA: 0x0059CF30 File Offset: 0x0059B130
	[NullableContext(1)]
	public UniTask RefreshAsync(List<string> descArray)
	{
		RoleSkillTrickDescItem.<RefreshAsync>d__5 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.descArray = descArray;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleSkillTrickDescItem.<RefreshAsync>d__5>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400A474 RID: 42100
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillInputDescItem, string> Layout;

	// Token: 0x02008124 RID: 33060
	private enum EComponent
	{
		// Token: 0x04029C41 RID: 171073
		Layout,
		// Token: 0x04029C42 RID: 171074
		DescText
	}
}
