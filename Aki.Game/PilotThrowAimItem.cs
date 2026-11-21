using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ACD RID: 6861
public class PilotThrowAimItem : UiPanelBase
{
	// Token: 0x0601105B RID: 69723 RVA: 0x005005B0 File Offset: 0x004FE7B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0601105C RID: 69724 RVA: 0x0050060A File Offset: 0x004FE80A
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0601105D RID: 69725 RVA: 0x00500634 File Offset: 0x004FE834
	[NullableContext(2)]
	public void OnFocusTarget(string targetPointText)
	{
		if (string.IsNullOrEmpty(targetPointText))
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(0);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(1);
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(targetPointText, true);
			return;
		}
	}

	// Token: 0x02007DA3 RID: 32163
	private class EViewComponent
	{
		// Token: 0x04028AD5 RID: 166613
		public const int NormalItem = 0;

		// Token: 0x04028AD6 RID: 166614
		public const int AimItem = 1;

		// Token: 0x04028AD7 RID: 166615
		public const int TargetNameText = 2;
	}
}
