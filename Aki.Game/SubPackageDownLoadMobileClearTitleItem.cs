using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002028 RID: 8232
public class SubPackageDownLoadMobileClearTitleItem : UiPanelBase
{
	// Token: 0x06014623 RID: 83491 RVA: 0x005F2440 File Offset: 0x005F0640
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickHelpBtn))
		};
	}

	// Token: 0x06014624 RID: 83492 RVA: 0x005F24A8 File Offset: 0x005F06A8
	public void RefreshItem(int type)
	{
		this.TitleType = type;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "SubPackageClearTipsTitle_" + SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber[(ESubPackageDownLoadPackageType)this.TitleType].ToString(), Array.Empty<object>());
	}

	// Token: 0x06014625 RID: 83493 RVA: 0x005F24F4 File Offset: 0x005F06F4
	private void OnClickHelpBtn()
	{
		if (this.OnClickHelpBtnCallBack != null)
		{
			this.OnClickHelpBtnCallBack(this.TitleType, base.GetButton(1).RootUIComp.Get());
		}
	}

	// Token: 0x0400ACDB RID: 44251
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400ACDC RID: 44252
	private int TitleType;

	// Token: 0x02008320 RID: 33568
	private class ESubPackageDownLoadMobileClearTitleItem
	{
		// Token: 0x0402A5F1 RID: 173553
		public const int Text = 0;

		// Token: 0x0402A5F2 RID: 173554
		public const int HelpBtn = 1;
	}
}
