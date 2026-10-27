using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024C2 RID: 9410
internal class CostDistributionItem : GridProxyAbstract<int>
{
	// Token: 0x06012DE3 RID: 77283 RVA: 0x004A8B3D File Offset: 0x004A6D3D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06012DE4 RID: 77284 RVA: 0x004A8B60 File Offset: 0x004A6D60
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(data.ToString(), true);
	}
}
