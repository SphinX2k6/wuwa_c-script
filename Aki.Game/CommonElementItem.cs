using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C68 RID: 7272
public class CommonElementItem : GridProxyAbstract<int>
{
	// Token: 0x060120BE RID: 73918 RVA: 0x0054E8A3 File Offset: 0x0054CAA3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x060120BF RID: 73919 RVA: 0x0054E8DC File Offset: 0x0054CADC
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Update(data);
		this.RefreshPanel();
	}

	// Token: 0x060120C0 RID: 73920 RVA: 0x0054E8EB File Offset: 0x0054CAEB
	public void Update(int elementId)
	{
		this.ElementId = elementId;
	}

	// Token: 0x060120C1 RID: 73921 RVA: 0x0054E8F4 File Offset: 0x0054CAF4
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

	// Token: 0x04009D5B RID: 40283
	private int ElementId;

	// Token: 0x02007F6D RID: 32621
	private enum ECommonElementCom
	{
		// Token: 0x040293B2 RID: 168882
		ElementBgSprite,
		// Token: 0x040293B3 RID: 168883
		ElementIconTexture
	}
}
