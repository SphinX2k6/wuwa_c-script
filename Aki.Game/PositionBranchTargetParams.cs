using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x0200014E RID: 334
[NullableContext(2)]
[Nullable(0)]
internal class PositionBranchTargetParams
{
	// Token: 0x0600149B RID: 5275 RVA: 0x0007256C File Offset: 0x0007076C
	[NullableContext(1)]
	public bool RefreshTarget(string blackboardKey, EAnsBranchTargetBlackboardType blackBoardType, string blackBoardSocket)
	{
		BaseActorComponent targetBaseActorComp = this.TargetBaseActorComp;
		bool flag;
		if (targetBaseActorComp == null)
		{
			flag = true;
		}
		else
		{
			Entity entity = targetBaseActorComp.Entity;
			flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.TargetBaseActorComp = null;
			this.TargetCharActorComp = null;
		}
		if (string.IsNullOrEmpty(blackboardKey))
		{
			BaseSkillComponent baseSkillComp = this.BaseSkillComp;
			EntityHandle entityHandle = (baseSkillComp != null) ? baseSkillComp.GetSkillTargetForAns() : null;
			if (entityHandle == null || !entityHandle.Valid)
			{
				return false;
			}
			BaseActorComponent targetBaseActorComp2 = this.TargetBaseActorComp;
			bool flag2;
			if (targetBaseActorComp2 == null)
			{
				flag2 = false;
			}
			else
			{
				Entity entity2 = targetBaseActorComp2.Entity;
				flag2 = ((entity2 != null) ? new bool?(entity2.Valid) : null).GetValueOrDefault();
			}
			if (flag2 && entityHandle.Id == this.TargetBaseActorComp.Entity.Id)
			{
				return true;
			}
			this.TargetBaseActorComp = entityHandle.Entity.GetComponent<BaseActorComponent>();
			this.TargetCharActorComp = entityHandle.Entity.GetComponent<CharacterActorComponent>();
			this.SocketName = this.BaseSkillComp.SkillTargetSocket;
		}
		else if (blackBoardType != EAnsBranchTargetBlackboardType.EntityId)
		{
			if (blackBoardType != EAnsBranchTargetBlackboardType.Location)
			{
				return false;
			}
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(this.BaseActorComp.Entity.Id, blackboardKey);
			if (vectorValueByEntity == null)
			{
				return false;
			}
			this.TargetPos = global::Vector.Create(vectorValueByEntity);
		}
		else
		{
			int? num = BlackboardController.Instance.GetEntityIdByEntity(this.BaseActorComp.Entity.Id, blackboardKey);
			if (num == null || num.Value <= 0)
			{
				num = BlackboardController.Instance.GetIntValueByEntity(this.BaseActorComp.Entity.Id, blackboardKey);
				if (num == null || num.Value <= 0)
				{
					return false;
				}
			}
			Entity entity3 = EntitySystem.Instance.Get(num.Value);
			if (entity3 == null || !entity3.Valid)
			{
				return false;
			}
			BaseActorComponent targetBaseActorComp3 = this.TargetBaseActorComp;
			bool flag3;
			if (targetBaseActorComp3 == null)
			{
				flag3 = false;
			}
			else
			{
				Entity entity4 = targetBaseActorComp3.Entity;
				flag3 = ((entity4 != null) ? new bool?(entity4.Valid) : null).GetValueOrDefault();
			}
			if (flag3 && this.TargetBaseActorComp.Entity.Id == entity3.Id)
			{
				return true;
			}
			this.TargetBaseActorComp = entity3.GetComponent<BaseActorComponent>();
			this.TargetCharActorComp = entity3.GetComponent<CharacterActorComponent>();
			this.SocketName = blackBoardSocket;
		}
		this.LastLocation.DeepCopy(this.BaseActorComp.LastActorLocation);
		return true;
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x000727C6 File Offset: 0x000709C6
	public void Clear()
	{
		this.BaseActorComp = null;
		this.BaseUnifiedComp = null;
		this.BaseSkillComp = null;
		this.TargetBaseActorComp = null;
		this.TargetCharActorComp = null;
		this.TargetPos = null;
		this.SocketName = "";
	}

	// Token: 0x04000EA5 RID: 3749
	public BaseActorComponent BaseActorComp;

	// Token: 0x04000EA6 RID: 3750
	public BaseUnifiedStateComponent BaseUnifiedComp;

	// Token: 0x04000EA7 RID: 3751
	public BaseSkillComponent BaseSkillComp;

	// Token: 0x04000EA8 RID: 3752
	public BaseActorComponent TargetBaseActorComp;

	// Token: 0x04000EA9 RID: 3753
	public CharacterActorComponent TargetCharActorComp;

	// Token: 0x04000EAA RID: 3754
	public global::Vector TargetPos;

	// Token: 0x04000EAB RID: 3755
	public float NowTime;

	// Token: 0x04000EAC RID: 3756
	public float TotalTime;

	// Token: 0x04000EAD RID: 3757
	[Nullable(1)]
	public string SocketName = "";

	// Token: 0x04000EAE RID: 3758
	[Nullable(1)]
	public readonly global::Vector LastLocation = global::Vector.Create();
}
