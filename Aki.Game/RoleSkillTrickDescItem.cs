using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028C9 RID: 10441
public class RoleSkillTrickDescItem : UiPanelBase
{
	// Token: 0x060158FF RID: 88319 RVA: 0x00571FE4 File Offset: 0x005701E4
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

	// Token: 0x06015900 RID: 88320 RVA: 0x0057204D File Offset: 0x0057024D
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RoleSkillInputDescItem, string>(base.GetVerticalLayout(0), new Func<RoleSkillInputDescItem>(this.InitRoleSkillInputDescItem), null, false, true);
	}

	// Token: 0x06015901 RID: 88321 RVA: 0x00572070 File Offset: 0x00570270
	[NullableContext(1)]
	private RoleSkillInputDescItem InitRoleSkillInputDescItem()
	{
		return new RoleSkillInputDescItem();
	}

	// Token: 0x06015902 RID: 88322 RVA: 0x00572078 File Offset: 0x00570278
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

	// Token: 0x0400A08B RID: 41099
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillInputDescItem, string> Layout;

	// Token: 0x02008EDC RID: 36572
	private enum EComponent
	{
		// Token: 0x0402E546 RID: 189766
		Layout,
		// Token: 0x0402E547 RID: 189767
		DescText
	}
}
