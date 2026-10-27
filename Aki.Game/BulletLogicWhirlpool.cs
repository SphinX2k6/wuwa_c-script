using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002DDE RID: 11742
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicWhirlpool : BulletLogicController<LogicDataWhirlpool, object>
{
	// Token: 0x06018A58 RID: 100952 RVA: 0x0064F7E8 File Offset: 0x0064D9E8
	public BulletLogicWhirlpool(LogicDataWhirlpool bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		base.NeedTick = true;
		this.WeightLimit = bulletLogicBase.WeightLimit;
		this.BulletInfo = (bullet as BulletEntity).GetBulletInfo();
		this.Id = WhirlpoolPoint.GenId();
		this.MoveTime = bulletLogicBase.MoveTime;
	}

	// Token: 0x06018A59 RID: 100953 RVA: 0x0064F84E File Offset: 0x0064DA4E
	public override void OnInit()
	{
	}

	// Token: 0x06018A5A RID: 100954 RVA: 0x0064F850 File Offset: 0x0064DA50
	protected override void Update(float deltaTime)
	{
		foreach (Entity item in this.BulletInfo.CollisionInfo.CharacterEntityMap.Keys)
		{
			this.CharacterInArea.Add(item);
		}
		foreach (Entity characterEntity in this.CharacterInArea)
		{
			this.UpdateCharacterWhirlpool(characterEntity);
		}
	}

	// Token: 0x06018A5B RID: 100955 RVA: 0x0064F8FC File Offset: 0x0064DAFC
	private void UpdateCharacterWhirlpool(Entity characterEntity)
	{
		CharacterMoveComponent characterMoveComponent = (characterEntity != null) ? characterEntity.GetComponent<CharacterMoveComponent>() : null;
		if (characterMoveComponent == null || !characterMoveComponent.Valid || this.WeightLimit < characterMoveComponent.CharacterWeight)
		{
			return;
		}
		if (characterMoveComponent.GetWhirlpoolId() != this.Id)
		{
			if (!characterMoveComponent.GetWhirlpoolEnable() || characterMoveComponent.CompareWhirlpoolPriority(this.MoveTime))
			{
				this.GetToLocation();
				characterMoveComponent.BeginWhirlpool(this.Id, this.MoveTime, this.Location, characterMoveComponent.ActorComp.ActorLocationProxy, -1f, (EVelocityCurveType)this.LogicController.VelocityCurve, this.LogicController.CancelByHit, GameplayTagUtils.IsValidTag(new FGameplayTag?(this.LogicController.TagNeed)) ? GameplayTagUtils.GetTagIdByName(this.LogicController.TagNeed.TagName.ToString()) : 0);
				bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
				return;
			}
		}
		else
		{
			this.GetToLocation();
			if (BulletConstant.Instance.OpenMoveLog)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.Location.ToUeVector(false), 10f, 10, new FLinearColor?(ColorUtils.LinearGreen), 3f, 3f);
			}
			characterMoveComponent.UpdateWhirlpoolLocation(this.Location);
		}
	}

	// Token: 0x06018A5C RID: 100956 RVA: 0x0064FA44 File Offset: 0x0064DC44
	private void GetToLocation()
	{
		if (FNameUtil.IsNothing(this.LogicController.AttackerSocketName))
		{
			this.Location.FromUeVector(this.BulletInfo.ActorComponent.ActorLocationProxy);
			return;
		}
		Vector location = this.Location;
		FVectorDouble socketLocation = this.BulletInfo.AttackerActorComp.GetSocketLocation(this.LogicController.AttackerSocketName);
		location.FromUeVector(socketLocation);
	}

	// Token: 0x06018A5D RID: 100957 RVA: 0x0064FAA8 File Offset: 0x0064DCA8
	public override void OnBulletDestroy()
	{
		foreach (Entity entity in this.CharacterInArea)
		{
			CharacterMoveComponent characterMoveComponent = (entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null;
			if (characterMoveComponent != null && characterMoveComponent.Valid && characterMoveComponent.GetWhirlpoolEnable() && characterMoveComponent.GetWhirlpoolId() == this.Id)
			{
				characterMoveComponent.EndWhirlpool("子弹销毁");
				bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
			}
		}
		this.CharacterInArea.Clear();
	}

	// Token: 0x0400B79B RID: 47003
	private const int DEBUG_SEGMENTS = 10;

	// Token: 0x0400B79C RID: 47004
	private const float DEBUG_DURATION = 3f;

	// Token: 0x0400B79D RID: 47005
	private const float DEBUG_THICKNESS = 3f;

	// Token: 0x0400B79E RID: 47006
	private readonly float WeightLimit;

	// Token: 0x0400B79F RID: 47007
	[Nullable(2)]
	private readonly BulletInfo BulletInfo;

	// Token: 0x0400B7A0 RID: 47008
	private readonly int Id;

	// Token: 0x0400B7A1 RID: 47009
	private readonly float MoveTime;

	// Token: 0x0400B7A2 RID: 47010
	private readonly HashSet<Entity> CharacterInArea = new HashSet<Entity>();

	// Token: 0x0400B7A3 RID: 47011
	private readonly Vector Location = Vector.Create();
}
