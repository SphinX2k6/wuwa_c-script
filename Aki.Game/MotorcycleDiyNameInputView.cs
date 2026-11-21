using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Module.Common.InputView.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200178F RID: 6031
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyNameInputView : CommonInputViewBase
{
	// Token: 0x0600EAA5 RID: 60069 RVA: 0x0044D965 File Offset: 0x0044BB65
	public MotorcycleDiyNameInputView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EAA6 RID: 60070 RVA: 0x0044D970 File Offset: 0x0044BB70
	protected override int GetMaxLimit()
	{
		return ConfigCommonParamById.GetIntConfig("MotorOutlookPresetNameLength").GetValueOrDefault();
	}

	// Token: 0x0600EAA7 RID: 60071 RVA: 0x0044D98F File Offset: 0x0044BB8F
	protected override void InitExtraParam()
	{
		this.RefreshUi();
	}

	// Token: 0x0600EAA8 RID: 60072 RVA: 0x0044D997 File Offset: 0x0044BB97
	protected override void RefreshDuplicateName(string inputText)
	{
		this.RefreshUi();
	}

	// Token: 0x0600EAA9 RID: 60073 RVA: 0x0044D99F File Offset: 0x0044BB9F
	protected override void RefreshTips(ETipsType type)
	{
		base.RefreshTips(type);
		if (type == ETipsType.Normal)
		{
			this.RefreshUi();
		}
	}

	// Token: 0x0600EAAA RID: 60074 RVA: 0x0044D9B1 File Offset: 0x0044BBB1
	protected override bool IsAllowMultiLine()
	{
		return false;
	}

	// Token: 0x0600EAAB RID: 60075 RVA: 0x0044D9B4 File Offset: 0x0044BBB4
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

	// Token: 0x0400854D RID: 34125
	private const int DEFAULT_TEXT_COMPONENT_INDEX = 6;
}
