using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016F6 RID: 5878
public class PreDownloadButtonItemB : UiPanelBase
{
	// Token: 0x0600E490 RID: 58512 RVA: 0x00431ACF File Offset: 0x0042FCCF
	[NullableContext(1)]
	public PreDownloadButtonItemB(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600E491 RID: 58513 RVA: 0x00431AE4 File Offset: 0x0042FCE4
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

	// Token: 0x0600E492 RID: 58514 RVA: 0x00431B50 File Offset: 0x0042FD50
	public void BindRedDot()
	{
		UUIItem item = base.GetItem(0);
		RedDotController.Instance.BindRedDot(ERedDotName.PreDownload, item, null, 0);
		UUIItem item2 = base.GetItem(1);
		RedDotController.Instance.BindRedDot(ERedDotName.PreDownloadComplete, item2, null, 0);
	}

	// Token: 0x0600E493 RID: 58515 RVA: 0x00431B8C File Offset: 0x0042FD8C
	public void UnBindRedDot()
	{
		UUIItem item = base.GetItem(0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PreDownload, item, 0);
		UUIItem item2 = base.GetItem(1);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.PreDownloadComplete, item2, 0);
	}

	// Token: 0x020078D2 RID: 30930
	private enum EComponentTypeB
	{
		// Token: 0x040272BC RID: 160444
		RedDot,
		// Token: 0x040272BD RID: 160445
		GreenDot
	}
}
