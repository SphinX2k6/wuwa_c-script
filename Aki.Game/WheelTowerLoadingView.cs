using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AD1 RID: 2769
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerLoadingView : LoadingViewBase
{
	// Token: 0x06007302 RID: 29442 RVA: 0x00237603 File Offset: 0x00235803
	[NullableContext(1)]
	public WheelTowerLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007303 RID: 29443 RVA: 0x0023760C File Offset: 0x0023580C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007304 RID: 29444 RVA: 0x0023771C File Offset: 0x0023591C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerLoadingView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerLoadingView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007305 RID: 29445 RVA: 0x0023775F File Offset: 0x0023595F
	[NullableContext(1)]
	private WheelTowerLoadingTeamRoleItem InitTeamItem()
	{
		return new WheelTowerLoadingTeamRoleItem();
	}

	// Token: 0x06007306 RID: 29446 RVA: 0x00237766 File Offset: 0x00235966
	protected override void UpdateProgressRate(float rate)
	{
		base.GetSprite(5).SetFillAmount(rate);
	}

	// Token: 0x06007307 RID: 29447 RVA: 0x00237775 File Offset: 0x00235975
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(6, value, "");
	}

	// Token: 0x04004840 RID: 18496
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004841 RID: 18497
	private WheelTowerModeTitleItem ModeTitleItem;

	// Token: 0x04004842 RID: 18498
	private WheelTowerLoadingBuffInfoPanel BuffInfoPanel;

	// Token: 0x04004843 RID: 18499
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerLoadingTeamRoleItem, int> TeamRoleLayout;
}
