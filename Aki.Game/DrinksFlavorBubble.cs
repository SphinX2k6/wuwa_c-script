using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F5C RID: 3932
public class DrinksFlavorBubble : UiPanelBase
{
	// Token: 0x06006499 RID: 25753 RVA: 0x0013EA87 File Offset: 0x0013CC87
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600649A RID: 25754 RVA: 0x0013EAC0 File Offset: 0x0013CCC0
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

	// Token: 0x0600649B RID: 25755 RVA: 0x0013EAEC File Offset: 0x0013CCEC
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

	// Token: 0x04002DAA RID: 11690
	[Nullable(1)]
	protected Vector Location = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002DAB RID: 11691
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x020075A9 RID: 30121
	private class EBubble
	{
		// Token: 0x04026E42 RID: 159298
		public const int TexIcon = 0;

		// Token: 0x04026E43 RID: 159299
		public const int TxtValue = 1;
	}
}
