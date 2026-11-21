using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024C5 RID: 9413
[NullableContext(1)]
[Nullable(0)]
public class SnapModifier : IStaticVariableResetter
{
	// Token: 0x06017614 RID: 95764 RVA: 0x006E2584 File Offset: 0x006E0784
	static SnapModifier()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SnapModifier.CreateStaticDefaultValue), new Action(SnapModifier.ResetStaticDefaultValue));
	}

	// Token: 0x17002474 RID: 9332
	// (get) Token: 0x06017615 RID: 95765 RVA: 0x006E25A3 File Offset: 0x006E07A3
	private static EExtraEffectId[] SnapModifyEffectIds
	{
		get
		{
			return SnapModifier._snapModifyEffectIds;
		}
	}

	// Token: 0x06017616 RID: 95766 RVA: 0x006E25AA File Offset: 0x006E07AA
	public static void CreateStaticDefaultValue()
	{
		SnapModifier._snapModifyEffectIds = new EExtraEffectId[]
		{
			EExtraEffectId.ModifySnapshotBeforeCalculation,
			EExtraEffectId.ShieldModifySnapshot
		};
		SnapModifier._resultMapPool = new List<Dictionary<EAttributeType, float>>();
		SnapModifier._effectListPool = new List<List<SnapModifyBuffEffect>>();
	}

	// Token: 0x06017617 RID: 95767 RVA: 0x006E25D4 File Offset: 0x006E07D4
	public static void ResetStaticDefaultValue()
	{
		SnapModifier._snapModifyEffectIds = null;
		SnapModifier._resultMapPool = null;
		SnapModifier._effectListPool = null;
	}

	// Token: 0x06017618 RID: 95768 RVA: 0x006E25E8 File Offset: 0x006E07E8
	private static Dictionary<EAttributeType, float> RentResultMap()
	{
		List<Dictionary<EAttributeType, float>> resultMapPool = SnapModifier._resultMapPool;
		if (resultMapPool == null || resultMapPool.Count == 0)
		{
			return new Dictionary<EAttributeType, float>();
		}
		Dictionary<EAttributeType, float> result = resultMapPool[resultMapPool.Count - 1];
		resultMapPool.RemoveAt(resultMapPool.Count - 1);
		return result;
	}

	// Token: 0x06017619 RID: 95769 RVA: 0x006E2628 File Offset: 0x006E0828
	private static void ReturnResultMap(Dictionary<EAttributeType, float> map)
	{
		map.Clear();
		List<Dictionary<EAttributeType, float>> resultMapPool = SnapModifier._resultMapPool;
		if (resultMapPool == null)
		{
			return;
		}
		resultMapPool.Add(map);
	}

	// Token: 0x0601761A RID: 95770 RVA: 0x006E2640 File Offset: 0x006E0840
	private static List<SnapModifyBuffEffect> RentEffectList()
	{
		List<List<SnapModifyBuffEffect>> effectListPool = SnapModifier._effectListPool;
		if (effectListPool == null || effectListPool.Count == 0)
		{
			return new List<SnapModifyBuffEffect>();
		}
		List<SnapModifyBuffEffect> result = effectListPool[effectListPool.Count - 1];
		effectListPool.RemoveAt(effectListPool.Count - 1);
		return result;
	}

	// Token: 0x0601761B RID: 95771 RVA: 0x006E2680 File Offset: 0x006E0880
	private static void ReturnEffectList(List<SnapModifyBuffEffect> list)
	{
		list.Clear();
		List<List<SnapModifyBuffEffect>> effectListPool = SnapModifier._effectListPool;
		if (effectListPool == null)
		{
			return;
		}
		effectListPool.Add(list);
	}

	// Token: 0x0601761C RID: 95772 RVA: 0x006E2698 File Offset: 0x006E0898
	private static void PrepareModify(RequirementPayload requirements, SnapshotPayload snapshots, bool isCheckCritical)
	{
		ExtraEffectManager buffEffectManager = snapshots.Attacker.OwnerBuffComponent.BuffEffectManager;
		ExtraEffectManager buffEffectManager2 = snapshots.Target.OwnerBuffComponent.BuffEffectManager;
		bool flag = buffEffectManager.HasAnyById(SnapModifier.SnapModifyEffectIds);
		bool flag2 = buffEffectManager2.HasAnyById(SnapModifier.SnapModifyEffectIds);
		if (!flag && !flag2)
		{
			return;
		}
		Dictionary<EAttributeType, float> dictionary = SnapModifier.RentResultMap();
		Dictionary<EAttributeType, float> dictionary2 = SnapModifier.RentResultMap();
		if (flag)
		{
			SnapModifier.CalculateModifyMap(requirements, snapshots, dictionary, buffEffectManager, ESnapTargetType.AttackerToAttacker, isCheckCritical);
			SnapModifier.CalculateModifyMap(requirements, snapshots, dictionary2, buffEffectManager, ESnapTargetType.AttackerToTarget, isCheckCritical);
		}
		if (flag2)
		{
			SnapModifier.CalculateModifyMap(requirements, snapshots, dictionary, buffEffectManager2, ESnapTargetType.TargetToAttacker, isCheckCritical);
			SnapModifier.CalculateModifyMap(requirements, snapshots, dictionary2, buffEffectManager2, ESnapTargetType.TargetToTarget, isCheckCritical);
		}
		SnapModifier.ModifySnapshot(dictionary, snapshots.AttackerSnapshot);
		SnapModifier.ModifySnapshot(dictionary2, snapshots.TargetSnapshot);
		SnapModifier.ReturnResultMap(dictionary);
		SnapModifier.ReturnResultMap(dictionary2);
	}

	// Token: 0x0601761D RID: 95773 RVA: 0x006E2752 File Offset: 0x006E0952
	public static void PreCriticalModify(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		SnapModifier.PrepareModify(requirements, snapshots, false);
	}

	// Token: 0x0601761E RID: 95774 RVA: 0x006E275C File Offset: 0x006E095C
	public static void PostCriticalModify(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		SnapModifier.PrepareModify(requirements, snapshots, true);
	}

	// Token: 0x0601761F RID: 95775 RVA: 0x006E2768 File Offset: 0x006E0968
	private static void CalculateModifyMap(RequirementPayload requires, SnapshotPayload snapshots, Dictionary<EAttributeType, float> resultMap, ExtraEffectManager holder, ESnapTargetType targetType, bool isCheckCritical)
	{
		IBuffComponent opponent = null;
		if (targetType > ESnapTargetType.AttackerToTarget)
		{
			if (targetType - ESnapTargetType.TargetToAttacker <= 1)
			{
				opponent = snapshots.Attacker.OwnerBuffComponent;
			}
		}
		else
		{
			opponent = snapshots.Target.OwnerBuffComponent;
		}
		List<SnapModifyBuffEffect> list = SnapModifier.RentEffectList();
		holder.CollectById<SnapModifyBuffEffect>(SnapModifier.SnapModifyEffectIds, list);
		foreach (SnapModifyBuffEffect snapModifyBuffEffect in list)
		{
			ESnapTargetType? targetType2 = snapModifyBuffEffect.TargetType;
			if ((targetType2.GetValueOrDefault() == targetType & targetType2 != null) && snapModifyBuffEffect.NeedCheckCritical == isCheckCritical)
			{
				snapModifyBuffEffect.TryExecuteSnap(requires, opponent, resultMap, snapshots);
			}
		}
		SnapModifier.ReturnEffectList(list);
	}

	// Token: 0x06017620 RID: 95776 RVA: 0x006E2828 File Offset: 0x006E0A28
	private static void ModifySnapshot(Dictionary<EAttributeType, float> resultMap, AttributeSnapshot snapshot)
	{
		foreach (KeyValuePair<EAttributeType, float> keyValuePair in resultMap)
		{
			EAttributeType eattributeType;
			float num;
			keyValuePair.Deconstruct(out eattributeType, out num);
			EAttributeType eattributeType2 = eattributeType;
			float num2 = num;
			snapshot.CurrentValues[(int)eattributeType2] += num2;
		}
	}

	// Token: 0x0400C682 RID: 50818
	[Nullable(2)]
	private static EExtraEffectId[] _snapModifyEffectIds;

	// Token: 0x0400C683 RID: 50819
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<Dictionary<EAttributeType, float>> _resultMapPool;

	// Token: 0x0400C684 RID: 50820
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static List<List<SnapModifyBuffEffect>> _effectListPool;
}
