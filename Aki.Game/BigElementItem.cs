using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017E5 RID: 6117
public class BigElementItem : UiPanelBase
{
	// Token: 0x0600B2E5 RID: 45797 RVA: 0x0028713B File Offset: 0x0028533B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600B2E6 RID: 45798 RVA: 0x00287174 File Offset: 0x00285374
	protected override void OnStart()
	{
	}

	// Token: 0x0600B2E7 RID: 45799 RVA: 0x00287178 File Offset: 0x00285378
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

	// Token: 0x04005111 RID: 20753
	private int ElementId;

	// Token: 0x02007DD1 RID: 32209
	private enum EChildComponentType
	{
		// Token: 0x040292FE RID: 168702
		ElementBg,
		// Token: 0x040292FF RID: 168703
		ElementTexture,
		// Token: 0x04029300 RID: 168704
		Panel
	}
}
