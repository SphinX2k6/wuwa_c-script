using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016F5 RID: 5877
public class PreDownloadButtonItemA : UiPanelBase
{
	// Token: 0x0600E48B RID: 58507 RVA: 0x004318EC File Offset: 0x0042FAEC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, this.OnClickBtn);
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600E48C RID: 58508 RVA: 0x004319CE File Offset: 0x0042FBCE
	public bool CanShow(bool isLogin)
	{
		return isLogin && (PreDownloadModel.Instance.IsPreDownloadAvailable() || PreDownloadModel.Instance.IsComplete());
	}

	// Token: 0x0600E48D RID: 58509 RVA: 0x004319F0 File Offset: 0x0042FBF0
	public void Refresh(bool isLogin = false)
	{
		if (!this.CanShow(isLogin))
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		string textStringId = PreDownloadModel.Instance.IsComplete() ? "PreDownload_Complete_Btn_Text" : "PreDownload_Downloading_Btn_Text";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
	}

	// Token: 0x0600E48E RID: 58510 RVA: 0x00431A48 File Offset: 0x0042FC48
	public void RefreshDot()
	{
		bool uiactive = PreDownloadModel.Instance.HasClickBtnCheck() && !PreDownloadModel.Instance.IsComplete();
		bool uiactive2 = PreDownloadModel.Instance.IsComplete();
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(uiactive2);
	}

	// Token: 0x040082A6 RID: 33446
	[Nullable(1)]
	private readonly Action OnClickBtn = delegate()
	{
		PreDownloadController.Instance.OnPreDownloadBtnClick(true);
	};

	// Token: 0x020078D0 RID: 30928
	private enum EComponentTypeA
	{
		// Token: 0x040272B5 RID: 160437
		BtnItem,
		// Token: 0x040272B6 RID: 160438
		TxtName,
		// Token: 0x040272B7 RID: 160439
		RedDot,
		// Token: 0x040272B8 RID: 160440
		GreenDot
	}
}
