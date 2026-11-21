using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001456 RID: 5206
public class InfoDisplayAttachmentBigImgView : UiViewBase
{
	// Token: 0x0600CF35 RID: 53045 RVA: 0x003D8E41 File Offset: 0x003D7041
	[NullableContext(1)]
	public InfoDisplayAttachmentBigImgView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CF36 RID: 53046 RVA: 0x003D8E4C File Offset: 0x003D704C
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

	// Token: 0x0600CF37 RID: 53047 RVA: 0x003D8F55 File Offset: 0x003D7155
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CF38 RID: 53048 RVA: 0x003D8F60 File Offset: 0x003D7160
	protected override UniTask OnBeforeStartAsync()
	{
		InfoDisplayAttachmentBigImgView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InfoDisplayAttachmentBigImgView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040075B8 RID: 30136
	private EAttachmentType CurrentShowAttachmentType;

	// Token: 0x02007704 RID: 30468
	private enum EInfoDisplayImgViewComponents
	{
		// Token: 0x04026A9A RID: 158362
		TexInfoImage,
		// Token: 0x04026A9B RID: 158363
		CloseMaskBtn,
		// Token: 0x04026A9C RID: 158364
		SpineItem,
		// Token: 0x04026A9D RID: 158365
		SpineFatherNode,
		// Token: 0x04026A9E RID: 158366
		TexBgFrame
	}
}
