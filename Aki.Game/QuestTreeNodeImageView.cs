using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026BB RID: 9915
public class QuestTreeNodeImageView : UiViewBase
{
	// Token: 0x06014545 RID: 83269 RVA: 0x00524B30 File Offset: 0x00522D30
	[NullableContext(1)]
	public QuestTreeNodeImageView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014546 RID: 83270 RVA: 0x00524B3C File Offset: 0x00522D3C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014547 RID: 83271 RVA: 0x00524BE4 File Offset: 0x00522DE4
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeNodeImageView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeNodeImageView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014548 RID: 83272 RVA: 0x00524C27 File Offset: 0x00522E27
	protected override void OnBeforeHide()
	{
		QuestTreeController.Instance.OpenNodeDetailView(this.Data);
	}

	// Token: 0x06014549 RID: 83273 RVA: 0x00524C39 File Offset: 0x00522E39
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x040098DC RID: 39132
	[Nullable(1)]
	private QuestTreeNodeData Data;

	// Token: 0x02008D18 RID: 36120
	private class EComponentDefine
	{
		// Token: 0x0402DCC1 RID: 187585
		public const int TextureDetail = 0;

		// Token: 0x0402DCC2 RID: 187586
		public const int BtnMask = 1;
	}
}
