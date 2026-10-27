using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200267B RID: 9851
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewDetailImageItem : UiPanelBase
{
	// Token: 0x060142FC RID: 82684 RVA: 0x005189D3 File Offset: 0x00516BD3
	public QuestReviewDetailImageItem(QuestReviewNodeData node)
	{
		this.Node = node;
	}

	// Token: 0x060142FD RID: 82685 RVA: 0x005189E4 File Offset: 0x00516BE4
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

	// Token: 0x060142FE RID: 82686 RVA: 0x00518A50 File Offset: 0x00516C50
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewDetailImageItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewDetailImageItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060142FF RID: 82687 RVA: 0x00518A94 File Offset: 0x00516C94
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

	// Token: 0x040097FA RID: 38906
	private readonly QuestReviewNodeData Node;

	// Token: 0x02008CC0 RID: 36032
	[NullableContext(0)]
	private class EImageItemComponentDefine
	{
		// Token: 0x0402DADF RID: 187103
		public const int BtnSelf = 0;

		// Token: 0x0402DAE0 RID: 187104
		public const int TextureBg = 1;
	}
}
