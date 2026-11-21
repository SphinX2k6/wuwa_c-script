using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000520 RID: 1312
public class GuessJokerCardBackItem : UiPanelBase
{
	// Token: 0x06003FFE RID: 16382 RVA: 0x00166C1F File Offset: 0x00164E1F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x00166C58 File Offset: 0x00164E58
	protected override void OnStart()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x00166C74 File Offset: 0x00164E74
	protected override void OnBeforeDestroy()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x020067ED RID: 26605
	private class EComponentDefine
	{
		// Token: 0x04022461 RID: 140385
		public const int ChooseCardItem = 0;

		// Token: 0x04022462 RID: 140386
		public const int SelectCardItem = 1;
	}
}
