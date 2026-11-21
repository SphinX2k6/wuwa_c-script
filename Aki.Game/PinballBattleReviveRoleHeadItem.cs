using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011D5 RID: 4565
public class PinballBattleReviveRoleHeadItem : GridProxyAbstract<int>
{
	// Token: 0x0600B514 RID: 46356 RVA: 0x00357D08 File Offset: 0x00355F08
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

	// Token: 0x0600B515 RID: 46357 RVA: 0x00357D50 File Offset: 0x00355F50
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		base.SetTextureShowUntilLoaded(PinballConfig.Instance.GetPinballRoleConfigById(data).Value.CircleIcon, base.GetTexture(0), null);
	}
}
