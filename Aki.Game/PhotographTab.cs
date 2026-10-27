using System;
using System.Collections.Generic;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025D5 RID: 9685
public class PhotographTab : UiPanelBase
{
	// Token: 0x06013A86 RID: 80518 RVA: 0x004EA9FF File Offset: 0x004E8BFF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06013A87 RID: 80519 RVA: 0x004EAA22 File Offset: 0x004E8C22
	protected override void OnBeforeShow()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06013A88 RID: 80520 RVA: 0x004EAA2C File Offset: 0x004E8C2C
	public void RefreshRedDot()
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FilterRedPoint) as ServerStorageBoolean;
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(serverStorageBoolean.Get().GetValueOrDefault(true));
	}

	// Token: 0x02008BEF RID: 35823
	private enum EChildType
	{
		// Token: 0x0402D6DC RID: 186076
		RedDot = 1
	}
}
