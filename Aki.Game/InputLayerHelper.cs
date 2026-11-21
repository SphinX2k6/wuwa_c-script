using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

// Token: 0x02002617 RID: 9751
[NullableContext(1)]
[Nullable(0)]
public class InputLayerHelper
{
	// Token: 0x06018599 RID: 99737 RVA: 0x00759114 File Offset: 0x00757314
	public void Init(EInputLayer layerType)
	{
		this.InputLayer = InputController.Instance.CreateInputLayer(layerType);
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
	}

	// Token: 0x0601859A RID: 99738 RVA: 0x00759188 File Offset: 0x00757388
	public void Clear()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		if (this.IsEnable)
		{
			this.RemoveInputLayer();
		}
		if (this.InputLayer != null)
		{
			this.InputLayer.Clear();
			this.InputLayer = null;
		}
	}

	// Token: 0x0601859B RID: 99739 RVA: 0x00759211 File Offset: 0x00757411
	public void AddInputLayer()
	{
		if (this.IsEnable)
		{
			return;
		}
		this.IsEnable = true;
		this.RefreshInputLayer();
	}

	// Token: 0x0601859C RID: 99740 RVA: 0x00759229 File Offset: 0x00757429
	public void RemoveInputLayer()
	{
		if (!this.IsEnable)
		{
			return;
		}
		this.IsEnable = false;
		this.RefreshInputLayer();
	}

	// Token: 0x0601859D RID: 99741 RVA: 0x00759241 File Offset: 0x00757441
	[NullableContext(2)]
	public InputLayer GetInputLayer()
	{
		return this.InputLayer;
	}

	// Token: 0x0601859E RID: 99742 RVA: 0x00759249 File Offset: 0x00757449
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.RefreshInputLayer();
	}

	// Token: 0x0601859F RID: 99743 RVA: 0x00759251 File Offset: 0x00757451
	private void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		this.RefreshInputLayer();
	}

	// Token: 0x060185A0 RID: 99744 RVA: 0x00759259 File Offset: 0x00757459
	private void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		this.RefreshInputLayer();
	}

	// Token: 0x060185A1 RID: 99745 RVA: 0x00759264 File Offset: 0x00757464
	private void RefreshInputLayer()
	{
		if (this.InputLayer == null)
		{
			return;
		}
		if (this.IsEnable)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
			CharacterDriveVehicleComponent characterDriveVehicleComponent;
			if (getCurrentEntity == null)
			{
				characterDriveVehicleComponent = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				characterDriveVehicleComponent = ((entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null);
			}
			CharacterDriveVehicleComponent characterDriveVehicleComponent2 = characterDriveVehicleComponent;
			if (characterDriveVehicleComponent2 != null)
			{
				Entity vehicleEntity = characterDriveVehicleComponent2.VehicleEntity;
				if (vehicleEntity != null && vehicleEntity.Valid)
				{
					Entity vehicleEntity2 = characterDriveVehicleComponent2.VehicleEntity;
					num = ((vehicleEntity2 != null) ? new int?(vehicleEntity2.Id) : null);
				}
			}
			int num2 = num.GetValueOrDefault();
			if (num == null)
			{
				num2 = 0;
				num = new int?(num2);
			}
			int? num3 = num;
			num2 = this.LayerEntityId;
			if (!(num3.GetValueOrDefault() == num2 & num3 != null))
			{
				this.LayerEntityId = num.Value;
				InputController.Instance.RemoveInputLayer(this.InputLayer);
				num3 = num;
				num2 = 0;
				if (!(num3.GetValueOrDefault() == num2 & num3 != null))
				{
					InputController.Instance.AddInputLayer(num.Value, this.InputLayer);
					return;
				}
			}
		}
		else if (this.LayerEntityId != 0)
		{
			this.LayerEntityId = 0;
			InputController.Instance.RemoveInputLayer(this.InputLayer);
		}
	}

	// Token: 0x0400D248 RID: 53832
	[Nullable(2)]
	private InputLayer InputLayer;

	// Token: 0x0400D249 RID: 53833
	private int LayerEntityId;

	// Token: 0x0400D24A RID: 53834
	private bool IsEnable;
}
