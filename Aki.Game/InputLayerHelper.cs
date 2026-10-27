using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;

// Token: 0x020030BF RID: 12479
[NullableContext(1)]
[Nullable(0)]
public class InputLayerHelper
{
	// Token: 0x0601AB8A RID: 109450 RVA: 0x007337A8 File Offset: 0x007319A8
	public void Init(EInputLayer layerType)
	{
		this.InputLayer = InputController.Instance.CreateInputLayer(layerType);
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
	}

	// Token: 0x0601AB8B RID: 109451 RVA: 0x0073381C File Offset: 0x00731A1C
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

	// Token: 0x0601AB8C RID: 109452 RVA: 0x007338A5 File Offset: 0x00731AA5
	public void AddInputLayer()
	{
		if (this.IsEnable)
		{
			return;
		}
		this.IsEnable = true;
		this.RefreshInputLayer();
	}

	// Token: 0x0601AB8D RID: 109453 RVA: 0x007338BD File Offset: 0x00731ABD
	public void RemoveInputLayer()
	{
		if (!this.IsEnable)
		{
			return;
		}
		this.IsEnable = false;
		this.RefreshInputLayer();
	}

	// Token: 0x0601AB8E RID: 109454 RVA: 0x007338D5 File Offset: 0x00731AD5
	[NullableContext(2)]
	public InputLayer GetInputLayer()
	{
		return this.InputLayer;
	}

	// Token: 0x0601AB8F RID: 109455 RVA: 0x007338DD File Offset: 0x00731ADD
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.RefreshInputLayer();
	}

	// Token: 0x0601AB90 RID: 109456 RVA: 0x007338E5 File Offset: 0x00731AE5
	private void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		this.RefreshInputLayer();
	}

	// Token: 0x0601AB91 RID: 109457 RVA: 0x007338ED File Offset: 0x00731AED
	private void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		this.RefreshInputLayer();
	}

	// Token: 0x0601AB92 RID: 109458 RVA: 0x007338F8 File Offset: 0x00731AF8
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

	// Token: 0x0400CE5C RID: 52828
	[Nullable(2)]
	private InputLayer InputLayer;

	// Token: 0x0400CE5D RID: 52829
	private int LayerEntityId;

	// Token: 0x0400CE5E RID: 52830
	private bool IsEnable;
}
