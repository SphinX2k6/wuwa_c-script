using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA6 RID: 7078
public class QuestTreeNodeImageView : UiViewBase
{
	// Token: 0x06011A27 RID: 72231 RVA: 0x00533868 File Offset: 0x00531A68
	[NullableContext(1)]
	public QuestTreeNodeImageView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06011A28 RID: 72232 RVA: 0x00533874 File Offset: 0x00531A74
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

	// Token: 0x06011A29 RID: 72233 RVA: 0x0053391C File Offset: 0x00531B1C
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeNodeImageView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeNodeImageView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A2A RID: 72234 RVA: 0x0053395F File Offset: 0x00531B5F
	protected override void OnBeforeHide()
	{
		QuestTreeController.Instance.OpenNodeDetailView(this.Data);
	}

	// Token: 0x06011A2B RID: 72235 RVA: 0x00533971 File Offset: 0x00531B71
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009A34 RID: 39476
	[Nullable(1)]
	private QuestTreeNodeData Data;

	// Token: 0x02007EA1 RID: 32417
	private class EComponentDefine
	{
		// Token: 0x04028FD8 RID: 167896
		public const int TextureDetail = 0;

		// Token: 0x04028FD9 RID: 167897
		public const int BtnMask = 1;
	}
}
