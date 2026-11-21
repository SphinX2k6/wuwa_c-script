using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001923 RID: 6435
public class PhantomBattleSelectedItem : UiPanelBase
{
	// Token: 0x0600FE5A RID: 65114 RVA: 0x004A42D1 File Offset: 0x004A24D1
	[NullableContext(1)]
	public PhantomBattleSelectedItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FE5B RID: 65115 RVA: 0x004A42E8 File Offset: 0x004A24E8
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

	// Token: 0x0600FE5C RID: 65116 RVA: 0x004A4363 File Offset: 0x004A2563
	protected override void OnStart()
	{
		base.GetItem(0).SetUIActive(true);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600FE5D RID: 65117 RVA: 0x004A4380 File Offset: 0x004A2580
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

	// Token: 0x02007B4B RID: 31563
	private enum ESelectedItemComponent
	{
		// Token: 0x04027F37 RID: 163639
		SelectedItem,
		// Token: 0x04027F38 RID: 163640
		SelectedNumText,
		// Token: 0x04027F39 RID: 163641
		DecomposeItem,
		// Token: 0x04027F3A RID: 163642
		DecomposeButton
	}
}
