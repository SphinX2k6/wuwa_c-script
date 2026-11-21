using System;
using System.Collections.Generic;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AC0 RID: 6848
public class PhotographTab : UiPanelBase
{
	// Token: 0x06010F66 RID: 69478 RVA: 0x004F95FF File Offset: 0x004F77FF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06010F67 RID: 69479 RVA: 0x004F9622 File Offset: 0x004F7822
	protected override void OnBeforeShow()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06010F68 RID: 69480 RVA: 0x004F962C File Offset: 0x004F782C
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

	// Token: 0x02007D77 RID: 32119
	private enum EChildType
	{
		// Token: 0x040289F1 RID: 166385
		RedDot = 1
	}
}
