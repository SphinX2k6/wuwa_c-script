using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003216 RID: 12822
[NullableContext(2)]
[Nullable(0)]
public class NpcSightController
{
	// Token: 0x0601BA73 RID: 113267 RVA: 0x007994BC File Offset: 0x007976BC
	[NullableContext(1)]
	public NpcSightController(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = this.Entity.GetComponent<BaseCharacterComponent>();
		this.AnimComp = this.Entity.GetComponent<BaseAnimationComponent>();
		this.CharacterAnimComp = this.Entity.GetComponent<CharacterAnimationComponent>();
		this.PerformComp = this.Entity.GetComponent<CommonNpcPerformComponent>();
	}

	// Token: 0x0601BA74 RID: 113268 RVA: 0x0079954C File Offset: 0x0079774C
	public void Init()
	{
		CommonNpcPerformComponent performComp = this.PerformComp;
		if (performComp == null)
		{
			return;
		}
		performComp.HandleCachedStareAction();
	}

	// Token: 0x0601BA75 RID: 113269 RVA: 0x00799560 File Offset: 0x00797760
	public void ChangeSightTarget([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<BaseActorComponent, Vector, AActor>? target, EStareActionType context)
	{
		if (target != null && target.Value.HasValue)
		{
			StareActionInfo stareActionInfo;
			if (!this.StareActionStackMap.TryGetValue(context, out stareActionInfo))
			{
				stareActionInfo = new StareActionInfo();
				this.StareActionStackMap[context] = stareActionInfo;
			}
			if (target.Value.IsT1)
			{
				BaseActorComponent asT = target.Value.AsT1;
				if (stareActionInfo.TargetItem == asT)
				{
					return;
				}
				stareActionInfo.TargetItem = asT;
				stareActionInfo.TargetActor = null;
				stareActionInfo.TargetLocation.Reset();
				stareActionInfo.IsDirty = true;
			}
			else if (target.Value.IsT2)
			{
				Vector asT2 = target.Value.AsT2;
				if (stareActionInfo.TargetLocation.Equals(asT2, 9.999999747378752E-05))
				{
					return;
				}
				stareActionInfo.TargetLocation = asT2;
				stareActionInfo.TargetItem = null;
				stareActionInfo.TargetActor = null;
				stareActionInfo.IsDirty = true;
			}
			else if (target.Value.IsT3)
			{
				AActor asT3 = target.Value.AsT3;
				if (stareActionInfo.TargetActor == asT3)
				{
					return;
				}
				stareActionInfo.TargetActor = asT3;
				stareActionInfo.TargetLocation.Reset();
				stareActionInfo.TargetItem = null;
				stareActionInfo.IsDirty = true;
			}
			this.TarActionType = Math.Max(this.TarActionType, (int)context);
			this.RefreshTargetType();
			this.RefreshSight(false);
			stareActionInfo.IsDirty = false;
			return;
		}
		StareActionInfo stareActionInfo2;
		if (!this.StareActionStackMap.TryGetValue(context, out stareActionInfo2) || !stareActionInfo2.IsValid())
		{
			return;
		}
		stareActionInfo2.ClearInfo();
		this.RefreshTargetType();
		this.RefreshSight(false);
	}

	// Token: 0x0601BA76 RID: 113270 RVA: 0x007996F5 File Offset: 0x007978F5
	public void DelaySetBlendSpaceLookAt(bool enable)
	{
		if (this.CharacterAnimComp == null || this.CharacterAnimComp.EnableBlendSpaceLookAt == enable)
		{
			this.ClearDelayedBlendSpaceLookAt();
			return;
		}
		this.PendingBlendSpaceLookAt = (enable ? NpcSightController.EBlendSpacePendingState.On : NpcSightController.EBlendSpacePendingState.Off);
		this.BlendSpaceLookAtDelayTarget = this.GetCurrentSightTarget();
	}

	// Token: 0x0601BA77 RID: 113271 RVA: 0x00799730 File Offset: 0x00797930
	[NullableContext(1)]
	public unsafe void EnableSightChange(bool enable, string reason)
	{
		if (enable != this.DisableSightTarget)
		{
			return;
		}
		this.DisableSightTarget = !enable;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[NpcSightController] 设置启用视线目标";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		BaseCharacterComponent actorComp = this.ActorComp;
		ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Enable", enable);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Reason", reason);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (enable)
		{
			this.RefreshTargetType();
			this.RefreshSight(true);
			return;
		}
		this.TryApplyDelayedBlendSpaceLookAt(null);
		BaseAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.SetSightTargetItem(null);
	}

