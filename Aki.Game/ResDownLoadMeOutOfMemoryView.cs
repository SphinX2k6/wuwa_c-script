using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

// Token: 0x02001C48 RID: 7240
public class ResDownLoadMeOutOfMemoryView : UiViewBase
{
	// Token: 0x06011F96 RID: 73622 RVA: 0x0054957F File Offset: 0x0054777F
	[NullableContext(1)]
	public ResDownLoadMeOutOfMemoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011F97 RID: 73623 RVA: 0x00549588 File Offset: 0x00547788
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

	// Token: 0x06011F98 RID: 73624 RVA: 0x005496D5 File Offset: 0x005478D5
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06011F99 RID: 73625 RVA: 0x005496E0 File Offset: 0x005478E0
	private void RefreshView()
	{
		long videoResSize = VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.LoginPrepare);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DownLoadText_NeedSpace", new <>z__ReadOnlySingleElementList<object>(HotFixManager.ByteConverter(videoResSize)));
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		LguiUtil.Instance.SetLocalText(base.GetText(1), "DownLoadText_LeftSpace", new <>z__ReadOnlySingleElementList<object>("<color=#c25757>" + HotFixManager.ByteConverter(freeSpace) + "</color>"));
	}

	// Token: 0x06011F9A RID: 73626 RVA: 0x00549755 File Offset: 0x00547955
	private void OnClickConfirmBtn()
	{
		QuestResourceModel.Instance.UserClickOutOfMemoryView(true);
	}

	// Token: 0x06011F9B RID: 73627 RVA: 0x00549762 File Offset: 0x00547962
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
		QuestResourceModel.Instance.UserClickOutOfMemoryView(false);
	}

	// Token: 0x02007F4C RID: 32588
	private enum EComponentDefine
	{
		// Token: 0x04029337 RID: 168759
		NeedSpaceText,
		// Token: 0x04029338 RID: 168760
		LeftSpaceText,
		// Token: 0x04029339 RID: 168761
		CancelBtn,
		// Token: 0x0402933A RID: 168762
		ConfirmBtn,
		// Token: 0x0402933B RID: 168763
		TitleText,
		// Token: 0x0402933C RID: 168764
		DesText
	}
}
