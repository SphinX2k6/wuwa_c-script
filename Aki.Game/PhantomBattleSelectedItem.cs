using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200243E RID: 9278
public class PhantomBattleSelectedItem : UiPanelBase
{
	// Token: 0x060129A4 RID: 76196 RVA: 0x00496D05 File Offset: 0x00494F05
	[NullableContext(1)]
	public PhantomBattleSelectedItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060129A5 RID: 76197 RVA: 0x00496D1C File Offset: 0x00494F1C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060129A6 RID: 76198 RVA: 0x00496D97 File Offset: 0x00494F97
	protected override void OnStart()
	{
		base.GetItem(0).SetUIActive(true);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x060129A7 RID: 76199 RVA: 0x00496DB4 File Offset: 0x00494FB4
	public void UpdateSelectedItem(int current, int sum)
	{
		string newText;
		if (current != sum)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#9d2437>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(current);
			defaultInterpolatedStringHandler.AppendLiteral("</color><color=#ffffff>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(sum);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			newText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(current);
			defaultInterpolatedStringHandler.AppendLiteral("</color><color=#ffffff>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(sum);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			newText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		base.GetText(1).SetText(newText, true);
	}

	// Token: 0x020089C4 RID: 35268
	private enum ESelectedItemComponent
	{
		// Token: 0x0402CC21 RID: 183329
		SelectedItem,
		// Token: 0x0402CC22 RID: 183330
		SelectedNumText,
		// Token: 0x0402CC23 RID: 183331
		DecomposeItem,
		// Token: 0x0402CC24 RID: 183332
		DecomposeButton
	}
}
