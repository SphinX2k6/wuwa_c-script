using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007BB RID: 1979
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItemWithoutProgress : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005A9C RID: 23196 RVA: 0x001D5FC0 File Offset: 0x001D41C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06005A9D RID: 23197 RVA: 0x001D5FFC File Offset: 0x001D41FC
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItemWithoutProgress.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItemWithoutProgress.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A9E RID: 23198 RVA: 0x001D6040 File Offset: 0x001D4240
	[NullableContext(1)]
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		this.NameItem.Refresh(data, false, 0);
		base.GetText(1).SetText(data.CurrentValue.ToString(), true);
	}

	// Token: 0x04003CEB RID: 15595
	[Nullable(2)]
	protected CharacterNameItem NameItem;

	// Token: 0x02006ACE RID: 27342
	private static class EComponentDefine
	{
		// Token: 0x04023245 RID: 143941
		public const int NameItem = 0;

		// Token: 0x04023246 RID: 143942
		public const int Value = 1;
	}
}
