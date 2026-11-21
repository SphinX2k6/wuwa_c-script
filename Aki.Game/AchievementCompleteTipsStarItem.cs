using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020003D1 RID: 977
public class AchievementCompleteTipsStarItem : GridProxyAbstract<bool>
{
	// Token: 0x06003575 RID: 13685 RVA: 0x0013A365 File Offset: 0x00138565
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06003576 RID: 13686 RVA: 0x0013A388 File Offset: 0x00138588
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data);
	}

	// Token: 0x020066F5 RID: 26357
	private enum EComponent
	{
		// Token: 0x0402203D RID: 139325
		StarObj
	}
}
