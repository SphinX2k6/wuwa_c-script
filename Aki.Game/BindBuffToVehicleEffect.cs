using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020024AA RID: 9386
[NullableContext(1)]
[Nullable(0)]
public class BindBuffToVehicleEffect : BuffEffect
{
	// Token: 0x060175B4 RID: 95668 RVA: 0x006DFFE9 File Offset: 0x006DE1E9
	public BindBuffToVehicleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175B5 RID: 95669 RVA: 0x006E0004 File Offset: 0x006DE204
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

	// Token: 0x060175B6 RID: 95670 RVA: 0x006E0063 File Offset: 0x006DE263
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175B7 RID: 95671 RVA: 0x006E0068 File Offset: 0x006DE268
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

	// Token: 0x060175B8 RID: 95672 RVA: 0x006E00FC File Offset: 0x006DE2FC
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

	// Token: 0x060175B9 RID: 95673 RVA: 0x006E0190 File Offset: 0x006DE390
	protected void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (!info.IsDriver)
		{
			return;
		}
		this.AddBuffVehicle(info.VehicleEntity, "OnEnterVehicle", null);
	}

	// Token: 0x060175BA RID: 95674 RVA: 0x006E01C0 File Offset: 0x006DE3C0
	protected void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (!info.IsDriver)
		{
			return;
		}
		this.RemoveBuffVehicle(info.VehicleEntity, "OnLeaveVehicle", null);
	}

	// Token: 0x060175BB RID: 95675 RVA: 0x006E01F0 File Offset: 0x006DE3F0
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

	// Token: 0x060175BC RID: 95676 RVA: 0x006E0300 File Offset: 0x006DE500
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

	// Token: 0x060175BD RID: 95677 RVA: 0x006E0404 File Offset: 0x006DE604
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		this.UpdateVehicleBuffStack(newCount, oldCount);
	}

	// Token: 0x060175BE RID: 95678 RVA: 0x006E040E File Offset: 0x006DE60E
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		this.UpdateVehicleBuffStack(newCount, oldCount);
	}

	// Token: 0x060175BF RID: 95679 RVA: 0x006E0418 File Offset: 0x006DE618
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

	// Token: 0x060175C0 RID: 95680 RVA: 0x006E0489 File Offset: 0x006DE689
	public override string GetDebugEffectString()
	{
		return "绑定buff到骑乘的载具上" + string.Join<long>(",", this.BuffIds);
	}

	// Token: 0x0400C610 RID: 50704
	public long[] BuffIds = Array.Empty<long>();
}
