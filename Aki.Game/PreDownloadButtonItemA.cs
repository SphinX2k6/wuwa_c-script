using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002211 RID: 8721
public class PreDownloadButtonItemA : UiPanelBase
{
	// Token: 0x06010FF6 RID: 69622 RVA: 0x00424D58 File Offset: 0x00422F58
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

	// Token: 0x06010FF7 RID: 69623 RVA: 0x00424E3C File Offset: 0x0042303C
	public void Refresh(bool isLogin = false)
	{
		if (!isLogin || (!PreDownloadModel.Instance.IsPreDownloadAvailable() && !PreDownloadModel.Instance.IsComplete()))
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		string textStringId = PreDownloadModel.Instance.IsComplete() ? "PreDownload_Complete_Btn_Text" : "PreDownload_Downloading_Btn_Text";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
	}

	// Token: 0x06010FF8 RID: 69624 RVA: 0x00424EAC File Offset: 0x004230AC
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

	// Token: 0x04008168 RID: 33128
	[Nullable(1)]
	private readonly Action OnClickBtn = delegate()
	{
		PreDownloadController.Instance.OnPreDownloadBtnClick(true);
	};

	// Token: 0x02008747 RID: 34631
	private enum EComponentTypeA
	{
		// Token: 0x0402BF9D RID: 180125
		BtnItem,
		// Token: 0x0402BF9E RID: 180126
		TxtName,
		// Token: 0x0402BF9F RID: 180127
		RedDot,
		// Token: 0x0402BFA0 RID: 180128
		GreenDot
	}
}
