using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024C6 RID: 9414
[NullableContext(1)]
[Nullable(0)]
public abstract class SnapModifyBuffEffect : BuffEffect
{
	// Token: 0x06017622 RID: 95778 RVA: 0x006E289C File Offset: 0x006E0A9C
	protected SnapModifyBuffEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017623 RID: 95779 RVA: 0x006E28AB File Offset: 0x006E0AAB
	protected override bool CheckAuthority()
	{
		return false;
	}

	// Token: 0x06017624 RID: 95780 RVA: 0x006E28B0 File Offset: 0x006E0AB0
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

	// Token: 0x06017625 RID: 95781 RVA: 0x006E28FE File Offset: 0x006E0AFE
	protected virtual void OnExecuteSnap(Dictionary<EAttributeType, float> resultMap, SnapshotPayload snapshots)
	{
		this.OnExecute(new object[]
		{
			resultMap,
			snapshots
		});
	}

	// Token: 0x06017626 RID: 95782 RVA: 0x006E2918 File Offset: 0x006E0B18
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

	// Token: 0x06017627 RID: 95783 RVA: 0x006E2968 File Offset: 0x006E0B68
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

	// Token: 0x0400C685 RID: 50821
	public ESnapTargetType? TargetType;

	// Token: 0x0400C686 RID: 50822
	public bool NeedCheckCritical;
}
