using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x020025D2 RID: 9682
public abstract class PhotographSetupBase : UiPanelBase, IPhotographSetupItem
{
	// Token: 0x06013A47 RID: 80455 RVA: 0x004E9867 File Offset: 0x004E7A67
	public virtual void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.SetupConfig = PhotographConfig.Instance.GetPhotoSetupConfig(this.SetupValueType);
		this.Refresh();
	}

	// Token: 0x06013A48 RID: 80456 RVA: 0x004E988C File Offset: 0x004E7A8C
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

	// Token: 0x06013A49 RID: 80457
	public abstract void Refresh();

	// Token: 0x06013A4A RID: 80458 RVA: 0x004E98D1 File Offset: 0x004E7AD1
	public void SetInCurrentMode(bool bInCurrentMode)
	{
		this.IsInCurrentMode = bInCurrentMode;
	}

	// Token: 0x06013A4B RID: 80459 RVA: 0x004E98DA File Offset: 0x004E7ADA
	public virtual void SetEnable(bool bEnable)
	{
		base.SetUiActive(bEnable);
	}

	// Token: 0x06013A4C RID: 80460 RVA: 0x004E98E3 File Offset: 0x004E7AE3
	public virtual void SetLock(bool bLock)
	{
	}

	// Token: 0x06013A4D RID: 80461 RVA: 0x004E98E5 File Offset: 0x004E7AE5
	public virtual void SetSubItem(bool bSubItem)
	{
	}

	// Token: 0x06013A4E RID: 80462 RVA: 0x004E98E7 File Offset: 0x004E7AE7
	public void Destroy()
	{
		base.Destroy(null);
	}

	// Token: 0x06013A4F RID: 80463 RVA: 0x004E98F0 File Offset: 0x004E7AF0
	protected bool IsPhotoSetupRedDotVisible()
	{
		return this.SetupConfig != null && this.SetupConfig.GetValueOrDefault().IsShowRedDot && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Photography) as ServerStorageSet).Has(this.SetupConfig.Value.Id);
	}

	// Token: 0x06013A50 RID: 80464 RVA: 0x004E9950 File Offset: 0x004E7B50
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

	// Token: 0x04009417 RID: 37911
	protected EPhotoSetupValueType SetupValueType;

	// Token: 0x04009418 RID: 37912
	protected PhotoSetup? SetupConfig;

	// Token: 0x04009419 RID: 37913
	protected bool IsInCurrentMode = true;
}
