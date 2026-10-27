using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001742 RID: 5954
public class CalabashCollectStarItem : GridProxyAbstract<bool>
{
	// Token: 0x0600AC42 RID: 44098 RVA: 0x00269D2D File Offset: 0x00267F2D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600AC43 RID: 44099 RVA: 0x00269D50 File Offset: 0x00267F50
	public override void Refresh(bool isUnlock, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isUnlock);
	}

	// Token: 0x02007D2B RID: 32043
	private enum EComponent
	{
		// Token: 0x04028FDF RID: 167903
		UnlockItem
	}
}
