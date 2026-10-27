using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001FC3 RID: 8131
public class AccessPathPcButton : UiPanelBase
{
	// Token: 0x0600FE55 RID: 65109 RVA: 0x003DBA33 File Offset: 0x003D9C33
	[NullableContext(1)]
	public AccessPathPcButton(UUIItem parentItem, int accessPathId)
	{
		this.AccessPathId = accessPathId;
		base.CreateThenShowByResourceIdAsync("UiItem_PcAccessPathButton_Prefab", parentItem, false).Forget();
	}

	// Token: 0x0600FE56 RID: 65110 RVA: 0x003DBA54 File Offset: 0x003D9C54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FE57 RID: 65111 RVA: 0x003DBA9C File Offset: 0x003D9C9C
	protected override void OnStart()
	{
		AccessPath? accessPathConfig = InventoryConfig.Instance.GetAccessPathConfig(this.AccessPathId);
		if (accessPathConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		string description = accessPathConfig.Value.Description;
		text.ShowTextNew(description);
	}

	// Token: 0x040075AE RID: 30126
	private readonly int AccessPathId;

	// Token: 0x020085D4 RID: 34260
	private enum EChildComponentType
	{
		// Token: 0x0402B8F5 RID: 178421
		AccessPathText
	}
}
