using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200198F RID: 6543
public class FetterGroupIcon : GridProxyAbstract<int>
{
	// Token: 0x06010219 RID: 66073 RVA: 0x004B3E30 File Offset: 0x004B2030
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0601021A RID: 66074 RVA: 0x004B3E8C File Offset: 0x004B208C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterElementPath, base.GetTexture(2), null, null);
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(gridIndex != 0);
	}
}
