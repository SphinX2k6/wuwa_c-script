using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C9E RID: 3230
public class BigElementItem : UiPanelBase
{
	// Token: 0x060086CF RID: 34511 RVA: 0x0029180F File Offset: 0x0028FA0F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x060086D0 RID: 34512 RVA: 0x00291848 File Offset: 0x0028FA48
	protected override void OnStart()
	{
	}

	// Token: 0x060086D1 RID: 34513 RVA: 0x0029184C File Offset: 0x0028FA4C
	public void Refresh(int elementId)
	{
		if (this.ElementId == elementId)
		{
			return;
		}
		this.ElementId = elementId;
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
		if (elementConfig == null)
		{
			return;
		}
		string icon4Pure = elementConfig.Value.Icon4Pure;
		if (StringUtils.IsEmpty(icon4Pure))
		{
			return;
		}
		FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
		base.GetSprite(0).SetColor(color);
		base.SetTextureByPath(icon4Pure, texture, null, null);
	}

	// Token: 0x040051BC RID: 20924
	private int ElementId;

	// Token: 0x02006F57 RID: 28503
	private enum EChildComponentType
	{
		// Token: 0x04024629 RID: 149033
		ElementBg,
		// Token: 0x0402462A RID: 149034
		ElementTexture,
		// Token: 0x0402462B RID: 149035
		Panel
	}
}
