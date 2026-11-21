using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019A9 RID: 6569
internal class CostDistributionItem : GridProxyAbstract<int>
{
	// Token: 0x060102A3 RID: 66211 RVA: 0x004B66F1 File Offset: 0x004B48F1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060102A4 RID: 66212 RVA: 0x004B6714 File Offset: 0x004B4914
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
