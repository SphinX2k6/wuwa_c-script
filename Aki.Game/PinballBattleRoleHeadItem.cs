using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011C6 RID: 4550
internal class PinballBattleRoleHeadItem : GridProxyAbstract<int>
{
	// Token: 0x0600B4CE RID: 46286 RVA: 0x00356C04 File Offset: 0x00354E04
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

	// Token: 0x0600B4CF RID: 46287 RVA: 0x00356C4C File Offset: 0x00354E4C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		base.SetTextureShowUntilLoaded(PinballConfig.Instance.GetPinballRoleConfigById(data).Value.Icon, base.GetTexture(0), null);
	}
}
