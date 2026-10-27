using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F94 RID: 8084
public class InfoDisplayAttachmentBigImgView : UiViewBase
{
	// Token: 0x0600FB13 RID: 64275 RVA: 0x003CD281 File Offset: 0x003CB481
	[NullableContext(1)]
	public InfoDisplayAttachmentBigImgView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB14 RID: 64276 RVA: 0x003CD28C File Offset: 0x003CB48C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB15 RID: 64277 RVA: 0x003CD395 File Offset: 0x003CB595
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FB16 RID: 64278 RVA: 0x003CD3A0 File Offset: 0x003CB5A0
	protected override UniTask OnBeforeStartAsync()
	{
		InfoDisplayAttachmentBigImgView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InfoDisplayAttachmentBigImgView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040074D6 RID: 29910
	private EAttachmentType CurrentShowAttachmentType;

	// Token: 0x0200857F RID: 34175
	private enum EInfoDisplayImgViewComponents
	{
		// Token: 0x0402B777 RID: 178039
		TexInfoImage,
		// Token: 0x0402B778 RID: 178040
		CloseMaskBtn,
		// Token: 0x0402B779 RID: 178041
		SpineItem,
		// Token: 0x0402B77A RID: 178042
		SpineFatherNode,
		// Token: 0x0402B77B RID: 178043
		TexBgFrame
	}
}
