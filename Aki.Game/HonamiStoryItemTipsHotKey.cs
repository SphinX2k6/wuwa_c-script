using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200136F RID: 4975
public class HonamiStoryItemTipsHotKey : UiPanelBase
{
	// Token: 0x0600C58E RID: 50574 RVA: 0x003ACE08 File Offset: 0x003AB008
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600C58F RID: 50575 RVA: 0x003ACE44 File Offset: 0x003AB044
	[NullableContext(1)]
	public void SetAutoLocation(UUIItem gridItem)
	{
		Vector adaptiveTipsPosition = LguiUtil.Instance.GetAdaptiveTipsPosition(gridItem, this.RootItem, 0f);
		float width = base.GetItem(1).Width;
		float num = (gridItem.Height > gridItem.Width) ? (-gridItem.Width / 2f) : (-gridItem.Height / 2f);
		adaptiveTipsPosition.X += (double)width;
		adaptiveTipsPosition.Z += (double)num;
		FVector fvector = adaptiveTipsPosition.ToUeVectorOld();
		this.RootItem.SetUIWorldLocation(fvector);
	}

	// Token: 0x02007607 RID: 30215
	private enum EDefine
	{
		// Token: 0x04026545 RID: 156997
		PnlKeyList,
		// Token: 0x04026546 RID: 156998
		PnlLocalOffsetX
	}
}
