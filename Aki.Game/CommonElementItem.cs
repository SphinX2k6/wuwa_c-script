using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200277D RID: 10109
public class CommonElementItem : GridProxyAbstract<int>
{
	// Token: 0x06014BDB RID: 84955 RVA: 0x0053FA17 File Offset: 0x0053DC17
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06014BDC RID: 84956 RVA: 0x0053FA50 File Offset: 0x0053DC50
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Update(data);
		this.RefreshPanel();
	}

	// Token: 0x06014BDD RID: 84957 RVA: 0x0053FA5F File Offset: 0x0053DC5F
	public void Update(int elementId)
	{
		this.ElementId = elementId;
	}

	// Token: 0x06014BDE RID: 84958 RVA: 0x0053FA68 File Offset: 0x0053DC68
	public void RefreshPanel()
	{
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(this.ElementId);
		if (elementConfig == null)
		{
			return;
		}
		FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
		base.GetSprite(0).SetColor(color);
		base.SetTextureByPath(elementConfig.Value.Icon5, base.GetTexture(1), null, null);
	}

	// Token: 0x04009C03 RID: 39939
	private int ElementId;

	// Token: 0x02008DE6 RID: 36326
	private enum ECommonElementCom
	{
		// Token: 0x0402E09E RID: 188574
		ElementBgSprite,
		// Token: 0x0402E09F RID: 188575
		ElementIconTexture
	}
}
