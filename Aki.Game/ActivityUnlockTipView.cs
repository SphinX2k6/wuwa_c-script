using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B3B RID: 2875
[NullableContext(1)]
[Nullable(0)]
public class ActivityUnlockTipView : UiViewBase
{
	// Token: 0x060076E7 RID: 30439 RVA: 0x0024A492 File Offset: 0x00248692
	public ActivityUnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x17000DEA RID: 3562
	// (get) Token: 0x060076E8 RID: 30440 RVA: 0x0024A49B File Offset: 0x0024869B
	// (set) Token: 0x060076E9 RID: 30441 RVA: 0x0024A4A3 File Offset: 0x002486A3
	protected ActivityBaseData ActivityBaseData { get; set; }

	// Token: 0x060076EA RID: 30442 RVA: 0x0024A4AC File Offset: 0x002486AC
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

	// Token: 0x060076EB RID: 30443 RVA: 0x0024A4F4 File Offset: 0x002486F4
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x060076EC RID: 30444 RVA: 0x0024A4FD File Offset: 0x002486FD
	protected override void OnStart()
	{
		this.ActivityBaseData = (this.OpenParam as ActivityBaseData);
		this.Refresh();
	}

	// Token: 0x060076ED RID: 30445 RVA: 0x0024A518 File Offset: 0x00248718
	protected void Refresh()
	{
		this.SetTitle(this.ActivityBaseData.LocalConfig.Value.Title);
	}

	// Token: 0x060076EE RID: 30446 RVA: 0x0024A543 File Offset: 0x00248743
	protected void SetTitle(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
	}

	// Token: 0x02006DC8 RID: 28104
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04023F8B RID: 147339
		public const int Title = 0;
	}
}
