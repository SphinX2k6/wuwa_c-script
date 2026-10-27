using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F57 RID: 12119
[NullableContext(1)]
[Nullable(0)]
public class BindBuffToVehicleEffect : BuffEffect
{
	// Token: 0x06019CA9 RID: 105641 RVA: 0x006B9CCD File Offset: 0x006B7ECD
	public BindBuffToVehicleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CAA RID: 105642 RVA: 0x006B9CE8 File Offset: 0x006B7EE8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			this.BuffIds = Array.Empty<long>();
			return;
		}
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.BuffIds[i] = long.Parse(array[i]);
		}
	}

	// Token: 0x06019CAB RID: 105643 RVA: 0x006B9D47 File Offset: 0x006B7F47
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CAC RID: 105644 RVA: 0x006B9D4C File Offset: 0x006B7F4C
	public override void OnCreated()
	{
		if (!this.CheckAuthority())
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.ExactOwnerEntity, EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.ExactOwnerEntity, EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		CharacterDriveVehicleComponent characterDriveVehicleComponent = (exactOwnerEntity != null) ? exactOwnerEntity.GetComponent<CharacterDriveVehicleComponent>() : null;
		if (characterDriveVehicleComponent != null && characterDriveVehicleComponent.IsDriver)
		{
			this.AddBuffVehicle(characterDriveVehicleComponent.VehicleEntity, "OnCreated", null);
		}
	}

	// Token: 0x06019CAD RID: 105645 RVA: 0x006B9DE0 File Offset: 0x006B7FE0
	public override void OnRemoved(bool bPremature)
	{
		if (!this.CheckAuthority())
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.ExactOwnerEntity, EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.ExactOwnerEntity, EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		CharacterDriveVehicleComponent characterDriveVehicleComponent = (exactOwnerEntity != null) ? exactOwnerEntity.GetComponent<CharacterDriveVehicleComponent>() : null;
		if (characterDriveVehicleComponent != null && characterDriveVehicleComponent.IsDriver)
		{
			this.RemoveBuffVehicle(characterDriveVehicleComponent.VehicleEntity, "OnRemoved", null);
		}
	}

	// Token: 0x06019CAE RID: 105646 RVA: 0x006B9E74 File Offset: 0x006B8074
	protected void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (!info.IsDriver)
		{
			return;
		}
		this.AddBuffVehicle(info.VehicleEntity, "OnEnterVehicle", null);
	}

	// Token: 0x06019CAF RID: 105647 RVA: 0x006B9EA4 File Offset: 0x006B80A4
	protected void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (!info.IsDriver)
		{
			return;
		}
		this.RemoveBuffVehicle(info.VehicleEntity, "OnLeaveVehicle", null);
	}

	// Token: 0x06019CB0 RID: 105648 RVA: 0x006B9ED4 File Offset: 0x006B80D4
	private unsafe void AddBuffVehicle([Nullable(2)] Entity vehicleEntity, string reason, int? stackCount = null)
	{
		IActiveBuff pendingBuff = base.PendingBuff;
		if (vehicleEntity == null || pendingBuff == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity ownerEntity = base.OwnerEntity;
			string message = "AddBuffToVehicleInvalid";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("vehicleEntityValid", vehicleEntity != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("buffValid", pendingBuff != null);
			instance.Warn(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		VehicleBuffComponent component = vehicleEntity.GetComponent<VehicleBuffComponent>();
		if (component != null)
		{
			foreach (long buffId in this.BuffIds)
			{
				component.AddIterativeBuff(buffId, pendingBuff, new int?(stackCount ?? pendingBuff.StackCount), false, "BindBuffToVehicle:" + reason, null, null);
			}
		}
	}

	// Token: 0x06019CB1 RID: 105649 RVA: 0x006B9FE4 File Offset: 0x006B81E4
	private unsafe void RemoveBuffVehicle([Nullable(2)] Entity vehicleEntity, string reason, int? stackCount = null)
	{
		IActiveBuff pendingBuff = base.PendingBuff;
		if (vehicleEntity == null || pendingBuff == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity ownerEntity = base.OwnerEntity;
			string message = "RemoveBindBuffVehicleInvalid";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("vehicleEntityValid", vehicleEntity != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("buffValid", pendingBuff != null);
			instance.Warn(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		VehicleBuffComponent component = vehicleEntity.GetComponent<VehicleBuffComponent>();
		if (component != null)
		{
			foreach (long buffId in this.BuffIds)
			{
				component.RemoveBuff(buffId, stackCount.GetValueOrDefault(-1), "BindBuffToVehicle:" + reason, pendingBuff.MessageId, null, null);
			}
		}
	}

	// Token: 0x06019CB2 RID: 105650 RVA: 0x006BA0E8 File Offset: 0x006B82E8
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		this.UpdateVehicleBuffStack(newCount, oldCount);
	}

	// Token: 0x06019CB3 RID: 105651 RVA: 0x006BA0F2 File Offset: 0x006B82F2
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		this.UpdateVehicleBuffStack(newCount, oldCount);
	}

	// Token: 0x06019CB4 RID: 105652 RVA: 0x006BA0FC File Offset: 0x006B82FC
	private void UpdateVehicleBuffStack(int newCount, int oldCount)
	{
		if (!this.CheckAuthority() || newCount == oldCount)
		{
			return;
		}
		Entity ownerEntity = base.OwnerEntity;
		CharacterDriveVehicleComponent characterDriveVehicleComponent = (ownerEntity != null) ? ownerEntity.GetComponent<CharacterDriveVehicleComponent>() : null;
		if (characterDriveVehicleComponent == null || !characterDriveVehicleComponent.IsDriver)
		{
			return;
		}
		Entity vehicleEntity = characterDriveVehicleComponent.VehicleEntity;
		if (vehicleEntity == null)
		{
			return;
		}
		if (newCount > oldCount)
		{
			this.AddBuffVehicle(vehicleEntity, "OnStackIncreased", new int?(newCount - oldCount));
			return;
		}
		this.RemoveBuffVehicle(vehicleEntity, "OnStackDecreased", new int?(oldCount - newCount));
	}

	// Token: 0x06019CB5 RID: 105653 RVA: 0x006BA16D File Offset: 0x006B836D
	public override string GetDebugEffectString()
	{
		return "绑定buff到骑乘的载具上" + string.Join<long>(",", this.BuffIds);
	}

	// Token: 0x0400C26E RID: 49774
	public long[] BuffIds = Array.Empty<long>();
}