	// Token: 0x0601BA78 RID: 113272 RVA: 0x00799820 File Offset: 0x00797A20
	public unsafe void LockSightChange(EStareActionType type, bool bLock)
	{
		if (!bLock)
		{
			if (!this.LockedStareActionTypeSet.Contains(type))
			{
				return;
			}
			this.LockedStareActionTypeSet.Remove(type);
		}
		else
		{
			if (this.LockedStareActionTypeSet.Contains(type))
			{
				return;
			}
			this.LockedStareActionTypeSet.Add(type);
			this.LockActionType = Math.Max(this.LockActionType, (int)type);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[NpcSightController] 锁定注视级别";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		BaseCharacterComponent actorComp = this.ActorComp;
		ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LockType", StareActionTypeHelper.GetActionTypeName(type));
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Lock", bLock);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.RefreshTargetLockType();
		this.RefreshSight(true);
	}

	// Token: 0x0601BA79 RID: 113273 RVA: 0x0079992C File Offset: 0x00797B2C
	protected void RefreshSight(bool bForce = false)
	{
		if (this.AnimComp == null || this.DisableSightTarget)
		{
			return;
		}
		StareActionInfo stareActionInfo;
		if (!bForce && this.CurActionType == this.TarActionType && (!this.StareActionStackMap.TryGetValue((EStareActionType)this.TarActionType, out stareActionInfo) || !stareActionInfo.IsDirty))
		{
			return;
		}
		this.CurActionType = this.TarActionType;
		if (this.TarActionType == -1 || this.TarActionType < this.LockActionType)
		{
			this.TryApplyDelayedBlendSpaceLookAt(null);
			this.AnimComp.SetSightTargetItem(null);
			return;
		}
		StareActionInfo stareActionInfo2 = this.StareActionStackMap[(EStareActionType)this.TarActionType];
		if (stareActionInfo2.TargetItem != null)
		{
			this.TryApplyDelayedBlendSpaceLookAt(new OneOf<BaseActorComponent, Vector, AActor>?(stareActionInfo2.TargetItem));
			this.AnimComp.SetSightTargetItem(stareActionInfo2.TargetItem);
			return;
		}
		if (stareActionInfo2.TargetActor != null)
		{
			this.TryApplyDelayedBlendSpaceLookAt(new OneOf<BaseActorComponent, Vector, AActor>?(stareActionInfo2.TargetActor));
			this.AnimComp.SetSightTargetActor(stareActionInfo2.TargetActor);
			return;
		}
		this.TryApplyDelayedBlendSpaceLookAt(new OneOf<BaseActorComponent, Vector, AActor>?(stareActionInfo2.TargetLocation));
		this.AnimComp.SetSightTargetPoint(stareActionInfo2.TargetLocation);
	}

	// Token: 0x0601BA7A RID: 113274 RVA: 0x00799A54 File Offset: 0x00797C54
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private OneOf<BaseActorComponent, Vector, AActor>? GetCurrentSightTarget()
	{
		BaseAnimationComponent animComp = this.AnimComp;
		BaseActorComponent baseActorComponent = (animComp != null) ? animComp.GetSightTargetItem() : null;
		if (baseActorComponent != null)
		{
			return new OneOf<BaseActorComponent, Vector, AActor>?(baseActorComponent);
		}
		BaseAnimationComponent animComp2 = this.AnimComp;
		Vector vector = (animComp2 != null) ? animComp2.GetSightTargetPoint() : null;
		if (vector != null)
		{
			return new OneOf<BaseActorComponent, Vector, AActor>?(Vector.Create(vector));
		}
		BaseAnimationComponent animComp3 = this.AnimComp;
		return new OneOf<BaseActorComponent, Vector, AActor>?((animComp3 != null) ? animComp3.GetSightTargetActor() : null);
	}

	// Token: 0x0601BA7B RID: 113275 RVA: 0x00799AC8 File Offset: 0x00797CC8
	private bool IsSightTargetEqual([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<BaseActorComponent, Vector, AActor>? left, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<BaseActorComponent, Vector, AActor>? right)
	{
		bool flag = left == null || (left.Value.IsT1 && left.Value.AsT1.Entity == null);
		bool flag2 = right == null || (right.Value.IsT1 && right.Value.AsT1.Entity == null);
		if (flag || flag2)
		{
			return flag && flag2;
		}
		if (left.Value.IsT1 && right.Value.IsT1)
		{
			return left.Value.AsT1.Entity.Id == right.Value.AsT1.Entity.Id;
		}
		if (left.Value.IsT2 && right.Value.IsT2)
		{
			return left.Value.AsT2.Equals(right.Value.AsT2, 9.999999747378752E-05);
		}
		return left.Value.Equals(right.Value);
	}

	// Token: 0x0601BA7C RID: 113276 RVA: 0x00799C0C File Offset: 0x00797E0C
	private void TryApplyDelayedBlendSpaceLookAt([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] OneOf<BaseActorComponent, Vector, AActor>? target)
	{
		if (this.PendingBlendSpaceLookAt == NpcSightController.EBlendSpacePendingState.None || this.CharacterAnimComp == null)
		{
			return;
		}
		if (this.IsSightTargetEqual(this.BlendSpaceLookAtDelayTarget, target))
		{
			return;
		}
		bool flag = this.PendingBlendSpaceLookAt == NpcSightController.EBlendSpacePendingState.On;
		this.ClearDelayedBlendSpaceLookAt();
		if (this.CharacterAnimComp.EnableBlendSpaceLookAt != flag)
		{
			this.CharacterAnimComp.SetBlendSpaceLookAt(flag);
		}
	}

	// Token: 0x0601BA7D RID: 113277 RVA: 0x00799C65 File Offset: 0x00797E65
	private void ClearDelayedBlendSpaceLookAt()
	{
		this.PendingBlendSpaceLookAt = NpcSightController.EBlendSpacePendingState.None;
		this.BlendSpaceLookAtDelayTarget = null;
	}

	// Token: 0x0601BA7E RID: 113278 RVA: 0x00799C7C File Offset: 0x00797E7C
	protected void RefreshTargetType()
	{
		StareActionInfo stareActionInfo;
		while (this.TarActionType >= 0 && (!this.StareActionStackMap.TryGetValue((EStareActionType)this.TarActionType, out stareActionInfo) || !stareActionInfo.IsValid()))
		{
			this.TarActionType--;
		}
	}

	// Token: 0x0601BA7F RID: 113279 RVA: 0x00799CBF File Offset: 0x00797EBF
	protected void RefreshTargetLockType()
	{
		while (this.LockActionType >= 0 && !this.LockedStareActionTypeSet.Contains((EStareActionType)this.LockActionType))
		{
			this.LockActionType--;
		}
	}

	// Token: 0x0400D982 RID: 55682
	protected Entity Entity;

	// Token: 0x0400D983 RID: 55683
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400D984 RID: 55684
	protected BaseAnimationComponent AnimComp;

	// Token: 0x0400D985 RID: 55685
	protected CharacterAnimationComponent CharacterAnimComp;

	// Token: 0x0400D986 RID: 55686
	protected CommonNpcPerformComponent PerformComp;

	// Token: 0x0400D987 RID: 55687
	[Nullable(1)]
	protected Dictionary<EStareActionType, StareActionInfo> StareActionStackMap = new Dictionary<EStareActionType, StareActionInfo>();

	// Token: 0x0400D988 RID: 55688
	protected int TarActionType = -1;

	// Token: 0x0400D989 RID: 55689
	protected int CurActionType = -1;

	// Token: 0x0400D98A RID: 55690
	[Nullable(1)]
	protected HashSet<EStareActionType> LockedStareActionTypeSet = new HashSet<EStareActionType>();

	// Token: 0x0400D98B RID: 55691
	protected int LockActionType = -1;

	// Token: 0x0400D98C RID: 55692
	protected bool DisableSightTarget;

	// Token: 0x0400D98D RID: 55693
	private NpcSightController.EBlendSpacePendingState PendingBlendSpaceLookAt = NpcSightController.EBlendSpacePendingState.None;

	// Token: 0x0400D98E RID: 55694
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private OneOf<BaseActorComponent, Vector, AActor>? BlendSpaceLookAtDelayTarget;

	// Token: 0x0200971B RID: 38683
	[NullableContext(0)]
	private enum EBlendSpacePendingState
	{
		// Token: 0x040305FA RID: 198138
		On,
		// Token: 0x040305FB RID: 198139
		Off,
		// Token: 0x040305FC RID: 198140
		None
	}
}
