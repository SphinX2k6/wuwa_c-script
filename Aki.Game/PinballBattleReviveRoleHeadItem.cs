using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D13 RID: 7443
public class PinballBattleReviveRoleHeadItem : GridProxyAbstract<int>
{
	// Token: 0x0600E0F7 RID: 57591 RVA: 0x0034C2D8 File Offset: 0x0034A4D8
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

	// Token: 0x0600E0F8 RID: 57592 RVA: 0x0034C320 File Offset: 0x0034A520
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		base.SetTextureShowUntilLoaded(PinballConfig.Instance.GetPinballRoleConfigById(data).Value.CircleIcon, base.GetTexture(0), null);
	}
}
