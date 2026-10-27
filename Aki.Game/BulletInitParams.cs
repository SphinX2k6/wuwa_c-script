using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002E14 RID: 11796
[NullableContext(1)]
[Nullable(0)]
public class BulletInitParams
{
	// Token: 0x06018CFB RID: 101627 RVA: 0x0065C1C8 File Offset: 0x0065A3C8
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

	// Token: 0x0400B9EA RID: 47594
	public readonly Entity Owner;

	// Token: 0x0400B9EB RID: 47595
	public readonly string BulletRowName;

	// Token: 0x0400B9EC RID: 47596
	public readonly FTransformDouble? InitialTransform;

	// Token: 0x0400B9ED RID: 47597
	public readonly FVectorDouble? InitTargetLocation;

	// Token: 0x0400B9EE RID: 47598
	public readonly int SkillId;

	// Token: 0x0400B9EF RID: 47599
	public readonly int ParentId;

	// Token: 0x0400B9F0 RID: 47600
	public readonly int TargetId;

	// Token: 0x0400B9F1 RID: 47601
	public readonly int BaseTransformId;

	// Token: 0x0400B9F2 RID: 47602
	public readonly int BaseVelocityId;

	// Token: 0x0400B9F3 RID: 47603
	[Nullable(2)]
	public readonly global::Vector Size;

	// Token: 0x0400B9F4 RID: 47604
	public readonly bool FromRemote;

	// Token: 0x0400B9F5 RID: 47605
	public readonly EBulletSyncType SyncType;

	// Token: 0x0400B9F6 RID: 47606
	public readonly long? ContextId;

	// Token: 0x0400B9F7 RID: 47607
	public readonly long? SkillContextId;

	// Token: 0x0400B9F8 RID: 47608
	public readonly Aki.Protocol.EBulletCreateSource Source;

	// Token: 0x0400B9F9 RID: 47609
	public readonly FVector? LocationOffset;

	// Token: 0x0400B9FA RID: 47610
	public readonly FRotator? BeginRotatorOffset;

	// Token: 0x0400B9FB RID: 47611
	[Nullable(2)]
	public readonly ISkillBattleContext BattleContext;

	// Token: 0x0400B9FC RID: 47612
	public readonly global::EBulletCreateSource CreateSource;
}
