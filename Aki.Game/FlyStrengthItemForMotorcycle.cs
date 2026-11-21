using System;
using System.Runtime.CompilerServices;

// Token: 0x0200141D RID: 5149
public class FlyStrengthItemForMotorcycle : FlyStrengthItem
{
	// Token: 0x0600CCBD RID: 52413 RVA: 0x003CEE39 File Offset: 0x003CD039
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnergyMoto";
	}

	// Token: 0x0600CCBE RID: 52414 RVA: 0x003CEE40 File Offset: 0x003CD040
	protected override void OnStart()
	{
		this.StrengthAttributeId = EFormationAttributeId.MotorcycleSoarStrength;
		base.OnStart();
	}

	// Token: 0x0600CCBF RID: 52415 RVA: 0x003CEE50 File Offset: 0x003CD050
	protected override void OnAddEntityEvents()
	{
		if (this.RoleData == null)
		{
			return;
		}
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		if (gameplayTagComponent == null)
		{
			return;
		}
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]), new Action<int, bool>(this.OnDrivingTagChanged));
		this.IsDriving = gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]);
		EntityHandle entityHandle = this.RoleData.EntityHandle;
		object obj;
		if (entityHandle == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			obj = ((entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null);
		}
		object obj2 = obj;
		BaseTagComponent baseTagComponent;
		if (obj2 == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity vehicleEntity = obj2.VehicleEntity;
			baseTagComponent = ((vehicleEntity != null) ? vehicleEntity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 != null)
		{
			base.ListenForTagAddOrRemove(baseTagComponent2, new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]), new Action<int, bool>(base.OnFlyTagChanged));
			base.ListenForTagAddOrRemove(baseTagComponent2, new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"]), new Action<int, bool>(base.OnSpeedUpTagChanged));
			base.ListenForTagAddOrRemove(baseTagComponent2, new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.滑翔体力锁定"]), new Action<int, bool>(base.OnLockTagChanged));
			base.ListenForTagAddOrRemove(baseTagComponent2, new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.滑翔体力隐藏"]), new Action<int, bool>(base.OnHideTagChanged));
			this.IsFlying = baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]);
			this.IsSpeedUp = baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"]);
			this.IsLock = baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.滑翔体力锁定"]);
			this.IsHideTag = baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.滑翔体力隐藏"]);
		}
	}

	// Token: 0x0600CCC0 RID: 52416 RVA: 0x003CF002 File Offset: 0x003CD202
	protected override void OnRefreshRoleData()
	{
		base.RefreshSpeedUp();
		base.RefreshLockState();
		this.RefreshVisible();
	}

	// Token: 0x0600CCC1 RID: 52417 RVA: 0x003CF016 File Offset: 0x003CD216
	private void OnDrivingTagChanged(int tagId, bool tagExists)
	{
		this.IsDriving = tagExists;
		this.RefreshVisible();
	}

	// Token: 0x0600CCC2 RID: 52418 RVA: 0x003CF028 File Offset: 0x003CD228
	protected override void RefreshVisible()
	{
		bool active = !this.IsHideTag && (this.IsFlying || !this.IsFullState) && this.IsDriving && this.EnableByHighPriority;
		this.SetActive(active);
	}

	// Token: 0x04007480 RID: 29824
	private bool IsDriving;
}
