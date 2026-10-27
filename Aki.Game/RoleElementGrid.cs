using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001963 RID: 6499
public class RoleElementGrid : UiPanelBase
{
	// Token: 0x0600BE24 RID: 48676 RVA: 0x002B01EE File Offset: 0x002AE3EE
	[NullableContext(1)]
	public RoleElementGrid(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x17000FE5 RID: 4069
	// (get) Token: 0x0600BE25 RID: 48677 RVA: 0x002B0200 File Offset: 0x002AE400
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

	// Token: 0x0600BE26 RID: 48678 RVA: 0x002B022F File Offset: 0x002AE42F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600BE27 RID: 48679 RVA: 0x002B0268 File Offset: 0x002AE468
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

	// Token: 0x0600BE28 RID: 48680 RVA: 0x002B02EF File Offset: 0x002AE4EF
	public void Refresh(int elementId)
	{
		this.ElementId = elementId;
		this.UpdateElementTexture();
	}

	// Token: 0x040055B9 RID: 21945
	private int ElementId;

	// Token: 0x02007EB9 RID: 32441
	private enum EChildType
	{
		// Token: 0x040296E0 RID: 169696
		TextureElement,
		// Token: 0x040296E1 RID: 169697
		SpriteBg
	}
}
