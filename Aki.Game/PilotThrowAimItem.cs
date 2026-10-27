using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025E2 RID: 9698
public class PilotThrowAimItem : UiPanelBase
{
	// Token: 0x06013B79 RID: 80761 RVA: 0x004F1880 File Offset: 0x004EFA80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013B7A RID: 80762 RVA: 0x004F18DA File Offset: 0x004EFADA
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

	// Token: 0x06013B7B RID: 80763 RVA: 0x004F1904 File Offset: 0x004EFB04
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

	// Token: 0x02008C1A RID: 35866
	private class EViewComponent
	{
		// Token: 0x0402D7BD RID: 186301
		public const int NormalItem = 0;

		// Token: 0x0402D7BE RID: 186302
		public const int AimItem = 1;

		// Token: 0x0402D7BF RID: 186303
		public const int TargetNameText = 2;
	}
}
