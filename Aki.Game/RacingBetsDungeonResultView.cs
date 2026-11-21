using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C1B RID: 7195
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDungeonResultView : UiViewBase
{
	// Token: 0x06011DD3 RID: 73171 RVA: 0x005407FE File Offset: 0x0053E9FE
	public RacingBetsDungeonResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DD4 RID: 73172 RVA: 0x00540808 File Offset: 0x0053EA08
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

	// Token: 0x06011DD5 RID: 73173 RVA: 0x00540914 File Offset: 0x0053EB14
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDungeonResultView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDungeonResultView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011DD6 RID: 73174 RVA: 0x00540957 File Offset: 0x0053EB57
	protected override void OnStart()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetVerticalLayout(1).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x06011DD7 RID: 73175 RVA: 0x0054098C File Offset: 0x0053EB8C
	protected override void OnBeforeDestroy()
	{
		this.Promise.SetResult(default(UniTaskVoid));
	}

	// Token: 0x06011DD8 RID: 73176 RVA: 0x005409AD File Offset: 0x0053EBAD
	private RacingBetsLegMatchResultItem ResultItemProxyCreate()
	{
		return new RacingBetsLegMatchResultItem();
	}

	// Token: 0x06011DD9 RID: 73177 RVA: 0x005409B4 File Offset: 0x0053EBB4
	private void OnClickCloseButton(EToggleState state)
	{
		base.CloseMe(null);
	}

	// Token: 0x04009BE2 RID: 39906
	private GenericLayout<RacingBetsLegMatchResultItem, IRacingBetsLegMatchResultData> MatchResultLayout;

	// Token: 0x04009BE3 RID: 39907
	private CustomPromise<UniTaskVoid> Promise;

	// Token: 0x02007F15 RID: 32533
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029206 RID: 168454
		LegMatchName,
		// Token: 0x04029207 RID: 168455
		MatchResultLayout,
		// Token: 0x04029208 RID: 168456
		ResultItem,
		// Token: 0x04029209 RID: 168457
		TimeText,
		// Token: 0x0402920A RID: 168458
		CloseButton
	}
}
