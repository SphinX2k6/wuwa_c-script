using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010DF RID: 4319
public abstract class AdvanceNoticeTabViewBase : UiTabViewBase
{
	// Token: 0x0600707D RID: 28797 RVA: 0x0016F2F2 File Offset: 0x0016D4F2
	protected override void OnBeforeCreate()
	{
		this.ViewModel = (this.Params as AdvanceNoticeViewModel);
	}

	// Token: 0x0600707E RID: 28798 RVA: 0x0016F308 File Offset: 0x0016D508
	protected override void OnBeforeShow()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}
		this.RefreshView();
	}

	// Token: 0x0600707F RID: 28799 RVA: 0x0016F33C File Offset: 0x0016D53C
	[NullableContext(1)]
	protected void SetTextureWithPath(UUITexture texture, string path)
	{
		bool flag = StringUtils.IsBlank(path);
		texture.SetUIActive(!flag);
		if (!flag)
		{
			base.SetTextureByPath(path, texture, null, null);
		}
	}

	// Token: 0x06007080 RID: 28800 RVA: 0x0016F370 File Offset: 0x0016D570
	public void OnSwitchSubTab(int index)
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}
		this.RefreshView();
	}

	// Token: 0x06007081 RID: 28801
	protected abstract void RefreshView();

	// Token: 0x04003428 RID: 13352
	[Nullable(2)]
	protected AdvanceNoticeViewModel ViewModel;
}
