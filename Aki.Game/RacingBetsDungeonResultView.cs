using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002730 RID: 10032
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDungeonResultView : UiViewBase
{
	// Token: 0x060148F1 RID: 84209 RVA: 0x00531AE6 File Offset: 0x0052FCE6
	public RacingBetsDungeonResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148F2 RID: 84210 RVA: 0x00531AF0 File Offset: 0x0052FCF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060148F3 RID: 84211 RVA: 0x00531BFC File Offset: 0x0052FDFC
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDungeonResultView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDungeonResultView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148F4 RID: 84212 RVA: 0x00531C3F File Offset: 0x0052FE3F
	protected override void OnStart()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetVerticalLayout(1).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x060148F5 RID: 84213 RVA: 0x00531C74 File Offset: 0x0052FE74
	protected override void OnBeforeDestroy()
	{
		this.Promise.SetResult(default(UniTaskVoid));
	}

	// Token: 0x060148F6 RID: 84214 RVA: 0x00531C95 File Offset: 0x0052FE95
	private RacingBetsLegMatchResultItem ResultItemProxyCreate()
	{
		return new RacingBetsLegMatchResultItem();
	}

	// Token: 0x060148F7 RID: 84215 RVA: 0x00531C9C File Offset: 0x0052FE9C
	private void OnClickCloseButton(EToggleState state)
	{
		base.CloseMe(null);
	}

	// Token: 0x04009A8A RID: 39562
	private GenericLayout<RacingBetsLegMatchResultItem, IRacingBetsLegMatchResultData> MatchResultLayout;

	// Token: 0x04009A8B RID: 39563
	private CustomPromise<UniTaskVoid> Promise;

	// Token: 0x02008D8D RID: 36237
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DEF0 RID: 188144
		LegMatchName,
		// Token: 0x0402DEF1 RID: 188145
		MatchResultLayout,
		// Token: 0x0402DEF2 RID: 188146
		ResultItem,
		// Token: 0x0402DEF3 RID: 188147
		TimeText,
		// Token: 0x0402DEF4 RID: 188148
		CloseButton
	}
}
