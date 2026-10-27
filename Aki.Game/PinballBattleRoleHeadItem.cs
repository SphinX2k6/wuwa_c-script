using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D04 RID: 7428
internal class PinballBattleRoleHeadItem : GridProxyAbstract<int>
{
	// Token: 0x0600E0B1 RID: 57521 RVA: 0x0034B1D4 File Offset: 0x003493D4
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

	// Token: 0x0600E0B2 RID: 57522 RVA: 0x0034B21C File Offset: 0x0034941C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		base.SetTextureShowUntilLoaded(PinballConfig.Instance.GetPinballRoleConfigById(data).Value.Icon, base.GetTexture(0), null);
	}
}
