using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F5B RID: 8027
public class FlyStrengthItemForMotorcycle : FlyStrengthItem
{
	// Token: 0x0600F89E RID: 63646 RVA: 0x003C334D File Offset: 0x003C154D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnergyMoto";
	}

	// Token: 0x0600F89F RID: 63647 RVA: 0x003C3354 File Offset: 0x003C1554
	protected override void OnStart()
	{
		this.StrengthAttributeId = EFormationAttributeId.MotorcycleSoarStrength;
		base.OnStart();
	}

	// Token: 0x0600F8A0 RID: 63648 RVA: 0x003C3364 File Offset: 0x003C1564
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

	// Token: 0x0600F8A1 RID: 63649 RVA: 0x003C3516 File Offset: 0x003C1716
	protected override void OnRefreshRoleData()
	{
		base.RefreshSpeedUp();
		base.RefreshLockState();
		this.RefreshVisible();
	}

	// Token: 0x0600F8A2 RID: 63650 RVA: 0x003C352A File Offset: 0x003C172A
	private void OnDrivingTagChanged(int tagId, bool tagExists)
	{
		this.IsDriving = tagExists;
		this.RefreshVisible();
	}

	// Token: 0x0600F8A3 RID: 63651 RVA: 0x003C353C File Offset: 0x003C173C
	protected override void RefreshVisible()
	{
		bool active = !this.IsHideTag && (this.IsFlying || !this.IsFullState) && this.IsDriving && this.EnableByHighPriority;
		this.SetActive(active);
	}

	// Token: 0x0400739F RID: 29599
	private bool IsDriving;
}
