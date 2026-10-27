using System;
using CSharpScript.Game.Ui;

// Token: 0x02002B83 RID: 11139
public class SurvivorsRogueCommandViewData : IViewOpenParamMultipleView
{
	// Token: 0x17001ED3 RID: 7891
	// (get) Token: 0x06017174 RID: 94580 RVA: 0x005DC820 File Offset: 0x005DAA20
	public int CommandIncId { get; }

	// Token: 0x17001ED4 RID: 7892
	// (get) Token: 0x06017175 RID: 94581 RVA: 0x005DC828 File Offset: 0x005DAA28
	// (set) Token: 0x06017176 RID: 94582 RVA: 0x005DC830 File Offset: 0x005DAA30
	public bool IsMultipleView { get; set; }

	// Token: 0x06017177 RID: 94583 RVA: 0x005DC839 File Offset: 0x005DAA39
	public SurvivorsRogueCommandViewData(int commandIncId, bool isMultipleView = false)
	{
		this.CommandIncId = commandIncId;
		this.IsMultipleView = isMultipleView;
	}
}
