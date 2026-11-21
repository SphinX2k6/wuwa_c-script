using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002339 RID: 9017
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicWhirlpool : BulletLogicController<LogicDataWhirlpool, object>
{
	// Token: 0x06016305 RID: 90885 RVA: 0x00675924 File Offset: 0x00673B24
	public BulletLogicWhirlpool(LogicDataWhirlpool bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		base.NeedTick = true;
		this.WeightLimit = bulletLogicBase.WeightLimit;
		this.BulletInfo = (bullet as BulletEntity).GetBulletInfo();
		this.Id = WhirlpoolPoint.GenId();
		this.MoveTime = bulletLogicBase.MoveTime;
	}

	// Token: 0x06016306 RID: 90886 RVA: 0x0067598A File Offset: 0x00673B8A
	public override void OnInit()
	{
	}

	// Token: 0x06016307 RID: 90887 RVA: 0x0067598C File Offset: 0x00673B8C
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

	// Token: 0x06016308 RID: 90888 RVA: 0x00675A38 File Offset: 0x00673C38
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

	// Token: 0x06016309 RID: 90889 RVA: 0x00675B80 File Offset: 0x00673D80
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

	// Token: 0x0601630A RID: 90890 RVA: 0x00675BE4 File Offset: 0x00673DE4
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

	// Token: 0x0400BB21 RID: 47905
	private const int DEBUG_SEGMENTS = 10;

	// Token: 0x0400BB22 RID: 47906
	private const float DEBUG_DURATION = 3f;

	// Token: 0x0400BB23 RID: 47907
	private const float DEBUG_THICKNESS = 3f;

	// Token: 0x0400BB24 RID: 47908
	private readonly float WeightLimit;

	// Token: 0x0400BB25 RID: 47909
	[Nullable(2)]
	private readonly BulletInfo BulletInfo;

	// Token: 0x0400BB26 RID: 47910
	private readonly int Id;

	// Token: 0x0400BB27 RID: 47911
	private readonly float MoveTime;

	// Token: 0x0400BB28 RID: 47912
	private readonly HashSet<Entity> CharacterInArea = new HashSet<Entity>();

	// Token: 0x0400BB29 RID: 47913
	private readonly Vector Location = Vector.Create();
}
