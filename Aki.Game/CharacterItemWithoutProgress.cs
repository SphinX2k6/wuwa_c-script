using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001307 RID: 4871
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItemWithoutProgress : GridProxyAbstract<CharacterData>
{
	// Token: 0x06008701 RID: 34561 RVA: 0x001CD154 File Offset: 0x001CB354
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06008702 RID: 34562 RVA: 0x001CD190 File Offset: 0x001CB390
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItemWithoutProgress.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItemWithoutProgress.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008703 RID: 34563 RVA: 0x001CD1D4 File Offset: 0x001CB3D4
	[NullableContext(1)]
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		this.NameItem.Refresh(data, false, 0);
		base.GetText(1).SetText(data.CurrentValue.ToString(), true);
	}

	// Token: 0x04003C53 RID: 15443
	[Nullable(2)]
	protected CharacterNameItem NameItem;

	// Token: 0x02007944 RID: 31044
	private static class EComponentDefine
	{
		// Token: 0x04027F18 RID: 163608
		public const int NameItem = 0;

		// Token: 0x04027F19 RID: 163609
		public const int Value = 1;
	}
}
