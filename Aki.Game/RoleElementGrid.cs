using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E20 RID: 3616
public class RoleElementGrid : UiPanelBase
{
	// Token: 0x06009227 RID: 37415 RVA: 0x002BB032 File Offset: 0x002B9232
	[NullableContext(1)]
	public RoleElementGrid(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x17001009 RID: 4105
	// (get) Token: 0x06009228 RID: 37416 RVA: 0x002BB044 File Offset: 0x002B9244
	private ElementInfo? Config
	{
		get
		{
			if (this.ElementId == 0)
			{
				return null;
			}
			return ElementInfoConfig.Instance.GetElementInfo(this.ElementId);
		}
	}

	// Token: 0x06009229 RID: 37417 RVA: 0x002BB073 File Offset: 0x002B9273
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600922A RID: 37418 RVA: 0x002BB0AC File Offset: 0x002B92AC
	private void UpdateElementTexture()
	{
		UUITexture texture = base.GetTexture(0);
		UUISprite sprite = base.GetSprite(1);
		if (texture == null || sprite == null)
		{
			return;
		}
		ElementInfo? config = this.Config;
		if (config == null)
		{
			return;
		}
		FColor color = FColor.FromHex(config.Value.ElementColor);
		sprite.SetColor(color);
		string icon = config.Value.Icon;
		if (string.IsNullOrEmpty(icon))
		{
			return;
		}
		base.SetElementIcon(icon, texture, this.ElementId, null);
	}

	// Token: 0x0600922B RID: 37419 RVA: 0x002BB133 File Offset: 0x002B9333
	public void Refresh(int elementId)
	{
		this.ElementId = elementId;
		this.UpdateElementTexture();
	}

	// Token: 0x04005666 RID: 22118
	private int ElementId;

	// Token: 0x02007048 RID: 28744
	private enum EChildType
	{
		// Token: 0x04024A1D RID: 150045
		TextureElement,
		// Token: 0x04024A1E RID: 150046
		SpriteBg
	}
}
