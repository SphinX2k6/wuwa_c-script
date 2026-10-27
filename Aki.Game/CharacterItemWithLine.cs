using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001306 RID: 4870
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItemWithLine : GridProxyAbstract<CharacterData>
{
	// Token: 0x060086FD RID: 34557 RVA: 0x001CD0A8 File Offset: 0x001CB2A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060086FE RID: 34558 RVA: 0x001CD0E4 File Offset: 0x001CB2E4
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItemWithLine.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItemWithLine.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060086FF RID: 34559 RVA: 0x001CD127 File Offset: 0x001CB327
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

	// Token: 0x04003C52 RID: 15442
	[Nullable(2)]
	protected CharacterItem CharacterItem;

	// Token: 0x02007942 RID: 31042
	private static class EComponentDefine
	{
		// Token: 0x04027F12 RID: 163602
		public const int CharacterItem = 0;

		// Token: 0x04027F13 RID: 163603
		public const int LineItem = 1;
	}
}
