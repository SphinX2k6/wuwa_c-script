using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002570 RID: 9584
[NullableContext(1)]
[Nullable(0)]
public class PhotoDetailPanelBase : UiPanelBase
{
	// Token: 0x170018FC RID: 6396
	// (get) Token: 0x06013593 RID: 79251 RVA: 0x004D0911 File Offset: 0x004CEB11
	protected virtual int TabLockPanelIndex
	{
		get
		{
			return -1;
		}
	}

	// Token: 0x170018FD RID: 6397
	// (get) Token: 0x06013594 RID: 79252 RVA: 0x004D0914 File Offset: 0x004CEB14
	protected virtual int SubTabLockPanelIndex
	{
		get
		{
			return -1;
		}
	}

	// Token: 0x170018FE RID: 6398
	// (get) Token: 0x06013595 RID: 79253 RVA: 0x004D0917 File Offset: 0x004CEB17
	protected virtual string SubTabSwitchSequenceName
	{
		get
		{
			return "Switch1";
		}
	}

	// Token: 0x170018FF RID: 6399
	// (get) Token: 0x06013596 RID: 79254 RVA: 0x004D091E File Offset: 0x004CEB1E
	protected bool IsCurrentTabBanned
	{
		get
		{
			return PhotographConfig.Instance.IsTabBanned(this.ViewModel.CurrentMode, this.TabId);
		}
	}

	// Token: 0x17001900 RID: 6400
	// (get) Token: 0x06013597 RID: 79255 RVA: 0x004D093B File Offset: 0x004CEB3B
	protected bool IsCurrentSubTabBanned
	{
		get
		{
			return !this.IsCurrentTabBanned && PhotographConfig.Instance.IsSubTabBanned(this.ViewModel.CurrentMode, this.CurrentSubTabId);
		}
	}

	// Token: 0x06013598 RID: 79256 RVA: 0x004D0962 File Offset: 0x004CEB62
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06013599 RID: 79257 RVA: 0x004D096B File Offset: 0x004CEB6B
	public void SetTabId(int tabId)
	{
		this.TabId = tabId;
	}

	// Token: 0x0601359A RID: 79258 RVA: 0x004D0974 File Offset: 0x004CEB74
	public void ShowDetail()
	{
		base.SetUiActive(true);
		this.PlaySwitchAnim();
		this.RefreshLockState();
		this.RefreshDetail();
	}

	// Token: 0x0601359B RID: 79259 RVA: 0x004D0990 File Offset: 0x004CEB90
	public void RefreshLockState()
	{
		PhotoCameraType currentMode = this.ViewModel.CurrentMode;
		bool flag = PhotographConfig.Instance.IsTabBanned(currentMode, this.TabId);
		bool isActive = !flag && PhotographConfig.Instance.IsSubTabBanned(currentMode, this.CurrentSubTabId);
		this.SetLockPanelActive(this.TabLockPanelIndex, flag);
		this.SetLockPanelActive(this.SubTabLockPanelIndex, isActive);
		this.RefreshContentVisible();
	}

	// Token: 0x0601359C RID: 79260 RVA: 0x004D09F3 File Offset: 0x004CEBF3
	protected virtual void RefreshContentVisible()
	{
	}

	// Token: 0x0601359D RID: 79261 RVA: 0x004D09F5 File Offset: 0x004CEBF5
	protected void SetSubTabId(int subTabId, bool playSwitchAnim = false)
	{
		this.CurrentSubTabId = subTabId;
		if (playSwitchAnim)
		{
			this.PlaySequence(this.SubTabSwitchSequenceName);
		}
		this.RefreshLockState();
	}

	// Token: 0x0601359E RID: 79262 RVA: 0x004D0A13 File Offset: 0x004CEC13
	private void SetLockPanelActive(int index, bool isActive)
	{
		if (index < 0)
		{
			return;
		}
		UUIItem item = base.GetItem(index);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isActive);
	}

	// Token: 0x0601359F RID: 79263 RVA: 0x004D0A2C File Offset: 0x004CEC2C
	public virtual void RefreshDetail()
	{
	}

	// Token: 0x060135A0 RID: 79264 RVA: 0x004D0A2E File Offset: 0x004CEC2E
	public virtual void OnTick(float delta)
	{
	}

	// Token: 0x060135A1 RID: 79265 RVA: 0x004D0A30 File Offset: 0x004CEC30
	public virtual void HideDetail()
	{
		base.SetUiActive(false);
	}

	// Token: 0x060135A2 RID: 79266 RVA: 0x004D0A39 File Offset: 0x004CEC39
	public void PlaySwitchAnim()
	{
		this.PlaySequence("Switch");
	}

	// Token: 0x060135A3 RID: 79267 RVA: 0x004D0A48 File Offset: 0x004CEC48
	protected void PlaySequence(string sequenceName)
	{
		if (this.SequencePlayer == null)
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.SequencePlayer.StopCurrentSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x060135A4 RID: 79268 RVA: 0x004D0A92 File Offset: 0x004CEC92
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x040091D2 RID: 37330
	private int TabId;

	// Token: 0x040091D3 RID: 37331
	private int CurrentSubTabId;

	// Token: 0x040091D4 RID: 37332
	protected PhotoMainViewModel ViewModel;

	// Token: 0x040091D5 RID: 37333
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;
}
