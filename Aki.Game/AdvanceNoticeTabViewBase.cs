using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000593 RID: 1427
public abstract class AdvanceNoticeTabViewBase : UiTabViewBase
{
	// Token: 0x06004413 RID: 17427 RVA: 0x00177CAE File Offset: 0x00175EAE
	protected override void OnBeforeCreate()
	{
		this.ViewModel = (this.Params as AdvanceNoticeViewModel);
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x00177CC4 File Offset: 0x00175EC4
	protected override void OnBeforeShow()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}
		this.RefreshView();
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x00177CF8 File Offset: 0x00175EF8
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

	// Token: 0x06004416 RID: 17430 RVA: 0x00177D2C File Offset: 0x00175F2C
	public void OnSwitchSubTab(int index)
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}
		this.RefreshView();
	}

	// Token: 0x06004417 RID: 17431
	protected abstract void RefreshView();

	// Token: 0x040034C1 RID: 13505
	[Nullable(2)]
	protected AdvanceNoticeViewModel ViewModel;
}
