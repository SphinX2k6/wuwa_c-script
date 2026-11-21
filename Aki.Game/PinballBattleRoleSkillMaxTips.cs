using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011C4 RID: 4548
public class PinballBattleRoleSkillMaxTips : PinballBattleTipsBase
{
	// Token: 0x0600B4CB RID: 46283 RVA: 0x00356B2B File Offset: 0x00354D2B
	[NullableContext(1)]
	public PinballBattleRoleSkillMaxTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B4CC RID: 46284 RVA: 0x00356B34 File Offset: 0x00354D34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B4CD RID: 46285 RVA: 0x00356BC0 File Offset: 0x00354DC0
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattleRoleSkillMaxTips.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleRoleSkillMaxTips.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04006899 RID: 26777
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PinballBattleRoleHeadItem, int> Layout;
}
