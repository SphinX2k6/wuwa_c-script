using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002212 RID: 8722
public class PreDownloadButtonItemB : UiPanelBase
{
	// Token: 0x06010FFA RID: 69626 RVA: 0x00424F33 File Offset: 0x00423133
	[NullableContext(1)]
	public PreDownloadButtonItemB(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06010FFB RID: 69627 RVA: 0x00424F48 File Offset: 0x00423148
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06010FFC RID: 69628 RVA: 0x00424FB4 File Offset: 0x004231B4
	public void BindRedDot()
	{
		UUIItem item = base.GetItem(0);
		RedDotController.Instance.BindRedDot(ERedDotName.PreDownload, item, null, 0);
		UUIItem item2 = base.GetItem(1);
		RedDotController.Instance.BindRedDot(ERedDotName.PreDownloadComplete, item2, null, 0);
	}

	// Token: 0x06010FFD RID: 69629 RVA: 0x00424FF0 File Offset: 0x004231F0
	public void UnBindRedDot()
	{
		UUIItem item = base.GetItem(0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PreDownload, item, 0);
		UUIItem item2 = base.GetItem(1);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PreDownloadComplete, item2, 0);
	}

	// Token: 0x02008749 RID: 34633
	private enum EComponentTypeB
	{
		// Token: 0x0402BFA4 RID: 180132
		RedDot,
		// Token: 0x0402BFA5 RID: 180133
		GreenDot
	}
}
