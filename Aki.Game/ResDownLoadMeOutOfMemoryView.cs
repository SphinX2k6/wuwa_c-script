using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

// Token: 0x0200275D RID: 10077
public class ResDownLoadMeOutOfMemoryView : UiViewBase
{
	// Token: 0x06014AB3 RID: 84659 RVA: 0x0053A6EB File Offset: 0x005388EB
	[NullableContext(1)]
	public ResDownLoadMeOutOfMemoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014AB4 RID: 84660 RVA: 0x0053A6F4 File Offset: 0x005388F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCancelBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014AB5 RID: 84661 RVA: 0x0053A841 File Offset: 0x00538A41
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06014AB6 RID: 84662 RVA: 0x0053A84C File Offset: 0x00538A4C
	private void RefreshView()
	{
		long videoResSize = VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.LoginPrepare);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DownLoadText_NeedSpace", new <>z__ReadOnlySingleElementList<object>(HotFixManager.ByteConverter(videoResSize)));
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		LguiUtil.Instance.SetLocalText(base.GetText(1), "DownLoadText_LeftSpace", new <>z__ReadOnlySingleElementList<object>("<color=#c25757>" + HotFixManager.ByteConverter(freeSpace) + "</color>"));
	}

	// Token: 0x06014AB7 RID: 84663 RVA: 0x0053A8C1 File Offset: 0x00538AC1
	private void OnClickConfirmBtn()
	{
		QuestResourceModel.Instance.UserClickOutOfMemoryView(true);
	}

	// Token: 0x06014AB8 RID: 84664 RVA: 0x0053A8CE File Offset: 0x00538ACE
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
		QuestResourceModel.Instance.UserClickOutOfMemoryView(false);
	}

	// Token: 0x02008DC3 RID: 36291
	private enum EComponentDefine
	{
		// Token: 0x0402E020 RID: 188448
		NeedSpaceText,
		// Token: 0x0402E021 RID: 188449
		LeftSpaceText,
		// Token: 0x0402E022 RID: 188450
		CancelBtn,
		// Token: 0x0402E023 RID: 188451
		ConfirmBtn,
		// Token: 0x0402E024 RID: 188452
		TitleText,
		// Token: 0x0402E025 RID: 188453
		DesText
	}
}
