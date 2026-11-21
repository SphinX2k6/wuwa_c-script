using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039AD RID: 14765
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraDebugTool
	{
		// Token: 0x06026082 RID: 155778 RVA: 0x00AAC080 File Offset: 0x00AAA280
		public void Initialize()
		{
			this.UiCameraSettingTable = ResourceSystem.Instance.GetLoadedAsset<UCompositeDataTable>("/Game/Aki/Data/UiCameraAnimation/DT_UiCameraSetting.DT_UiCameraSetting");
		}

		// Token: 0x06026083 RID: 155779 RVA: 0x00AAC097 File Offset: 0x00AAA297
		public bool GetDtSyncEnabled()
		{
			return this.DtSyncEnabled;
		}

		// Token: 0x06026084 RID: 155780 RVA: 0x00AAC0A0 File Offset: 0x00AAA2A0
		public void StartDtSync()
		{
			if (this.DtSyncEnabled)
			{
				return;
			}
			if (this.UiCameraSettingTable == null)
			{
				this.UiCameraSettingTable = ResourceSystem.Instance.GetLoadedAsset<UCompositeDataTable>("/Game/Aki/Data/UiCameraAnimation/DT_UiCameraSetting.DT_UiCameraSetting");
			}
			UCompositeDataTable uiCameraSettingTable = this.UiCameraSettingTable;
			TArray<UDataTable> tarray = (uiCameraSettingTable != null) ? uiCameraSettingTable.ParentTables : null;
			if (tarray == null)
			{
				return;
			}
			FOnDataTableChanged fonDataTableChanged = DelegateUtils.ToManualReleaseDelegate<FOnDataTableChanged>(new Action(this.OnDataTableChanged));
			for (int i = 0; i < tarray.Num(); i++)
			{
				UKuroDataTableFunctionLibrary.AddOnDataTableChangedDelegate(tarray.Get(i), GlobalData.World, fonDataTableChanged);
			}
			this.DtSyncEnabled = true;
		}

		// Token: 0x06026085 RID: 155781 RVA: 0x00AAC128 File Offset: 0x00AAA328
		public void EndDtSync()
		{
			if (!this.DtSyncEnabled)
			{
				return;
			}
			UCompositeDataTable uiCameraSettingTable = this.UiCameraSettingTable;
			TArray<UDataTable> tarray = (uiCameraSettingTable != null) ? uiCameraSettingTable.ParentTables : null;
			if (tarray != null)
			{
				for (int i = 0; i < tarray.Num(); i++)
				{
					UKuroDataTableFunctionLibrary.RemoveOnDataTableChangedDelegate(tarray.Get(i), GlobalData.World);
				}
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnDataTableChanged));
			this.DtSyncEnabled = false;
		}

		// Token: 0x06026086 RID: 155782 RVA: 0x00AAC190 File Offset: 0x00AAA390
		public void UpdateDebugCameraProps()
		{
			UiCameraHandleData lastHandleData = UiCameraModel.Instance.GetLastHandleData();
			this.DebugCameraProps["CurrentHandleName"] = (((lastHandleData != null) ? lastHandleData.GetHandleName() : null) ?? string.Empty);
			this.DebugCameraProps["DtSync"] = (this.DtSyncEnabled ? "true" : "false");
			this.DebugCameraProps["ArmLengthSync"] = (this.ArmLengthSyncEnabled ? "true" : "false");
		}

		// Token: 0x06026087 RID: 155783 RVA: 0x00AAC215 File Offset: 0x00AAA415
		public IReadOnlyDictionary<string, string> GetDebugCameraProps()
		{
			return this.DebugCameraProps;
		}

		// Token: 0x06026088 RID: 155784 RVA: 0x00AAC21D File Offset: 0x00AAA41D
		public bool GetArmLengthSyncEnabled()
		{
			return this.ArmLengthSyncEnabled;
		}

		// Token: 0x06026089 RID: 155785 RVA: 0x00AAC225 File Offset: 0x00AAA425
		public void StartArmLengthSync()
		{
			this.ArmLengthSyncEnabled = true;
		}

		// Token: 0x0602608A RID: 155786 RVA: 0x00AAC22E File Offset: 0x00AAA42E
		public void EndArmLengthSync()
		{
			this.ArmLengthSyncEnabled = false;
		}

		// Token: 0x0602608B RID: 155787 RVA: 0x00AAC237 File Offset: 0x00AAA437
		public void ArmLengthSync(float armLength)
		{
			UiCameraModel.Instance.GetOrCreateCamera().GetComponent<UiCameraLogicComponent>().SetArmLength(armLength);
		}

		// Token: 0x0602608C RID: 155788 RVA: 0x00AAC24E File Offset: 0x00AAA44E
		private void OnDataTableChanged()
		{
			UiCameraModel.Instance.ReactivateCameraHandle();
		}

		// Token: 0x04014E3E RID: 85566
		private const string UiCameraSettingTablePath = "/Game/Aki/Data/UiCameraAnimation/DT_UiCameraSetting.DT_UiCameraSetting";

		// Token: 0x04014E3F RID: 85567
		[Nullable(2)]
		private UCompositeDataTable UiCameraSettingTable;

		// Token: 0x04014E40 RID: 85568
		private bool DtSyncEnabled;

		// Token: 0x04014E41 RID: 85569
		private bool ArmLengthSyncEnabled;

		// Token: 0x04014E42 RID: 85570
		private readonly Dictionary<string, string> DebugCameraProps = new Dictionary<string, string>();
	}
}
