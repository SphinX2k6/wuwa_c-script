using System;
using CSharpScript.Game.Ui;

// Token: 0x020020FF RID: 8447
public class SurvivorsRogueCommandViewData : IViewOpenParamMultipleView
{
	// Token: 0x17001F2B RID: 7979
	// (get) Token: 0x06014BA5 RID: 84901 RVA: 0x00609400 File Offset: 0x00607600
	public int CommandIncId { get; }

	// Token: 0x17001F2C RID: 7980
	// (get) Token: 0x06014BA6 RID: 84902 RVA: 0x00609408 File Offset: 0x00607608
	// (set) Token: 0x06014BA7 RID: 84903 RVA: 0x00609410 File Offset: 0x00607610
	public bool IsMultipleView { get; set; }

	// Token: 0x06014BA8 RID: 84904 RVA: 0x00609419 File Offset: 0x00607619
	public SurvivorsRogueCommandViewData(int commandIncId, bool isMultipleView = false)
	{
		this.CommandIncId = commandIncId;
		this.IsMultipleView = isMultipleView;
	}
}
