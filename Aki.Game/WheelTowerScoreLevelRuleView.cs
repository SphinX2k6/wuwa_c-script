using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AFA RID: 2810
public class WheelTowerScoreLevelRuleView : UiViewBase
{
	// Token: 0x060073F9 RID: 29689 RVA: 0x0023D7EF File Offset: 0x0023B9EF
	[NullableContext(1)]
	public WheelTowerScoreLevelRuleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060073FA RID: 29690 RVA: 0x0023D7F8 File Offset: 0x0023B9F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060073FB RID: 29691 RVA: 0x0023D8A4 File Offset: 0x0023BAA4
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerScoreLevelRuleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerScoreLevelRuleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060073FC RID: 29692 RVA: 0x0023D8E7 File Offset: 0x0023BAE7
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04004982 RID: 18818
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004983 RID: 18819
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<WheelTowerScoreLevelTargetItem, WheelTowerScoreLevelTargetData> TargetLoopScroll;
}
