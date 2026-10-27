using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F72 RID: 12146
[NullableContext(1)]
[Nullable(0)]
public abstract class SnapModifyBuffEffect : BuffEffect
{
	// Token: 0x06019D10 RID: 105744 RVA: 0x006BBFB0 File Offset: 0x006BA1B0
	protected SnapModifyBuffEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D11 RID: 105745 RVA: 0x006BBFBF File Offset: 0x006BA1BF
	protected override bool CheckAuthority()
	{
		return false;
	}

	// Token: 0x06019D12 RID: 105746 RVA: 0x006BBFC4 File Offset: 0x006BA1C4
	public bool TryExecuteSnap(Partial_RequirementPayload context, IBuffComponent opponent, Dictionary<EAttributeType, float> resultMap, SnapshotPayload snapshots)
	{
		if (!base.Check(context, opponent))
		{
			return false;
		}
		this.ExecuteContext = context;
		this.LoopLock = Time.Instance.Frame;
		this.OnExecuteSnap(resultMap, snapshots);
		this.PostExecuted();
		this.LoopLock = -1;
		this.ExecuteContext = null;
		return true;
	}

	// Token: 0x06019D13 RID: 105747 RVA: 0x006BC012 File Offset: 0x006BA212
	protected virtual void OnExecuteSnap(Dictionary<EAttributeType, float> resultMap, SnapshotPayload snapshots)
	{
		this.OnExecute(new object[]
		{
			resultMap,
			snapshots
		});
	}

	// Token: 0x06019D14 RID: 105748 RVA: 0x006BC02C File Offset: 0x006BA22C
	protected float GetAttrValue(SnapshotPayload snapshots, EAttributeType attrId, EAttributeRefType attributeType, ESnapAttributeSourceType targetType)
	{
		IAttributeSet attrSet = this.GetAttrSet(snapshots, targetType);
		if (attrSet == null)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.LC, "[SnapModifier] Get attributeSet failed.", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0f;
		}
		if (attributeType == EAttributeRefType.BaseValue)
		{
			return attrSet.GetBaseValue(attrId);
		}
		return attrSet.GetCurrentValue(attrId);
	}

	// Token: 0x06019D15 RID: 105749 RVA: 0x006BC07C File Offset: 0x006BA27C
	[return: Nullable(2)]
	private IAttributeSet GetAttrSet(SnapshotPayload snapshots, ESnapAttributeSourceType targetType)
	{
		IAttributeSet result;
		switch (targetType)
		{
		case ESnapAttributeSourceType.BuffMaker:
		{
			EntityHandle instigatorEntity = base.InstigatorEntity;
			IAttributeSet attributeSet;
			if (instigatorEntity == null)
			{
				attributeSet = null;
			}
			else
			{
				WorldEntity entity = instigatorEntity.Entity;
				attributeSet = ((entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null);
			}
			result = attributeSet;
			break;
		}
		case ESnapAttributeSourceType.BuffHolder:
		{
			Entity ownerEntity = base.OwnerEntity;
			result = ((ownerEntity != null) ? ownerEntity.GetComponent<BaseAttributeComponent>() : null);
			break;
		}
		case ESnapAttributeSourceType.Attacker:
			result = snapshots.AttackerSnapshot;
			break;
		case ESnapAttributeSourceType.Target:
			result = snapshots.TargetSnapshot;
			break;
		default:
			result = null;
			break;
		}
		return result;
	}

	// Token: 0x0400C2DC RID: 49884
	public ESnapTargetType? TargetType;

	// Token: 0x0400C2DD RID: 49885
	public bool NeedCheckCritical;
}
