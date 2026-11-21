using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x020026A6 RID: 9894
[NullableContext(1)]
[Nullable(0)]
public class FightDataTableCollection
{
	// Token: 0x06018C9A RID: 101530 RVA: 0x007870E7 File Offset: 0x007852E7
	public FightDataTableCollection(int entityId)
	{
		this.EntityId = entityId;
		this.SkillRepository = new SkillDataTableRepository(this);
		this.BulletRepository = new BulletDataTableRepository(this);
		this.HitEffectRepository = new HitEffectDataTableRepository(this);
	}

	// Token: 0x06018C9B RID: 101531 RVA: 0x0078711A File Offset: 0x0078531A
	[NullableContext(2)]
	public void SetSkillTableChangeListener(ISkillTableChangeListener listener)
	{
		this.SkillTableChangeListener = listener;
	}

	// Token: 0x06018C9C RID: 101532 RVA: 0x00787123 File Offset: 0x00785323
	public void NotifySkillIdsChanged(IReadOnlyList<int> candidateSkillIds)
	{
		ISkillTableChangeListener skillTableChangeListener = this.SkillTableChangeListener;
		if (skillTableChangeListener == null)
		{
			return;
		}
		skillTableChangeListener.OnSkillIdsChanged(candidateSkillIds);
	}

	// Token: 0x06018C9D RID: 101533 RVA: 0x00787136 File Offset: 0x00785336
	public void NotifyDebugSkillIdsChanged()
	{
		this.SkillRepository.NotifyDebugSkillIdsChanged();
	}

	// Token: 0x06018C9E RID: 101534 RVA: 0x00787143 File Offset: 0x00785343
	[NullableContext(2)]
	public void SetTable(EFightDataTableKind kind, UDataTable data, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Self)
		{
			this.GetRepository(kind).SelfTable = data;
			if (kind == EFightDataTableKind.Bullet)
			{
				BulletConfig.Instance.EnqueueSelfPreload(this.EntityId, data);
			}
		}
	}

	// Token: 0x06018C9F RID: 101535 RVA: 0x0078716B File Offset: 0x0078536B
	public void ClearTables(EFightDataTableKind kind, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).ClearExtraTables();
		}
	}

	// Token: 0x06018CA0 RID: 101536 RVA: 0x0078717D File Offset: 0x0078537D
	[NullableContext(2)]
	public void AddTable(EFightDataTableKind kind, UDataTable data, EFightDataTableSourceType tableSourceType = EFightDataTableSourceType.Extra)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).AddExtraTable(data);
		}
	}

	// Token: 0x06018CA1 RID: 101537 RVA: 0x00787190 File Offset: 0x00785390
	[NullableContext(2)]
	public void RemoveTable(EFightDataTableKind kind, UDataTable data, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).RemoveExtraTable(data);
		}
	}

	// Token: 0x06018CA2 RID: 101538 RVA: 0x007871A3 File Offset: 0x007853A3
	[NullableContext(2)]
	public void ReplaceTable(EFightDataTableKind kind, UDataTable oldData, UDataTable newData, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).ReplaceExtraTable(oldData, newData);
		}
	}

	// Token: 0x06018CA3 RID: 101539 RVA: 0x007871B8 File Offset: 0x007853B8
	[NullableContext(2)]
	public UDataTable GetTable(EFightDataTableKind kind, EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		switch (kind)
		{
		case EFightDataTableKind.Skill:
			return this.SkillRepository.GetTable(tableSourceType, new EEntityType?(entityType));
		case EFightDataTableKind.Bullet:
			return this.BulletRepository.GetTable(tableSourceType, null);
		case EFightDataTableKind.HitEffect:
			return this.HitEffectRepository.GetTable(tableSourceType, null);
		default:
			return null;
		}
	}

	// Token: 0x06018CA4 RID: 101540 RVA: 0x00787219 File Offset: 0x00785419
	[NullableContext(2)]
	public void SetDebugTable(EFightDataTableKind kind, ECharacterLoadType loadType, UDataTable data)
	{
		if (kind == EFightDataTableKind.Skill)
		{
			this.SkillRepository.SetDebugTable(loadType, data);
		}
	}

	// Token: 0x06018CA5 RID: 101541 RVA: 0x0078722B File Offset: 0x0078542B
	public Dictionary<ECharacterLoadType, UDataTable> GetDebugTables(EFightDataTableKind kind)
	{
		if (kind == EFightDataTableKind.Skill)
		{
			return this.SkillRepository.DebugTables;
		}
		return FightDataTableCollection.EmptyDebugTables;
	}

	// Token: 0x06018CA6 RID: 101542 RVA: 0x00787241 File Offset: 0x00785441
	public IEnumerable<DataTableKeyRow<SSkillInfo>> EnumerateSkillInfoRows(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		return this.SkillRepository.EnumerateSkillInfoRows(tableSourceType, entityType);
	}

	// Token: 0x06018CA7 RID: 101543 RVA: 0x00787250 File Offset: 0x00785450
	public IEnumerable<int> EnumerateSkillIds(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		return this.SkillRepository.EnumerateSkillIds(tableSourceType, entityType);
	}

	// Token: 0x06018CA8 RID: 101544 RVA: 0x0078725F File Offset: 0x0078545F
	[NullableContext(2)]
	public ResolvedSkillInfo FindSkillInfo(long skillId, EEntityType entityType)
	{
		return this.SkillRepository.FindSkillInfo(skillId, entityType);
	}

	// Token: 0x06018CA9 RID: 101545 RVA: 0x0078726E File Offset: 0x0078546E
	[return: Nullable(2)]
	public ResolvedBulletDataMain FindBulletDataMain(string rowName)
	{
		return this.BulletRepository.FindBulletDataMain(rowName);
	}

	// Token: 0x06018CAA RID: 101546 RVA: 0x0078727C File Offset: 0x0078547C
	public IEnumerable<long> EnumerateBulletIds(EFightDataTableSourceType tableSourceType)
	{
		return this.BulletRepository.EnumerateBulletIds(tableSourceType);
	}

	// Token: 0x06018CAB RID: 101547 RVA: 0x0078728A File Offset: 0x0078548A
	[return: Nullable(2)]
	public SHitEffect FindHitEffect(string rowName)
	{
		return this.HitEffectRepository.FindHitEffect(rowName);
	}

	// Token: 0x06018CAC RID: 101548 RVA: 0x00787298 File Offset: 0x00785498
	private BaseFightDataTableRepository GetRepository(EFightDataTableKind kind)
	{
		switch (kind)
		{
		case EFightDataTableKind.Skill:
			return this.SkillRepository;
		case EFightDataTableKind.Bullet:
			return this.BulletRepository;
		case EFightDataTableKind.HitEffect:
			return this.HitEffectRepository;
		default:
			return this.SkillRepository;
		}
	}

	// Token: 0x0400D74B RID: 55115
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ECharacterLoadType, UDataTable> EmptyDebugTables = new Dictionary<ECharacterLoadType, UDataTable>();

	// Token: 0x0400D74C RID: 55116
	private readonly SkillDataTableRepository SkillRepository;

	// Token: 0x0400D74D RID: 55117
	private readonly BulletDataTableRepository BulletRepository;

	// Token: 0x0400D74E RID: 55118
	private readonly HitEffectDataTableRepository HitEffectRepository;

	// Token: 0x0400D74F RID: 55119
	[Nullable(2)]
	private ISkillTableChangeListener SkillTableChangeListener;

	// Token: 0x0400D750 RID: 55120
	public readonly int EntityId;
}
