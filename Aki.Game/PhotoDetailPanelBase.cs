using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A5B RID: 6747
[NullableContext(1)]
[Nullable(0)]
public class PhotoDetailPanelBase : UiPanelBase
{
	// Token: 0x17001936 RID: 6454
	// (get) Token: 0x06010A75 RID: 68213 RVA: 0x004DF549 File Offset: 0x004DD749
	protected virtual int TabLockPanelIndex
	{
		get
		{
			return -1;
		}
	}

	// Token: 0x17001937 RID: 6455
	// (get) Token: 0x06010A76 RID: 68214 RVA: 0x004DF54C File Offset: 0x004DD74C
	protected virtual int SubTabLockPanelIndex
	{
		get
		{
			return -1;
		}
	}

	// Token: 0x17001938 RID: 6456
	// (get) Token: 0x06010A77 RID: 68215 RVA: 0x004DF54F File Offset: 0x004DD74F
	protected virtual string SubTabSwitchSequenceName
	{
		get
		{
			return "Switch1";
		}
	}

	// Token: 0x17001939 RID: 6457
	// (get) Token: 0x06010A78 RID: 68216 RVA: 0x004DF556 File Offset: 0x004DD756
	protected bool IsCurrentTabBanned
	{
		get
		{
			return PhotographConfig.Instance.IsTabBanned(this.ViewModel.CurrentMode, this.TabId);
		}
	}

	// Token: 0x1700193A RID: 6458
	// (get) Token: 0x06010A79 RID: 68217 RVA: 0x004DF573 File Offset: 0x004DD773
	protected bool IsCurrentSubTabBanned
	{
		get
		{
			return !this.IsCurrentTabBanned && PhotographConfig.Instance.IsSubTabBanned(this.ViewModel.CurrentMode, this.CurrentSubTabId);
		}
	}

	// Token: 0x06010A7A RID: 68218 RVA: 0x004DF59A File Offset: 0x004DD79A
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06010A7B RID: 68219 RVA: 0x004DF5A3 File Offset: 0x004DD7A3
	public void SetTabId(int tabId)
	{
		this.TabId = tabId;
	}

	// Token: 0x06010A7C RID: 68220 RVA: 0x004DF5AC File Offset: 0x004DD7AC
	public void ShowDetail()
	{
		base.SetUiActive(true);
		this.PlaySwitchAnim();
		this.RefreshLockState();
		this.RefreshDetail();
	}

	// Token: 0x06010A7D RID: 68221 RVA: 0x004DF5C8 File Offset: 0x004DD7C8
	public void RefreshLockState()
	{
		PhotoCameraType currentMode = this.ViewModel.CurrentMode;
		bool flag = PhotographConfig.Instance.IsTabBanned(currentMode, this.TabId);
		bool isActive = !flag && PhotographConfig.Instance.IsSubTabBanned(currentMode, this.CurrentSubTabId);
		this.SetLockPanelActive(this.TabLockPanelIndex, flag);
		this.SetLockPanelActive(this.SubTabLockPanelIndex, isActive);
		this.RefreshContentVisible();
	}

	// Token: 0x06010A7E RID: 68222 RVA: 0x004DF62B File Offset: 0x004DD82B
	protected virtual void RefreshContentVisible()
	{
	}

	// Token: 0x06010A7F RID: 68223 RVA: 0x004DF62D File Offset: 0x004DD82D
	protected void SetSubTabId(int subTabId, bool playSwitchAnim = false)
	{
		this.CurrentSubTabId = subTabId;
		if (playSwitchAnim)
		{
			this.PlaySequence(this.SubTabSwitchSequenceName);
		}
		this.RefreshLockState();
	}

	// Token: 0x06010A80 RID: 68224 RVA: 0x004DF64B File Offset: 0x004DD84B
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

	// Token: 0x06010A81 RID: 68225 RVA: 0x004DF664 File Offset: 0x004DD864
	public virtual void RefreshDetail()
	{
	}

	// Token: 0x06010A82 RID: 68226 RVA: 0x004DF666 File Offset: 0x004DD866
	public virtual void OnTick(float delta)
	{
	}

	// Token: 0x06010A83 RID: 68227 RVA: 0x004DF668 File Offset: 0x004DD868
	public virtual void HideDetail()
	{
		base.SetUiActive(false);
	}

	// Token: 0x06010A84 RID: 68228 RVA: 0x004DF671 File Offset: 0x004DD871
	public void PlaySwitchAnim()
	{
		this.PlaySequence("Switch");
	}

	// Token: 0x06010A85 RID: 68229 RVA: 0x004DF680 File Offset: 0x004DD880
	protected void PlaySequence(string sequenceName)
	{
		if (this.SequencePlayer == null)
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.SequencePlayer.StopCurrentSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06010A86 RID: 68230 RVA: 0x004DF6CA File Offset: 0x004DD8CA
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x0400932B RID: 37675
	private int TabId;

	// Token: 0x0400932C RID: 37676
	private int CurrentSubTabId;

	// Token: 0x0400932D RID: 37677
	protected PhotoMainViewModel ViewModel;

	// Token: 0x0400932E RID: 37678
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;
}
