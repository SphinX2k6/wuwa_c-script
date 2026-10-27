using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F1C RID: 3868
public class AchievementCompleteTipsStarItem : GridProxyAbstract<bool>
{
	// Token: 0x060061DD RID: 25053 RVA: 0x00131A41 File Offset: 0x0012FC41
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x00131A64 File Offset: 0x0012FC64
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data);
	}

	// Token: 0x02007561 RID: 30049
	private enum EComponent
	{
		// Token: 0x04026CF2 RID: 158962
		StarObj
	}
}
