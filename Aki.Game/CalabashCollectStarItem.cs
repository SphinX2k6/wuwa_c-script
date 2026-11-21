using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000BFB RID: 3067
public class CalabashCollectStarItem : GridProxyAbstract<bool>
{
	// Token: 0x06008029 RID: 32809 RVA: 0x00274169 File Offset: 0x00272369
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x0027418C File Offset: 0x0027238C
	public override void Refresh(bool isUnlock, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isUnlock);
	}

	// Token: 0x02006EB1 RID: 28337
	private enum EComponent
	{
		// Token: 0x04024309 RID: 148233
		UnlockItem
	}
}
