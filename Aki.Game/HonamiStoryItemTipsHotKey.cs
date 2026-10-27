using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EAD RID: 7853
public class HonamiStoryItemTipsHotKey : UiPanelBase
{
	// Token: 0x0600F16F RID: 61807 RVA: 0x003A1300 File Offset: 0x0039F500
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600F170 RID: 61808 RVA: 0x003A133C File Offset: 0x0039F53C
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

	// Token: 0x02008482 RID: 33922
	private enum EDefine
	{
		// Token: 0x0402B221 RID: 176673
		PnlKeyList,
		// Token: 0x0402B222 RID: 176674
		PnlLocalOffsetX
	}
}
