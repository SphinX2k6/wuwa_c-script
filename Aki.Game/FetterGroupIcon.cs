using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024A8 RID: 9384
public class FetterGroupIcon : GridProxyAbstract<int>
{
	// Token: 0x06012D58 RID: 77144 RVA: 0x004A6338 File Offset: 0x004A4538
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012D59 RID: 77145 RVA: 0x004A6394 File Offset: 0x004A4594
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
