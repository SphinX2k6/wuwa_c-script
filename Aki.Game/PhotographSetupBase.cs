using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x02001ABD RID: 6845
public abstract class PhotographSetupBase : UiPanelBase, IPhotographSetupItem
{
	// Token: 0x06010F27 RID: 69415 RVA: 0x004F8467 File Offset: 0x004F6667
	public virtual void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.SetupConfig = PhotographConfig.Instance.GetPhotoSetupConfig(this.SetupValueType);
		this.Refresh();
	}

	// Token: 0x06010F28 RID: 69416 RVA: 0x004F848C File Offset: 0x004F668C
	public virtual void InitializeById(int setupId)
	{
		PhotoSetup? photoSetupConfigById = PhotographConfig.Instance.GetPhotoSetupConfigById(setupId);
		if (photoSetupConfigById == null)
		{
			return;
		}
		this.SetupValueType = (EPhotoSetupValueType)photoSetupConfigById.Value.ValueType;
		this.SetupConfig = photoSetupConfigById;
		this.Refresh();
	}

	// Token: 0x06010F29 RID: 69417
	public abstract void Refresh();

	// Token: 0x06010F2A RID: 69418 RVA: 0x004F84D1 File Offset: 0x004F66D1
	public void SetInCurrentMode(bool bInCurrentMode)
	{
		this.IsInCurrentMode = bInCurrentMode;
	}

	// Token: 0x06010F2B RID: 69419 RVA: 0x004F84DA File Offset: 0x004F66DA
	public virtual void SetEnable(bool bEnable)
	{
		this.SetActive(bEnable);
	}

	// Token: 0x06010F2C RID: 69420 RVA: 0x004F84E3 File Offset: 0x004F66E3
	public virtual void SetLock(bool bLock)
	{
	}

	// Token: 0x06010F2D RID: 69421 RVA: 0x004F84E5 File Offset: 0x004F66E5
	public virtual void SetSubItem(bool bSubItem)
	{
	}

	// Token: 0x06010F2E RID: 69422 RVA: 0x004F84E7 File Offset: 0x004F66E7
	public void Destroy()
	{
		base.Destroy(null);
	}

	// Token: 0x06010F2F RID: 69423 RVA: 0x004F84F0 File Offset: 0x004F66F0
	protected bool IsPhotoSetupRedDotVisible()
	{
		return this.SetupConfig != null && this.SetupConfig.GetValueOrDefault().IsShowRedDot && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Photography) as ServerStorageSet).Has(this.SetupConfig.Value.Id);
	}

	// Token: 0x06010F30 RID: 69424 RVA: 0x004F8550 File Offset: 0x004F6750
	[NullableContext(1)]
	protected void MarkPhotoSetupRedDotAsRead(Action onRead)
	{
		if (this.SetupConfig == null || !this.SetupConfig.GetValueOrDefault().IsShowRedDot)
		{
			return;
		}
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Photography) as ServerStorageSet;
		if (serverStorageSet.Has(this.SetupConfig.Value.Id))
		{
			return;
		}
		serverStorageSet.Add(this.SetupConfig.Value.Id);
		onRead();
		EventSystem.Instance.Emit(EEventName.RedDotPhotoSetup);
	}

	// Token: 0x0400956D RID: 38253
	protected EPhotoSetupValueType SetupValueType;

	// Token: 0x0400956E RID: 38254
	protected PhotoSetup? SetupConfig;

	// Token: 0x0400956F RID: 38255
	protected bool IsInCurrentMode = true;
}
