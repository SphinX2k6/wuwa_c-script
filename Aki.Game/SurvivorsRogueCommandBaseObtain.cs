using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02002059 RID: 8281
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCommandBaseObtain : SurvivorsRogueCommandBase
{
	// Token: 0x17001EB7 RID: 7863
	// (get) Token: 0x06014793 RID: 83859 RVA: 0x005F8CD1 File Offset: 0x005F6ED1
	protected SurvivorsRogueGeneralObtainView ObtainViewProxy
	{
		get
		{
			return this.ViewProxy as SurvivorsRogueGeneralObtainView;
		}
	}

	// Token: 0x06014794 RID: 83860 RVA: 0x005F8CDE File Offset: 0x005F6EDE
	public SurvivorsRogueCommandBaseObtain(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06014795 RID: 83861 RVA: 0x005F8CF2 File Offset: 0x005F6EF2
	protected override void OnStartExecute()
	{
		this.TryOpenViewOrRefresh();
	}

	// Token: 0x06014796 RID: 83862 RVA: 0x005F8CFA File Offset: 0x005F6EFA
	protected override void Back2Fore()
	{
		if (this.ObtainViewProxy == null)
		{
			this.TryOpenViewOrRefresh();
		}
	}

	// Token: 0x06014797 RID: 83863 RVA: 0x005F8D0A File Offset: 0x005F6F0A
	private void TryOpenViewOrRefresh()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.SurvivorsRogueGeneralObtainView))
		{
			base.OpenView(EUiViewName.SurvivorsRogueGeneralObtainView, false);
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.SurvivorsRebindCommandView, this.IncId);
	}

	// Token: 0x06014798 RID: 83864 RVA: 0x005F8D40 File Offset: 0x005F6F40
	protected override void OnFinish()
	{
		base.RequestCommand(this.SelectIds.ToArray(), null);
	}

	// Token: 0x06014799 RID: 83865 RVA: 0x005F8D54 File Offset: 0x005F6F54
	[NullableContext(1)]
	protected ISurvivorsChooseData GetChooseData(SurvivorsOption info, ESurvivorsObtainMode? forceMode = null)
	{
		return new SurvivorsChooseData(forceMode ?? ((info.MaxSelectCount >= info.GoodsDetails.Count) ? ESurvivorsObtainMode.All : ESurvivorsObtainMode.SingleSelect));
	}

	// Token: 0x0601479A RID: 83866 RVA: 0x005F8D91 File Offset: 0x005F6F91
	public virtual ISurvivorsObtainViewInfo GetViewInfo()
	{
		return null;
	}

	// Token: 0x0400ADAE RID: 44462
	[Nullable(1)]
	public List<int> SelectIds = new List<int>();
}
