using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B66 RID: 7014
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewDetailImageItem : UiPanelBase
{
	// Token: 0x060117DE RID: 71646 RVA: 0x0052770B File Offset: 0x0052590B
	public QuestReviewDetailImageItem(QuestReviewNodeData node)
	{
		this.Node = node;
	}

	// Token: 0x060117DF RID: 71647 RVA: 0x0052771C File Offset: 0x0052591C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060117E0 RID: 71648 RVA: 0x00527788 File Offset: 0x00525988
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewDetailImageItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewDetailImageItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060117E1 RID: 71649 RVA: 0x005277CC File Offset: 0x005259CC
	public UniTask RefreshAsync(QuestReviewNodeData node)
	{
		QuestReviewDetailImageItem.<RefreshAsync>d__4 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.node = node;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<QuestReviewDetailImageItem.<RefreshAsync>d__4>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04009952 RID: 39250
	private readonly QuestReviewNodeData Node;

	// Token: 0x02007E49 RID: 32329
	[NullableContext(0)]
	private class EImageItemComponentDefine
	{
		// Token: 0x04028DF6 RID: 167414
		public const int BtnSelf = 0;

		// Token: 0x04028DF7 RID: 167415
		public const int TextureBg = 1;
	}
}
