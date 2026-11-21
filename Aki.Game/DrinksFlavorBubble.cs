using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000411 RID: 1041
public class DrinksFlavorBubble : UiPanelBase
{
	// Token: 0x06003831 RID: 14385 RVA: 0x00147323 File Offset: 0x00145523
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06003832 RID: 14386 RVA: 0x0014735C File Offset: 0x0014555C
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText("+0", true);
	}

	// Token: 0x06003833 RID: 14387 RVA: 0x00147388 File Offset: 0x00145588
	public void Refresh(EDrinksFlavorType type, int value, float locX, float locZ)
	{
		base.SetTextureByPath(DrinksConfig.Instance.GetFlavorType(type).Value.Icon, base.GetTexture(0), null, null);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		this.Location.X = (double)locX;
		this.Location.Z = (double)locZ;
		UUIItem rootItem = this.RootItem;
		FVector fvector = this.Location.ToUeVectorOld();
		rootItem.SetUIWorldLocation(fvector);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x04002E43 RID: 11843
	[Nullable(1)]
	protected Vector Location = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002E44 RID: 11844
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x0200673D RID: 26429
	private class EBubble
	{
		// Token: 0x0402218D RID: 139661
		public const int TexIcon = 0;

		// Token: 0x0402218E RID: 139662
		public const int TxtValue = 1;
	}
}
