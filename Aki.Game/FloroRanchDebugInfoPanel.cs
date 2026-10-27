using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B8A RID: 7050
public class FloroRanchDebugInfoPanel : UiPanelBase
{
	// Token: 0x0600D1E0 RID: 53728 RVA: 0x00301FE0 File Offset: 0x003001E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D1E1 RID: 53729 RVA: 0x003020A7 File Offset: 0x003002A7
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<FloroRanchDebugInfoItem, string>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<FloroRanchDebugInfoItem>(this.InitItem), false);
	}

	// Token: 0x0600D1E2 RID: 53730 RVA: 0x003020DC File Offset: 0x003002DC
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		FloroRanchDebugInfoPanel.<OnBeforeShowAsyncImplement>d__4 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<FloroRanchDebugInfoPanel.<OnBeforeShowAsyncImplement>d__4>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600D1E3 RID: 53731 RVA: 0x0030211F File Offset: 0x0030031F
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnFloroRanchDebugInfoRefresh, new Action(this.OnDebugInfoRefresh));
	}

	// Token: 0x0600D1E4 RID: 53732 RVA: 0x0030213D File Offset: 0x0030033D
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchDebugInfoRefresh, new Action(this.OnDebugInfoRefresh));
	}

	// Token: 0x0600D1E5 RID: 53733 RVA: 0x0030215B File Offset: 0x0030035B
	protected void OnClickCloseButton()
	{
		base.Hide(null);
	}

	// Token: 0x0600D1E6 RID: 53734 RVA: 0x00302164 File Offset: 0x00300364
	[NullableContext(1)]
	protected FloroRanchDebugInfoItem InitItem()
	{
		return new FloroRanchDebugInfoItem();
	}

	// Token: 0x0600D1E7 RID: 53735 RVA: 0x0030216C File Offset: 0x0030036C
	protected void OnDebugInfoRefresh()
	{
		List<string> actionInfoList = FloroRanchGamePlayModel.Instance.ActionInfoList;
		this.LoopScrollView.RefreshByData(actionInfoList, false, null, false);
		this.LoopScrollView.ScrollToGridIndex(actionInfoList.Count - 1, true);
	}

	// Token: 0x0400603F RID: 24639
	[Nullable(1)]
	protected LoopScrollView<FloroRanchDebugInfoItem, string> LoopScrollView;

	// Token: 0x0200810D RID: 33037
	private class EComponent
	{
		// Token: 0x0402A1EC RID: 172524
		public const int CloseButton = 0;

		// Token: 0x0402A1ED RID: 172525
		public const int LoopScrollView = 1;

		// Token: 0x0402A1EE RID: 172526
		public const int TemplateActor = 2;
	}
}
