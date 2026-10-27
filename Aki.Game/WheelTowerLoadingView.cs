using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001619 RID: 5657
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerLoadingView : LoadingViewBase
{
	// Token: 0x06009F24 RID: 40740 RVA: 0x0022D7D3 File Offset: 0x0022B9D3
	[NullableContext(1)]
	public WheelTowerLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F25 RID: 40741 RVA: 0x0022D7DC File Offset: 0x0022B9DC
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

	// Token: 0x06009F26 RID: 40742 RVA: 0x0022D8EC File Offset: 0x0022BAEC
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerLoadingView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerLoadingView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F27 RID: 40743 RVA: 0x0022D92F File Offset: 0x0022BB2F
	[NullableContext(1)]
	private WheelTowerLoadingTeamRoleItem InitTeamItem()
	{
		return new WheelTowerLoadingTeamRoleItem();
	}

	// Token: 0x06009F28 RID: 40744 RVA: 0x0022D936 File Offset: 0x0022BB36
	protected override void UpdateProgressRate(float rate)
	{
		base.GetSprite(5).SetFillAmount(rate);
	}

	// Token: 0x06009F29 RID: 40745 RVA: 0x0022D945 File Offset: 0x0022BB45
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(6, value, "");
	}

	// Token: 0x0400479A RID: 18330
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400479B RID: 18331
	private WheelTowerModeTitleItem ModeTitleItem;

	// Token: 0x0400479C RID: 18332
	private WheelTowerLoadingBuffInfoPanel BuffInfoPanel;

	// Token: 0x0400479D RID: 18333
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerLoadingTeamRoleItem, int> TeamRoleLayout;
}
