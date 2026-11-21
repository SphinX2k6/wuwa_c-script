using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E47 RID: 7751
public class RoleSkillTrickTextureItem : UiPanelBase
{
	// Token: 0x0601330C RID: 78604 RVA: 0x0059D0E8 File Offset: 0x0059B2E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601330D RID: 78605 RVA: 0x0059D130 File Offset: 0x0059B330
	[NullableContext(1)]
	public UniTask SetTexture(string icon)
	{
		RoleSkillTrickTextureItem.<SetTexture>d__2 <SetTexture>d__;
		<SetTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetTexture>d__.<>4__this = this;
		<SetTexture>d__.icon = icon;
		<SetTexture>d__.<>1__state = -1;
		<SetTexture>d__.<>t__builder.Start<RoleSkillTrickTextureItem.<SetTexture>d__2>(ref <SetTexture>d__);
		return <SetTexture>d__.<>t__builder.Task;
	}

	// Token: 0x02008129 RID: 33065
	private enum EComponent
	{
		// Token: 0x04029C53 RID: 171091
		Texture
	}
}
