using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007BA RID: 1978
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItemWithLine : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005A98 RID: 23192 RVA: 0x001D5F14 File Offset: 0x001D4114
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06005A99 RID: 23193 RVA: 0x001D5F50 File Offset: 0x001D4150
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItemWithLine.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItemWithLine.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A9A RID: 23194 RVA: 0x001D5F93 File Offset: 0x001D4193
	[NullableContext(1)]
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		this.CharacterItem.Refresh(data, isSelected, gridIndex);
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(gridIndex != 0);
	}

	// Token: 0x04003CEA RID: 15594
	[Nullable(2)]
	protected CharacterItem CharacterItem;

	// Token: 0x02006ACC RID: 27340
	private static class EComponentDefine
	{
		// Token: 0x0402323F RID: 143935
		public const int CharacterItem = 0;

		// Token: 0x04023240 RID: 143936
		public const int LineItem = 1;
	}
}
