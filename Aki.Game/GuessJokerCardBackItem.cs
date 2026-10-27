using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200106C RID: 4204
public class GuessJokerCardBackItem : UiPanelBase
{
	// Token: 0x06006C69 RID: 27753 RVA: 0x0015E2EB File Offset: 0x0015C4EB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06006C6A RID: 27754 RVA: 0x0015E324 File Offset: 0x0015C524
	protected override void OnStart()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06006C6B RID: 27755 RVA: 0x0015E340 File Offset: 0x0015C540
	protected override void OnBeforeDestroy()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x02007659 RID: 30297
	private class EComponentDefine
	{
		// Token: 0x04027116 RID: 160022
		public const int ChooseCardItem = 0;

		// Token: 0x04027117 RID: 160023
		public const int SelectCardItem = 1;
	}
}
