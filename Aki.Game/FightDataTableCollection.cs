using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02003144 RID: 12612
[NullableContext(1)]
[Nullable(0)]
public class FightDataTableCollection
{
	// Token: 0x0601B202 RID: 111106 RVA: 0x0076082A File Offset: 0x0075EA2A
	public FightDataTableCollection(int entityId)
	{
		this.EntityId = entityId;
		this.SkillRepository = new SkillDataTableRepository(this);
		this.BulletRepository = new BulletDataTableRepository(this);
		this.HitEffectRepository = new HitEffectDataTableRepository(this);
	}

	// Token: 0x0601B203 RID: 111107 RVA: 0x0076085D File Offset: 0x0075EA5D
	[NullableContext(2)]
	public void SetTable(EFightDataTableKind kind, UDataTable data, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Self)
		{
			this.GetRepository(kind).SelfTable = data;
			if (kind == EFightDataTableKind.Bullet)
			{
				BulletConfig.Instance.EnqueueSelfPreload(this.EntityId, data);
				return;
			}
		}
		else if (tableSourceType == EFightDataTableSourceType.Common)
		{
			this.GetRepository(kind).SetCommonOverrideTable(data);
		}
	}

	// Token: 0x0601B204 RID: 111108 RVA: 0x00760897 File Offset: 0x0075EA97
	public void ClearTables(EFightDataTableKind kind, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).ClearExtraTables();
			return;
		}
		if (tableSourceType == EFightDataTableSourceType.Common)
		{
			this.GetRepository(kind).SetCommonOverrideTable(null);
		}
	}

	// Token: 0x0601B205 RID: 111109 RVA: 0x007608BB File Offset: 0x0075EABB
	[NullableContext(2)]
	public void AddTable(EFightDataTableKind kind, UDataTable data, EFightDataTableSourceType tableSourceType = EFightDataTableSourceType.Extra)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).AddExtraTable(data);
		}
	}

	// Token: 0x0601B206 RID: 111110 RVA: 0x007608CE File Offset: 0x0075EACE
	[NullableContext(2)]
	public void RemoveTable(EFightDataTableKind kind, UDataTable data, EFightDataTableSourceType tableSourceType)
	{
		if (tableSourceType == EFightDataTableSourceType.Extra)
		{
			this.GetRepository(kind).RemoveExtraTable(data);
		}
	}

	// Token: 0x0601B207 RID: 111111 RVA: 0x007608E4 File Offset: 0x0075EAE4
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

	// Token: 0x0601B208 RID: 111112 RVA: 0x00760945 File Offset: 0x0075EB45
	[NullableContext(2)]
	public void SetDebugTable(EFightDataTableKind kind, ECharacterLoadType loadType, UDataTable data)
	{
		if (kind == EFightDataTableKind.Skill)
		{
			this.SkillRepository.SetDebugTable(loadType, data);
		}
	}

	// Token: 0x0601B209 RID: 111113 RVA: 0x00760957 File Offset: 0x0075EB57
	public Dictionary<ECharacterLoadType, UDataTable> GetDebugTables(EFightDataTableKind kind)
	{
		if (kind == EFightDataTableKind.Skill)
		{
			return this.SkillRepository.DebugTables;
		}
		return FightDataTableCollection.EmptyDebugTables;
	}

	// Token: 0x0601B20A RID: 111114 RVA: 0x0076096D File Offset: 0x0075EB6D
	public IEnumerable<DataTableKeyRow<SSkillInfo>> EnumerateSkillInfoRows(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		return this.SkillRepository.EnumerateSkillInfoRows(tableSourceType, entityType);
	}

	// Token: 0x0601B20B RID: 111115 RVA: 0x0076097C File Offset: 0x0075EB7C
	public IEnumerable<int> EnumerateSkillIds(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		return this.SkillRepository.EnumerateSkillIds(tableSourceType, entityType);
	}

	// Token: 0x0601B20C RID: 111116 RVA: 0x0076098B File Offset: 0x0075EB8B
	[NullableContext(2)]
	public SSkillInfo FindSkillInfo(long skillId, EEntityType entityType)
	{
		return this.SkillRepository.FindSkillInfo(skillId, entityType);
	}

	// Token: 0x0601B20D RID: 111117 RVA: 0x0076099A File Offset: 0x0075EB9A
	[return: Nullable(2)]
	public SReBulletDataMain FindBulletDataMain(string rowName)
	{
		return this.BulletRepository.FindBulletDataMain(rowName);
	}

	// Token: 0x0601B20E RID: 111118 RVA: 0x007609A8 File Offset: 0x0075EBA8
	public IEnumerable<long> EnumerateBulletIds(EFightDataTableSourceType tableSourceType)
	{
		return this.BulletRepository.EnumerateBulletIds(tableSourceType);
	}

	// Token: 0x0601B20F RID: 111119 RVA: 0x007609B6 File Offset: 0x0075EBB6
	[return: Nullable(2)]
	public SHitEffect FindHitEffect(string rowName)
	{
		return this.HitEffectRepository.FindHitEffect(rowName);
	}

	// Token: 0x0601B210 RID: 111120 RVA: 0x007609C4 File Offset: 0x0075EBC4
	public FightDataTableSnapshot CreateSnapshot(EFightDataTableKind kind, EEntityType entityType)
	{
		switch (kind)
		{
		case EFightDataTableKind.Skill:
			return this.SkillRepository.CreateSnapshot(entityType);
		case EFightDataTableKind.Bullet:
			return this.BulletRepository.CreateSnapshot(entityType);
		case EFightDataTableKind.HitEffect:
			return this.HitEffectRepository.CreateSnapshot(entityType);
		default:
			return new FightDataTableSnapshot();
		}
	}

	// Token: 0x0601B211 RID: 111121 RVA: 0x00760A11 File Offset: 0x0075EC11
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

	// Token: 0x0400D30E RID: 54030
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ECharacterLoadType, UDataTable> EmptyDebugTables = new Dictionary<ECharacterLoadType, UDataTable>();

	// Token: 0x0400D30F RID: 54031
	private readonly SkillDataTableRepository SkillRepository;

	// Token: 0x0400D310 RID: 54032
	private readonly BulletDataTableRepository BulletRepository;

	// Token: 0x0400D311 RID: 54033
	private readonly HitEffectDataTableRepository HitEffectRepository;

	// Token: 0x0400D312 RID: 54034
	public readonly int EntityId;
}
