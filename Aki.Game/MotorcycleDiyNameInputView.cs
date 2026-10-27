using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Module.Common.InputView.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022AB RID: 8875
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyNameInputView : CommonInputViewBase
{
	// Token: 0x0601160D RID: 71181 RVA: 0x00440D6C File Offset: 0x0043EF6C
	public MotorcycleDiyNameInputView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601160E RID: 71182 RVA: 0x00440D78 File Offset: 0x0043EF78
	protected override int GetMaxLimit()
	{
		return ConfigCommonParamById.GetIntConfig("MotorOutlookPresetNameLength").GetValueOrDefault();
	}

	// Token: 0x0601160F RID: 71183 RVA: 0x00440D97 File Offset: 0x0043EF97
	protected override void InitExtraParam()
	{
		this.RefreshUi();
	}

	// Token: 0x06011610 RID: 71184 RVA: 0x00440D9F File Offset: 0x0043EF9F
	protected override void RefreshDuplicateName(string inputText)
	{
		this.RefreshUi();
	}

	// Token: 0x06011611 RID: 71185 RVA: 0x00440DA7 File Offset: 0x0043EFA7
	protected override void RefreshTips(ETipsType type)
	{
		base.RefreshTips(type);
		if (type == ETipsType.Normal)
		{
			this.RefreshUi();
		}
	}

	// Token: 0x06011612 RID: 71186 RVA: 0x00440DB9 File Offset: 0x0043EFB9
	protected override bool IsAllowMultiLine()
	{
		return false;
	}

	// Token: 0x06011613 RID: 71187 RVA: 0x00440DBC File Offset: 0x0043EFBC
	private void RefreshUi()
	{
		string text = this.InputText.Text;
		int stringRealCount = StringUtils.GetStringRealCount(text);
		if (stringRealCount > this.GetMaxLimit())
		{
			this.ConfirmButton.SetSelfInteractive(false);
			return;
		}
		bool flag = this.InputData.NeedCheckBlank.GetValueOrDefault() && text.Length > 0 && StringUtils.CheckIsOnlyBlank(text);
		if (this.InputData.IsCheckNone && (stringRealCount == 0 || flag))
		{
			if (stringRealCount == 0)
			{
				UUIText text2 = base.GetText(6);
				LguiUtil.Instance.SetLocalTextNew(text2, "DIYProjectTips01", Array.Empty<object>());
			}
			base.RefreshTips(flag ? ETipsType.Blank : ETipsType.NoneText);
			this.ConfirmButton.SetSelfInteractive(false);
			return;
		}
		base.RefreshTips(ETipsType.Normal);
		this.ConfirmButton.SetSelfInteractive(true);
	}

	// Token: 0x0400840F RID: 33807
	private const int DEFAULT_TEXT_COMPONENT_INDEX = 6;
}
