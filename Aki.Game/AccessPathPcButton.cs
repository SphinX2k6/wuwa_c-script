using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001496 RID: 5270
public class AccessPathPcButton : UiPanelBase
{
	// Token: 0x0600D2BD RID: 53949 RVA: 0x003E800F File Offset: 0x003E620F
	[NullableContext(1)]
	public AccessPathPcButton(UUIItem parentItem, int accessPathId)
	{
		this.AccessPathId = accessPathId;
		base.CreateThenShowByResourceIdAsync("UiItem_PcAccessPathButton_Prefab", parentItem, false).Forget();
	}

	// Token: 0x0600D2BE RID: 53950 RVA: 0x003E8030 File Offset: 0x003E6230
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

	// Token: 0x0600D2BF RID: 53951 RVA: 0x003E8078 File Offset: 0x003E6278
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

	// Token: 0x04007697 RID: 30359
	private readonly int AccessPathId;

	// Token: 0x0200775B RID: 30555
	private enum EChildComponentType
	{
		// Token: 0x04026C04 RID: 158724
		AccessPathText
	}
}
