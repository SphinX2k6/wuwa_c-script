using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002370 RID: 9072
[NullableContext(1)]
[Nullable(0)]
public class BulletInitParams
{
	// Token: 0x060165BC RID: 91580 RVA: 0x00682328 File Offset: 0x00680528
	public BulletInitParams(Entity owner, string bulletRowName, FTransformDouble? initialTransform, FVectorDouble? initTargetLocation, int skillId = 0, int parentId = 0, int targetId = 0, int baseTransformId = 0, int baseVelocityId = 0, [Nullable(2)] global::Vector size = null, bool fromRemote = false, EBulletSyncType syncType = EBulletSyncType.Local, long? contextId = null, long? skillContextId = null, Aki.Protocol.EBulletCreateSource source = Aki.Protocol.EBulletCreateSource.NormalSource, FVector? locationOffset = null, FRotator? beginRotatorOffset = null, [Nullable(2)] ISkillBattleContext battleContext = null, global::EBulletCreateSource createSource = global::EBulletCreateSource.Others)
	{
		this.Owner = owner;
		this.BulletRowName = bulletRowName;
		this.InitialTransform = initialTransform;
		this.InitTargetLocation = initTargetLocation;
		this.SkillId = skillId;
		this.ParentId = parentId;
		this.TargetId = targetId;
		this.BaseTransformId = baseTransformId;
		this.BaseVelocityId = baseVelocityId;
		this.Size = size;
		this.FromRemote = fromRemote;
		this.SyncType = syncType;
		this.ContextId = contextId;
		this.SkillContextId = skillContextId;
		this.Source = source;
		this.LocationOffset = locationOffset;
		this.BeginRotatorOffset = beginRotatorOffset;
		this.BattleContext = battleContext;
		this.CreateSource = createSource;
	}

	// Token: 0x0400BD78 RID: 48504
	public readonly Entity Owner;

	// Token: 0x0400BD79 RID: 48505
	public readonly string BulletRowName;

	// Token: 0x0400BD7A RID: 48506
	public readonly FTransformDouble? InitialTransform;

	// Token: 0x0400BD7B RID: 48507
	public readonly FVectorDouble? InitTargetLocation;

	// Token: 0x0400BD7C RID: 48508
	public readonly int SkillId;

	// Token: 0x0400BD7D RID: 48509
	public readonly int ParentId;

	// Token: 0x0400BD7E RID: 48510
	public readonly int TargetId;

	// Token: 0x0400BD7F RID: 48511
	public readonly int BaseTransformId;

	// Token: 0x0400BD80 RID: 48512
	public readonly int BaseVelocityId;

	// Token: 0x0400BD81 RID: 48513
	[Nullable(2)]
	public readonly global::Vector Size;

	// Token: 0x0400BD82 RID: 48514
	public readonly bool FromRemote;

	// Token: 0x0400BD83 RID: 48515
	public readonly EBulletSyncType SyncType;

	// Token: 0x0400BD84 RID: 48516
	public readonly long? ContextId;

	// Token: 0x0400BD85 RID: 48517
	public readonly long? SkillContextId;

	// Token: 0x0400BD86 RID: 48518
	public readonly Aki.Protocol.EBulletCreateSource Source;

	// Token: 0x0400BD87 RID: 48519
	public readonly FVector? LocationOffset;

	// Token: 0x0400BD88 RID: 48520
	public readonly FRotator? BeginRotatorOffset;

	// Token: 0x0400BD89 RID: 48521
	[Nullable(2)]
	public readonly ISkillBattleContext BattleContext;

	// Token: 0x0400BD8A RID: 48522
	public readonly global::EBulletCreateSource CreateSource;
}
