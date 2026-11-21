using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E08 RID: 3592
public class MiniElementItem : UiPanelBase
{
	// Token: 0x06009120 RID: 37152 RVA: 0x002B76BD File Offset: 0x002B58BD
	[NullableContext(2)]
	public MiniElementItem(int elementId, UUIItem parentUiItem = null, AActor rootActor = null)
	{
		this.ElementId = elementId;
		if (rootActor == null && parentUiItem != null)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_MiniElement_Prefab", parentUiItem, false);
			return;
		}
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x06009121 RID: 37153 RVA: 0x002B76E9 File Offset: 0x002B58E9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06009122 RID: 37154 RVA: 0x002B7722 File Offset: 0x002B5922
	protected override void OnStart()
	{
		this.RefreshMiniElement(this.ElementId);
	}

	// Token: 0x06009123 RID: 37155 RVA: 0x002B7730 File Offset: 0x002B5930
	public void RefreshMiniElement(int elementId)
	{
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
		if (string.IsNullOrEmpty(elementConfig.Value.Icon5))
		{
			return;
		}
		FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
		base.GetSprite(0).SetColor(color);
		base.SetTextureByPath(elementConfig.Value.Icon5, texture, null, null);
	}

	// Token: 0x06009124 RID: 37156 RVA: 0x002B77BC File Offset: 0x002B59BC
	[NullableContext(1)]
	public void SetIconByPath(string iconPath)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(iconPath, texture, null);
	}

	// Token: 0x04005606 RID: 22022
	private readonly int ElementId;

	// Token: 0x02007037 RID: 28727
	private enum EChildComponentType
	{
		// Token: 0x040249DA RID: 149978
		ElementBg,
		// Token: 0x040249DB RID: 149979
		ElementTexture
	}
}
