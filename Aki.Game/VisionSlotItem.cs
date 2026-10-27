using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024F6 RID: 9462
public class VisionSlotItem : UiPanelBase
{
	// Token: 0x06013081 RID: 77953 RVA: 0x004B682B File Offset: 0x004B4A2B
	[NullableContext(1)]
	public VisionSlotItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06013082 RID: 77954 RVA: 0x004B6840 File Offset: 0x004B4A40
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06013083 RID: 77955 RVA: 0x004B68B0 File Offset: 0x004B4AB0
	[NullableContext(1)]
	public void Update(VisionSlotData data)
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		if (data.SlotState == EVisionSlotState.Lock)
		{
			base.GetItem(0).SetUIActive(true);
			return;
		}
		if (data.SlotState == EVisionSlotState.PreviewUnLock)
		{
			base.GetItem(1).SetUIActive(true);
			return;
		}
		if (data.SlotState == EVisionSlotState.UnlockAndNoProp)
		{
			base.GetItem(2).SetUIActive(true);
			return;
		}
		if (data.SlotState == EVisionSlotState.UnlockAndHaveProp)
		{
			base.GetItem(3).SetUIActive(true);
		}
	}

	// Token: 0x02008A89 RID: 35465
	private enum ESlotComponent
	{
		// Token: 0x0402CFCC RID: 184268
		ShowStateD,
		// Token: 0x0402CFCD RID: 184269
		ShowStateC,
		// Token: 0x0402CFCE RID: 184270
		ShowStateB,
		// Token: 0x0402CFCF RID: 184271
		ShowStateA
	}
}
