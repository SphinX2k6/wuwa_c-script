using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x020020C7 RID: 8391
public class SurvivorsRogueSettleExternalView : SurvivorsRogueSettleBaseView
{
	// Token: 0x06014A29 RID: 84521 RVA: 0x006037B5 File Offset: 0x006019B5
	[NullableContext(1)]
	public SurvivorsRogueSettleExternalView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A2A RID: 84522 RVA: 0x006037BE File Offset: 0x006019BE
	protected override void OnClickBtnReturnMain()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014A2B RID: 84523 RVA: 0x006037C7 File Offset: 0x006019C7
	[NullableContext(2)]
	protected override ResultView GetViewInfo()
	{
		return this.OpenParam as ResultView;
	}
}
