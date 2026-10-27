using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

// Token: 0x02001A45 RID: 6725
public class DangoAbyssNpcTips : GenericPromptFloatTipsBase
{
	// Token: 0x0600C5E1 RID: 50657 RVA: 0x002CEF99 File Offset: 0x002CD199
	[NullableContext(1)]
	public DangoAbyssNpcTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C5E2 RID: 50658 RVA: 0x002CEFA4 File Offset: 0x002CD1A4
	protected override void SetMainText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
		if (this.Data.MainTextObj != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.ExtraText, this.Data.MainTextObj.TextKey, Array.Empty<object>());
			base.ExtraText.SetUIActive(true);
			return;
		}
	}

	// Token: 0x0600C5E3 RID: 50659 RVA: 0x002CEFF0 File Offset: 0x002CD1F0
	protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
	}
}
