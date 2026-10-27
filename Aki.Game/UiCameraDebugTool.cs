using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using UnrealEngine;

// Token: 0x02002C4E RID: 11342
[NullableContext(1)]
[Nullable(0)]
public class UiCameraDebugTool
{
	// Token: 0x06017A8E RID: 96910 RVA: 0x006050FB File Offset: 0x006032FB
	public void Init()
	{
		this.UiCameraSettingTable = ResourceSystem.Instance.GetLoadedAsset<UCompositeDataTable>("/Game/Aki/Data/UiCameraAnimation/DT_UiCameraSetting.DT_UiCameraSetting");
	}

	// Token: 0x06017A8F RID: 96911 RVA: 0x00605112 File Offset: 0x00603312
	public bool GetDtSyncEnabled()
	{
		return this.DtSyncEnabled;
	}

	// Token: 0x06017A90 RID: 96912 RVA: 0x0060511C File Offset: 0x0060331C
	public void StartDtSync()
	{
		if (this.DtSyncEnabled)
		{
			return;
		}
		UCompositeDataTable uiCameraSettingTable = this.UiCameraSettingTable;
		TArray<UDataTable> tarray = (uiCameraSettingTable != null) ? uiCameraSettingTable.ParentTables : null;
		if (tarray == null)
		{
			return;
		}
		FOnDataTableChanged fonDataTableChanged = DelegateUtils.ToManualReleaseDelegate<FOnDataTableChanged>(new Action(this.OnDataTableChange));
		for (int i = 0; i < tarray.Num(); i++)
		{
			UKuroDataTableFunctionLibrary.AddOnDataTableChangedDelegate(tarray.Get(i), GlobalData.World, fonDataTableChanged);
		}
		this.DtSyncEnabled = true;
	}

	// Token: 0x06017A91 RID: 96913 RVA: 0x00605188 File Offset: 0x00603388
	public void EndDtSync()
	{
		if (!this.DtSyncEnabled)
		{
			return;
		}
		UCompositeDataTable uiCameraSettingTable = this.UiCameraSettingTable;
		TArray<UDataTable> tarray = (uiCameraSettingTable != null) ? uiCameraSettingTable.ParentTables : null;
		if (tarray == null)
		{
			return;
		}
		for (int i = 0; i < tarray.Num(); i++)
		{
			UKuroDataTableFunctionLibrary.RemoveOnDataTableChangedDelegate(tarray.Get(i), GlobalData.World);
		}
		DelegateUtils.ToManualReleaseDelegate<FOnDataTableChanged>(new Action(this.OnDataTableChange));
		this.DtSyncEnabled = false;
	}

	// Token: 0x06017A92 RID: 96914 RVA: 0x006051F0 File Offset: 0x006033F0
	private void OnDataTableChange()
	{
		UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
		if (lastHandleData != null)
		{
			lastHandleData.Refresh();
		}
		UiCameraAnimationManager.Instance.ReactivateCameraHandle(false, false);
	}

	// Token: 0x06017A93 RID: 96915 RVA: 0x00605214 File Offset: 0x00603414
	public void UpdateDebugCameraProps()
	{
		UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
		this.DebugCameraProps["CurrentHandleName"] = (((lastHandleData != null) ? lastHandleData.GetHandleName() : null) ?? string.Empty);
		this.DebugCameraProps["DtSync"] = (this.GetDtSyncEnabled() ? "true" : "false");
		this.DebugCameraProps["ArmLengthSync"] = (this.GetArmLengthSyncEnabled() ? "true" : "false");
	}

	// Token: 0x06017A94 RID: 96916 RVA: 0x00605299 File Offset: 0x00603499
	public IDictionary<string, string> GetDebugCameraProps()
	{
		return this.DebugCameraProps;
	}

	// Token: 0x06017A95 RID: 96917 RVA: 0x006052A1 File Offset: 0x006034A1
	public bool GetArmLengthSyncEnabled()
	{
		return this.ArmLengthSyncEnabled;
	}

	// Token: 0x06017A96 RID: 96918 RVA: 0x006052A9 File Offset: 0x006034A9
	public void StartArmLengthSync()
	{
		this.ArmLengthSyncEnabled = true;
	}

	// Token: 0x06017A97 RID: 96919 RVA: 0x006052B2 File Offset: 0x006034B2
	public void EndArmLengthSync()
	{
		this.ArmLengthSyncEnabled = false;
	}

	// Token: 0x06017A98 RID: 96920 RVA: 0x006052BB File Offset: 0x006034BB
	public void ArmLengthSync(float armLength)
	{
		UiCameraManager.Get().GetUiCameraComponent<UiCameraControlRotationComponent>().SetArmLength(armLength);
	}

	// Token: 0x0400B064 RID: 45156
	[Nullable(2)]
	private UCompositeDataTable UiCameraSettingTable;

	// Token: 0x0400B065 RID: 45157
	private bool DtSyncEnabled;

	// Token: 0x0400B066 RID: 45158
	private bool ArmLengthSyncEnabled;

	// Token: 0x0400B067 RID: 45159
	private readonly Dictionary<string, string> DebugCameraProps = new Dictionary<string, string>();
}
