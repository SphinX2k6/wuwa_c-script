using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028CA RID: 10442
public class RoleSkillTrickInputItem : UiPanelBase
{
	// Token: 0x06015904 RID: 88324 RVA: 0x005720CC File Offset: 0x005702CC
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

	// Token: 0x06015905 RID: 88325 RVA: 0x00572135 File Offset: 0x00570335
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RoleSkillInputItem, IRoleSkillInputParam>(base.GetVerticalLayout(0), new Func<RoleSkillInputItem>(this.InitRoleSkillInputItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06015906 RID: 88326 RVA: 0x00572168 File Offset: 0x00570368
	[NullableContext(1)]
	private RoleSkillInputItem InitRoleSkillInputItem()
	{
		return new RoleSkillInputItem();
	}

	// Token: 0x06015907 RID: 88327 RVA: 0x00572170 File Offset: 0x00570370
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

	// Token: 0x0400A08C RID: 41100
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillInputItem, IRoleSkillInputParam> Layout;

	// Token: 0x02008EDE RID: 36574
	private enum ESkillInputComponent
	{
		// Token: 0x0402E54E RID: 189774
		Layout,
		// Token: 0x0402E54F RID: 189775
		InputItem
	}
}
