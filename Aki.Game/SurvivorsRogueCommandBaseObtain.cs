using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02002ADD RID: 10973
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCommandBaseObtain : SurvivorsRogueCommandBase
{
	// Token: 0x17001E5F RID: 7775
	// (get) Token: 0x06016D62 RID: 93538 RVA: 0x005CC181 File Offset: 0x005CA381
	protected SurvivorsRogueGeneralObtainView ObtainViewProxy
	{
		get
		{
			return this.ViewProxy as SurvivorsRogueGeneralObtainView;
		}
	}

	// Token: 0x06016D63 RID: 93539 RVA: 0x005CC18E File Offset: 0x005CA38E
	public SurvivorsRogueCommandBaseObtain(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016D64 RID: 93540 RVA: 0x005CC1A2 File Offset: 0x005CA3A2
	protected override void OnStartExecute()
	{
		this.TryOpenViewOrRefresh();
	}

	// Token: 0x06016D65 RID: 93541 RVA: 0x005CC1AA File Offset: 0x005CA3AA
	protected override void Back2Fore()
	{
		if (this.ObtainViewProxy == null)
		{
			this.TryOpenViewOrRefresh();
		}
	}

	// Token: 0x06016D66 RID: 93542 RVA: 0x005CC1BA File Offset: 0x005CA3BA
	private void TryOpenViewOrRefresh()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.SurvivorsRogueGeneralObtainView))
		{
			base.OpenView(EUiViewName.SurvivorsRogueGeneralObtainView, false);
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.SurvivorsRebindCommandView, this.IncId);
	}

	// Token: 0x06016D67 RID: 93543 RVA: 0x005CC1F0 File Offset: 0x005CA3F0
	protected override void OnFinish()
	{
		base.RequestCommand(this.SelectIds.ToArray(), null);
	}

	// Token: 0x06016D68 RID: 93544 RVA: 0x005CC204 File Offset: 0x005CA404
	[NullableContext(1)]
	protected ISurvivorsChooseData GetChooseData(SurvivorsOption info, ESurvivorsObtainMode? forceMode = null)
	{
		return new SurvivorsChooseData(forceMode ?? ((info.MaxSelectCount >= info.GoodsDetails.Count) ? ESurvivorsObtainMode.All : ESurvivorsObtainMode.SingleSelect));
	}

	// Token: 0x06016D69 RID: 93545 RVA: 0x005CC241 File Offset: 0x005CA441
	public virtual ISurvivorsObtainViewInfo GetViewInfo()
	{
		return null;
	}

	// Token: 0x0400A9A8 RID: 43432
	[Nullable(1)]
	public List<int> SelectIds = new List<int>();
}
