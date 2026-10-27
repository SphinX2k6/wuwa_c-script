using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028CC RID: 10444
public class RoleSkillTrickTextureItem : UiPanelBase
{
	// Token: 0x0601590C RID: 88332 RVA: 0x00572230 File Offset: 0x00570430
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

	// Token: 0x0601590D RID: 88333 RVA: 0x00572278 File Offset: 0x00570478
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

	// Token: 0x02008EE1 RID: 36577
	private enum EComponent
	{
		// Token: 0x0402E558 RID: 189784
		Texture
	}
}
