using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D76 RID: 11638
public class PopupRightItemA : PopupTypeRightItem
{
	// Token: 0x0601878D RID: 100237 RVA: 0x0063A46C File Offset: 0x0063866C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickCloseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601878E RID: 100238 RVA: 0x0063A534 File Offset: 0x00638734
	protected override UniTask OnBeforeStartAsync()
	{
		PopupRightItemA.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PopupRightItemA.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601878F RID: 100239 RVA: 0x0063A577 File Offset: 0x00638777
	[NullableContext(1)]
	public void SetTitleIcon(string resourceId)
	{
		PopupCaption popupCaption = this.PopupCaption;
		if (popupCaption == null)
		{
			return;
		}
		popupCaption.SetTitleIcon(resourceId);
	}

	// Token: 0x06018790 RID: 100240 RVA: 0x0063A58A File Offset: 0x0063878A
	[NullableContext(1)]
	public void SetTitleLocalTxt(string txtId)
	{
		PopupCaption popupCaption = this.PopupCaption;
		if (popupCaption == null)
		{
			return;
		}
		popupCaption.SetTitleLocalTxt(txtId);
	}

	// Token: 0x0400B567 RID: 46439
	[Nullable(2)]
	private PopupCaption PopupCaption;

	// Token: 0x02009311 RID: 37649
	public static class EComponents
	{
		// Token: 0x0402F860 RID: 194656
		public const int BackBtn = 0;

		// Token: 0x0402F861 RID: 194657
		public const int Content = 1;

		// Token: 0x0402F862 RID: 194658
		public const int Caption = 2;
	}
}
