using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02002B4B RID: 11083
public class SurvivorsRogueSettleExternalView : SurvivorsRogueSettleBaseView
{
	// Token: 0x06016FF8 RID: 94200 RVA: 0x005D6C48 File Offset: 0x005D4E48
	[NullableContext(1)]
	public SurvivorsRogueSettleExternalView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016FF9 RID: 94201 RVA: 0x005D6C51 File Offset: 0x005D4E51
	protected override void OnClickBtnReturnMain()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016FFA RID: 94202 RVA: 0x005D6C5A File Offset: 0x005D4E5A
	[NullableContext(2)]
	protected override ResultView GetViewInfo()
	{
		return this.OpenParam as ResultView;
	}
}
