using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02000124 RID: 292
[NullableContext(1)]
[Nullable(0)]
internal class CurveMoveParams
{
	// Token: 0x060011A5 RID: 4517 RVA: 0x00063150 File Offset: 0x00061350
	public bool RefreshTarget(string key, string socket, EPositionDatumTarget datum, ECurveMoveTargetBlackboardType? keyType = null)
	{
		BaseActorComponent targetActorComp = this.TargetActorComp;
		bool flag;
		if (targetActorComp == null)
		{
			flag = true;
		}
		else
		{
			Entity entity = targetActorComp.Entity;
			flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.TargetActorComp = null;
			this.TargetCharActorComp = null;
		}
		this.LastLocation.DeepCopy(this.CharActorComp.LastActorLocation);
		ECurveMoveTargetBlackboardType? ecurveMoveTargetBlackboardType = keyType;
		ECurveMoveTargetBlackboardType ecurveMoveTargetBlackboardType2 = ECurveMoveTargetBlackboardType.LocationVector;
		if (ecurveMoveTargetBlackboardType.GetValueOrDefault() == ecurveMoveTargetBlackboardType2 & ecurveMoveTargetBlackboardType != null)
		{
			this.TargetActorComp = this.CharActorComp;
			this.TargetCharActorComp = this.CharActorComp;
			this.SocketName = socket;
			return true;
		}
		switch (datum)
		{
		case EPositionDatumTarget.User:
			this.TargetActorComp = this.CharActorComp;
			this.TargetCharActorComp = this.CharActorComp;
			this.SocketName = socket;
			break;
		case EPositionDatumTarget.Skill:
		{
			CharacterSkillComponent charSkillComp = this.CharSkillComp;
			EntityHandle entityHandle = (charSkillComp != null) ? charSkillComp.GetSkillTargetForAns() : null;
			if (entityHandle == null || !entityHandle.Valid)
			{
				return false;
			}
			BaseActorComponent targetActorComp2 = this.TargetActorComp;
			bool flag2;
			if (targetActorComp2 == null)
			{
				flag2 = false;
			}
			else
			{
				Entity entity2 = targetActorComp2.Entity;
				flag2 = ((entity2 != null) ? new bool?(entity2.Valid) : null).GetValueOrDefault();
			}
			if (flag2 && entityHandle.Id == this.TargetActorComp.Entity.Id)
			{
				return true;
			}
			this.TargetActorComp = entityHandle.Entity.GetComponent<BaseActorComponent>();
			this.TargetCharActorComp = entityHandle.Entity.GetComponent<CharacterActorComponent>();
			this.SocketName = this.CharSkillComp.SkillTargetSocket;
			break;
		}
		case EPositionDatumTarget.Blackboard:
		{
			Entity targetEntity = this.GetTargetEntity(key, keyType);
			if (targetEntity == null || !targetEntity.Valid)
			{
				return false;
			}
			BaseActorComponent targetActorComp3 = this.TargetActorComp;
			bool flag3;
			if (targetActorComp3 == null)
			{
				flag3 = false;
			}
			else
			{
				Entity entity3 = targetActorComp3.Entity;
				flag3 = ((entity3 != null) ? new bool?(entity3.Valid) : null).GetValueOrDefault();
			}
			if (flag3 && this.TargetActorComp.Entity.Id == targetEntity.Id)
			{
				return true;
			}
			this.TargetActorComp = targetEntity.GetComponent<BaseActorComponent>();
			this.TargetCharActorComp = targetEntity.GetComponent<CharacterActorComponent>();
			this.SocketName = socket;
			break;
		}
		}
		return true;
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00063370 File Offset: 0x00061570
	[return: Nullable(2)]
	private Entity GetTargetEntity(string key, ECurveMoveTargetBlackboardType? keyType)
	{
		int? num = BlackboardController.Instance.GetIntValueByEntity(this.CharActorComp.Entity.Id, key);
		ECurveMoveTargetBlackboardType? ecurveMoveTargetBlackboardType = keyType;
		ECurveMoveTargetBlackboardType ecurveMoveTargetBlackboardType2 = ECurveMoveTargetBlackboardType.CreatureDataId;
		if (ecurveMoveTargetBlackboardType.GetValueOrDefault() == ecurveMoveTargetBlackboardType2 & ecurveMoveTargetBlackboardType != null)
		{
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity((long)num.Value);
					if (entity == null)
					{
						return null;
					}
					return entity.Entity;
				}
			}
			return null;
		}
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				goto IL_DB;
			}
		}
		num = BlackboardController.Instance.GetEntityIdByEntity(this.CharActorComp.Entity.Id, key);
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				goto IL_DB;
			}
		}
		return null;
		IL_DB:
		return EntitySystem.Instance.Get(num.Value);
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00063469 File Offset: 0x00061669
	public void Clear()
	{
		this.CharActorComp = null;
		this.CharUnifiedComp = null;
		this.CharSkillComp = null;
		this.TargetActorComp = null;
		this.TargetCharActorComp = null;
		this.SocketName = "";
	}

	// Token: 0x04000D26 RID: 3366
	[Nullable(2)]
	public CharacterActorComponent CharActorComp;

	// Token: 0x04000D27 RID: 3367
	[Nullable(2)]
	public CharacterUnifiedStateComponent CharUnifiedComp;

	// Token: 0x04000D28 RID: 3368
	[Nullable(2)]
	public CharacterSkillComponent CharSkillComp;

	// Token: 0x04000D29 RID: 3369
	[Nullable(2)]
	public BaseActorComponent TargetActorComp;

	// Token: 0x04000D2A RID: 3370
	[Nullable(2)]
	public CharacterActorComponent TargetCharActorComp;

	// Token: 0x04000D2B RID: 3371
	public double NowTime;

	// Token: 0x04000D2C RID: 3372
	public double TotalTime;

	// Token: 0x04000D2D RID: 3373
	public string SocketName = "";

	// Token: 0x04000D2E RID: 3374
	public readonly Vector LastLocation = Vector.Create();

	// Token: 0x04000D2F RID: 3375
	public readonly Vector InitLocation = Vector.Create();

	// Token: 0x04000D30 RID: 3376
	public readonly Vector TargetOffset = Vector.Create();

	// Token: 0x04000D31 RID: 3377
	public readonly Vector TargetPos = Vector.Create();

	// Token: 0x04000D32 RID: 3378
	public readonly Vector LastTargetPos = Vector.Create();

	// Token: 0x04000D33 RID: 3379
	public readonly Vector TargetVec = Vector.Create();

	// Token: 0x04000D34 RID: 3380
	public bool AlongStraightLine;

	// Token: 0x04000D35 RID: 3381
	public bool AllowMovement;

	// Token: 0x04000D36 RID: 3382
	public bool CanSetActorTargetPos;

	// Token: 0x04000D37 RID: 3383
	public bool FlyingMove;

	// Token: 0x04000D38 RID: 3384
	public float LastSplineDistance;
}
