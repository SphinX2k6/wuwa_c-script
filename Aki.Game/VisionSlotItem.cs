using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019DD RID: 6621
public class VisionSlotItem : UiPanelBase
{
	// Token: 0x06010540 RID: 66880 RVA: 0x004C44BA File Offset: 0x004C26BA
	[NullableContext(1)]
	public VisionSlotItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06010541 RID: 66881 RVA: 0x004C44D0 File Offset: 0x004C26D0
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

	// Token: 0x06010542 RID: 66882 RVA: 0x004C4540 File Offset: 0x004C2740
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

	// Token: 0x02007C11 RID: 31761
	private enum ESlotComponent
	{
		// Token: 0x040282E4 RID: 164580
		ShowStateD,
		// Token: 0x040282E5 RID: 164581
		ShowStateC,
		// Token: 0x040282E6 RID: 164582
		ShowStateB,
		// Token: 0x040282E7 RID: 164583
		ShowStateA
	}
}
