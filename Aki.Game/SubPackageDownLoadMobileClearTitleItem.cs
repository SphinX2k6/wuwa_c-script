using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002AAC RID: 10924
public class SubPackageDownLoadMobileClearTitleItem : UiPanelBase
{
	// Token: 0x06016BF4 RID: 93172 RVA: 0x005C59AC File Offset: 0x005C3BAC
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

	// Token: 0x06016BF5 RID: 93173 RVA: 0x005C5A14 File Offset: 0x005C3C14
	public void RefreshItem(int type)
	{
		this.TitleType = type;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "SubPackageClearTipsTitle_" + SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber[(ESubPackageDownLoadPackageType)this.TitleType].ToString(), Array.Empty<object>());
	}

	// Token: 0x06016BF6 RID: 93174 RVA: 0x005C5A60 File Offset: 0x005C3C60
	private void OnClickHelpBtn()
	{
		if (this.OnClickHelpBtnCallBack != null)
		{
			this.OnClickHelpBtnCallBack(this.TitleType, base.GetButton(1).RootUIComp.Get());
		}
	}

	// Token: 0x0400A8D5 RID: 43221
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400A8D6 RID: 43222
	private int TitleType;

	// Token: 0x020090DC RID: 37084
	private class ESubPackageDownLoadMobileClearTitleItem
	{
		// Token: 0x0402EEEC RID: 192236
		public const int Text = 0;

		// Token: 0x0402EEED RID: 192237
		public const int HelpBtn = 1;
	}
}
