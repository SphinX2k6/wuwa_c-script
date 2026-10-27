using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F71 RID: 12145
[NullableContext(1)]
[Nullable(0)]
public class SnapModifier : IStaticVariableResetter
{
	// Token: 0x06019D02 RID: 105730 RVA: 0x006BBC98 File Offset: 0x006B9E98
	static SnapModifier()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SnapModifier.CreateStaticDefaultValue), new Action(SnapModifier.ResetStaticDefaultValue));
	}

	// Token: 0x170023B2 RID: 9138
	// (get) Token: 0x06019D03 RID: 105731 RVA: 0x006BBCB7 File Offset: 0x006B9EB7
	private static EExtraEffectId[] SnapModifyEffectIds
	{
		get
		{
			return SnapModifier._snapModifyEffectIds;
		}
	}

	// Token: 0x06019D04 RID: 105732 RVA: 0x006BBCBE File Offset: 0x006B9EBE
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

	// Token: 0x06019D05 RID: 105733 RVA: 0x006BBCE8 File Offset: 0x006B9EE8
	public static void ResetStaticDefaultValue()
	{
		SnapModifier._snapModifyEffectIds = null;
		SnapModifier._resultMapPool = null;
		SnapModifier._effectListPool = null;
	}

	// Token: 0x06019D06 RID: 105734 RVA: 0x006BBCFC File Offset: 0x006B9EFC
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

	// Token: 0x06019D07 RID: 105735 RVA: 0x006BBD3C File Offset: 0x006B9F3C
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

	// Token: 0x06019D08 RID: 105736 RVA: 0x006BBD54 File Offset: 0x006B9F54
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

	// Token: 0x06019D09 RID: 105737 RVA: 0x006BBD94 File Offset: 0x006B9F94
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

	// Token: 0x06019D0A RID: 105738 RVA: 0x006BBDAC File Offset: 0x006B9FAC
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

	// Token: 0x06019D0B RID: 105739 RVA: 0x006BBE66 File Offset: 0x006BA066
	public static void PreCriticalModify(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		SnapModifier.PrepareModify(requirements, snapshots, false);
	}

	// Token: 0x06019D0C RID: 105740 RVA: 0x006BBE70 File Offset: 0x006BA070
	public static void PostCriticalModify(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		SnapModifier.PrepareModify(requirements, snapshots, true);
	}

	// Token: 0x06019D0D RID: 105741 RVA: 0x006BBE7C File Offset: 0x006BA07C
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

	// Token: 0x06019D0E RID: 105742 RVA: 0x006BBF3C File Offset: 0x006BA13C
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

	// Token: 0x0400C2D9 RID: 49881
	[Nullable(2)]
	private static EExtraEffectId[] _snapModifyEffectIds;

	// Token: 0x0400C2DA RID: 49882
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<Dictionary<EAttributeType, float>> _resultMapPool;

	// Token: 0x0400C2DB RID: 49883
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static List<List<SnapModifyBuffEffect>> _effectListPool;
}
