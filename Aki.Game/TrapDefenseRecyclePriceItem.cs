using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D2C RID: 7468
public class TrapDefenseRecyclePriceItem : UiPanelBase
{
	// Token: 0x0600E239 RID: 57913 RVA: 0x00352491 File Offset: 0x00350691
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600E23A RID: 57914 RVA: 0x003524CC File Offset: 0x003506CC
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

	// Token: 0x02008330 RID: 33584
	private static class EDefine
	{
		// Token: 0x0402AC8E RID: 175246
		public const int Icon = 0;

		// Token: 0x0402AC8F RID: 175247
		public const int Value = 1;
	}
}
