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

// Token: 0x02001642 RID: 5698
public class WheelTowerScoreLevelRuleView : UiViewBase
{
	// Token: 0x0600A01B RID: 40987 RVA: 0x002339AB File Offset: 0x00231BAB
	[NullableContext(1)]
	public WheelTowerScoreLevelRuleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A01C RID: 40988 RVA: 0x002339B4 File Offset: 0x00231BB4
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

	// Token: 0x0600A01D RID: 40989 RVA: 0x00233A60 File Offset: 0x00231C60
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerScoreLevelRuleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerScoreLevelRuleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A01E RID: 40990 RVA: 0x00233AA3 File Offset: 0x00231CA3
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040048DC RID: 18652
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040048DD RID: 18653
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<WheelTowerScoreLevelTargetItem, WheelTowerScoreLevelTargetData> TargetLoopScroll;
}
