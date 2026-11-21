using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011EE RID: 4590
public class TrapDefenseRecyclePriceItem : UiPanelBase
{
	// Token: 0x0600B656 RID: 46678 RVA: 0x0035DEC1 File Offset: 0x0035C0C1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600B657 RID: 46679 RVA: 0x0035DEFC File Offset: 0x0035C0FC
	public void UpdatePrice(int recyclePrice)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("+");
		defaultInterpolatedStringHandler.AppendFormatted<int>(recyclePrice);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x020074B9 RID: 29881
	private static class EDefine
	{
		// Token: 0x04025FB6 RID: 155574
		public const int Icon = 0;

		// Token: 0x04025FB7 RID: 155575
		public const int Value = 1;
	}
}
