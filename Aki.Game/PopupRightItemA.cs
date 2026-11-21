using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022D0 RID: 8912
public class PopupRightItemA : PopupTypeRightItem
{
	// Token: 0x0601602F RID: 90159 RVA: 0x00660484 File Offset: 0x0065E684
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

	// Token: 0x06016030 RID: 90160 RVA: 0x0066054C File Offset: 0x0065E74C
	protected override UniTask OnBeforeStartAsync()
	{
		PopupRightItemA.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PopupRightItemA.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016031 RID: 90161 RVA: 0x0066058F File Offset: 0x0065E78F
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

	// Token: 0x06016032 RID: 90162 RVA: 0x006605A2 File Offset: 0x0065E7A2
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

	// Token: 0x0400B8DC RID: 47324
	[Nullable(2)]
	private PopupCaption PopupCaption;

	// Token: 0x02008538 RID: 34104
	public static class EComponents
	{
		// Token: 0x0402AEE8 RID: 175848
		public const int BackBtn = 0;

		// Token: 0x0402AEE9 RID: 175849
		public const int Content = 1;

		// Token: 0x0402AEEA RID: 175850
		public const int Caption = 2;
	}
}
