using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200194B RID: 6475
public class MiniElementItem : UiPanelBase
{
	// Token: 0x0600BD1D RID: 48413 RVA: 0x002AC879 File Offset: 0x002AAA79
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

	// Token: 0x0600BD1E RID: 48414 RVA: 0x002AC8A5 File Offset: 0x002AAAA5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600BD1F RID: 48415 RVA: 0x002AC8DE File Offset: 0x002AAADE
	protected override void OnStart()
	{
		this.RefreshMiniElement(this.ElementId);
	}

	// Token: 0x0600BD20 RID: 48416 RVA: 0x002AC8EC File Offset: 0x002AAAEC
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

	// Token: 0x0600BD21 RID: 48417 RVA: 0x002AC978 File Offset: 0x002AAB78
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

	// Token: 0x04005559 RID: 21849
	private readonly int ElementId;

	// Token: 0x02007EA8 RID: 32424
	private enum EChildComponentType
	{
		// Token: 0x0402969D RID: 169629
		ElementBg,
		// Token: 0x0402969E RID: 169630
		ElementTexture
	}
}
