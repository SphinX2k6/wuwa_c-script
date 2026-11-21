using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

// Token: 0x02000F04 RID: 3844
public class DangoAbyssNpcTips : GenericPromptFloatTipsBase
{
	// Token: 0x060099F1 RID: 39409 RVA: 0x002DA09D File Offset: 0x002D829D
	[NullableContext(1)]
	public DangoAbyssNpcTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060099F2 RID: 39410 RVA: 0x002DA0A8 File Offset: 0x002D82A8
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

	// Token: 0x060099F3 RID: 39411 RVA: 0x002DA0F4 File Offset: 0x002D82F4
	protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
	}
}
