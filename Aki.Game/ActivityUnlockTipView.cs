using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001683 RID: 5763
[NullableContext(1)]
[Nullable(0)]
public class ActivityUnlockTipView : UiViewBase
{
	// Token: 0x0600A309 RID: 41737 RVA: 0x00240506 File Offset: 0x0023E706
	public ActivityUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x17000DC9 RID: 3529
	// (get) Token: 0x0600A30A RID: 41738 RVA: 0x0024050F File Offset: 0x0023E70F
	// (set) Token: 0x0600A30B RID: 41739 RVA: 0x00240517 File Offset: 0x0023E717
	protected ActivityBaseData ActivityBaseData { get; set; }

	// Token: 0x0600A30C RID: 41740 RVA: 0x00240520 File Offset: 0x0023E720
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A30D RID: 41741 RVA: 0x00240568 File Offset: 0x0023E768
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A30E RID: 41742 RVA: 0x00240571 File Offset: 0x0023E771
	protected override void OnStart()
	{
		this.ActivityBaseData = (this.OpenParam as ActivityBaseData);
		this.Refresh();
	}

	// Token: 0x0600A30F RID: 41743 RVA: 0x0024058C File Offset: 0x0023E78C
	protected void Refresh()
	{
		this.SetTitle(this.ActivityBaseData.LocalConfig.Value.Title);
	}

	// Token: 0x0600A310 RID: 41744 RVA: 0x002405B7 File Offset: 0x0023E7B7
	protected void SetTitle(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
	}

	// Token: 0x02007C41 RID: 31809
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028C5A RID: 167002
		public const int Title = 0;
	}
}
